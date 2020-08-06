﻿using ChatterBot.Core;
using MahApps.Metro.IconPacks;
using System.Collections.ObjectModel;

namespace ChatterBot.ViewModels
{
    public class CommandsViewModel : MenuItemViewModel
    {
        public ObservableCollection<CustomCommand> CustomCommands { get; } = new ObservableCollection<CustomCommand>();

        public CommandsViewModel()
        {
            Icon = new PackIconFontAwesome { Kind = PackIconFontAwesomeKind.ExclamationSolid };
            Label = "Commands";
            ToolTip = "Custom Commands";

            CustomCommands.Add(new CustomCommand { Access = Access.Everyone, CommandWord = "!ping", Response = "Pong!" });
            CustomCommands.Add(new CustomCommand
            {
                Access = Access.VIPs,
                CommandWord = "!so",
                Response = "Huge shout out to $arg1! Go check them out! https://www.twitch.tv/$name1"
            });
        }
    }
}