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

        [Description("A mensagem que aparece quando o choras ta puto")]
        public string FicandoPutoMessage { get; set; } = "Você está <color=red>PUTO</color>";

        [Description("A mensagem que aparece quando o choras se acalma")]
        public string AcalmandoMessage { get; set; } = "Você está se <color=yellow>acalmando</color>";

        [Description("A mensagem que aparece quando alguem anda no tantrum do SCP-173")]
        public string AndandoNoCocoMessage { get; set; } = "Você está sendo corroido.";
        [Description("A mensagem que aparece quando alguem olhou pro choras")]
        public string OlhoProChoras { get; set; } = "Você está entrando em pânico.";

        [Description("Quanto tempo o SCP-173 Fica com o efeito do SCP-207 após colocar o tantrum")]
        public float CocoPeanutTempoCoca { get; set; } = 10;

        [Description("Tempo que a pessoa fica com o efeito de envenenado depois de andar no tantrum do SCP-173")]
        public float CocoPeanutTempoEnvenenado { get; set; } = 6;

        [Description("Tempo que a pessoa fica com o efeito de sangrando depois de andar no tantrum do SCP-173")]
        public float CocoPeanutTempoSangrando { get; set; } = 9;

        [Description("A quantidade de tempo que a pessoa fica em pânico depois de olhar pro choras.")]
        public float TempoPanico { get; set; } = 5;
        /// <summary>
        /// Issae.
        /// <summary>
        [Description("AHP Maxima do chorão em rage")]
        public int AHPMaximoChorasEmRage { get; set; } = 2000;

        [Description("AHP Maxima depois do chorão enquanto esta se acalmando")]
        public int AHPMaximoChorasDepoisDeAcalmar { get; set; } = 1500;
        /// <summary>
        /// Seinãohein.
        /// <summary>
        [Description("AHP Que o chorão fica quando ta em rage (Exemplo: Se ele tava com 300 de AHP antes de ficar em rage quando ele entrar em rage ele vai ficar com esta quantia que você colocar)")]
        public int AHPFicaEmRageChoras { get; set; } = 1500;
        /// <summary>
        /// -1 de qi.
        /// <summary>
        [Description("Vida maxima do chorão em rage")]
        public int VidaMaximaChorasRage { get; set; } = 2500;
        /// <summary>
        /// N sei mais.
        /// <summary>
        [Description("Vida maxima do choras enquanto esta se acalmando")]
        public int VidaMaximaChorasAcalmado { get; set; } = 2100;

        [Description("Quanto de tempo o choras ganha de rage quando alguém olha pra ele")]
        public float ChorasTempoRageGanharOlhada { get; set; } = 2;

    }
}