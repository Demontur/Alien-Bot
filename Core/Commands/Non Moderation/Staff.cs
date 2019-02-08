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

namespace Discord_bot_gta.Core.Commands.Non_Moderation
{
    public class staff : ModuleBase<SocketCommandContext>
    {
        [Command("Staff"), Alias("staff")]
        public async Task Build()
        {
            EmbedBuilder builder = new EmbedBuilder();

            builder.WithTitle("Staff application")

                .WithTimestamp(DateTimeOffset.UtcNow)

                .WithAuthor("")

                .WithColor(Color.Orange);

                builder.WithDescription("https://docs.google.com/forms/d/e/1FAIpQLSd3zwNkA4fjrOC-65AoZiqgFXb64qnljaXOYJ4SkZipalfVvg/viewform");

            var embed = builder.Build();
            await Context.Channel.SendMessageAsync(
                "",
                embed: embed)
                .ConfigureAwait(false);
        }
    }
}
