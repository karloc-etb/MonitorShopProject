using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETProject.Models
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Monitors.Any())
            {
                context.AddRange
                (
                    new Monitor { Name = "AOC G2460VQ6", Price = 124.97, DisplaySize = 24, Color = "Black", SoldBy = "Amazon.co.uk", ModelYear = 2015, ImageThumbnailUrl = "https://images-eu.ssl-images-amazon.com/images/I/51oPKPb2F3L._SL500_AC_SS350_.jpg", ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/612PaclFQOL._SL1000_.jpg" },
                    new Monitor { Name = "HP ROG STRIX XG27VQ", Price = 379.00, DisplaySize = 27, Color = "Black", SoldBy = "Amazon.co.uk", ModelYear = 2017, ImageThumbnailUrl = "https://images-eu.ssl-images-amazon.com/images/I/41RR7fJLgWL._SL500_AC_SS350_.jpg", ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/91A45H86Z4L._SL1500_.jpg" },
                    new Monitor { Name = "Samsung C24F390", Price = 126.48, DisplaySize = 24, Color = "Black", SoldBy = "Amazon.co.uk", ModelYear = 2016, ImageThumbnailUrl = "https://images-eu.ssl-images-amazon.com/images/I/51tquznj7EL._SL500_AC_SS350_.jpg", ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/914KVrXKtyL._SL1500_.jpg" },
                    new Monitor { Name = "Acer K242HLbid", Price = 89.99, DisplaySize = 23, Color = "Black Glossy", SoldBy = "Amazon.co.uk", ModelYear = 2016, ImageThumbnailUrl = "https://images-eu.ssl-images-amazon.com/images/I/41LxtMP9yhL._SL500_AC_SS350_.jpg", ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/81LLEq76j8L._SL1500_.jpg" }
                );
            }
            context.SaveChanges();
        }
    }
}
