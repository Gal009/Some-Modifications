using Exiled.Events.EventArgs;
using Exiled.API.Features;
using CustomPlayerEffects;
using Exiled.API.Enums;

namespace ChorãoUtilities.Handlers
{
    public class Player2
    {

        public void OnEnraging(EnragingEventArgs ev)
        {
            ev.Player.Broadcast(6, Plugin.Singleton.Config.AngryMessage);
            ev.Player.MaxArtificialHealth = Plugin.Singleton.Config.Max096AHPInRage;
        }

        public void OnCalmingDown(CalmingDownEventArgs ev)
        {
            ev.Player.ShowHint(Plugin.Singleton.Config.CalmingDownMessage, 5);
            ev.Player.MaxArtificialHealth = Plugin.Singleton.Config.Max096AHPAfterCalmingDown;
        }

        public void OnAddingTarget(AddingTargetEventArgs ev)
        {
            ev.EnrageTimeToAdd = Plugin.Singleton.Config.TimeThat096GainsOfRageWhenSomeoneLooks;
        }

        public void OnEnraging096(AddingTargetEventArgs ev)
        {
            ev.Target.ShowHint(Plugin.Singleton.Config.LookedTo096);
            ev.Target.EnableEffect(EffectType.BodyshotReduction, Plugin.Singleton.Config.PanicTime);
        }

        public void OnWalkingOnTantrum(WalkingOnTantrumEventArgs ev)
        {
            if (ev.Player.IsHuman)
            {
                ev.Player.ShowHint(Plugin.Singleton.Config.WalkingOnTantrumMessage, 5);
                ev.Player.EnableEffect(EffectType.Poisoned, Plugin.Singleton.Config.PeanutPoisoningWalkingOnTantrumTime);
            }
        }

        public void OnPlacingTantrum(PlacingTantrumEventArgs ev)
        {
            ev.Player.EnableEffect(EffectType.Scp207, Plugin.Singleton.Config.PeanutPlacingTantrumCokeTime);
        }

        public void OnEnteringFemurBreaker(EnteringFemurBreakerEventArgs ev)
        {
            ev.Player.ShowHint(Plugin.Singleton.Config.EnteringOnFemurBreaker, 5);
        }

        public void OnGettingHurt(HurtingEventArgs ev)
        {
            if (ev.Handler.Type == DamageType.Decontamination)
            {
                ev.Target.ShowHint(Plugin.Singleton.Config.NoobDiedtoDecontamination, 5);
            }
        }

        public void OnHurtingAPlayer(HurtingEventArgs ev)
        {
            foreach (Player player in Player.List)
                if (ev.Attacker != null && player.ReferenceHub != null)
                    if (ev.Attacker.Role == RoleType.Scp93989)
            {
                ev.Target.ShowHint(Plugin.Singleton.Config.BleedingAppearDogMessage, 5);
                ev.Target.EnableEffect(EffectType.Bleeding, Plugin.Singleton.Config.BleedingDogBiteTime);
            }
            else

            {
                        if (ev.Attacker.Role == RoleType.Scp93989)
                        {
                            ev.Target.ShowHint(Plugin.Singleton.Config.PoisonedDogMessage);
                            ev.Target.EnableEffect(EffectType.Poisoned, Plugin.Singleton.Config.PoisonedDogBiteTime);
                        }
           }
        }
    }
}
    


