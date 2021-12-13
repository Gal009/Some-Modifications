using Exiled.Events.EventArgs;
using Exiled.API.Features;
using CustomPlayerEffects;
using Exiled.API.Enums;

namespace ChorãoUtilities.Handlers
{
    public class Player2
    {
        // I made this so i don't have to use a singleton

        private readonly Plugin plugin;
        public Player2( Plugin plugin ) => this.plugin = plugin;

        // I don't know if the CurMaxShield is the 096's maxshield, i think Cur stands for Current, so maybe it will work but i haven't tested it yet.

        public void OnEnraging(EnragingEventArgs ev)
        {
            ev.Player.Broadcast(6, plugin.Config.AngryMessage);
            ev.Scp096.CurMaxShield = plugin.Config.Max096AHPInRage;
        }

        // I don't know if the CurMaxShield is the 096's maxshield, i think Cur stands for Current, so maybe it will work but i haven't tested it yet.

        public void OnCalmingDown(CalmingDownEventArgs ev)
        {
            ev.Player.ShowHint(plugin.Config.CalmingDownMessage, 5);
            ev.Scp096.CurMaxShield = plugin.Config.Max096AHPCalmingDown;
        }

        // I don't know if this code works because i haven't tested it yet, if it doesn't works dm me on discord that im going to try to fix it

        public void OnAddingTarget(AddingTargetEventArgs ev)
        {
            ev.EnrageTimeToAdd = plugin.Config.TimeThat096GainsOfRageWhenSomeoneLooks;
        }

        //I made this a broadcast so people can use ScpUtils and my plugin

        public void OnEnraging096(AddingTargetEventArgs ev)
        {
            ev.Target.Broadcast(5, plugin.Config.LookedTo096);
            ev.Target.EnableEffect(EffectType.BodyshotReduction, plugin.Config.PanicTime);
        }

        //I put the check: If (ev.Player.IsHuman) because i only want to this event trigger to humans.

        public void OnWalkingOnTantrum(WalkingOnTantrumEventArgs ev)
        {
            if (ev.Player.IsHuman)
            {
                ev.Player.ShowHint(plugin.Config.WalkingOnTantrumMessage, 5);
                ev.Player.EnableEffect(EffectType.Poisoned, plugin.Config.PeanutPoisoningWalkingOnTantrumTime);
                ev.Player.EnableEffect(EffectType.Bleeding, plugin.Config.PeanutBleedingWalkingOnTantrumTime);
            }
        }

        //Here i didn't put a Hint/Bc because i think it's not nescessary, but i think im going to add one soon so people don't get confused on why they are not regenerating the hume shield when they place the tantrum.

        public void OnPlacingTantrum(PlacingTantrumEventArgs ev)
        {
            ev.Player.EnableEffect(EffectType.Scp207, plugin.Config.PeanutPlacingTantrumCokeTime);
        }

        //Here i removed the if (ev.Player.IsHuman) check because Sc

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

        //I know maybe this code is not efficient, but i tried.

        public void OnHurtingAPlayer(HurtingEventArgs ev)
        {
            foreach (Player player in Player.List)
                if (ev.Attacker != null && player.ReferenceHub != null)
                    if (ev.Attacker.Role == RoleType.Scp93953)
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

        //Hey! You reached the end, if you have suggestions of things to add in my plugin dm me on discord!
    }
}
    


