using Exiled.API.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace SomeModifications
{
    public class Translations : ITranslation
    {

        [Description("The message that appears when 096 is enraged")]
        public string AngryMessage { get; set; } = "You are <color=red>ANGRY</color>";

        [Description("The message that appears when 096 is calming down")]
        public string WalkingOnTantrumMessage { get; set; } = "You are getting <color=black>corroded</color>.";

        [Description("The message that appears to someone when the looked at 096")]
        public string LookedTo096 { get; set; } = "you are panicking.";

        [Description("The message that appears when a SCP-93953 hits the player and the player starts bleeding")]
        public string Hitscp93953Message { get; set; } = "As a result of your injuries you started to bleed.";

        [Description("The message that appears when SCP-173 places the tantrum")]
        public string PlacingTantrumMessage { get; set; } = "You feel faster...";

        [Description("The message that appears when a player joins the server (It appears as a report Pop-Up)")]
        public string JoinedTheServerMessage { get; set; } = "Welcome to my cool server, enjoy your stay! :D";

        [Description("The message that appears to someone when a SCP-93989 bites him")]
        public string Hitscp93989Message { get; set; } = "You are poisoned";
    }
}
