using Exiled.Events.EventArgs;
using CustomPlayerEffects;
using Exiled.API.Enums;

namespace SomeModifications.Handlers
{
    public class Player2
    {

        private readonly Plugin plugin;
        public Player2(Plugin plugin) => this.plugin = plugin;

        public void OnEnraging(EnragingEventArgs ev)
        {
            if (plugin.Config.Scp096EnrageThings)
            {
                ev.Player.Broadcast(6, plugin.Config.AngryMessage);
                ev.Scp096.CurMaxShield = plugin.Config.Max096AHPInRage;
                ev.Scp096.ShieldRechargeRate = plugin.Config.SCP096ShieldRechargeRate;
            }
        }
        public void OnAddingTarget(AddingTargetEventArgs ev)
        {
            if (plugin.Config.Scp096EnrageThings)
            {
                ev.EnrageTimeToAdd = plugin.Config.TimeThat096GainsOfRageWhenSomeoneLooks;
            }
        }
        public void OnEnraging096(AddingTargetEventArgs ev)
        {
            if (plugin.Config.Scp096EnrageThings)
            {
                ev.Target.Broadcast(5, plugin.Config.LookedTo096);
                ev.Target.EnableEffect(EffectType.BodyshotReduction, plugin.Config.PanicTime);
            }
        }
        public void OnWalkingOnTantrum(WalkingOnTantrumEventArgs ev)
        {
            if (plugin.Config.Scp173TantrumDamageThings)
                if (ev.Player.IsHuman)
                {
                    ev.Player.ShowHint(plugin.Config.WalkingOnTantrumMessage, 5);
                    ev.Player.EnableEffect(EffectType.Bleeding, plugin.Config.BleedingTimeWalkingOnTantrum);
                    ev.Player.EnableEffect(EffectType.Poisoned, plugin.Config.PoisonTimeWalkingOnTantrum);
                }
        }
        public void OnPlacingTantrum(PlacingTantrumEventArgs ev)
        {
            if (plugin.Config.Scp173PlacingTantrumThings)
            {
                ev.Player.ShowHint(plugin.Config.PlacingTantrumMessage, 5);
                ev.Player.EnableEffect(EffectType.MovementBoost, plugin.Config.Scp173MovementBoostTime);
                ev.Player.ChangeEffectIntensity<MovementBoost>(plugin.Config.SCP173SpeedboostIntensity);
            }
        }

        public void OnHurtingAPlayer(HurtingEventArgs ev)
        {
            if (!plugin.Config.Scp939Things || ev.Attacker == null) return;

            if (ev.Attacker.Role == RoleType.Scp93953)
            {
                ev.Target.ShowHint(plugin.Config.HitScp93953Message, 5);
                ev.Target.EnableEffect(EffectType.Bleeding, plugin.Config.HitSCP93953BleedingTime);
            }
            else if (ev.Attacker.Role == RoleType.Scp93989)
            {
                ev.Target.ShowHint(plugin.Config.HitSCP93989Message);
                ev.Target.EnableEffect(EffectType.Poisoned, plugin.Config.HitSCP93989PoisonedTime);
            }
        }
        
        public void OnUsedItem(UsedItemEventArgs ev)
        {
            if (plugin.Config.ShouldMedkitRemoveEffects)
            if (ev.Player.CurrentItem.Type == ItemType.Medkit)
            {
                ev.Player.DisableEffect<Bleeding>();
                ev.Player.DisableEffect<Poisoned>();
            }
        }
        public void OnInteractingWithScp330(InteractingScp330EventArgs ev)
        {
            if (ev.UsageCount > plugin.Config.NumberOfCandiesYouCanPick)
            {
                ev.ShouldSever = true;
            }
            else
            {
                ev.ShouldSever = false;
            }
        }
        public void OnPlayerVerified(VerifiedEventArgs ev)
        {
            if (plugin.Config.ReportPopUpIsEnabled)
            {
                ev.Player.OpenReportWindow(plugin.Config.JoinedTheServerMessage);
            }
        }
    }
}