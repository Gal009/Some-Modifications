using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RemoteAdmin;
using CommandSystem;

namespace ChorãoUtilities.Commands
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    class denai : ICommand
    {
        public string Command { get; } = "denai";

        public string[] Aliases { get; } = { };

        public string Description { get; } = "A comando dat is denaiado";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            response = "Comando nao suceso";
            return false;
        }
    }
}
