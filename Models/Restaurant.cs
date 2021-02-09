using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _413_4.Models
{
    //this model is for the displaying the top 5 restaurants
    public class Restaurant
    {
        [Required]
        public int Rank { get; set; }
        [Required]
        public string Name { get; set; }
        public string FavDish { get; set; } = "It's all tasty!";
        [Required]
        public string Address { get; set; }
        [Phone]
        public string PhoneNum { get; set; }
        public string WebLink { get; set; } = "Coming Soon.";

        //this is to generate the top restaurants
        public static Restaurant[] GetRestaurant()
        {
            Restaurant r1 = new Restaurant
            {
                Rank = 1,
                Name = "Bombay House",
                FavDish = "Chicken Tikka Masala",
                Address = "463 N University Ave, Provo, UT 84601",
                PhoneNum = "(801)373-6677",
                WebLink = "www.bombayhouse.com/",
            };

            Restaurant r2 = new Restaurant
            {
                Rank = 2,
                Name = "Neighborhood Thai Cuisine",
                Address = "170 W 300 S, Provo, UT 84601",
                PhoneNum = "(385)223-8169",
                WebLink = "www.thaineighborcuisine1.com/",
            };

            Restaurant r3 = new Restaurant
            {
                Rank = 3,
                Name = "Don Joaquin's Street Tacos",
                FavDish = "Carne Asada Burrito",
                Address = "150 W 1230 N St, Provo, UT 84604",
                PhoneNum = "(801)400-2894",
                
            };

            Restaurant r4 = new Restaurant
            {
                Rank = 4,
                Name = "J-Dawgz",
                Address = "858 700 E, Provo, UT 84606",
                PhoneNum = "(801)373-3294",
                WebLink = "www.jdawgs.com/",
            };

            Restaurant r5 = new Restaurant
            {
                Rank = 5,
                Name = "Brick Oven",
                FavDish = "Margherita Pizza",
                Address = "111 E 800 N, Provo, UT 84606",
                PhoneNum = "(801)374-8800",
                WebLink = "www.brickovenrestaurants.com",
            };

            return new Restaurant[] { r1, r2, r3, r4, r5 };
        }

    }

    //this model is for the form submission and display
    public class RestSubmit
    {
        public string PersonName { get; set; }
        public string RestName { get; set; }
        public string FavDish { get; set; } = "It's all tasty!";
        [Phone(ErrorMessage = "Please input phone with valid format")]
        public string? RestPhone { get; set; }
    }

    //this model is for the temporary storage to display the input responses
    public static class TempStorage
    {
        //creating the list of entries
        private static List<RestSubmit> entries = new List<RestSubmit>();
        //this is a llambda that will dynamically change as more entries are added
        public static IEnumerable<RestSubmit> Entries => entries;
        //method that will add the entries to the list
        public static void AddEntry( RestSubmit entry)
        {
            entries.Add(entry);
        }
    }
}
