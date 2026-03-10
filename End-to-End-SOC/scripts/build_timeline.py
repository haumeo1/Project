#!/usr/bin/env python3
import argparse
import json
from datetime import datetime
from pathlib import Path


def parse_ts(ts: str) -> datetime:
    return datetime.fromisoformat(ts.replace("Z", "+00:00"))


def load_events(path: Path):
    events = []
    for idx, line in enumerate(path.read_text().splitlines(), start=1):
        line = line.strip()
        if not line:
            continue
        try:
            item = json.loads(line)
        except json.JSONDecodeError as exc:
            raise ValueError(f"Invalid JSON on line {idx}: {exc}") from exc
        if "timestamp" not in item:
            raise ValueError(f"Missing timestamp on line {idx}")
        item["_parsed_ts"] = parse_ts(item["timestamp"])
        events.append(item)
    return sorted(events, key=lambda e: e["_parsed_ts"])


def write_json(events, out_path: Path):
    sanitized = []
    for e in events:
        e2 = dict(e)
        e2.pop("_parsed_ts", None)
        sanitized.append(e2)
    out_path.write_text(json.dumps(sanitized, indent=2) + "\n")


def write_markdown(events, out_path: Path):
    lines = [
        "# Incident Timeline",
        "",
        "| Timestamp (UTC) | Phase | Tool | Severity | Confidence | Source -> Destination | ATT&CK | Evidence |",
        "|---|---|---|---|---|---|---|---|",
    ]
    for e in events:
        src = e.get("src_ip", "?")
        dst = e.get("dst_ip", "?")
        lines.append(
            "| {timestamp} | {phase} | {tool} | {severity} | {confidence} | {src}->{dst} | {tech} | {evidence} |".format(
                timestamp=e.get("timestamp", ""),
                phase=e.get("phase", ""),
                tool=e.get("tool", ""),
                severity=e.get("severity", ""),
                confidence=e.get("confidence", ""),
                src=src,
                dst=dst,
                tech=e.get("attack_technique", ""),
                evidence=e.get("evidence", "").replace("|", "\\|"),
            )
        )
    out_path.write_text("\n".join(lines) + "\n")


def main():
    parser = argparse.ArgumentParser(description="Build SOC incident timeline from JSONL evidence.")
    parser.add_argument("--input", required=True, type=Path, help="Input JSONL evidence file")
    parser.add_argument("--json-out", required=True, type=Path, help="Output timeline JSON")
    parser.add_argument("--md-out", required=True, type=Path, help="Output timeline Markdown")
    args = parser.parse_args()

    events = load_events(args.input)
    args.json_out.parent.mkdir(parents=True, exist_ok=True)
    args.md_out.parent.mkdir(parents=True, exist_ok=True)

    write_json(events, args.json_out)
    write_markdown(events, args.md_out)
    print(f"Wrote {len(events)} events to {args.json_out} and {args.md_out}")


if __name__ == "__main__":
    main()
