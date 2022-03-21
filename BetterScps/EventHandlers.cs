using Qurre;
using Qurre.API;
using Qurre.API.Events;
using Qurre.Tools;

namespace BetterScps
{
    public class EventHandlers
    {
        public void ScpChange(RoleChangeEvent ev)
        {
            if (ev.NewRole.IsScp() && ev.Allowed)
            {
                if (Round.ElapsedTime.TotalSeconds <= Config.Instance.Time)
                {
                    ev.Player.Broadcast(Config.Instance.MessageIsForceAllowed, 10);

#if DEBUG
                    Log.Debug(string.Format("{0} role changed to {1}, force is allowed", ev.Player.Name(), ev.Player.Role));
#endif
                }
                else
                {
                    ev.Player.Broadcast(Config.Instance.MessageIsForceNotAllowed, 8);

#if DEBUG
                    Log.Debug(string.Format("{0} role changed to {1}, force is not allowed", ev.Player.Name(), ev.Player.Role));
#endif
                }
            }
        }
    }
}
