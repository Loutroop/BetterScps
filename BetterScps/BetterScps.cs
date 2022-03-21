using Qurre;
using Qurre.Events;
using System;

namespace BetterScps
{
    public class BetterScps : Plugin
    {
        public override string Name => "BetterScps";

        public override string Developer => "Aureate#2824";

        public override Version Version => new(1, 0, 1);

        public override Version NeededQurreVersion => new(1, 13, 0);

        public static new Config Config { get; private set; }

        public static EventHandlers EventHandlers { get; private set; }

        public override void Enable()
        {
            Config = new Config();
            EventHandlers = new EventHandlers();
            CustomConfigs.Add(Config);

            Player.RoleChange += EventHandlers.ScpChange;
        }

        public override void Disable()
        {
            Player.RoleChange -= EventHandlers.ScpChange;

            CustomConfigs.Remove(Config);
            EventHandlers = null;
            Config = null;
        }
    }
}
