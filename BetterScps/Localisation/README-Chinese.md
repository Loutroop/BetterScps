<a href="https://github.com/I-Aureate-I/BetterScps/releases/latest">
<img src="https://img.shields.io/github/downloads/I-Aureate-I/BetterScps/total.svg" />
</a>  

## BetterScps
### 描述
一个插件，允许SCP对象将其对象更改为另一个对象，以及了解有关其他SCP的信息。
### 安装
* 移动 `Qurre.Tools.dll` 至`(.config or %AppData%)/Qurre/Plugins/dependencies`
* 移动`BetterScps-Release.dll`或者`BetterScps-Debug.dll` (将编写调试消息)至 `(.config or %AppData%)/Qurre/Plugins`.
### 配置
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
