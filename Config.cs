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
        public string FicandoPutoMessage { get; set; } = "You are <color=red>ANGRY</color>";

        [Description("The message that appears when 096 is calming down")]
        public string AcalmandoMessage { get; set; } = "You are getting <color=yellow>calmed</color> down";

        [Description("The message that appears when someone walks on 173's tantrum")]
        public string AndandoNoCocoMessage { get; set; } = "You are getting <color=black>corroded</color>.";
        [Description("The message that appears to someone when the looked at 096")]
        public string OlhoProChoras { get; set; } = "you are panicking.";

        [Description("How much time 173 stays with the SCP-207 effect after placing the tantrum")]
        public float CocoPeanutTempoCoca { get; set; } = 10;

        [Description("how much time a person is poisoned after walking in the SCP-173 tantrum")]
        public float CocoPeanutTempoEnvenenado { get; set; } = 6;

        [Description("how much time a person is bleeding after walking in the SCP-173 tantrum")]
        public float CocoPeanutTempoSangrando { get; set; } = 9;

        [Description("How much time someone stays panicking after looking at 096")]
        public float TempoPanico { get; set; } = 5;
        /// <summary>
        /// Issae.
        /// <summary>
        [Description("Max AHP of 096 in rage")]
        public int AHPMaximoChorasEmRage { get; set; } = 2000;

        [Description("Max AHP of 096 when he is calming down")]
        public int AHPMaximoChorasDepoisDeAcalmar { get; set; } = 1500;
        /// <summary>
        /// Seinãohein.
        /// <summary>
        [Description("AHP That 096 gets when he is entering rage Ex: If he has 200 AHP before entering in rage he is gonna get this amount of AHP after entering in rage")]
        public int AHPFicaEmRageChoras { get; set; } = 1500;
        /// <summary>
        /// -1 de qi.
        /// <summary>
        [Description("Max 096 health in rage")]
        public int VidaMaximaChorasRage { get; set; } = 2500;
        /// <summary>
        /// N sei mais.
        /// <summary>
        [Description("Max 096 health when he is calming down")]
        public int VidaMaximaChorasAcalmado { get; set; } = 2100;

        [Description("How much time he gains of rage when someone looks at him")]
        public float ChorasTempoRageGanharOlhada { get; set; } = 2;

        [Description("How much colas effects are given to SCP-173 when he places his tantrum")]
        public byte IntensidadeCocaQuantasEfeitoPeanut { get; set; } = 2;

    }
}