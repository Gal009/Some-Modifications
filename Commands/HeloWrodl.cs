using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandSystem;
using RemoteAdmin;

namespace ChorãoUtilities.Commands
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    class HeloWrodl : ICommand
    {
        public string Command { get; } = "Helo";

        public string[] Aliases { get; } = { "helo wold" };

        public string Description { get; } = "Comando do helo";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (sender is PlayerCommandSender player)
            {
                response = $"ralo {player.Nickname}";
                return false;
            }
            else
            {
                response = "wold";
                return true;
            }
        }
    }
}
