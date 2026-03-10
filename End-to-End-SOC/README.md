# End-to-End SOC Investigation Simulation

This project provides a **repeatable SOC lab workflow** to execute and investigate a full attack chain:

1. **Recon / Scan** (Nmap)
2. **Exploit** (Metasploit)
3. **Post-exploitation shell** (Meterpreter)
4. **Detection + investigation evidence** (Wireshark + Splunk/ELK)
5. **Structured incident timeline output** (JSON + Markdown)



## 1) Architecture

- **Attacker:** Kali Linux (Nmap, Metasploit, tcpdump/Wireshark)
- **Victim:** Metasploitable2 (or DVWA/Juice Shop + intentionally vulnerable service)
- **Visibility:**
  - Packet capture: Wireshark/tcpdump on attacker or SPAN interface
  - SIEM: Splunk *or* ELK stack
- **Artifacts directory:**
  - `artifacts/raw/` for raw logs/pcaps/tool outputs
  - `artifacts/processed/` for normalized evidence and timeline output

## 2) Repository layout

- `docs/runbook.md` – Full operator runbook (scan → exploit → shell → evidence)
- `docs/detection-mapping.md` – ATT&CK mapping + detections
- `scripts/build_timeline.py` – Build structured timeline from evidence JSONL
- `scripts/sample_attack_chain.rc` – Metasploit resource script template
- `progress.md` – Progress tracker requested in task

## 3) Quick start

### Prerequisites

- Kali VM/container with `nmap`, `msfconsole`, `tcpdump`
- Wireshark (GUI or tshark)
- Splunk Enterprise or ELK (single-node is fine)
- A vulnerable target VM on an isolated network
- Python 3.9+

### A) Run attack chain from Kali

Use `docs/runbook.md` commands in order:
- Nmap service/version scan
- Metasploit exploit selection and execution
- Verify shell access and basic host discovery

### B) Collect evidence

Save outputs into `artifacts/raw/`:
- `nmap_scan.txt`
- `msf_console.log`
- `attack_traffic.pcap`
- `siem_alerts.json` (exported from Splunk/ELK)

### C) Normalize evidence and build timeline

Create `artifacts/processed/evidence.jsonl` entries (example in runbook), then:

```bash
python3 scripts/build_timeline.py \
  --input artifacts/processed/evidence.jsonl \
  --json-out artifacts/processed/incident_timeline.json \
  --md-out artifacts/processed/incident_timeline.md
```

## 4) Expected output

- A chronologically sorted timeline with:
  - timestamp (UTC)
  - phase (scan/exploit/shell/detect/contain)
  - source tool
  - IOC/evidence
  - ATT&CK technique references
  - confidence and severity

This supports SOC handoff, post-incident review, and report generation.
