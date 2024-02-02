using DwitterLoungeBar.Interfaces;
using DwitterLoungeBar.Models;

namespace DwitterLoungeBar.MocksData
{
    public class MockDrinkRepository : IDrinkRepository
    {
        private readonly ICategoryRepository categoryRepository;

        public MockDrinkRepository(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public Drink GetDrinkById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Drink> GetDrinks()
        {

            return new List<Drink>
                {
                    new Drink {
                        Name = "Beer",
                        Price = 7.95M, ShortDescription = "The most widely consumed alcohol",
                        LongDescription = "Beer is the world's oldest[1][2][3] and most widely consumed[4] alcoholic drink; it is the third most popular drink overall, after water and tea.[5] The production of beer is called brewing, which involves the fermentation of starches, mainly derived from cereal grains—most commonly malted barley, although wheat, maize (corn), and rice are widely used.[6] Most beer is flavoured with hops, which add bitterness and act as a natural preservative, though other flavourings such as herbs or fruit may occasionally be included. The fermentation process causes a natural carbonation effect, although this is often removed during processing, and replaced with forced carbonation.[7] Some of humanity's earliest known writings refer to the production and distribution of beer: the Code of Hammurabi included laws regulating beer and beer parlours.",
                        Category = categoryRepository.Categories.First(),
                        ImageUrl = "https://www.encopadebalon.com/7695-large_default/heineken-premium-lager-beer-bottle-24-x-330ml.jpg",
                        InStock = true,
                        IsPreferredDrink = true,
                        ImageThumbnailUrl = "https://www.encopadebalon.com/7695-large_default/heineken-premium-lager-beer-bottle-24-x-330ml.jpg"
                    },
                    new Drink {
                        Name = "Rum & Coke",
                        Price = 12.95M, ShortDescription = "Cocktail made of cola, lime and rum.",
                        LongDescription = "The world's second most popular drink was born in a collision between the United States and Spain. It happened during the Spanish-American War at the turn of the century when Teddy Roosevelt, the Rough Riders, and Americans in large numbers arrived in Cuba. One afternoon, a group of off-duty soldiers from the U.S. Signal Corps were gathered in a bar in Old Havana. Fausto Rodriguez, a young messenger, later recalled that Captain Russell came in and ordered Bacardi (Gold) rum and Coca-Cola on ice with a wedge of lime. The captain drank the concoction with such pleasure that it sparked the interest of the soldiers around him. They had the bartender prepare a round of the captain's drink for them. The Bacardi rum and Coke was an instant hit. As it does to this day, the drink united the crowd in a spirit of fun and good fellowship. When they ordered another round, one soldier suggested that they toast ¡Por Cuba Libre! in celebration of the newly freed Cuba.",
                        Category =  categoryRepository.Categories.First(),
                        ImageUrl = "https://hips.hearstapps.com/hmg-prod/images/delish-190904-rum-and-coke-0399-landscape-pf-1568846708.jpg?crop=0.668xw:1.00xh;0.167xw,0&resize=1200:*",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://hips.hearstapps.com/hmg-prod/images/delish-190904-rum-and-coke-0399-landscape-pf-1568846708.jpg?crop=0.668xw:1.00xh;0.167xw,0&resize=1200:*"
                    },
                    new Drink {
                        Name = "Tequila ",
                        Price = 12.95M, ShortDescription = "Beverage made from the blue agave plant.",
                        LongDescription = "Tequila (Spanish About this sound [teˈkila] (help·info)) is a regionally specific name for a distilled beverage made from the blue agave plant, primarily in the area surrounding the city of Tequila, 65 km (40 mi) northwest of Guadalajara, and in the highlands (Los Altos) of the central western Mexican state of Jalisco. Although tequila is similar to mezcal, modern tequila differs somewhat in the method of its production, in the use of only blue agave plants, as well as in its regional specificity. Tequila is commonly served neat in Mexico and as a shot with salt and lime across the rest of the world.The red volcanic soil in the surrounding region is particularly well suited to the growing of the blue agave, and more than 300 million of the plants are harvested there each year.[1] Agave tequila grows differently depending on the region. Blue agaves grown in the highlands Los Altos region are larger in size and sweeter in aroma and taste. Agaves harvested in the lowlands, on the other hand, have a more herbaceous fragrance and flavor.",
                        Category =  categoryRepository.Categories.First(),
                        ImageUrl = "https://www.finewineandgoodspirits.com/ccstore/v1/images/?source=/file/v1362111050664050562/products/000006584_1007050_F1.jpg&height=475&width=475",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://www.finewineandgoodspirits.com/ccstore/v1/images/?source=/file/v1362111050664050562/products/000006584_1007050_F1.jpg&height=475&width=475"
                    },
                    new Drink
                    {
                        Name = "Juice ",
                        Price = 12.95M,
                        ShortDescription = "Naturally contained in fruit or vegetable tissue.",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = categoryRepository.Categories.Last(),
                        ImageUrl = "https://images.squarespace-cdn.com/content/v1/6122f65198e6c829c578ee19/1630288662951-LBC7LU4IDK412ZQBFPPU/Wild-One-Organic-Juice-Orange-webi.jpg?format=1000w",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://images.squarespace-cdn.com/content/v1/6122f65198e6c829c578ee19/1630288662951-LBC7LU4IDK412ZQBFPPU/Wild-One-Organic-Juice-Orange-webi.jpg?format=1000w"
                    },
                     new Drink
                    {
                        Name = "Coca-Cola ",
                        Price = 10.95M,
                        ShortDescription = "Best soda juice ever.",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = categoryRepository.Categories.Last(),
                        ImageUrl = "https://www.vipbottles.co.uk/wp-content/uploads/2021/06/Coca-Cola-Coke-Zero-20cl.jpg",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://www.vipbottles.co.uk/wp-content/uploads/2021/06/Coca-Cola-Coke-Zero-20cl.jpg"
                    }

            };
        }
    
        public IEnumerable<Drink> GetPreferredDrinks()
        {
            throw new NotImplementedException();
        }
    }
}
