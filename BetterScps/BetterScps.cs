using Qurre;
using Qurre.Events;
using System;

namespace BetterScps
{
    public class BetterScps : Plugin
    {
        public override string Name => "BetterScps";

        public override string Developer => "Qurre Team (Aureate#2824)";

        public override Version Version => new(1, 1, 0);

        public override Version NeededQurreVersion => new(1, 13, 0);

        public static new Config Config { get; private set; }

        public static EventHandlers EventHandlers { get; private set; }

        public override void Enable()
        {
            Config = new Config();
            EventHandlers = new EventHandlers();
            CustomConfigs.Add(Config);

            Player.RoleChange += EventHandlers.ScpChange;
            Round.End += EventHandlers.RoundEnd;
            Scp049.FinishRecall += EventHandlers.Revive;
            Scp079.ChangeCamera += EventHandlers.Scp079;
            Scp079.ElevatorTeleport += EventHandlers.Scp079;
            Scp079.InteractDoor += EventHandlers.Scp079;
            Scp079.InteractLift += EventHandlers.Scp079;
            Scp079.InteractTesla += EventHandlers.Scp079;
            Scp079.Lockdown += EventHandlers.Scp079;
        }

        public override void Disable()
        {
            Scp079.Lockdown -= EventHandlers.Scp079;
            Scp079.InteractTesla -= EventHandlers.Scp079;
            Scp079.InteractLift -= EventHandlers.Scp079;
            Scp079.InteractDoor -= EventHandlers.Scp079;
            Scp079.ElevatorTeleport -= EventHandlers.Scp079;
            Scp079.ChangeCamera -= EventHandlers.Scp079;
            Scp049.FinishRecall -= EventHandlers.Revive;
            Round.End -= EventHandlers.RoundEnd;
            Player.RoleChange -= EventHandlers.ScpChange;

            CustomConfigs.Remove(Config);
            EventHandlers = null;
            Config = null;
        }

        public override void Reload()
        {
            Disable();
            Enable();
            base.Reload();
        }
    }
}
