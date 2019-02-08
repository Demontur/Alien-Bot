using Discord;

using Discord.Commands;

using System;

using System.Threading.Tasks;
using Discord.Commands;
using Discord.WebSocket;





namespace Discordbot

{

    public class Ban : ModuleBase<SocketCommandContext>

    {
        


        [Command("ban"), RequireBotPermission(GuildPermission.BanMembers), RequireUserPermission(GuildPermission.BanMembers)]

        public async Task BanTaskAsync(IGuildUser userToBan, [Remainder]string reason = null)

        {
            var user = Context.User as SocketGuildUser;

            EmbedBuilder builder = new EmbedBuilder();

            builder.WithTitle("banned")

                .WithDescription("Banned " + userToBan.Username)

                .WithTimestamp(DateTimeOffset.UtcNow)

                .WithAuthor($"{user}")

                .WithColor(Color.DarkRed);



            if (userToBan != Context.User)

            {



                await Context.Guild.AddBanAsync(userToBan, 0, reason);



                if (reason != null)

                {

                    builder.WithDescription("Banned " + userToBan.Username + " for " + reason);

                }



                await ReplyAsync("", false, builder.Build());



            }

            else

            {

                builder.WithDescription("You can't ban yourself!")

                    .WithColor(Color.Red);



                await ReplyAsync("", false, builder.Build());

            }





        }

        

    }

}