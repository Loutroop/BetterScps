<a href="https://github.com/I-Aureate-I/BetterScps/releases/latest">
  <img src="https://img.shields.io/github/downloads/I-Aureate-I/BetterScps/total.svg" />
</a>  

## BetterScps
### Описание
Плагин позволяющий SCP-Объектам менять свой объект на другой, а также получать информацию о других объектах SCP.
### Installation
* Перемистите `Qurre.Tools.dll` в `(.config or %AppData%)/Qurre/Plugins/dependencies`
* Перемистите `BetterScps-Release.dll` или `BetterScps-Debug.dll` (будет писать отладку) в `(.config or %AppData%)/Qurre/Plugins`.
### Config
```yaml
# Включен ли плагин?
IsEnabled: true
# Время в которое можно менять SCP-Объект (В секундах).
Time: 90
# Список запрещённых SCP (SCP Содержавшиеся в этом листе не могут использовать команду для смены SCP-Объекта).
BlackListedScps:
- Scp0492
# Список лимитированных объектов (Невозможно смениться на объект указанный в этом списке, если за него уже кто-то играет).
LimitedScps:
- Scp096
- Scp079
- Scp173
# Сообщение при появлении для SCP, если время для смены объекта еще не прошло.
MessageIsForceAllowed: <i>You can use <color=#FF0000>.force</color> command to switch your object or <color=#FFFF00>.scps</color> command to find out the status of all objects</i>
# Сообщение при появлении для SCP, если время для смены объекта уже прошло.
MessageIsForceNotAllowed: <i>You can use <color=#FFFF00>.scps</color> command to find out the status of all objects</i>
```
### Плагин написан на [Qurre](https://github.com/Qurre-Team/Qurre-sl).  
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