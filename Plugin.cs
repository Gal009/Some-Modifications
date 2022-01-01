using System;
using Exiled.API.Features;
using Player = Exiled.Events.Handlers.Player;
using ExEvents = Exiled.Events.Handlers;

namespace ChorãoUtilities
{
    public class Plugin : Plugin<Config>
    {
        public override Version RequiredExiledVersion { get; } = new Version(4, 1, 7);

        private Handlers.Server2 server;
        public Handlers.Player2 player;

		public override void OnEnabled()
        {

            player = new Handlers.Player2(this);
            server = new Handlers.Server2(this);

            ExEvents.Scp096.Enraging += player.OnEnraging;
            ExEvents.Scp096.AddingTarget += player.OnAddingTarget;
            ExEvents.Scp096.CalmingDown += player.OnCalmingDown;
            ExEvents.Scp096.AddingTarget += player.OnEnraging096;
            ExEvents.Scp096.StartPryingGate += player.OnStartPryingGate;
            ExEvents.Scp173.PlacingTantrum += player.OnPlacingTantrum;
            Player.Hurting += player.OnGettingHurt;
            Player.Hurting += player.OnHurtingAPlayer;
            Player.ItemUsed += player.OnUsedItem;
            Player.WalkingOnTantrum += player.OnWalkingOnTantrum;
            Player.EnteringFemurBreaker += player.OnEnteringFemurBreaker;
            Player.InteractingScp330 += player.OnInteractingWithScp330;
            ExEvents.Server.RoundStarted += server.OnRoundStarted;
            ExEvents.Server.RespawningTeam += server.OnRespawningTeam;

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            ExEvents.Scp096.AddingTarget -= player.OnEnraging096;
            ExEvents.Scp096.Enraging -= player.OnEnraging;
            ExEvents.Scp096.AddingTarget -= player.OnAddingTarget;
            ExEvents.Scp096.CalmingDown -= player.OnCalmingDown;
            ExEvents.Scp096.StartPryingGate -= player.OnStartPryingGate;
            ExEvents.Scp173.PlacingTantrum -= player.OnPlacingTantrum;
            Player.Hurting -= player.OnGettingHurt;
            Player.Hurting -= player.OnHurtingAPlayer;
            Player.ItemUsed -= player.OnUsedItem;
            Player.WalkingOnTantrum -= player.OnWalkingOnTantrum;
            Player.EnteringFemurBreaker -= player.OnEnteringFemurBreaker;
            Player.InteractingScp330 -= player.OnInteractingWithScp330;
            ExEvents.Server.RoundStarted -= server.OnRoundStarted;
            ExEvents.Server.RespawningTeam -= server.OnRespawningTeam;

            player = null;
            server = null;

            base.OnDisabled();
        }
    }
}