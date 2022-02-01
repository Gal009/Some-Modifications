using System;
using Exiled.API.Features;
using Player = Exiled.Events.Handlers.Player;
using ExEvents = Exiled.Events.Handlers;

namespace SomeModifications
{
    public class Plugin : Plugin<Config, Translations>
    {
        public override Version RequiredExiledVersion { get; } = new Version(4, 2, 2);
        public override string Name { get; } = "SomeModifications";
        public override Version Version { get; } = new Version(2, 6, 0);

        public static Plugin Singleton;
        public Handlers.Player2 player;

        public override void OnEnabled()
        {
            Singleton = this;
            player = new Handlers.Player2();

            ExEvents.Server.RoundStarted += player.OnRoundStarted;
            ExEvents.Scp096.Enraging += player.OnEnraging;
            ExEvents.Scp096.AddingTarget += player.OnAddingTarget;
            ExEvents.Scp096.AddingTarget += player.OnEnraging096;
            ExEvents.Scp173.PlacingTantrum += player.OnPlacingTantrum;
            Player.Hurting += player.OnHurtingAPlayer;
            Player.ItemUsed += player.OnUsedItem;
            Player.WalkingOnTantrum += player.OnWalkingOnTantrum;
            Player.InteractingScp330 += player.OnInteractingWithScp330;
            Player.Verified += player.OnPlayerVerified;

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            ExEvents.Server.RoundStarted += player.OnRoundStarted;
            ExEvents.Scp096.AddingTarget -= player.OnEnraging096;
            ExEvents.Scp096.Enraging -= player.OnEnraging;
            ExEvents.Scp096.AddingTarget -= player.OnAddingTarget;
            ExEvents.Scp173.PlacingTantrum -= player.OnPlacingTantrum;
            Player.Hurting -= player.OnHurtingAPlayer;
            Player.ItemUsed -= player.OnUsedItem;
            Player.WalkingOnTantrum -= player.OnWalkingOnTantrum;
            Player.InteractingScp330 -= player.OnInteractingWithScp330;
            Player.Verified -= player.OnPlayerVerified;

            Singleton = null;
            player = null;

            base.OnDisabled();
        }
    }
}