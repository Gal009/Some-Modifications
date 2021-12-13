using System;
using Exiled.API.Features;
using Player = Exiled.Events.Handlers.Player;
using ExEvents = Exiled.Events.Handlers;
using HarmonyLib;
using Exiled.Loader;

namespace ChorãoUtilities
{
    public class Plugin : Plugin<Config>
    {
        public override Version RequiredExiledVersion { get; } = new Version(4, 1, 4);

        public Handlers.Player2 player;

        private int _patchesCounter;

        private Harmony Harmony { get; set; }

        //Maybe im going to add some patches soon, if i don't add im going to delete this.

        private void Patch()
        {
            try
            {
                Harmony = new Harmony($"Choras.ChoraoUtilities.{++_patchesCounter}");

                bool lastDebugStatus = Harmony.DEBUG;
                Harmony.DEBUG = true;

                Harmony.PatchAll();

                Harmony.DEBUG = lastDebugStatus;

                Log.Debug("Patches applied successfully!", Loader.ShouldDebugBeShown);
            }
            catch (Exception e)
            {
                Log.Error($"Patches have failed {e}");
            }
        }

        private void Unpatch()
        {
            Harmony.UnpatchAll();

            Log.Debug("Patches have been undone!", Loader.ShouldDebugBeShown);
        }

        //I know maybe it's not nescessary but i created a function for the events.

        public override void OnEnabled()
        {
            RegisterEvents();

            base.OnEnabled();
            Patch();
        }

        public override void OnDisabled()
        {
            UnRegisterEvents();

            base.OnDisabled();
            Unpatch();
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