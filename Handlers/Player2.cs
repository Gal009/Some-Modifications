using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.Events.EventArgs;
using Exiled.API.Features;
using Exiled.API.Extensions;
using Exiled.API.Features.Components;
using CustomPlayerEffects;
using ExEvents = Exiled.Events.Handlers;
using Exiled.API.Enums;
using MEC;
using Exiled.API;
using Exiled.Events;
using System.Reflection;
using System.Runtime.CompilerServices;
using Exiled.API.Features.Items;
using Hints;
using InventorySystem;
using InventorySystem.Disarming;
using InventorySystem.Items;
using InventorySystem.Items.Firearms;
using InventorySystem.Items.Firearms.Attachments;
using InventorySystem.Items.Firearms.BasicMessages;
using Mirror;
using NorthwoodLib;
using NorthwoodLib.Pools;
using PlayableScps;
using PlayableScps.ScriptableObjects;
using PlayerStatsSystem;
using RemoteAdmin;
using UnityEngine;
using Utils.Networking;


namespace ChorãoUtilities.Handlers
{
    public class Player2
    {

        public void OnEnraging(EnragingEventArgs ev)
        {
            ev.Player.Broadcast(6, Plugin.Singleton.Config.AngryMessage);
            ev.Player.MaxArtificialHealth = Plugin.Singleton.Config.Max096AHPInRage;
            ev.Player.MaxHealth = Plugin.Singleton.Config.MaxHealth096InRage;
        }

        public void OnCalmingDown(CalmingDownEventArgs ev)
        {
            ev.Player.ShowHint(Plugin.Singleton.Config.CalmingDownMessage, 5);
            ev.Player.MaxArtificialHealth = Plugin.Singleton.Config.Max096AHPAfterCalmingDown;
            ev.Player.MaxHealth = Plugin.Singleton.Config.MaxHealth096CalmingDown;
        }

        public void OnAddingTarget(AddingTargetEventArgs ev)
        {
            ev.EnrageTimeToAdd = Plugin.Singleton.Config.TimeThat096GainsOfRageWhenSomeoneLooks;
        }

        public void OnEnraging096(AddingTargetEventArgs ev)
        {
            ev.Target.ShowHint(Plugin.Singleton.Config.LookedTo096);
            ev.Target.EnableEffect(EffectType.BodyshotReduction, Plugin.Singleton.Config.PanicTime);
        }

        public void OnWalkingOnTantrum(WalkingOnTantrumEventArgs ev)
        {
            if (ev.Player.IsHuman)
            {
                ev.Player.ShowHint(Plugin.Singleton.Config.WalkingOnTantrumMessage, 5);
                ev.Player.EnableEffect(EffectType.Poisoned, Plugin.Singleton.Config.PeanutPoisoningWalkingOnTantrumTime);
            }
        }

        public void OnPlacingTantrum(PlacingTantrumEventArgs ev)
        {
            ev.Player.EnableEffect(EffectType.Scp207, Plugin.Singleton.Config.PeanutPlacingTantrumCokeTime);
            ev.Player.ChangeEffectIntensity<Scp207>(Plugin.Singleton.Config.CokeIntensityWhenPeanutPlacesTantrum);
        }

        public void OnEnteringFemurBreaker(EnteringFemurBreakerEventArgs ev)
        {
            if (ev.Player.IsHuman)
            {
                ev.Player.ShowHint(Plugin.Singleton.Config.EnteringOnFemurBreaker, 5);
            }
        }

        public void OnTogglingNoClip(TogglingNoClipEventArgs ev)
        {
            ev.Player.ShowHint("Adm Abusus", 5);
        }

        public void OnGettingHurt(HurtingEventArgs ev)
        {
            if (ev.Handler.Type == DamageType.Decontamination)
            {
                ev.Target.ShowHint(Plugin.Singleton.Config.NoobDiedtoDecontamination, 5);
            }
        }

        public void OnHurtingAPlayer(HurtingEventArgs ev)
        {
            foreach(Player player in Player.List)
                if (ev.Attacker != null && player.ReferenceHub != null)
                    if (ev.Attacker.Role == RoleType.Scp93989)
            {
                ev.Target.ShowHint(Plugin.Singleton.Config.BleedingAppearDogMessage);
                ev.Target.EnableEffect(EffectType.Bleeding, 5);
            }
        }
    }
}
    


