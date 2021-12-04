using Exiled.API.Enums;
using Exiled.API.Interfaces;
using System.Collections.Generic;
using System.ComponentModel;
using Exiled.API.Features;
using MEC;
using Exiled.Events.EventArgs;
using UnityEngine;
using PlayableScps;

namespace ChorãoUtilities
{
    public sealed class Config : IConfig
    {
        [Description("Se o plugin está habilitado")]
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

        [Description("Max AHP of 096 when he is calming down")]
        public int Max096AHPAfterCalmingDown { get; set; } = 1500;

        [Description("Max 096 health in rage")]
        public int MaxHealth096InRage { get; set; } = 2500;

        [Description("Max 096 max health when he is calming down")]
        public int MaxHealth096CalmingDown { get; set; } = 2100;

        [Description("How much time he gains of rage when someone looks at him")]
        public float TimeThat096GainsOfRageWhenSomeoneLooks { get; set; } = 2;

        [Description("How much colas effects are given to SCP-173 when he places his tantrum")]
        public byte CokeIntensityWhenPeanutPlacesTantrum { get; set; } = 2;

        [Description("The message that appears when someone enters on the femur breaker")]
        public string EnteringOnFemurBreaker { get; set; } = "You feel your <color=red>FEMUR</color> breaking";

        [Description("The message that appears when someone is dying to decontamination")]
        public string NoobDiedtoDecontamination { get; set; } = "You can't breath";

        [Description("The message that appears when SCP-939 bites someone.")]
        public string BleedingMessage { get; set; } = "You are bleeding";

        [Description("The amount of time someone stays with the bleeding effect after being hit by a bite of an SCP-939")]
        public float BleedingTime { get; set; } = 5;
    }
}