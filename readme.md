# Godaddy Dynamic Dns for IPv4 and IPv6 dns addresses

To run this application you will need to set up a developer account with godaddy
 - https://developer.godaddy.com/getstarted

You can set up the application constants in one of two ways
 1) Edit the strings in the Core.Common.Constants file
 2) Set up environment variables for
    - AccessKey
    - SecretKey
    - SyncDomain

>New-Service -Name "DnsSync" -BinaryPathName "c:\GodaddyDnsWrapper\DnsSyncTool\
bin\Release\DnsSyncTool.WindowsService.exe" -StartupType auto -DisplayName "DnsSync" -Description "This service dynamicl
y updated ipv6 and ipv4 addresses"