using Qurre;
using Qurre.API;
using Qurre.API.Events;
using Qurre.API.Objects;
using Qurre.Tools;
using System.Collections.Generic;

namespace BetterScps
{
    public class EventHandlers
    {
        public Dictionary<Player, int> ZombiesCount { get; private set; } = new();

        public void RoundEnd(RoundEndEvent ev) => ZombiesCount.Clear();

        public void ScpChange(RoleChangeEvent ev)
        {
            if (ev.NewRole.IsScp() && ev.Allowed)
            {
                bool forceAllowed = Round.ElapsedTime.TotalSeconds <= Config.Instance.Time;
                ev.Player.Broadcast(forceAllowed ? Config.Instance.MessageIsForceAllowed : Config.Instance.MessageIsForceNotAllowed, (ushort)(forceAllowed ? 10 : 8));

                #if DEBUG
                Log.Debug(string.Format("{0} role changed to {1}, force is {2}", ev.Player.Name(), ev.Player.Role, forceAllowed ? "allowed" : "not allowed"));
                #endif
            }
        }

        public void Revive(FinishRecallEvent ev)
        {
            if (ev.Allowed)
            {
                if (!ZombiesCount.ContainsKey(ev.Scp049))
                {
                    ZombiesCount.Add(ev.Scp049, 0);
                }

                ZombiesCount[ev.Scp049]++;
            }
        }

        public void Scp079(Scp079InteractDoorEvent ev)
        {
            if (ev.Door.Open)
            {
                ev.PowerCost = ev.Door.Type switch
                {
                    DoorType.Checkpoint_EZ_HCZ or DoorType.Checkpoint_LCZ_A or DoorType.Checkpoint_LCZ_B => Config.Instance.Scp079.CloseDoor["Chkp"],
                    DoorType.HCZ_096 or DoorType.LCZ_012_Locker or DoorType.LCZ_330 or DoorType.LCZ_330_Chamber => Config.Instance.Scp079.CloseDoor["Scps"],
                    DoorType.LCZ_914 => Config.Instance.Scp079.CloseDoor["Scp914"],
                    DoorType.HCZ_049_Armory or DoorType.HCZ_Armory or DoorType.LCZ_Armory => Config.Instance.Scp079.CloseDoor["ArmoryDef"],
                    DoorType.Nuke_Armory => Config.Instance.Scp079.CloseDoor["WarheadArmor"],
                    DoorType.HID or DoorType.HID_Left or DoorType.HID_Right => Config.Instance.Scp079.CloseDoor["Gates"],
                    DoorType.Gate_A or DoorType.Gate_B => Config.Instance.Scp079.CloseDoor["SurfaceGate"],
                    DoorType.Surface_Gate => Config.Instance.Scp079.CloseDoor["MicroHidRoom"],
                    DoorType.HCZ_079_First or DoorType.HCZ_079_Second => Config.Instance.Scp079.CloseDoor["Scp079andScp106"],
                    DoorType.HCZ_106_Bottom or DoorType.HCZ_106_Primary or DoorType.HCZ_106_Secondary => Config.Instance.Scp079.CloseDoor["Scp079andScp106"],
                    DoorType.Surface_Nuke => Config.Instance.Scp079.CloseDoor["SurfaceWarhead"],
                    _ => Config.Instance.Scp079.CloseDoor["Default"],
                };
            }
            else
            {
                ev.PowerCost = ev.Door.Type switch
                {
                    DoorType.Checkpoint_EZ_HCZ or DoorType.Checkpoint_LCZ_A or DoorType.Checkpoint_LCZ_B => Config.Instance.Scp079.OpenDoor["Chkp"],
                    DoorType.HCZ_096 or DoorType.LCZ_012_Locker or DoorType.LCZ_330 or DoorType.LCZ_330_Chamber => Config.Instance.Scp079.OpenDoor["Scps"],
                    DoorType.LCZ_914 => Config.Instance.Scp079.OpenDoor["Scp914"],
                    DoorType.HCZ_049_Armory or DoorType.HCZ_Armory or DoorType.LCZ_Armory => Config.Instance.Scp079.OpenDoor["ArmoryDef"],
                    DoorType.Nuke_Armory => Config.Instance.Scp079.OpenDoor["WarheadArmor"],
                    DoorType.HID or DoorType.HID_Left or DoorType.HID_Right => Config.Instance.Scp079.OpenDoor["Gates"],
                    DoorType.Gate_A or DoorType.Gate_B => Config.Instance.Scp079.OpenDoor["SurfaceGate"],
                    DoorType.Surface_Gate => Config.Instance.Scp079.OpenDoor["MicroHidRoom"],
                    DoorType.HCZ_079_First or DoorType.HCZ_079_Second => Config.Instance.Scp079.OpenDoor["Scp079andScp106"],
                    DoorType.HCZ_106_Bottom or DoorType.HCZ_106_Primary or DoorType.HCZ_106_Secondary => Config.Instance.Scp079.OpenDoor["Scp079andScp106"],
                    DoorType.Surface_Nuke => Config.Instance.Scp079.OpenDoor["SurfaceWarhead"],
                    _ => Config.Instance.Scp079.OpenDoor["Default"],
                };
            }
        }

        public void Scp079(Scp079InteractLiftEvent ev) => ev.PowerCost = Config.Instance.Scp079.InteractLift;

        public void Scp079(Scp079LockdownEvent ev) => ev.PowerCost = Config.Instance.Scp079.Blackout;

        public void Scp079(Scp079ElevatorTeleportEvent ev) => ev.PowerCost = Config.Instance.Scp079.ElevatorTeleport;

        public void Scp079(Scp079InteractTeslaEvent ev)
        {
            ev.PowerCost = Config.Instance.Scp079.ActivateTesla;
            ev.Instant = Config.Instance.Scp079.InstantTesla;
        }

        public void Scp079(ChangeCameraEvent ev) => ev.PowerCost = Config.Instance.Scp079.ChangeCamera;
    }
}
