$ErrorActionPreference = 'Stop'

# This is an example PowerShell script that will remotely execute a Unicorn sync using the new CHAP authentication system.

$ScriptPath = 'C:\Users\kk43\Documents\Visual Studio 2015\Projects\SampleWebSite\build\unicorn.psm1'

Import-Module $ScriptPath

# SYNC ALL CONFIGURATIONS
Sync-Unicorn -ControlPanelUrl 'http://demowebsite/unicorn.aspx' -SharedSecret 'sBPcp7j95ALLtMKFAn25nC3Sh76GPS4fDyNdUwvXfsxApcWA2LpfbJX7C3Cgv22qaphDdn2XhzVv7uMBWZWd97SU4X9gyc4p2dHC'

# Note: you may pass -Verb 'Reserialize' for remote reserialize. Usually not needed though.

# Note: If you are having authorization issues, add -DebugSecurity to your cmdlet invocation; this will display the raw signatures being used to compare to the server.