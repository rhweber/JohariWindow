using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Models;

namespace Infrastructure.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any Categories.
            if (context.Adjective.Any())
            {
                return; // DB has been seeded
            }

            var adjective = new List<Adjective>
            {
                new Adjective{AdjectiveName="Violent", AdjectiveType=false},
                new Adjective{AdjectiveName="Insecure", AdjectiveType=false},
                new Adjective{AdjectiveName="Hostile", AdjectiveType=false},
                new Adjective{AdjectiveName="Needy", AdjectiveType=false},
                new Adjective{AdjectiveName="Ignorant", AdjectiveType=false},
                new Adjective{AdjectiveName="Blase", AdjectiveType=false},
                new Adjective{AdjectiveName="Simple", AdjectiveType=false},
                new Adjective{AdjectiveName="Cynical", AdjectiveType=false},
                new Adjective{AdjectiveName="Boastful", AdjectiveType=false},
                new Adjective{AdjectiveName="Weak", AdjectiveType=false},
                new Adjective{AdjectiveName="Unethical", AdjectiveType=false},
                new Adjective{AdjectiveName="Rash", AdjectiveType=false},
                new Adjective{AdjectiveName="Callous", AdjectiveType=false},
                new Adjective{AdjectiveName="Humorless", AdjectiveType=false},
                new Adjective{AdjectiveName="Responsive", AdjectiveType=true},
                new Adjective{AdjectiveName="Searching", AdjectiveType=true},
                new Adjective{AdjectiveName="Self-assertive", AdjectiveType=true},
                new Adjective{AdjectiveName="Conscientious", AdjectiveType=true},
                new Adjective{AdjectiveName="Sensible", AdjectiveType=true},
                new Adjective{AdjectiveName="Shy", AdjectiveType=true},
                new Adjective{AdjectiveName="Spontaneous", AdjectiveType=true},
                new Adjective{AdjectiveName="Sympathetic", AdjectiveType=true},
                new Adjective{AdjectiveName="Attentive", AdjectiveType=true},
                new Adjective{AdjectiveName="Trustworthy", AdjectiveType=true},
                new Adjective{AdjectiveName="Warm", AdjectiveType=true},
                new Adjective{AdjectiveName="Wise", AdjectiveType=true},
                new Adjective{AdjectiveName="Witty", AdjectiveType=true},
                new Adjective{AdjectiveName="Spiritual", AdjectiveType=true}
            };

            foreach (Adjective a in adjective)
            {
                context.Adjective.Add(a);
            }
            context.SaveChanges();
        }
    }
}
