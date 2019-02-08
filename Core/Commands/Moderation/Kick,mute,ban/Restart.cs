using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using System.Linq;
using Discord.WebSocket;
using Discord;
using Discord.Commands;
using Discord.Net;
using Discord.Webhook;
using Discord.WebSocket;
using Discord.Rest;
using System.Reflection;
using System.IO;
using Newtonsoft.Json;

namespace Discord_bot_gta.Core.Commands.Moderation.Kick_mute_ban
{
    class Restart : ModuleBase<SocketCommandContext>
    {
        [Command("Reload"), Alias("reload")]
        public async Task reload(SocketGuild userName)
        {
            var user = Context.User as SocketGuildUser;
            var role = (user as IGuildUser).Guild.Roles.FirstOrDefault(x => x.Name == "Bot Dev");
            if (!userName.Roles.Contains(role))
            {
               await Context.Channel.SendMessageAsync(":x: You cannot do this command.");
               return;
            }
            string SettingsLocation = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location).Replace(@"bin\Debug\netcoreapp2.1", @"bin\Debug\netcoreapp2.1");
            if (!File.Exists(SettingsLocation))
            {
                await Context.Channel.SendMessageAsync(":x: The File is not found in the correct location!");
                Console.WriteLine(SettingsLocation);
                return;
            }
            string JSON = "";
            using (var Stream = new FileStream(SettingsLocation, FileMode.Open, FileAccess.Read))
            using (var Readsettings = new StreamReader(Stream))
            {
                JSON = Readsettings.ReadToEnd();
            }
        }


    }
}
