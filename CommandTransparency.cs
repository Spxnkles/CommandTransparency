using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rocket.Core.Plugins;
using Rocket.Core.Logging;
using Rocket.Unturned.Player;
using Rocket.Unturned.Permissions;
using Rocket.Unturned.Commands;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Events;
using Steamworks;
using UnityEngine;
using SDG.Unturned;
using Rocket.Unturned.Enumerations;
using Rocket.API.Collections;
using Rocket.API;
using Rocket.Core.RCON;
using Logger = Rocket.Core.Logging.Logger;


namespace CommandTransparency
{
    public class CommandTransparency : RocketPlugin<CommandTransparencyConfiguration>
    {
        public static bool isToggled { get; set; }

        // Load message
        protected override void Load()
        {
            Logger.Log($"Loading {name} by Spinkles...");

            CommandTransparency.isToggled = true;

            UnturnedPlayerEvents.OnPlayerChatted += onPlayerChatted;


            Logger.Log($"{Name} {Assembly.GetName().Version} has been loaded!");
            Logger.Log($"");
        }


        // unload message
        protected override void Unload()
        {

            CommandTransparency.isToggled = false;

            UnturnedPlayerEvents.OnPlayerChatted -= onPlayerChatted;

            Logger.Log($"{name} by Spinkles has been unloaded!");
            Logger.Log($"");


        }


        private void onPlayerChatted(UnturnedPlayer player, ref Color color, string message, EChatMode chatmode, ref bool cancel)
        {
            if (CommandTransparency.isToggled == true)
            {

                Logger.Log($"{player} has chatted! Checking for permission.");

                if (player.HasPermission("CommandTransparency.TransparentCommands"))
                {
                    Logger.Log($"Permission found from {player}.");

                    string wasCommand = message.Substring(0, 1);


                    if (wasCommand == "/")
                    {
                        Logger.Log($"Chat is a command, because it starts with /!");

                        Logger.Log("Checking if the command isn't ignored.");


                        if (Configuration.Instance.IgnoredCommands.Any(message.ToLower().Contains))
                        {

                            Logger.Log($"Command is included in Ignored Commands.");

                        }
                        else
                        {

                            Logger.Log($"Command isn't ignored!");
                            Logger.Log($"Broadcasting to everyone what the command was now.");

                            var broadcastMessage = $"{player.CharacterName} has executed command {message}";


                            UnturnedChat.Say(color: Color.red, message: broadcastMessage);

                            Logger.Log($"Now everyone knows what the admin did! >:)");
                        }
                    }
                    else
                    {
                        Logger.Log($"It's not a command. Ignoring.");
                    }
                }

            }
        }








    }
}
