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
### 描述
一个插件，允许SCP对象将其对象更改为另一个对象，以及了解有关其他SCP的信息。
### 安装
* 移动 `Qurre.Tools.dll` 至`(.config or %AppData%)/Qurre/Plugins/dependencies`
* 移动`BetterScps-Release.dll`或者`BetterScps-Debug.dll` (将编写调试消息)至 `(.config or %AppData%)/Qurre/Plugins`.
### 配置
```yaml
# 插件是否启用
IsEnabled: true
# 允许更改对象的时间（以秒为单位）
Time: 90
# 列入黑名单的SCP列表(此列表中包含的SCP不能使用开关命令)
BlackListedScps:
- Scp0492
# 有限的scps列表（如果他已经在地图中生成，则无法切换到此列表中包含的scps）
LimitedScps:
- Scp096
- Scp079
- Scp173
# 如果更改对象的时间尚未过，则出现SCP时的消息
MessageIsForceAllowed: <i>You can use <color=#FF0000>.force</color> command to switch your object or <color=#FFFF00>.scps</color> command to find out the status of all objects</i>
# 如果更改对象的时间已经过去，则出现SCP时的消息
MessageIsForceNotAllowed: <i>You can use <color=#FFFF00>.scps</color> command to find out the status of all objects</i>
# SCP-079 configuration
Scp079:
# 开门时消耗的电力
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
  # 锁门时消耗的电力
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
  # 与电梯进行互动时所消耗的电力
  InteractLift: 10
  # 改变摄像头所消耗的电力
  ChangeCamera: 10
  # 传送至另一个收容区（原文: 传送电梯）所消耗的电梯
  ElevatorTeleport: 20
  # 使特斯拉活动（电人）所消耗的电力
  ActivateTesla: 50
  # 关一个房间的灯所消耗的电力
  Blackout: 60
  # 特斯拉在互动上的即时触发?
  InstantTesla: false
```
### 插件使用[Qurre]进行编写(https://github.com/Qurre-Team/Qurre-sl).  
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
