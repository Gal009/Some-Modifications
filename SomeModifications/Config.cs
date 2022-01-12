using Exiled.API.Interfaces;
using System.Collections.Generic;
using System.ComponentModel;

namespace SomeModifications
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

        [Description("How much time 173 stays with the Movement Boost effect after placing the tantrum")]
        public float Scp173MovementBoostTime { get; set; } = 10;

        [Description("how much time a person is poisoned after walking in the SCP-173 tantrum")]
        public float PoisonTimeWalkingOnTantrum { get; set; } = 6;

        [Description("How much time a person is bleeding after walking in the SCP-173 tantrum")]
        public float BleedingTimeWalkingOnTantrum { get; set; } = 5;

        [Description("How much time someone stays panicking after looking at 096")]
        public float PanicTime { get; set; } = 5;

        [Description("Max AHP of 096 in rage")]
        public int Max096AHPInRage { get; set; } = 1500;

        [Description("How much time he gains of rage when someone looks at him")]
        public float TimeThat096GainsOfRageWhenSomeoneLooks { get; set; } = 2;

        [Description("The message that appears when someone enters on the femur breaker")]
        public string EnteringOnFemurBreaker { get; set; } = "You feel your <color=red>FEMUR</color> breaking";

        [Description("The message that appears when a SCP-93953 hits the player and the player starts bleeding")]
        public string HitScp93953Message { get; set; } = "As a result of your injuries you started to bleed.";

        [Description("The amount of time that someone stays bleeding when the SCP-93953 bites him (Minimum time for the bleeding to work: 8)")]
        public float HitSCP93953BleedingTime { get; set; } = 9;

        [Description("The amount of time that someone stays poisoned when the SCP-93989 bites him (Minimum time for the poison to work: 8)")]
        public float HitSCP93989PoisonedTime { get; set; } = 8;

        [Description("The message that appears to someone when a SCP-93989 bites him")]
        public string HitSCP93989Message { get; set; } = "You are poisoned";

        [Description("The recharge rate of 096's shield when he enters in rage (Base-Game default: 40) Ps: I recommend the default config that i put because increasing it would be too op.")]
        public float SCP096ShieldRechargeRate { get; set; } = 45;

        [Description("The message that appears when SCP-173 places the tantrum")]
        public string PlacingTantrumMessage { get; set; } = "You feel faster...";
        [Description("The intensity of the 173 speed boost when he places the tantrum")]
        public byte SCP173SpeedboostIntensity { get; set; } = 20;

        [Description("The amount of candies that someone can pickup before his hands get severed, the way it works is: If you put the value in 0 it will be the default thing, so when someone picks up more than 2 candies his hands will get severed but if you put 1 it will be 3 and so on.")]
        public int NumberOfCandiesYouCanPick { get; set; } = 5;
        [Description("The message that appears when a player joins the server (It appears as a report Pop-Up)")]
        public string JoinedTheServerMessage { get; set; } = "Welcome to my cool server, enjoy your stay! :D";
        [Description("If the enraging things of SCP-096 are enabled")]
        public bool Scp096EnrageThings { get; set; } = true;

        [Description("If the SCP-173 Tantrum damage things are enabled")]
        public bool Scp173TantrumDamageThings { get; set; } = true;

        [Description("If the SCP-173 Placing Tantrum things are enabled")]
        public bool Scp173PlacingTantrumThings { get; set; } = true;

        [Description("If the SCP-939 things are enabled")]
        public bool Scp939Things { get; set; } = true;

        [Description("If the Report-PopUp Thing is enabled")]
        public bool ReportPopUpIsEnabled { get; set; } = true;

        [Description("If players should get the effects: Poisoned/Bleeding removed when they have used a medkit or a scp500")]
        public bool ShouldMedkitRemoveEffects { get; set; } = true;
    }
}