using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rocket.API;

namespace CommandTransparency
{
    public class CommandTransparencyConfiguration : IRocketPluginConfiguration
    {
       
        public List<string> IgnoredCommands;



        public void LoadDefaults()
        {
            IgnoredCommands = new List<string> {"/vanish"};

        }




    }
}
