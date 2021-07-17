using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ScriptureJournal.Data;

namespace ScriptureJournal.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ScriptureJournalContext(
                serviceProvider.GetService<DbContextOptions<ScriptureJournalContext>>()))
            {
                if (context.Scripture.Any())
                {
                    return;
                }

                context.Scripture.AddRange(
                    new Scripture
                    {
                        Book = "Mormon",
                        Chapter = 5,
                        Verses = 23,
                        Notes = "We are the hands of God."
                    },

                    new Scripture
                    {
                        Book = "Luke",
                        Chapter = 12,
                        Verses = 34,
                        Notes = "Where is my treasure?"
                    },

                    new Scripture
                    {
                        Book = "1 Nephi",
                        Chapter = 20,
                        Verses = 10,
                        Notes = "Afflictions refine us."
                    },

                    new Scripture
                    {
                        Book = "Alma",
                        Chapter = 7,
                        Verses = 11,
                        Notes = "Best scripture about the atonement of Jesus Christ."
                    }
                );
                context.SaveChanges();
            }
        }
    }
}