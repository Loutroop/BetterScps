<img src="https://cdn.fydne.xyz/qurre/Qurre-web_ol.gif" align="right" />
<p>
   <a href="https://github.com/I-Aureate-I/BetterScps/releases/latest">
     <img src="https://img.shields.io/github/downloads/I-Aureate-I/BetterScps/total.svg" />
   </a>
   <a href="https://github.com/I-Aureate-I/BetterScps/commits/master">
     <img src="https://img.shields.io/github/commits-since/I-Aureate-I/BetterScps/latest?include_prereleases" />
   </a>
</p>

## BetterScps
### Description
A plugin that allows SCP Objects to change their object to another as well as to learn information about other SCPs.
### Installation
* Move `Qurre.Tools.dll` into the `(.config or %AppData%)/Qurre/Plugins/dependencies`
* Move `BetterScps-Release.dll` or `BetterScps-Debug.dll` (will write debug messages) into the `(.config or %AppData%)/Qurre/Plugins`.
### Config
```yaml
# Whether the plugin is enabled.
IsEnabled: true
# The time at which it is allowed to change the object (In seconds).
Time: 90
# List of the blacklisted scps (Scps which contains in this list cannot use switch command).
BlackListedScps:
- Scp0492
# List of the limited scps (Cannot switch to scps which contains in this list if he is already spawn in the map).
LimitedScps:
- Scp096
- Scp079
- Scp173
# The message when appearing for SCP if the time for changing the object has not yet passed.
MessageIsForceAllowed: <i>You can use <color=#FF0000>.force</color> command to switch your object or <color=#FFFF00>.scps</color> command to find out the status of all objects</i>
# The message when appearing for SCP if the time for changing the object has already passed.
MessageIsForceNotAllowed: <i>You can use <color=#FFFF00>.scps</color> command to find out the status of all objects</i>
# SCP-079 configuration
Scp079:
# Power cost on open a door.
  OpenDoor:
    Default: 5
    Chkp: 10
    Scps: 40
    Scp914: 50
    ArmoryDef: 50
    WarheadArmor: 60
    Gates: 60
    SurfaceGate: 60
    MicroHidRoom: 70
    Scp079andScp106: 110
    SurfaceWarhead: 110
  # Power cost on close a door.
  CloseDoor:
    Default: 5
    Chkp: 10
    Scps: 40
    Scp914: 50
    ArmoryDef: 50
    WarheadArmor: 60
    Gates: 60
    SurfaceGate: 60
    MicroHidRoom: 70
    Scp079andScp106: 110
    SurfaceWarhead: 110
  # Power cost on interact with lift.
  InteractLift: 10
  # Power cost on change camera.
  ChangeCamera: 10
  # Power cost on elevator teleport.
  ElevatorTeleport: 20
  # Power cost on activate a tesla.
  ActivateTesla: 50
  # Power cost on blackout in a room.
  Blackout: 60
  # Instant trigger of the tesla on interact
  InstantTesla: false
```
### Plugin written on [Qurre](https://github.com/Qurre-Team/Qurre-sl).  
<p>
   <a href="https://discord.gg/zGUqfJQebn" alt="Discord">
      <img src="https://discord.com/api/guilds/779412392651653130/embed.png" alt="Discord"/>
   </a>
   <a href="https://github.com/Qurre-Team/Qurre-sl/releases/latest" alt="Downloads">
      <img src="https://img.shields.io/github/downloads/Qurre-Team/Qurre-sl/total?color=%2300b813&style=plastic" alt="Downloads"/>
   </a>
   <a href="https://github.com/Qurre-Team/Qurre-sl/releases/latest" alt="Release">
      <img src="https://img.shields.io/github/v/release/Qurre-Team/Qurre-sl.svg?style=plastic" alt="Release"/>
   </a>
</p>
