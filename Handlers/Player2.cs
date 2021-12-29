using Exiled.Events.EventArgs;
using Exiled.API.Features;
using CustomPlayerEffects;
using Exiled.API.Enums;
using System;
using System.Collections.Generic;
using NorthwoodLib.Pools;

namespace ChorãoUtilities.Handlers
{
    public class Player2
    {

        private readonly Plugin plugin;
        public Player2(Plugin plugin) => this.plugin = plugin;

        public void OnEnraging(EnragingEventArgs ev)
        {
            ev.Player.Broadcast(6, plugin.Config.AngryMessage);
            ev.Scp096.CurMaxShield = plugin.Config.Max096AHPInRage;
            ev.Scp096.ShieldRechargeRate = plugin.Config.RechargeRateShield;
        }

        public void OnCalmingDown(CalmingDownEventArgs ev)
        {
            ev.Player.ShowHint(plugin.Config.CalmingDownMessage, 5);
        }

        public void OnAddingTarget(AddingTargetEventArgs ev)
        {
            ev.EnrageTimeToAdd = plugin.Config.TimeThat096GainsOfRageWhenSomeoneLooks;
        }

        public void OnEnraging096(AddingTargetEventArgs ev)
        {
            ev.Target.Broadcast(5, plugin.Config.LookedTo096);
            ev.Target.EnableEffect(EffectType.BodyshotReduction, plugin.Config.PanicTime);
        }

        public void OnWalkingOnTantrum(WalkingOnTantrumEventArgs ev)
        {
            if (ev.Player.IsHuman)
            {
                ev.Player.ShowHint(plugin.Config.WalkingOnTantrumMessage, 5);
                ev.Player.EnableEffect(EffectType.Poisoned, plugin.Config.PeanutPoisoningWalkingOnTantrumTime);
                ev.Player.EnableEffect(EffectType.Bleeding, plugin.Config.PeanutBleedingWalkingOnTantrumTime);
            }
        }

        public void OnPlacingTantrum(PlacingTantrumEventArgs ev)
        {
            ev.Player.ShowHint(plugin.Config.PlacingTantrumMessage, 5);
            ev.Player.EnableEffect(EffectType.MovementBoost, plugin.Config.PeanutPlacingTantrumCokeTime);
            ev.Player.ChangeEffectIntensity<MovementBoost>(plugin.Config.Intensity173Speedboost);
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
            if (ev.Attacker == null || ev.Target == null || ev.Attacker == ev.Target)
                return;
            if (ev.Attacker.Role == RoleType.Scp93953)
            {
                ev.Target.ShowHint(plugin.Config.BleedingAppearDogMessage, 5);
                ev.Target.EnableEffect(EffectType.Bleeding, plugin.Config.BleedingDogBiteTime);
                {
                    if (ev.Attacker.Role == RoleType.Scp93989)
                    {
                        ev.Target.ShowHint(plugin.Config.PoisonedDogMessage, 5);
                        ev.Target.EnableEffect(EffectType.Poisoned, plugin.Config.PoisonedDogBiteTime);
                    }
                }
            }
        }
        public void OnUsedItem(UsedItemEventArgs ev)
        {
            if (ev.Player.CurrentItem.Type == ItemType.Medkit)
            {
                ev.Player.DisableEffect<Bleeding>();
                ev.Player.DisableEffect<Poisoned>();
            }
        }

        public void OnPickingUpScp330(PickingUpScp330EventArgs ev)

            {
                ev.Usage = -9;
            }
    }
}


