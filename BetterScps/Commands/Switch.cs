using CommandSystem;
using Qurre;
using Qurre.API;
using Qurre.Tools;
using System;
using System.Linq;

namespace BetterScps.Commands
{
    [CommandHandler(typeof(GameConsoleCommandHandler))]
    public class Switch : ICommand
    {
        public string Command => "switch";

        public string[] Aliases => new string[3] { "force", "change", "scpswap" };

        public string Description => "Switching your object.";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            #if DEBUG
            Log.Debug("BetterScps switch command use");
            #endif

            if (arguments.Count is not 1)
            {
                response = "\nFor use, you need to enter the number of the object.";
                return false;
            }

            if (!Round.Started)
            {
                response = "\nThe round hasn't even started, what are you doing?";
                return false;
            }

            if (!Config.Instance.IsEnabled)
            {
                response = "\nBetterScps modification is disabled";
                return false;
            }

            var user = Players.Get(sender);

            if (user.IsScp())
            {
                if (Config.Instance.BlackListedScps.Contains(user.Role))
                {
                    response = "\nYour object is banned to switch.";
                    return false;
                }

                if (Round.ElapsedTime.TotalSeconds > Config.Instance.Time)
                {
                    response = "\nThe time for switch has passed.";
                    return false;
                }

                string scpNumber = arguments.ElementAt(0).ToString().ToLower();

                if (!int.TryParse(scpNumber, out int result))
                    result = int.Parse(scpNumber.Substring(scpNumber.IndexOf(scpNumber.FirstOrDefault(x => int.TryParse(x.ToString(), out int _))), 3));

                if (result.ToString() == user.ScpNumber())
                {
                    response = "\nYou are already a given object.";
                    return true;
                }

                var role = result switch
                {
                    049 => RoleType.Scp049,
                    0492 => RoleType.Scp0492,
                    079 => RoleType.Scp079,
                    106 => RoleType.Scp106,
                    173 => RoleType.Scp173,
                    939 => UnityEngine.Random.Range(0, 2) == 2 ? RoleType.Scp93953 : RoleType.Scp93989,
                    93953 => RoleType.Scp93953,
                    93989 => RoleType.Scp93989,
                    096 => RoleType.Scp096,
                    _ => RoleType.None,
                };

                if (Config.Instance.LimitedScps.Contains(role) && Player.List.Where(x => x.Role == role).Count() > 0)
                {
                    response = "\nThis object is limited and occupied!";
                    return true;
                }

                if (role != RoleType.None && !Config.Instance.BlackListedScps.Contains(role))
                {
                    user.Role = role;
                    response = "\nSuccessfully!";
                    return true;
                }

                response = "\nThe object number could not be processed or the object is forbidden to change!";
                return true;
            }

            response = "\nYou are not SCP-Object!";
            return false;
        }
    }
}
