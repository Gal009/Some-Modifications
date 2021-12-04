using Exiled.API.Features;
using Exiled.API.Enums;
using PlayableScps;
using Exiled.Events.EventArgs;
using System;
using System.Collections.Generic;
using MEC;
using Server = Exiled.Events.Handlers.Server;
using Player = Exiled.Events.Handlers.Player;
using Exiled.API.Extensions;
using Exiled.API.Features.Components;
using CustomPlayerEffects;
using ExEvents = Exiled.Events.Handlers;

namespace ChorãoUtilities
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin Instance => Singleton;

        public override PluginPriority Priority { get; } = PluginPriority.Lowest;
        public Handlers.Server2 server;
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
            server = new Handlers.Server2();
            player = new Handlers.Player2();


            Exiled.Events.Handlers.Scp096.AddingTarget += player.OnEnraging096;
            Player.WalkingOnTantrum += player.OnWalkingOnTantrum;
            Player.EnteringFemurBreaker += player.OnEnteringFemurBreaker;
            ExEvents.Scp096.Enraging += player.OnEnraging;
            ExEvents.Scp096.AddingTarget += player.OnAddingTarget;
            ExEvents.Scp096.CalmingDown += player.OnCalmingDown;
            ExEvents.Scp173.PlacingTantrum += player.OnPlacingTantrum;
            Player.Hurting += player.OnPlayerHurt;
        }

        public void UnRegisterEvents()
        {

            Exiled.Events.Handlers.Scp096.AddingTarget -= player.OnEnraging096;
            Player.WalkingOnTantrum -= player.OnWalkingOnTantrum;
            ExEvents.Scp096.Enraging -= player.OnEnraging;
            ExEvents.Scp096.AddingTarget -= player.OnAddingTarget;
            ExEvents.Scp096.CalmingDown -= player.OnCalmingDown;
            ExEvents.Scp173.PlacingTantrum -= player.OnPlacingTantrum;

            player = null;
            server = null;
        }
    }
}