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
    class alau : ICommand
    {
        public string Command { get; } = "alau";

        public string[] Aliases { get; } = { };

        public string Description { get; } = "Comando que suceso";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            response = "Comando sim suceso";
            return true;
        }
    }
}
