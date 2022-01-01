using Exiled.API.Features;
using Exiled.Events.EventArgs;

namespace ChorãoUtilities.Handlers
{
    public class Server2
    {
        private readonly Plugin plugin;
        public Server2(Plugin plugin) => this.plugin = plugin;

        public void OnRoundStarted()
        {
            Cassie.Message("pitch_1.1 xmas_bouncyballs", true, false);
        }

        public void OnRespawningTeam(RespawningTeamEventArgs ev)
        {
            if (ev.NextKnownTeam is Respawning.SpawnableTeamType.ChaosInsurgency)
            {
                Cassie.Message("pitch_1.3 xmas_bouncyballs", true, false);
             {
             }
            if (ev.NextKnownTeam is Respawning.SpawnableTeamType.NineTailedFox)
                {
                    Cassie.Message("pitch_0.8 xmas_JingleBells", true, false);
                }
            }
        }
    }
}
