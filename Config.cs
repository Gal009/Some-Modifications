using Exiled.API.Interfaces;
using System.ComponentModel;

namespace ChorãoUtilities
{
    public sealed class Config : IConfig
    {

        [Description("If the plugin is enabled")]
        public bool IsEnabled { get; set; } = true;

        [Description("The message that appears when 096 is enraged")]
        public string AngryMessage { get; set; } = "You are <color=red>ANGRY</color>";

        [Description("The message that appears when 096 is calming down")]
        public string CalmingDownMessage { get; set; } = "You are getting <color=yellow>calmed</color> down";

        [Description("The message that appears when someone walks on 173's tantrum")]
        public string WalkingOnTantrumMessage { get; set; } = "You are getting <color=black>corroded</color>.";
        [Description("The message that appears to someone when the looked at 096")]
        public string LookedTo096 { get; set; } = "you are panicking.";

        [Description("How much time 173 stays with the SCP-207 effect after placing the tantrum")]
        public float PeanutPlacingTantrumCokeTime { get; set; } = 10;

        [Description("how much time a person is poisoned after walking in the SCP-173 tantrum")]
        public float PeanutPoisoningWalkingOnTantrumTime { get; set; } = 6;

        [Description("How much time a person is bleeding after walking in the SCP-173 tantrum")]
        public float PeanutBleedingWalkingOnTantrumTime { get; set; } = 5;

        [Description("How much time someone stays panicking after looking at 096")]
        public float PanicTime { get; set; } = 5;

        [Description("Max AHP of 096 in rage")]
        public int Max096AHPInRage { get; set; } = 2000;

        [Description("How much time he gains of rage when someone looks at him")]
        public float TimeThat096GainsOfRageWhenSomeoneLooks { get; set; } = 2;

        [Description("The message that appears when someone enters on the femur breaker")]
        public string EnteringOnFemurBreaker { get; set; } = "You feel your <color=red>FEMUR</color> breaking";

        [Description("The message that appears when someone is dying to decontamination")]
        public string NoobDiedtoDecontamination { get; set; } = "You can't breath";

        [Description("The message that appears when a SCP-93953 hits the player and the player starts bleeding")]
        public string BleedingAppearDogMessage { get; set; } = "As a result of your injuries you started to bleed.";

        [Description("The amount of time that someone stays bleeding when the SCP-93953 bites him (Minimum time for the bleeding to work: 8)")]
        public float BleedingDogBiteTime { get; set; } = 9;

        [Description("The amount of time that someone stays poisoned when the SCP-93989 bites him (Minimum time for the poison to work: 8)")]
        public float PoisonedDogBiteTime { get; set; } = 8;

        [Description("The message that appears to someone when a SCP-93989 bites him")]
        public string PoisonedDogMessage { get; set; } = "You are poisoned";

        [Description("The recharge rate of 096's shield when he enters in rage (Base-Game default: 40) Ps: I recommend the default config that i put because increasing it would be too op.")]
        public float RechargeRateShield { get; set; } = 45;

        [Description("The message that appears when SCP-173 places the tantrum")]
        public string PlacingTantrumMessage { get; set; } = "You feel faster...";
    }
}