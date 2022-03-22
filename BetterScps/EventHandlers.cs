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
                bool forceAllowed = Round.ElapsedTime.TotalSeconds <= Config.Instance.Time;
                ev.Player.Broadcast(forceAllowed ? Config.Instance.MessageIsForceAllowed : Config.Instance.MessageIsForceNotAllowed, (ushort)(forceAllowed ? 10 : 8));

                #if DEBUG
                Log.Debug(string.Format("{0} role changed to {1}, force is {2}", ev.Player.Name(), ev.Player.Role, forceAllowed ? "allowed" : "not allowed"));
                #endif
            }
        }
    }
}
