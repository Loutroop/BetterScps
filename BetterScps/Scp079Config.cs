using System.Collections.Generic;
using System.ComponentModel;

namespace BetterScps
{
    public class Scp079Config
    {
        [Description("Power cost on open a door.")]
        public Dictionary<string, int> OpenDoor { get; set; } = new()
        {
            { "Default", 5 },
            { "Chkp", 10 },
            { "Scps", 40 },
            { "Scp914", 50 },
            { "ArmoryDef", 50 },
            { "WarheadArmor", 60 },
            { "Gates", 60 },
            { "SurfaceGate", 60 },
            { "MicroHidRoom", 70 },
            { "Scp079andScp106", 110 },
            { "SurfaceWarhead", 110 }
        };

        [Description("Power cost on close a door.")]
        public Dictionary<string, int> CloseDoor { get; set; } = new()
        {
            { "Default", 5 },
            { "Chkp", 10 },
            { "Scps", 40 },
            { "Scp914", 50 },
            { "ArmoryDef", 50 },
            { "WarheadArmor", 60 },
            { "Gates", 60 },
            { "SurfaceGate", 60 },
            { "MicroHidRoom", 70 },
            { "Scp079andScp106", 110 },
            { "SurfaceWarhead", 110 }
        };

        [Description("Power cost on interact with lift.")]
        public int InteractLift { get; set; } = 10;

        [Description("Power cost on change camera.")]
        public int ChangeCamera { get; set; } = 10;

        [Description("Power cost on elevator teleport.")]
        public int ElevatorTeleport { get; set; } = 20;

        [Description("Power cost on activate a tesla.")]
        public int ActivateTesla { get; set; } = 50;

        [Description("Power cost on blackout in a room.")]
        public int Blackout { get; set; } = 60;

        [Description("Instant trigger of the tesla on interact?")]
        public bool InstantTesla { get; set; } = false;
    }
}
