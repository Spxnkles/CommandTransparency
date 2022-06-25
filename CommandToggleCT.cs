using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rocket.API;
using Rocket.Unturned.Chat;
using Rocket.Core.Logging;
using UnityEngine;
using Logger = Rocket.Core.Logging.Logger;

namespace CommandTransparency
{
    public class CommandToggleCT : IRocketCommand
    {
        public AllowedCaller AllowedCaller => AllowedCaller.Both;

        public string Name => "ToggleCT";

        public string Help => "Command to toggle command transparency on and off.";

        public string Syntax => string.Empty;

        public List<string> Aliases => new List<string> {"TCT"};

        public List<string> Permissions => new List<string> {"CommandTransparency.ToggleCT"};

        public void Execute(IRocketPlayer caller, string[] command)
        { 
            if (CommandTransparency.isToggled == true)
            {
                CommandTransparency.isToggled = false;

                UnturnedChat.Say(color: Color.yellow, message: $"Disabled command transparency!", player: caller);

                Logger.Log($"[{caller}] {caller.DisplayName} has disabled command transparency!");
            }
            else
            {
                CommandTransparency.isToggled = true;

                UnturnedChat.Say(color: Color.yellow, message: $"Enabled command transparency!", player: caller);

                Logger.Log($"[{caller}] {caller.DisplayName} has enabled command transparency!");
            }
        }             
    }
}
