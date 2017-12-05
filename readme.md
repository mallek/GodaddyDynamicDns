# Godaddy Dynamic DNS for IPv4 and IPv6 addresses

This application will sync your ipv4 and ipv6 address through the godaddy API allowing you to run a local dynamic dns updater.  I use this because I lost my static IP addresses and it allowed me to send RDP, web and email into my home computer using a easy hostname ``` (home.your-domain.com) ```

To run this application you will need to set up a developer account with godaddy
 - https://developer.godaddy.com/getstarted
 - You must own a domain from Godaddy
 - your records will be on the "home" subdomain ``` (home.your-domain.com) ```
 - creates A and AAAA records (they will be added if they don't exist)

 ***If you have A or AAAA records on the home subdomain they will be overwritten***

You can set up the application constants in one of two ways
 1) Edit the strings in the Core.Common.Constants file
 2) Set up environment variables for
    - AccessKey
    - SecretKey
    - SyncDomain

 - Build the application in visual studio
 - The libraries are written in dotnet standard, if there is request for a cross platform version I will build a loader

### Powershell Install Command
>New-Service -Name "DnsSync" -BinaryPathName "c:\GodaddyDnsWrapper\DnsSyncTool\
bin\Release\DnsSyncTool.WindowsService.exe" -StartupType auto -DisplayName "DnsSync" -Description "This service dynamicl
y updated ipv6 and ipv4 addresses"