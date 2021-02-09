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

    }

    //this model is for the form submission and display
    public class RestSubmit
    {
        public string PersonName { get; set; }
        public string RestName { get; set; }
        public string FavDish { get; set; } = "It's all tasty!";
        [Phone(ErrorMessage = "Please input phone with valid format")]
        public string RestPhone { get; set; }
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
