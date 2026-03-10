# Incident Timeline

| Timestamp (UTC) | Phase | Tool | Severity | Confidence | Source -> Destination | ATT&CK | Evidence |
|---|---|---|---|---|---|---|---|
| 2026-01-15T10:00:05Z | scan | nmap | medium | high | 192.168.56.101->192.168.56.110 | T1046 | SYN scan identified 21/tcp ftp vsftpd 2.3.4, 22/tcp ssh, 80/tcp http |
| 2026-01-15T10:05:18Z | exploit | metasploit | high | high | 192.168.56.101->192.168.56.110 | T1190 | Exploit module exploit/unix/ftp/vsftpd_234_backdoor succeeded; command shell session 1 opened |
| 2026-01-15T10:05:20Z | detect | splunk | high | medium | 192.168.56.101->192.168.56.110 | T1190 | Correlation search flagged exploit-like FTP traffic followed by shell callback |
| 2026-01-15T10:06:02Z | shell | metasploit | high | high | 192.168.56.101->192.168.56.110 | T1059 | Interactive shell established; whoami returned root |
