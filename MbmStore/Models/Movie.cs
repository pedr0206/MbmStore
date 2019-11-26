using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Movie : Product
    {
        private string director;

        public string Director
        {
            get { return director; }
            set { director = value; }
        }

        public short Released { get; set; }

        // constructors
        public Movie()
        {
            
        }
        public Movie(int productId, string title, decimal price) : base(productId, title , price)
        {
            Title = title;
            Price = price;
        }

        public Movie(int productId, string title, decimal price, string imageUrl, string director) : base(productId, title,price)
        {
            ImageUrl = imageUrl;
            this.director = director;
        }
    }
}