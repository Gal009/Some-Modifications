using System;
using Exiled.API.Features;
using Player = Exiled.Events.Handlers.Player;
using ExEvents = Exiled.Events.Handlers;

namespace ChorãoUtilities
{
    public class Plugin : Plugin<Config>
    {
        public override Version RequiredExiledVersion { get; } = new Version(4, 1, 4);

        public Handlers.Player2 player;

        //I know maybe it's not nescessary but i created a function for the events.

        public override void OnEnabled()
        {
            RegisterEvents();

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            UnRegisterEvents();

            base.OnDisabled();
        }

        public void RegisterEvents()
        {
            player = new Handlers.Player2(this);

            ExEvents.Scp096.AddingTarget += player.OnEnraging096;
            Player.WalkingOnTantrum += player.OnWalkingOnTantrum;
            Player.EnteringFemurBreaker += player.OnEnteringFemurBreaker;
            ExEvents.Scp096.Enraging += player.OnEnraging;
            ExEvents.Scp096.AddingTarget += player.OnAddingTarget;
            ExEvents.Scp096.CalmingDown += player.OnCalmingDown;
            ExEvents.Scp173.PlacingTantrum += player.OnPlacingTantrum;
            Player.Hurting += player.OnGettingHurt;
            Player.Hurting += player.OnHurtingAPlayer;
        }

        public void UnRegisterEvents()
        {
            ExEvents.Scp096.AddingTarget -= player.OnEnraging096;
            Player.WalkingOnTantrum -= player.OnWalkingOnTantrum;
            Player.EnteringFemurBreaker -= player.OnEnteringFemurBreaker;
            ExEvents.Scp096.Enraging -= player.OnEnraging;
            ExEvents.Scp096.AddingTarget -= player.OnAddingTarget;
            ExEvents.Scp096.CalmingDown -= player.OnCalmingDown;
            ExEvents.Scp173.PlacingTantrum -= player.OnPlacingTantrum;
            Player.Hurting -= player.OnGettingHurt;
            Player.Hurting -= player.OnHurtingAPlayer;

            player = null;
        }
    }
}