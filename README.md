= Monitor =

== Description == 

A Simple Windows Service that monitors another Service. 

If the target Service is not in Running state, one of the following actions can be automatically scheduled to happen:

- Lock the Workstation (regardless of logged in user)
- Start the target Service again

== Installation ==

To Install the Windows Service (Monitor)

	./Monitor.exe --install

Uninstall using the following command

	./Monitor.exe --uninstall

Log files will be created in the same folder

== Configuration ==

Open up in a Text Editor

	Monitor.exe.config

This line can be tweaked to support compatible .NET versions:

    <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.8.1"/>

Configure the Target Service Name with: (Default: SCardSvr "Smart Card")

	<setting name="ServiceName" serializeAs="String">
		<value>SCardSvr</value>
	</setting>

Configure the Action to perform with: (Supported: LockDevice or StartService)

	<setting name="ActionClass" serializeAs="String">
		<value>LockDevice</value>
	</setting>

== Compatibility ==

This project was tested on Windows 11 Pro (22H2) with .NET Framework 4.8.1. 

In order for the Monitor Service to do its work, it must run as Local System or similar access. 
Only running in Local Service will NOT work. 

== Other ==

Monitor
 Logon: Local System (An account, used by the service control manager, that has extensive privileges on the local computer and acts as the computer on the network.)
  Can check for Status and Start/Stop other Services
 Logon: Local Service (An account that acts as a non-privileged user on the local computer, and presents anonymous credentials to any remote server.) | Default
  Can NOT. Access Denied
 Network Service (An account that provides extensive local privileges, and presents the computer's credentials to any remote server)
  Can NOT. Access Denied.

Smart Card (SCardSvr)
 Logon: Local Service

