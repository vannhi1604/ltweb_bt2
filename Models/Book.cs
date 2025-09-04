using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ltweb_bt2.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
        public string Image { get; set; }
        public float Price { get; set; }
        public int TotalPage { get; set; }
        public string Summary { get; set; }

        //ds sach
        public List<Book> GetBookList()
        {
            List<Book> books = new List<Book>()
            {
                new Book()
                {
                    Id = 1,
                    Title = "To Kill a Mockingbird",
                    AuthorId = 1,
                    GenreId = 1,
                    Image = "/images/products/b1.jpg",
                    Price = 15,
                    Summary = "A young girl named Scout Finch grows up in Alabama during the 1930s, where her father, Atticus, defends a Black man unjustly accused of a terrible crime.",
                    TotalPage = 324
                },
                new Book()
                {
                    Id = 2,
                    Title = "1984",
                    AuthorId = 2,
                    GenreId = 2,
                    Image = "/images/products/b2.jpg",
                    Price = 10,
                    Summary = "Winston Smith lives under constant surveillance in a totalitarian regime, and finds himself drawn to rebellion against the Party’s oppressive rule.",
                    TotalPage = 328
                },
                new Book()
                {
                    Id = 3,
                    Title = "Pride and Prejudice",
                    AuthorId = 3,
                    GenreId = 3,
                    Image = "/images/products/b3.jpg",
                    Price = 12,
                    Summary = "Elizabeth Bennet navigates societal expectations and her own prejudices as she and the proud Mr. Darcy come to understand love’s true value.",
                    TotalPage = 279
                },
                new Book()
                {
                    Id = 4,
                    Title = "The Great Gatsby",
                    AuthorId = 4,
                    GenreId = 4,
                    Image = "/images/products/b4.jpg",
                    Price = 10,
                    Summary = "Nick Carraway tells the tragic story of Jay Gatsby’s obsessive love and the empty pursuit of the American Dream on Long Island in the Roaring Twenties.",
                    TotalPage = 180
                }
            };
            return books;
        }
        public Book GetBookById(int id)
        {
            Book book = this.GetBookList().FirstOrDefault(b => b.Id == id);
            return book;
        }
        public List<SelectListItem> Authors { get; } = new List<SelectListItem>
        {
            new SelectListItem {Value = "1", Text = "Harper Lee"},
            new SelectListItem {Value = "2", Text = "George Orwell"},
            new SelectListItem {Value = "3", Text = "Jane Austen"},
            new SelectListItem {Value = "4", Text = "F. Scott Fitzgerald"}
        };
        public List<SelectListItem> Genres { get; } = new List<SelectListItem>
        {
            new SelectListItem {Value = "1", Text = "Southern Gothic"},
            new SelectListItem {Value = "2", Text = "Dystopian political fiction"},
            new SelectListItem {Value = "3", Text = "Romance"},
            new SelectListItem {Value = "4", Text = "Tragedy"}
        };

    }
}
