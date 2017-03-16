namespace Churchy.Repository.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Churchy.Model;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<Churchy.Repository.ChurchContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Churchy.Repository.ChurchContext context)
        {
            var church = new List<Church>
            {
                new Church {Name = "Renewal Christian Centre"},
                new Church {Name = "Mount Zion Community Church"},
                new Church {Name = "George Road Baptist Church"}
            };

            church.ForEach(s => context.Churches.AddOrUpdate(p => p.Name, s));
            context.SaveChanges();

            var notice = new List<Notice>
            {
                new Notice { Title = "Prayer Meeting", Description="prayer meeting everyday 6am & 6pm", ChurchId=1},
                new Notice { Title = "Member Meeting", Description="Annual members meeting please be there", ChurchId=2},
                new Notice { Title = "Alpha Starting Soon", Description="Invite someone alone to alpha", ChurchId=3},
                new Notice { Title = "Remember First Fruits Sunday", Description="Please remember your first fruits offering this sunday", ChurchId=1},
                new Notice { Title = "Prayer Meeting", Description="prayer meeting every tuesday 6am & 6pm", ChurchId=2},
                new Notice { Title = "Help Needed setting up this saturday", Description="we have a big event taking place this weekend help needed setting up", ChurchId=3},
                new Notice { Title = "Prayer Meeting", Description="prayer meeting every tuesday 6am & 6pm", ChurchId=3},
                new Notice { Title = "Leadership Course", Description="All leaders are required to attend", ChurchId=2},
                new Notice { Title = "Continue to Pray for these people", Description="please remember to pray for all sick members", ChurchId=3},
                new Notice { Title = "You have a meeting this week", Description="here is a list summary of all your meeting this week", ChurchId=3}

            };
        }
    }
}
