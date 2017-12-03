[AID_QCOM_DIAG]
value:2950

[system/bin/wcnss_filter]
user: AID_BLUETOOTH
group: AID_BLUETOOTH
mode: 0755
caps: BLOCK_SUSPEND

[system/bin/cnss-daemon]
user: AID_SYSTEM
group: AID_SYSTEM
mode: 0755
caps: NET_BIND_SERVICE

[system/bin/pm-service]
user: AID_SYSTEM
group: AID_SYSTEM
mode: 0755
caps: NET_BIND_SERVICE

[system/bin/imsdatadaemon]
user: AID_SYSTEM
group: AID_SYSTEM
mode: 0755
caps: NET_BIND_SERVICE

[system/bin/ims_rtp_daemon]
user: AID_SYSTEM
group: AID_RADIO
mode: 0755
caps: NET_BIND_SERVICE

[system/vendor/bin/qvrservice]
user: AID_SYSTEM
group: AID_SYSTEM
mode: 0755
caps: SYS_NICE