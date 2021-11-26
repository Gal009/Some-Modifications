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
using moreStatusEffects;
using ExEvents = Exiled.Events.Handlers;
using Exiled.API.Enums;
using MEC;
using Exiled.API;
using Exiled.Events;


namespace ChorãoUtilities.Handlers
{
    public class Player2
    {

        public void OnLeft(LeftEventArgs ev)
        {
            Log.Info(message: $"{ev.Player} Saiu do server");
        }

        public void OnJoined(JoinedEventArgs ev)
        {
            Log.Info(message: $"{ev.Player} Entrou no server");
        }

        public void OnEnraging(EnragingEventArgs ev)
        {
            if (ev.Player.Role == RoleType.Scp096)
            {
                ev.Player.Broadcast(6, Plugin.Instance.Config.FicandoPutoMessage);
                ev.Player.MaxArtificialHealth = Plugin.Singleton.Config.AHPMaximoChorasEmRage;
                ev.Player.MaxHealth = Plugin.Singleton.Config.VidaMaximaChorasRage;
                ev.Player.ArtificialHealth = Plugin.Singleton.Config.AHPFicaEmRageChoras;
            }
        }

        public void OnCalmingDown(CalmingDownEventArgs ev)
        {
            if (ev.Player.Role == RoleType.Scp096)
            {
                ev.Player.ShowHint(Plugin.Instance.Config.AcalmandoMessage, 5);
                ev.Player.MaxArtificialHealth = Plugin.Singleton.Config.AHPMaximoChorasDepoisDeAcalmar;
                ev.Player.MaxHealth = Plugin.Singleton.Config.VidaMaximaChorasAcalmado;
            }
        }

        public void OnAddingTarget(AddingTargetEventArgs ev)
        {
            {
                ev.EnrageTimeToAdd = Plugin.Singleton.Config.ChorasTempoRageGanharOlhada;
            }
        }

        public void OnEnraging096(AddingTargetEventArgs ev)
        {
            ev.Target.ShowHint(Plugin.Instance.Config.OlhoProChoras);
            ev.Target.EnableEffect(EffectType.Panic, Plugin.Singleton.Config.TempoPanico);
        }

        public void OnWalkingOnTantrum(WalkingOnTantrumEventArgs ev)
        {
            if (ev.Player.Team != Team.SCP)
            {
                ev.Player.ShowHint(Plugin.Instance.Config.AndandoNoCocoMessage, 5);
                ev.Player.EnableEffect(EffectType.Bleeding, Plugin.Singleton.Config.CocoPeanutTempoSangrando);
                ev.Player.EnableEffect(EffectType.Poisoned, Plugin.Singleton.Config.CocoPeanutTempoEnvenenado);
            }
        }

        public void OnPlacingTantrum(PlacingTantrumEventArgs ev)
        {
            if (ev.Player.IsScp)
            {
                ev.Player.EnableEffect(EffectType.Scp207, Plugin.Singleton.Config.CocoPeanutTempoCoca);
            }
        }
    }
}

