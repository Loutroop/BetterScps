using CommandSystem;
using PlayableScps;
using Qurre.API;
using Qurre.Tools;
using System;
using System.Linq;

namespace BetterScps.Commands
{
    [CommandHandler(typeof(GameConsoleCommandHandler))]
    public class List : ICommand
    {
        public string Command => "scps";

        public string[] Aliases => new string[3] { "allscps", "alivescps", "живыесцп" };

        public string Description => "Показывает всех живых SCP";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (arguments.Count is not 0)
            {
                response = "\nFor use, you not need to enter arguments.";
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

            Player user = Player.Get(sender as CommandSender);

            if (user.IsScp())
            {
                response = string.Empty;

                var scps = Player.List.Where(x => x.IsScp() && x != user);

                if (scps.Count() == 0)
                {
                    response += "\nYou are the only SCP, but we still believe that you will win!"; 
                    return true;
                }
                else
                {
                    foreach (var scp in scps)
                    {
                        response += string.Format("{0} ({1}):\n", scp.Name(), scp.ScpNumber());
                        response += string.Format("Location: {0}\n", scp.Role == RoleType.Scp079 ? scp.Scp079Controller.Camera.Room.Zone.ToString() : scp.Zone.ToString());
                        response += string.Format("HP: {0}/{1}\n", scp.Hp, scp.MaxHp);
                        
                        if (scp.MaxAhp > 0)
                        {
                            response += string.Format("AHP: {0}/{1}\n", scp.Ahp, scp.MaxAhp);
                        }

                        if (scp.Role == RoleType.Scp096)
                        {
                            Scp096 scp096 = scp.CurrentScp as Scp096;
                            response += string.Format("Status: {0}\n", scp096.Enraged ? "Enraged." : scp096.Enraging ? "Enraging" : "Calm");

                            if (scp096.Enraged)
                            {
                                int count = scp.Scp096Controller.Targets.Where(x => x.Team != Team.RIP).Count();
                                response += string.Format("{0}\n", count == 0 ? "No live targets." : string.Format("Targets: {0}", count));
                            }
                        }
                        else if (scp.Role == RoleType.Scp173)
                        {
                            Scp173 scp173 = scp.CurrentScp as Scp173;

                            if (scp173._isObserved)
                                response += string.Format("Observers: {0}\n", scp173._observingPlayers.Count);
                        }
                        else if (scp.Role == RoleType.Scp079)
                        {
                            response += string.Format("Access level: {0}\n", scp.Scp079Controller.Lvl);
                            response += string.Format("Available energy: {0}/{1}\n", scp.Scp079Controller.Energy, scp.Scp079Controller.MaxEnergy);
                        }
                    }

                    return true;
                }
            }

            response = "\nYou are not SCP-Object!";
            return false;
        }
    }
}
