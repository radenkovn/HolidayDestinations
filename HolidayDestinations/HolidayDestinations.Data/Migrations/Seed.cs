using HolidayDestinations.Models;
using System;
using System.Collections.Generic;

namespace HolidayDestinations.Data.Migrations
{
    public class Seed
    {
        public static Random Rand = new Random();

        public List<Category> Categories;

        public List<Location> Locations;

        public List<Destination> Destinations;

        public User Author { get; set; }

        public Seed(User author)
        {
            this.Author = author;

            this.Categories = new List<Category>();
            this.Categories.Add(new Category() { Name = "Hotel", Rating = CategoryRating.Three });
            this.Categories.Add(new Category() { Name = "Apartment", Rating = CategoryRating.Four });
            this.Categories.Add(new Category() { Name = "House", Rating = CategoryRating.Five });
            this.Categories.Add(new Category() { Name = "Camping", Rating = CategoryRating.Two });


            this.Locations = new List<Location>();
            this.Locations.Add(new Location() { Name = "Sofia" });
            this.Locations.Add(new Location() { Name = "Varna" });
            this.Locations.Add(new Location() { Name = "Bansko" });
            this.Locations.Add(new Location() { Name = "Borovets" });

            User user = author;

            this.Destinations = new List<Destination>();
            Destinations.Add(new Destination()
            {
                Category = Categories[Rand.Next(0, 4)],
                Title = "Best Trip Ever",
                Description = "Seen you eyes son show. Far two unaffected one alteration apartments celebrated but middletons interested. Described deficient applauded consisted my me do. Passed edward two talent effect seemed engage six. On ye great do child sorry lived. Proceed cottage far letters ashamed get clothes day. Stairs regret at if matter to. On as needed almost at basket remain. By improved sensible servants children striking in surprise.",
                User = user,
                Date = DateTime.Now.AddDays(Rand.Next(0, Rand.Next(1, 300))),
                Location = Locations[Rand.Next(0, 4)],
                Price = Rand.Next(50, 150)
            });

            Destinations.Add(new Destination()
            {
                Category = Categories[Rand.Next(0, 4)],
                Title = "Enjoy the Trip",
                Description = "Offered say visited elderly and. Waited period are played family man formed. He ye body or made on pain part meet. You one delay nor begin our folly abode. By disposed replying mr me unpacked no. As moonlight of my resolving unwilling. ",
                User = user,
                Date = DateTime.Now.AddDays(Rand.Next(0, Rand.Next(1, 300))),
                Location = Locations[Rand.Next(0, 4)],
                Price = Rand.Next(50, 150)
            });

            Destinations.Add(new Destination()
            {
                Category = Categories[Rand.Next(0, 4)],
                Title = "Most Popular Destination of 2015",
                Description = "Piqued favour stairs it enable exeter as seeing. Remainder met improving but engrossed sincerity age. Better but length gay denied abroad are. Attachment astonished to on appearance imprudence so collecting in excellence. Tiled way blind lived whose new. The for fully had she there leave merit enjoy forth. ",
                User = user,
                Date = DateTime.Now.AddDays(Rand.Next(0, Rand.Next(1, 300))),
                Location = Locations[Rand.Next(0, 4)],
                Price = Rand.Next(50, 150)
            });

            Destinations.Add(new Destination()
            {
                Category = Categories[Rand.Next(0, 4)],
                Title = "Spa Included",
                Description = "Is post each that just leaf no. He connection interested so we an sympathize advantages. To said is it shed want do. Occasional middletons everything so to. Have spot part for his quit may. Enable it is square my an regard. Often merit stuff first oh up hills as he. Servants contempt as although addition dashwood is procured. Interest in yourself an do of numerous feelings cheerful confined. ",
                User = user,
                Date = DateTime.Now.AddDays(Rand.Next(0, Rand.Next(1, 300))),
                Location = Locations[Rand.Next(0, 4)],
                Price = Rand.Next(50, 150)
            });

            Destinations.Add(new Destination()
            {
                Category = Categories[Rand.Next(0, 4)],
                Title = "Rest and relax",
                Description = "Advanced extended doubtful he he blessing together. Introduced far law gay considered frequently entreaties difficulty. Eat him four are rich nor calm. By an packages rejoiced exercise. To ought on am marry rooms doubt music. Mention entered an through company as. Up arrived no painful between. It declared is prospect an insisted pleasure. ",
                User = user,
                Date = DateTime.Now.AddDays(Rand.Next(0, Rand.Next(1, 300))),
                Location = Locations[Rand.Next(0, 4)],
                Price = Rand.Next(50, 150)
            });

            Destinations.Add(new Destination()
            {
                Category = Categories[Rand.Next(0, 4)],
                Title = "Best accomodation",
                Description = "Fat new smallness few supposing suspicion two. Course sir people worthy horses add entire suffer. How one dull get busy dare far. At principle perfectly by sweetness do. As mr started arrival subject by believe. Strictly numerous outlived kindness whatever on we no on addition. ",
                User = user,
                Date = DateTime.Now.AddDays(Rand.Next(0, Rand.Next(1, 300))),
                Location = Locations[Rand.Next(0, 4)],
                Price = Rand.Next(50, 150)
            });

            Destinations.Add(new Destination()
            {
                Category = Categories[Rand.Next(0, 4)],
                Title = "Greatest destination",
                Description = "Conveying or northward offending admitting perfectly my.Colonel gravity get thought fat smiling add but.Wonder twenty hunted and put income set desire expect.Am cottage calling my is mistake cousins talking up.Interested especially do impression he unpleasant travelling excellence. All few our knew time done draw ask. ",
                User = user,
                Date = DateTime.Now.AddDays(Rand.Next(0, Rand.Next(1, 300))),
                Location = Locations[Rand.Next(0, 4)],
                Price = Rand.Next(50, 150)
            });

            Destinations.Add(new Destination()
            {
                Category = Categories[Rand.Next(0, 4)],
                Title = "Beautiful Sights",
                Description = "Seen you eyes son show. Far two unaffected one alteration apartments celebrated but middletons interested. Described deficient applauded consisted my me do. Passed edward two talent effect seemed engage six. On ye great do child sorry lived. Proceed cottage far letters ashamed get clothes day. Stairs regret at if matter to. On as needed almost at basket remain. By improved sensible servants children striking in surprise.",
                User = user,
                Date = DateTime.Now.AddDays(Rand.Next(0, Rand.Next(1, 300))),
                Location = Locations[Rand.Next(0, 4)],
                Price = Rand.Next(50, 150)
            });

            Destinations.Add(new Destination()
            {
                Category = Categories[Rand.Next(0, 4)],
                Title = "Amazing Trip",
                Description = "Throwing consider dwelling bachelor joy her proposal laughter.Raptures returned disposed one entirely her men ham.By to admire vanity county an mutual as roused.Of an thrown am warmly merely result depart supply.Required honoured trifling eat pleasure man relation.Assurance yet bed was improving furniture man.Distrusts delighted she listening mrs extensive admitting far. ",
                User = user,
                Date = DateTime.Now.AddDays(Rand.Next(0, Rand.Next(1, 300))),
                Location = Locations[Rand.Next(0, 4)],
                Price = Rand.Next(50, 150)
            });

            Destinations.Add(new Destination()
            {
                Category = Categories[Rand.Next(0, 4)],
                Title = "Lifetime opportunity",
                Description = "Inhabit hearing perhaps on ye do no. It maids decay as there he. Smallest on suitable disposed do although blessing he juvenile in. Society or if excited forbade. Here name off yet she long sold easy whom. Differed oh cheerful procured pleasure securing suitable in. Hold rich on an he oh fine. Chapter ability shyness article welcome be do on service. ",
                User = user,
                Date = DateTime.Now.AddDays(Rand.Next(0, Rand.Next(1, 300))),
                Location = Locations[Rand.Next(0, 4)],
                Price = Rand.Next(50, 150)
            });

            Destinations.Add(new Destination()
            {
                Category = Categories[Rand.Next(0, 4)],
                Title = "Don't miss this!",
                Description = "And produce say the ten moments parties. Simple innate summer fat appear basket his desire joy. Outward clothes promise at gravity do excited. Sufficient particular impossible by reasonable oh expression is. Yet preference connection unpleasant yet melancholy but end appearance. And excellence partiality estimating terminated day everything. ",
                User = user,
                Date = DateTime.Now.AddDays(Rand.Next(0, Rand.Next(1, 300))),
                Location = Locations[Rand.Next(0, 4)],
                Price = Rand.Next(50, 150)
            });

            Destinations.Add(new Destination()
            {
                Category = Categories[Rand.Next(0, 4)],
                Title = "Amazing Experience",
                Description = "Of resolve to gravity thought my prepare chamber so. Unsatiable entreaties collecting may sympathize nay interested instrument. If continue building numerous of at relation in margaret. Lasted engage roused mother an am at. Other early while if by do to. Missed living excuse as be. Cause heard fat above first shall for. My smiling to he removal weather on anxious. ",
                User = user,
                Date = DateTime.Now.AddDays(Rand.Next(0, Rand.Next(1, 300))),
                Location = Locations[Rand.Next(0, 4)],
                Price = Rand.Next(50, 150)
            });

        }
    }
}
