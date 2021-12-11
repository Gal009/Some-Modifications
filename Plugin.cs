using Exiled.API.Features;
using Exiled.API.Enums;
using Player = Exiled.Events.Handlers.Player;
using ExEvents = Exiled.Events.Handlers;
using System;

namespace ChorãoUtilities
{
    public class Plugin : Plugin<Config>
    {
        public override Version RequiredExiledVersion { get; } = new Version(4, 1, 4);

        public Handlers.Player2 player;
        public static Plugin Singleton;


        public override void OnEnabled()
        {
            Singleton = this;
            RegisterEvents();

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Singleton = null;
            UnRegisterEvents();

            base.OnDisabled();
        }

        public void RegisterEvents()
        {
            player = new Handlers.Player2();


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
            ExEvents.Scp096.Enraging -= player.OnEnraging;
            ExEvents.Scp096.AddingTarget -= player.OnAddingTarget;
            ExEvents.Scp096.CalmingDown -= player.OnCalmingDown;
            ExEvents.Scp173.PlacingTantrum -= player.OnPlacingTantrum;
            Player.Hurting -= player.OnHurtingAPlayer;
            Player.Hurting -= player.OnGettingHurt;

            player = null;
        }
    }
}