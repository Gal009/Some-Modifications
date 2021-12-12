using Exiled.Events.EventArgs;
using Exiled.API.Features;
using CustomPlayerEffects;
using Exiled.API.Enums;

namespace ChorãoUtilities.Handlers
{
    public class Player2
    {
        private readonly Plugin plugin;
        public Player2( Plugin plugin ) => this.plugin = plugin;

        public void OnEnraging(EnragingEventArgs ev)
        {
            ev.Player.Broadcast(6, plugin.Config.AngryMessage);
            ev.Player.MaxArtificialHealth = plugin.Config.Max096AHPInRage;
        }

        public void OnCalmingDown(CalmingDownEventArgs ev)
        {
            ev.Player.ShowHint(plugin.Config.CalmingDownMessage, 5);
            ev.Player.MaxArtificialHealth = plugin.Config.Max096AHPAfterCalmingDown;
        }

        public void OnAddingTarget(AddingTargetEventArgs ev)
        {
            ev.EnrageTimeToAdd = plugin.Config.TimeThat096GainsOfRageWhenSomeoneLooks;
        }

        public void OnEnraging096(AddingTargetEventArgs ev)
        {
            ev.Target.ShowHint(plugin.Config.LookedTo096);
            ev.Target.EnableEffect(EffectType.BodyshotReduction, plugin.Config.PanicTime);
        }

        public void OnWalkingOnTantrum(WalkingOnTantrumEventArgs ev)
        {
            if (ev.Player.IsHuman)
            {
                ev.Player.ShowHint(plugin.Config.WalkingOnTantrumMessage, 5);
                ev.Player.EnableEffect(EffectType.Poisoned, plugin.Config.PeanutPoisoningWalkingOnTantrumTime);
            }
        }

        public void OnPlacingTantrum(PlacingTantrumEventArgs ev)
        {
            ev.Player.EnableEffect(EffectType.Scp207, plugin.Config.PeanutPlacingTantrumCokeTime);
        }

        public void OnEnteringFemurBreaker(EnteringFemurBreakerEventArgs ev)
        {
            ev.Player.ShowHint(plugin.Config.EnteringOnFemurBreaker, 5);
        }

        public void OnGettingHurt(HurtingEventArgs ev)
        {
            if (ev.Handler.Type == DamageType.Decontamination)
            {
                ev.Target.ShowHint(plugin.Config.NoobDiedtoDecontamination, 5);
            }
        }

        public void OnHurtingAPlayer(HurtingEventArgs ev)
        {
            foreach (Player player in Player.List)
                if (ev.Attacker != null && player.ReferenceHub != null)
                    if (ev.Attacker.Role == RoleType.Scp93989)
            {
                        ev.Target.ShowHint(plugin.Config.BleedingAppearDogMessage, 5);
                        ev.Target.EnableEffect(EffectType.Bleeding, plugin.Config.BleedingDogBiteTime);
            }
            else
            {
                        if (ev.Attacker.Role == RoleType.Scp93989)
                        {
                            ev.Target.ShowHint(plugin.Config.PoisonedDogMessage);
                            ev.Target.EnableEffect(EffectType.Poisoned, plugin.Config.PoisonedDogBiteTime);
                        }
           }
        }
    }
}
    


