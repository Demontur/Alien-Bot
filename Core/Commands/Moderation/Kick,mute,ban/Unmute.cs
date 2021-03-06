﻿using Discord;

using Discord.Commands;

using System;

using System.Threading.Tasks;

using System.IO;





namespace Discordbot.Core.Moderation

{

    public class unmute : ModuleBase<SocketCommandContext>

    {



        [Command("unmute"), RequireBotPermission(GuildPermission.ManageRoles), RequireUserPermission(GuildPermission.KickMembers)]

        public async Task UnMuteTaskAsync(IGuildUser userToMute, [Remainder] string _ = null)

        {

            EmbedBuilder builder = new EmbedBuilder();

            builder.WithTitle("Muted")

                .WithTimestamp(DateTimeOffset.UtcNow)

                .WithAuthor("")

                .WithColor(Color.Blue);



            if (!userToMute.IsBot || userToMute != Context.User || !userToMute.GuildPermissions.KickMembers)

            {

                var role = Context.Guild.GetRole(542174153818767370);

                await userToMute.RemoveRoleAsync(role);

                File.WriteAllText("mutedPeople.txt", $"{userToMute.Id}\n");

                builder.WithDescription($"Successfully unmuted {userToMute.Username}");

            }

            else

            {

                builder.WithDescription($"{userToMute.Username} isn't a valid user to mute.");

            }



            await ReplyAsync("", false, builder.Build());

        }



    }

}