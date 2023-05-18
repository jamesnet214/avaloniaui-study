using System;
using System.Collections.Generic;

namespace AvaloniaApplication4.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public string Greeting => "Welcome to Avalonia!";

        public List<Team> Teams { get; }

        public MainViewModel()
        {

            Teams = new List<Team>();
            Teams.Add(new Team().DataGen("EPL", "Tottenham"));
            Teams.Add(new Team().DataGen("EPL", "Manchester City"));
            Teams.Add(new Team().DataGen("EPL", "Arsnal"));
        }
    }

    public class Team
    {
        public string Id { get; private set; }
        public string Name { get; private set; }

        internal Team DataGen(string id, string name)
        {
            Id = id;
            Name = name;
            return this;
        }
    }
}