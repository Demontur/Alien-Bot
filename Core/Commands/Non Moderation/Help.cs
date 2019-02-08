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
    public class Help : ModuleBase<SocketCommandContext>
    {
        [Command("Help"), Alias("help")]
        public async Task Build()

        {
            var user = Context.User as SocketGuildUser;

            var builder = new EmbedBuilder()
                .WithTitle("")
                .WithDescription("")
                .WithUrl("")
                .WithColor(new Color(0xFF8B00))
                .WithTimestamp(DateTimeOffset.FromUnixTimeMilliseconds(1543446898250))
                .WithFooter(footer =>
                {
                    footer
                        .WithText("Dm me command Ideals")
                        .WithIconUrl("https://cdn.discordapp.com/attachments/510272482415083531/517481934205616132/LightPhox.png");
                })

                .WithAuthor(author =>
                {
                    author
                        .WithName($"{user}");

                })
                 .AddField("**Alien's Bot**","**Main Commands**")
                .AddField("Owner", "Tell's you who created this Bot.")
                 .AddField("Staff", "Show's you the link to the staff application.")
                .AddField("Ideals","Please Dm Demontur#0524 to send command ideals")
                .AddField("----------------------------------------------------------------------------------------", "**Moderation Commands**")
                .AddField("Kick", "Kicks a member from the discord server")
                .AddField("Ban","Bans member from the discord server")
                .AddField("Mute","Mutes a player in the discord server")
                .AddField("Unmute", "Unmute's a player in the discord server");


            var embed = builder.Build();
            await Context.Channel.SendMessageAsync(
                "",
                embed: embed)
                .ConfigureAwait(false);
        }
    }
}