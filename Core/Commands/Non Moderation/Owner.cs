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

namespace Discordbot.Core.Commands
{
    public class Owner : ModuleBase<SocketCommandContext>
    {
        [Command("Owner"), Alias("owner")]
        public async Task Talk()

        {
            await Context.Channel.SendMessageAsync("The owner of this bot is Demontur#0524 and the Owner of the server is 卂尺匚卂几ㄩ爪#0357");
        }
    }
}