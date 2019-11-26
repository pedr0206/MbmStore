using MbmStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Infraestructure
{
    public static class Repository
    {
        public static List<Product> Products = new List<Product>();
        public static List<Invoice> Invoices = new List<Invoice>();


        static Repository()
        {
            //--Customer Objects--
            Customer customer1 = new Customer(1, "Maria", "Silva", "Rua da Graça", "3000", "Porto"/*, new List<string> { "324234", "234234" }*/, new DateTime(2009, 02, 22));
            Customer customer2 = new Customer(2, "Bruno", "Lage", "Estrada de Benfica", "2000", "Lisboa"/*, new List<string> { "00037", "37373737" }*/, new DateTime(1981, 04, 11));


                                            // +++ PRODUCTS +++
            //--Books objects--

            Book book = new Book(1,"Buzz Aldrin", "The Man on the Moon", 150, 2000);
            book.Publisher = "Autorama";
            book.ISBN = "00001";
            book.ImageUrl = "The-Man-on-the-Moon.jpg";
            book.Category = "Book";
            Products.Add(book);

            //Object Initialization
            Book book2 = new Book
            {
                ProductId = 2,                
                Title = " Korolev: How One Man Masterminded the Soviet Drive to Beat America to the Moon ",
                Publisher = "EuropaAmerica",
                Author = "James Harford",
                Price = 200M,
                ImageUrl = "Korolev.jpg",
                ISBN = "00002",
                Category ="Book"
            };
            Products.Add(book2);

            Book book3 = new Book
            {
                ProductId = 3,
                Title = " Rockets and people ",
                Publisher = "Dom Quixote",
                Author = "Boris Chertok",
                Price = 250M,
                ImageUrl = "Rockets-and-people.jpg",
                ISBN = "00003",
                Category = "Book"
        };
            Products.Add(book3);

            //--Music objects--

            MusicCd cd = new MusicCd(4,"Michael Jackson", "Thriller", 200, 1982);
            cd.AddTrack(new Track("Wanna Be Startin' Somethin'", "Michael Jackson", new TimeSpan(0, 2, 30)));
            cd.AddTrack(new Track("Baby Be Mine", "Michael Jackson", new TimeSpan(0, 1, 45)));
            cd.AddTrack(new Track("The Girl Is Mine", "Michael Jackson", new TimeSpan(0, 3, 35)));
            cd.AddTrack(new Track("Thriller", "Michael Jackson", new TimeSpan(0, 4, 30)));
            cd.AddTrack(new Track("Beat It", "Michael Jackson", new TimeSpan(0, 3, 55)));
            cd.AddTrack(new Track("Billie Jean", "Michael Jackson", new TimeSpan(0, 4, 05)));
            cd.AddTrack(new Track("Human Nature", "Michael Jackson", new TimeSpan(0, 3, 22)));
            cd.AddTrack(new Track("P.Y.T. (Pretty Young Thing)", "Michael Jackson", new TimeSpan(0, 2, 30)));
            cd.AddTrack(new Track("The Lady In My Life", "Michael Jackson", new TimeSpan(0, 2, 30)));
            cd.ImageUrl = "Thriller.jpeg";
            cd.Category = "MusicCd";
            Products.Add(cd);

            MusicCd cd2 = new MusicCd
            {
                ProductId = 5,
                Artist = "Kelly Minougue",
                Title = "Aphrodite",
                Price = 300M,
                Released = 2002,
                Category = "MusicCd"
            };
            cd2.AddTrack(new Track("All the Lovers", "Kelly Minougue", new TimeSpan(0, 2, 30)));
            cd2.AddTrack(new Track("Get outta my way", "Kelly Minougue", new TimeSpan(0, 1, 04)));
            cd2.AddTrack(new Track("Put your hands up", "Kelly Minougue", new TimeSpan(0, 2, 00)));
            cd2.AddTrack(new Track("Closer", "Kelly Minougue", new TimeSpan(0, 4, 48)));
            cd2.AddTrack(new Track("Everything is beautiful", "Kelly Minougue", new TimeSpan(0, 3, 22)));
            cd2.AddTrack(new Track("Aphrodite", "Kelly Minougue", new TimeSpan(0, 3, 11)));
            cd2.AddTrack(new Track("Illusion", "Kelly Minougue", new TimeSpan(0, 5, 23)));
            cd2.AddTrack(new Track("Too much", "Kelly Minougue", new TimeSpan(0, 2, 55)));
            cd2.AddTrack(new Track("Cupid Boy", "Kelly Minougue", new TimeSpan(0, 3, 06)));
            cd2.AddTrack(new Track("Looking for an Angel", "Kelly Minougue", new TimeSpan(0, 2, 30)));
            cd2.AddTrack(new Track("Can't beat the feeling", "Kelly Minougue", new TimeSpan(0, 2, 30)));
            cd2.ImageUrl = "Kelly.jpg";
            Products.Add(cd2);

            //--Movie objects--

            Movie movie = new Movie(6,"Men In Black", 150.50m, "mib-homens-preto.jpg", "John Jonson");
            movie.Category = "Movie";
            Products.Add(movie);

            //--Invoice and OrderItems Objects
            Invoice invoice1 = new Invoice(1, new DateTime(2019, 09, 20), customer1);
            invoice1.AddOrderItem(book,1);
            invoice1.AddOrderItem(cd, 1);
            Invoices.Add(invoice1);
            Invoice invoice2 = new Invoice(2, new DateTime(2019, 09, 25), customer2);
            invoice2.AddOrderItem(movie, 1);
            invoice2.AddOrderItem(book, 1);
            Invoices.Add(invoice2);

        }


    }
}
