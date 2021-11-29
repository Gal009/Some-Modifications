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
using moreStatusEffects;
using ExEvents = Exiled.Events.Handlers;
using ChorãoUtilities.Handlers;

namespace ChorãoUtilities
{
    public class Plugin : Plugin<Config>
    {
        private static readonly Lazy<Plugin> LazyInstance = new Lazy<Plugin>(valueFactory: () => new Plugin());
        public static Plugin Instance => LazyInstance.Value;

        public override PluginPriority Priority { get; } = PluginPriority.Lowest;
        public Handlers.Server2 server;
        public Handlers.Player2 player;
        public static Plugin Singleton;
        public EventHandlers EventHandlers;

        public override void OnEnabled()
        {
            Singleton = this;
            EventHandlers = new EventHandlers(this);
            RegisterEvents();

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Singleton = null;
            EventHandlers = null;
            UnRegisterEvents();

            base.OnDisabled();
        }

        public void RegisterEvents()
        {
            server = new Handlers.Server2();
            player = new Handlers.Player2();


            Player.Hurting += player.OnHurting;
            Exiled.Events.Handlers.Scp096.AddingTarget += player.OnEnraging096;
            Player.WalkingOnTantrum += player.OnWalkingOnTantrum;
            Player.EnteringFemurBreaker += player.OnEnteringFemurBreaker;
            ExEvents.Scp096.Enraging += player.OnEnraging;
            ExEvents.Scp096.AddingTarget += player.OnAddingTarget;
            ExEvents.Scp096.CalmingDown += player.OnCalmingDown;
            ExEvents.Scp173.PlacingTantrum += player.OnPlacingTantrum;
        }

        public void UnRegisterEvents()
        {

            Player.Hurting -= player.OnHurting;
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