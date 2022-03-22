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
### Описание
Плагин позволяющий SCP-Объектам менять свой объект на другой, а также получать информацию о других объектах SCP.
### Установка
* Переместите `Qurre.Tools.dll` в `(.config or %AppData%)/Qurre/Plugins/dependencies`
* Переместите `BetterScps-Release.dll` или `BetterScps-Debug.dll` (будет писать отладку) в `(.config or %AppData%)/Qurre/Plugins`.
### Конфигурация
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
MessageIsForceAllowed: <i>Вы можете использовать команду <color=#FF0000>.force</color> для смены своего объекта или команду <color=#FFFF00>.scps</color> чтобы узнать состояние всех объектов</i>
# Сообщение при появлении для SCP, если время для смены объекта уже прошло.
MessageIsForceNotAllowed: <i>Вы можете использовать команду <color=#FFFF00>.scps</color> чтобы узнать состояние всех объектов</i>
# Конфигурация SCP-079
Scp079:
# Стоимость открытия двери.
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
  # Стоимость закрытия двери.
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
  # Стоимость взаимодействия с лифтом.
  InteractLift: 10
  # Стоимость смены камеры.
  ChangeCamera: 10
  # Стоимость смены зоны.
  ElevatorTeleport: 20
  # Стоимость активации Тесла-ворот.
  ActivateTesla: 50
  # Стоимость blackout'а.
  Blackout: 60
  # Мгновенное включение тесла-ворот при взаимодействии?
  InstantTesla: false
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
