using Exiled.Events.EventArgs;
using CustomPlayerEffects;
using Exiled.API.Enums;

namespace SomeModifications.Handlers
{
    public class Player2
    {

        private readonly Config config = Plugin.Singleton.Config;
        private readonly Translations translations = Plugin.Singleton.Translation;

        public void OnEnraging(EnragingEventArgs ev)
        {
            if (config.scp096EnrageThings)
            {
                ev.Player.ShowHint(translations.AngryMessage, 5);
                ev.Scp096.CurMaxShield = config.Max096AHPInRage;
                ev.Scp096.ShieldRechargeRate = config.scp096ShieldRechargeRate;
            }
        }
        public void OnAddingTarget(AddingTargetEventArgs ev)
        {
            if (config.scp096EnrageThings)
            {
                ev.EnrageTimeToAdd = config.TimeThat096GainsOfRageWhenSomeoneLooks;
            }
        }
        public void OnEnraging096(AddingTargetEventArgs ev)
        {
            if (config.scp096EnrageThings)
            {
                ev.Target.Broadcast(5, translations.LookedTo096);
                ev.Target.EnableEffect(EffectType.BodyshotReduction, config.PanicTime);
            }
        }
        public void OnWalkingOnTantrum(WalkingOnTantrumEventArgs ev)
        {
            if (!config.scp173TantrumDamageThings || ev.Player.IsHuman)
            {
                ev.Player.ShowHint(translations.WalkingOnTantrumMessage, 5);
                ev.Player.EnableEffect(EffectType.Bleeding, config.BleedingTimeWalkingOnTantrum);
                ev.Player.EnableEffect(EffectType.Poisoned, config.PoisonTimeWalkingOnTantrum);
            }
        }
        public void OnPlacingTantrum(PlacingTantrumEventArgs ev)
        {
            if (config.scp173PlacingTantrumThings)
            {
                ev.Player.ShowHint(translations.PlacingTantrumMessage, 5);
                ev.Player.EnableEffect(EffectType.MovementBoost, config.Scp173MovementBoostTime);
                ev.Player.ChangeEffectIntensity<MovementBoost>(config.scp173SpeedboostIntensity);
            }
        }

        public void OnHurtingAPlayer(HurtingEventArgs ev)
        {
            if (!config.scp939Things || ev.Attacker == null) return;

            if (ev.Attacker.Role == RoleType.Scp93953)
            {
                ev.Target.ShowHint(translations.Hitscp93953Message, 5);
                ev.Target.EnableEffect(config.Scp93953OnBiteEffect, config.Hitscp93953BleedingTime);
            }
            else if (ev.Attacker.Role == RoleType.Scp93989)
            {
                ev.Target.ShowHint(translations.Hitscp93989Message);
                ev.Target.EnableEffect(config.Scp93989OnBiteEffect, config.Hitscp93989PoisonedTime);
            }
        }

        public void OnUsedItem(UsedItemEventArgs ev)
        {
            if (config.ShouldMedkitRemoveEffects || ev.Player.CurrentItem.Type == ItemType.Medkit)
            {
                ev.Player.DisableEffect<Bleeding>();
                ev.Player.DisableEffect<Poisoned>();
            }
        }
        public void OnInteractingWithScp330(InteractingScp330EventArgs ev)
        {
            if (ev.UsageCount > config.NumberOfCandiesYouCanPick)
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
            if (config.ReportPopUpIsEnabled)
            {
                ev.Player.OpenReportWindow(translations.JoinedTheServerMessage);
            }
        }
    }
}