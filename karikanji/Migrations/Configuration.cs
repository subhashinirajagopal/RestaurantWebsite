namespace karikanji.Migrations
{
    using karikanji.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using karikanji.Constants;
    using System.Collections.Generic;
    using karikanji.DAL;

    internal sealed class Configuration : DbMigrationsConfiguration<Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(karikanji.DAL.Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            SeedAboutModel(context);
            SeedContactModel(context);
            SeedMenuModelBiriyani(context);
            SeedMenuModelDinner(context);
            SeedMenuModelSideDish(context);
            SeedMenuModelCombo(context);
        }

        private static void SeedMenuModelCombo(Context context)
        {
            context.Menus.AddOrUpdate(
            p => p.Name,
            new Menu
            {
                Name = "KK1",
                Price = 100M,
                MenuType = Constants.MenuType.Combo,
                Combos = new List<Combo>() {
                    new Combo {Item = "சாதம்" },
                    new Combo {Item = "சிக்கன் கிரேவி"},
                    new Combo {Item = "இரத்த பொரியல் " },
                    new Combo {Item = "முட்டை பொரியல் " }, 
                    new Combo {Item = "சிக்கன் குழம்பு" }, 
                    new Combo {Item = "மட்டன் குழம்பு" },
                    new Combo {Item = "மீன் குழம்பு" },
                    new Combo {Item = "ரசம்" },
                    new Combo {Item = "மோர்" },
                    new Combo {Item = "ஊருகாய்" },
                    new Combo {Item = "தயிர் பச்சடி" },
                    new Combo {Item = "ஐஸ்க்ரீம்" }
                }
            },
           new Menu
           {
               Name = "KK2",
               Price = 170M,
               MenuType = Constants.MenuType.Combo,
               Combos = new List<Combo>() {
                    new Combo {Item = "சாதம்"},
                    new Combo {Item = "சிக்கன் கிரேவி"},
                    new Combo {Item = "மட்டன் சுக்கா"},
                    new Combo {Item = "குடல் கூட்டு"},
                    new Combo {Item = "இரத்த பொரியல் "},
                    new Combo {Item = "முட்டை பொரியல் "},
                    new Combo {Item = "சிக்கன் குழம்பு" }, 
                    new Combo {Item = "மட்டன் குழம்பு"},
                    new Combo {Item = "மீன் குழம்பு"},
                    new Combo {Item = "ரசம்"},
                    new Combo {Item = "மோர்"},
                    new Combo {Item = "ஊருகாய்" },
                    new Combo {Item = "தயிர் பச்சடி" },
                    new Combo {Item = "ஐஸ்க்ரீம்" }
                }
           },
           new Menu
           {
               Name = "KK3",
               Price = 300M,
               MenuType = Constants.MenuType.Combo,
               Combos = new List<Combo>() {
                    new Combo {Item = "சாதம்"},
                    new Combo {Item = "சிக்கன் கிரேவி"},
                    new Combo {Item = "மட்டன் சுக்கா"},
                    new Combo {Item = "குடல் கூட்டு"},
                    new Combo {Item = "இரத்த பொரியல் "},
                    new Combo {Item = "சிக்கன் 65"},
                    new Combo {Item = "மீன் Fry "},
                    new Combo {Item = "முயல் கூட்டு/நண்டு கூட்டு"},
                    new Combo {Item = "புறா கூட்டு/இறால் கூட்டு"},
                    new Combo {Item = "முட்டை பொரியல் "},
                    new Combo {Item = "சிக்கன் குழம்பு"},
                    new Combo {Item = "மட்டன் குழம்பு"},
                    new Combo {Item = "மீன் குழம்பு"},
                    new Combo {Item = "ரசம்" },
                    new Combo {Item = "மோர்"},
                    new Combo {Item = "ஊருகாய்"},
                    new Combo {Item = "தயிர் பச்சடி"},
                    new Combo {Item = "ஐஸ்க்ரீம்"}
                }
           });
        }

        private static void SeedMenuModelSideDish(Context context)
        {
            context.Menus.AddOrUpdate(
           p => p.Name,
             new Menu
             {
                 Name = " Half Boil",
                 Price = 10M,
                 MenuType = Constants.MenuType.SideDish

             },
            new Menu
            {
                Name = " Full Boil",
                Price = 10M,
                MenuType = Constants.MenuType.SideDish

            },

            new Menu
            {
                Name = " ஆம்லெட்",
                Price = 15M,
                MenuType = Constants.MenuType.SideDish

            },
            new Menu
            {
                Name = "Ding Dong",
                Price = 20M,
                MenuType = Constants.MenuType.SideDish

            },
            new Menu
            {
                Name = "முட்டை பொரியல்",
                Price = 25M,
                MenuType = Constants.MenuType.SideDish

            },
            new Menu
            {
                Name = "Double ஆம்லெட்",
                Price = 30M,
                MenuType = Constants.MenuType.SideDish

            },
            new Menu
            {
                Name = "சிக்கன் ஆம்லெட்",
                Price = 70M,
                MenuType = Constants.MenuType.SideDish

            },

             new Menu
             {
                 Name = "மட்டன் ஆம்லெட்",
                 Price = 90M,
                 MenuType = Constants.MenuType.SideDish

             },

             new Menu
             {
                 Name = "மீன் ஆம்லெட்",
                 Price = 70M,
                 MenuType = Constants.MenuType.SideDish

             },

             new Menu
             {
                 Name = "நண்டு ஆம்லெட்",
                 Price = 80M,
                 MenuType = Constants.MenuType.SideDish

             },

             new Menu
             {
                 Name = "இறால் ஆம்லெட்",
                 Price = 90M,
                 MenuType = Constants.MenuType.SideDish

             },

             new Menu
             {
                 Name = "3 STAR ஆம்லெட்",
                 Price = 90M,
                 MenuType = Constants.MenuType.SideDish

             },

             new Menu
             {
                 Name = "5 STAR ஆம்லெட்",
                 Price = 110M,
                 MenuType = Constants.MenuType.SideDish

             },

             new Menu
             {
                 Name = "மீன் Fry",
                 Price = 80M,
                 MenuType = Constants.MenuType.SideDish

             },
             new Menu
             {
                 Name = "இரத்த பொரியல் ",
                 Price = 50M,
                 MenuType = Constants.MenuType.SideDish

             },
             new Menu
             {
                 Name = "குடல் வறுவல்",
                 Price = 80M,
                 MenuType = Constants.MenuType.SideDish

             },
             new Menu
             {
                 Name = "சிக்கன் 65",
                 Price = 80M,
                 MenuType = Constants.MenuType.SideDish

             },
             new Menu
             {
                 Name = "எலும்பு ரோஸ்ட்",
                 Price = 90M,
                 MenuType = Constants.MenuType.SideDish

             },
             new Menu
             {
                 Name = "காடை 65",
                 Price = 90M,
                 MenuType = Constants.MenuType.SideDish

             },
             new Menu
             {
                 Name = "சிக்கன்  கிரேவி",
                 Price = 90M,
                 MenuType = Constants.MenuType.SideDish

             },
             new Menu
             {
                 Name = "மூளை ரோஸ்ட்",
                 Price = 100M,
                 MenuType = Constants.MenuType.SideDish

             },
             new Menu
             {
                 Name = "ஈரல்",
                 Price = 100M,
                 MenuType = Constants.MenuType.SideDish

             },

             new Menu
             {
                 Name = "முட்டை கறி",
                 Price = 110M,
                 MenuType = Constants.MenuType.SideDish

             },

             new Menu
             {
                 Name = "மட்டன் சுக்கா",
                 Price = 100M,
                 MenuType = Constants.MenuType.SideDish

             },
             new Menu
             {
                 Name = "நண்டு கிரேவி",
                 Price = 120M,
                 MenuType = Constants.MenuType.SideDish

             },
             new Menu
             {
                 Name = "இறால் கிரேவி",
                 Price = 120M,
                 MenuType = Constants.MenuType.SideDish

             },
             new Menu
             {
                 Name = "புறா கறி",
                 Price = 150M,
                 MenuType = Constants.MenuType.SideDish

             },
             new Menu
             {
                 Name = "முயல் கூட்டு",
                 Price = 150M,
                 MenuType = Constants.MenuType.SideDish

             },
             new Menu
             {
                 Name = "நாட்டு கோழி ரோஸ்ட்",
                 Price = 140M,
                 MenuType = Constants.MenuType.SideDish

             },
             new Menu
             {
                 Name = "வான்கோழி ரோஸ்ட்",
                 Price = 140M,
                 MenuType = Constants.MenuType.SideDish

             },
             new Menu
             {
                 Name = "வாத்து ரோஸ்ட்",
                 Price = 140M,
                 MenuType = Constants.MenuType.SideDish

             },
            new Menu
            {
                Name = "நண்டு Lollipop",
                Price = 120M,
                MenuType = Constants.MenuType.SideDish

            },
            new Menu
            {
                Name = "சிக்கன் Lollipop ",
                Price = 120M,
                MenuType = Constants.MenuType.SideDish
            });
        }

        private static void SeedMenuModelDinner(Context context)
        {
            context.Menus.AddOrUpdate(
           p => p.Name,
             new Menu
             {
                 Name = "இட்லி",
                 Price = 20M,
                 MenuType = Constants.MenuType.Dinner

             },
             new Menu
             {
                 Name = "சிக்கன் இட்லி",
                 Price = 70M,
                 MenuType = Constants.MenuType.Dinner

             },
             new Menu
             {
                 Name = "மட்டன் இட்லி",
                 Price = 90M,
                 MenuType = Constants.MenuType.Dinner

             },
             new Menu
             {
                 Name = "மீன் இட்லி",
                 Price = 70M,
                 MenuType = Constants.MenuType.Dinner

             },
             new Menu
             {
                 Name = "நண்டு இட்லி",
                 Price = 80M,
                 MenuType = Constants.MenuType.Dinner

             },
             new Menu
             {
                 Name = "இறால் இட்லி",
                 Price = 90M,
                 MenuType = Constants.MenuType.Dinner

             },
             new Menu
             {
                 Name = "3 STAR இட்லி",
                 Price = 100M,
                 MenuType = Constants.MenuType.Dinner

             },
             new Menu
             {
                 Name = "5 STAR இட்லி",
                 Price = 120M,
                 MenuType = Constants.MenuType.Dinner

             },
             new Menu
             {
                 Name = "தோசை",
                 Price = 40M,
                 MenuType = Constants.MenuType.Dinner

             },

             new Menu
             {
                 Name = "Half Boiled தோசை",
                 Price = 50M,
                 MenuType = Constants.MenuType.Dinner

             },

             new Menu
             {
                 Name = "முட்டை தோசை",
                 Price = 50M,
                 MenuType = Constants.MenuType.Dinner

             },

             new Menu
             {
                 Name = "மட்டன் தோசை",
                 Price = 1400M,
                 MenuType = Constants.MenuType.Dinner

             },

             new Menu
             {
                 Name = "சிக்கன் தோசை",
                 Price = 120M,
                 MenuType = Constants.MenuType.Dinner

             },

             new Menu
             {
                 Name = "மீன் தோசை",
                 Price = 120M,
                 MenuType = Constants.MenuType.Dinner

             },

             new Menu
             {
                 Name = "3 STAR தோசை",
                 Price = 140M,
                 MenuType = Constants.MenuType.Dinner

             },

             new Menu
             {
                 Name = "5 STAR தோசை",
                 Price = 160M,
                 MenuType = Constants.MenuType.Dinner

             },

             new Menu
             {
                 Name = "நெய் தோசை",
                 Price = 70M,
                 MenuType = Constants.MenuType.Dinner

             },

             new Menu
             {
                 Name = "பொடி தோசை",
                 Price = 50M,
                 MenuType = Constants.MenuType.Dinner

             },

             new Menu
             {
                 Name = "Spl. தோசை",
                 Price = 60M,
                 MenuType = Constants.MenuType.Dinner

             },

             new Menu
             {
                 Name = "இறால் தோசை",
                 Price = 140M,
                 MenuType = Constants.MenuType.Dinner

             },

             new Menu
             {
                 Name = "நண்டு தோசை",
                 Price = 130M,
                 MenuType = Constants.MenuType.Dinner

             },

             new Menu
             {
                 Name = "ஊத்தப்பம்",
                 Price = 40M,
                 MenuType = Constants.MenuType.Dinner

             },

             new Menu
             {
                 Name = "ஆனியன் ஊத்தப்பம்",
                 Price = 50M,
                 MenuType = Constants.MenuType.Dinner

             },
             new Menu
             {
                 Name = "முட்டை ஆனியன் ஊத்தப்பம்",
                 Price = 60M,
                 MenuType = Constants.MenuType.Dinner

             },

             new Menu
             {
                 Name = "இடியாப்பம்(2)",
                 Price = 25M,
                 MenuType = Constants.MenuType.Dinner

             },

             new Menu
             {
                 Name = "முட்டை இடியாப்பம்",
                 Price = 60M,
                 MenuType = Constants.MenuType.Dinner

             },

             new Menu
             {
                 Name = "சிக்கன் இடியாப்பம்",
                 Price = 80M,
                 MenuType = Constants.MenuType.Dinner

             },

             new Menu
             {
                 Name = "மட்டன் இடியாப்பம்",
                 Price = 100M,
                 MenuType = Constants.MenuType.Dinner

             },

             new Menu
             {
                 Name = "மீன் இடியாப்பம்",
                 Price = 80M,
                 MenuType = Constants.MenuType.Dinner

             },

             new Menu
             {
                 Name = "நண்டு இடியாப்பம்",
                 Price = 90M,
                 MenuType = Constants.MenuType.Dinner

             },

             new Menu
             {
                 Name = "இறால் இடியாப்பம்",
                 Price = 100M,
                 MenuType = Constants.MenuType.Dinner

             },

             new Menu
             {
                 Name = "3 STAR இடியாப்பம்",
                 Price = 110M,
                 MenuType = Constants.MenuType.Dinner

             },

             new Menu
             {
                 Name = "5 STAR இடியாப்பம்",
                 Price = 130M,
                 MenuType = Constants.MenuType.Dinner

             },
             new Menu
             {
                 Name = "புரோட்டா",
                 Price = 10M,
                 MenuType = Constants.MenuType.Dinner

             },

             new Menu
             {
                 Name = "முட்டை புரோட்டா",
                 Price = 60M,
                 MenuType = Constants.MenuType.Dinner

             },

             new Menu
             {
                 Name = "சிக்கன் புரோட்டா",
                 Price = 100M,
                 MenuType = Constants.MenuType.Dinner

             },

             new Menu
             {
                 Name = "மட்டன் புரோட்டா",
                 Price = 120M,
                 MenuType = Constants.MenuType.Dinner

             },

             new Menu
             {
                 Name = "மீன் புரோட்டா",
                 Price = 100M,
                 MenuType = Constants.MenuType.Dinner

             },

             new Menu
             {
                 Name = "நண்டு புரோட்டா",
                 Price = 110M,
                 MenuType = Constants.MenuType.Dinner

             },

             new Menu
             {
                 Name = "இறால் புரோட்டா",
                 Price = 120M,
                 MenuType = Constants.MenuType.Dinner

             },

             new Menu
             {
                 Name = "3 STAR புரோட்டா",
                 Price = 130M,
                 MenuType = Constants.MenuType.Dinner

             },

             new Menu
             {
                 Name = "5 STAR புரோட்டா",
                 Price = 150M,
                 MenuType = Constants.MenuType.Dinner

             },
             new Menu
             {
                 Name = "SPL மட்டன் புரோட்டா",
                 Price = 80M,
                 MenuType = Constants.MenuType.Dinner

             },

             new Menu
             {
                 Name = "SPL சிக்கன் புரோட்டா",
                 Price = 70M,
                 MenuType = Constants.MenuType.Dinner

             },
             new Menu
             {
                 Name = "சிக்கன் கொத்து புரோட்டா",
                 Price = 100M,
                 MenuType = Constants.MenuType.Dinner

             },

             new Menu
             {
                 Name = "மட்டன் கொத்து புரோட்டா",
                 Price = 120M,
                 MenuType = Constants.MenuType.Dinner

             },

             new Menu
             {
                 Name = "மீன் கொத்து புரோட்டா",
                 Price = 100M,
                 MenuType = Constants.MenuType.Dinner

             },

             new Menu
             {
                 Name = "நண்டு கொத்து புரோட்டா",
                 Price = 110M,
                 MenuType = Constants.MenuType.Dinner

             },

             new Menu
             {
                 Name = "இறால் கொத்து புரோட்டா",
                 Price = 120M,
                 MenuType = Constants.MenuType.Dinner

             },

             new Menu
             {
                 Name = "3 STAR கொத்து புரோட்டா",
                 Price = 130M,
                 MenuType = Constants.MenuType.Dinner

             },

             new Menu
             {
                 Name = "5 STAR கொத்து புரோட்டா",
                 Price = 150M,
                 MenuType = Constants.MenuType.Dinner

             },

             new Menu
             {
                 Name = "வீச்சு புரோட்டா",
                 Price = 20M,
                 MenuType = Constants.MenuType.Dinner

             },
             new Menu
             {
                 Name = " முட்டை வீச்சு புரோட்டா",
                 Price = 60M,
                 MenuType = Constants.MenuType.Dinner

             });
        }

        private static void SeedMenuModelBiriyani(Context context)
        {
            context.Menus.AddOrUpdate(
           p => p.Name,
           new Menu
           {
               Name = "பிளைன் பிரியாணி + ஐஸ்க்ரீம்",
               Price = 80M,
               MenuType = Constants.MenuType.Biryani
           },

           new Menu
           {
               Name = " முட்டை பிரியாணி + ஐஸ்க்ரீம்",
               Price = 90M,
               MenuType = Constants.MenuType.Biryani
           },
            new Menu
            {
                Name = "சிக்கன் பிரியாணி + ஐஸ்க்ரீம்",
                Price = 120M,
                MenuType = Constants.MenuType.Biryani
            },

            new Menu
            {
                Name = "மட்டன் பிரியாணி + ஐஸ்க்ரீம்",
                Price = 140M,
                MenuType = Constants.MenuType.Biryani

            },

            new Menu
            {
                Name = "ஸ்பெஷல் பிரியாணி(நாட்டு கோழி/வான்கோழி/முயல்/வாத்து) + ஐஸ்க்ரீம்",
                Price = 160M,
                MenuType = Constants.MenuType.Biryani

            },

            new Menu
            {
                Name = "கோலா உருண்டை",
                Price = 20M,
                MenuType = Constants.MenuType.Biryani

            },

            new Menu
            {
                Name = "Extra Rice",
                Price = 20M,
                MenuType = Constants.MenuType.Biryani

            });
        }

        private static void SeedContactModel(Context context)
        {
            context.Contacts.AddOrUpdate(
            p => p.Email,
            new Contact
            {
                Email = Constant.Emailid,
                AddressLine1 = Constant.AddressLine1,
                AddressLine2 = Constant.AddressLine2,
                AddressLine3 = Constant.AddressLine3,
                City = Constant.City,
                Pincode = Constant.Pincode,
                Timings = Constant.Timings,
                PhoneNumber = Constant.PhoneNo,
            });
        }

        private static void SeedAboutModel(Context context)
        {
            context.Abouts.AddOrUpdate(
              p => p.Description,
              new About { Description = Constant.KariKanjiIntroduction });
        }
    }
}
