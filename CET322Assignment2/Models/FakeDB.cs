using System;
namespace CET322Assignment2.Models
{
	public class FakeDB
	{
        public static List<Book> Db { get; set; } = new List<Book>();

        static FakeDB()
		{
			Db.Add(
				new Book
				{
					Id = 1,
                    Title = "Think of A Number",
                    Description = "Mystery - Dave Gurney",
                    Author = "John Verdon",
                    PageSize = 475,
                    Price = 130,
                    PublishDate = DateTime.Now
                }
				);
			Db.Add(
				new Book
				{
                    Id = 2,
                    Title = "Shut Your Eyes Tight",
                    Description = "Mystery - Dave Gurney",
                    Author = "John Verdon",
                    PageSize = 509,
                    Price = 140,
                    PublishDate = DateTime.Now
                }
				);
            Db.Add(
                new Book
                {
                    Id = 3,
                    Title = "Let the Devil Sleep",
                    Description = "Mystery - Dave Gurney",
                    Author = "John Verdon",
                    PageSize = 449,
                    Price = 130,
                    PublishDate = DateTime.Now
                }
                );
        }

        public List<Book> GetAllBooks()
        {
            return Db;
        }

        public Book? GetBookById(int id)
        {
            return Db.FirstOrDefault(b => b.Id == id);
        }

        public bool DeleteBook(int id)
        {
            var book = GetBookById(id);

            if (book == null) return false;
            Db.Remove(book);
            return true;
        }
	}
}

