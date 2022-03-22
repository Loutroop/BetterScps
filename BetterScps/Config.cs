using Qurre.API.Addons;
using System.Collections.Generic;
using System.ComponentModel;

namespace BetterScps
{
    public sealed class Config : IConfig
    {
        [Description("Name of the plugin.")]
        public string Name { get; set; } = "BetterScps";

        [Description("Whether the plugin is enabled.")]
        public bool IsEnabled { get; set; } = true;

        [Description("The time at which it is allowed to change the object (In seconds).")]
        public int Time { get; set; } = 90;

        [Description("List of the blacklisted scps (Scps which contains in this list cannot use switch command).")]
        public List<RoleType> BlackListedScps { get; set; } = new List<RoleType>() 
        {
            RoleType.Scp0492,
        };

        [Description("List of the limited scps (Cannot switch to scps which contains in this list if he is already spawn in the map).")]
        public List<RoleType> LimitedScps { get; set; } = new List<RoleType>()
        { 
            RoleType.Scp096,
            RoleType.Scp079,
            RoleType.Scp173
        };

        [Description("The message when appearing for SCP if the time for changing the object has not yet passed.")]
        public string MessageIsForceAllowed { get; set; } = "<i>You can use <color=#FF0000>.force</color> command to switch your object or <color=#FFFF00>.scps</color> command to find out the status of all objects</i>";

        [Description("The message when appearing for SCP if the time for changing the object has already passed.")]
        public string MessageIsForceNotAllowed { get; set; } = "<i>You can use <color=#FFFF00>.scps</color> command to find out the status of all objects</i>";

        [Description("SCP-079 configuration")]
        public Scp079Config Scp079 { get; set; } = new Scp079Config();

        public Config() => Instance = this;

        public static Config Instance { get; private set; }
    }
}
