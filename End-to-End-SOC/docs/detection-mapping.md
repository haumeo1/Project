# Detection & ATT&CK Mapping

## Attack chain mapping

1. **Network Service Discovery** → ATT&CK `T1046`
2. **Exploit Public-Facing Application / Service** → ATT&CK `T1190`
3. **Command and Scripting Interpreter** → ATT&CK `T1059`

## Data sources

- Nmap CLI output (`artifacts/raw/nmap_scan.txt`)
- Metasploit logs (`artifacts/raw/msf_console.log`)
- Network packet capture (`artifacts/raw/attack_traffic.pcap`)
- SIEM alerts (`artifacts/raw/siem_alerts.json`)

## High-value detection opportunities

- Sequential port probing from a single source over short interval.
- Exploit-signature traffic against known vulnerable service versions.
- New inbound shell sessions shortly after exploit event.
- Correlated signal: scan + exploit + shell within one source/destination pair.
