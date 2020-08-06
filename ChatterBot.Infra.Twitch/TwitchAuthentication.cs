﻿using System;
using System.Collections.Generic;

namespace ChatterBot.Infra.Twitch
{
    public class TwitchAuthentication
    {
        public const string ClientId = "4e5f6e3z1rfby5qaxcooobv2hpq2wg";

        public List<string> States { get; set; } = new List<string>();

        public const string RedirectUrl = "http://localhost:1111/";

        public static string[] Scopes =
        {
            "bits:read",
            "channel:edit:commercial",
            "channel:read:hype_train",
            "channel:read:subscriptions",
            "channel:moderate",
            "chat:edit",
            "chat:read",
            "whispers:read",
            "whispers:edit",
        };
        public static string ScopeString = string.Join("+", value: Scopes);


        public string GetUrl()
        {
            string state = Guid.NewGuid().ToString();
            States.Add(state);

            return $"https://id.twitch.tv/oauth2/authorize?client_id={ClientId}&redirect_uri={RedirectUrl}&response_type=token&scope={ScopeString}&state={state}";
        }
    }
}