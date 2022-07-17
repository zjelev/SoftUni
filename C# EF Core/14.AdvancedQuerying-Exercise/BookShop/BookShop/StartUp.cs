namespace BookShop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using BookShop.Models.Enums;
    using Data;
    using Initializer;
    // get-childitem -Include bin -Recurse -force | Remove-Item -Force -Recurse
    // get-childitem -Include obj -Recurse -force | Remove-Item -Force -Recurse

    public class StartUp
    {
        public static void Main()
        {
            using var db = new BookShopContext();
            // DbInitializer.ResetDatabase(db);

            // string input = Console.ReadLine();

            IncreasePrices(db);
            //Console.WriteLine(result);
        }

        public static string GetBooksByAgeRestriction(BookShopContext context, string command)
        {
            List<string> bookTitles = context.Books
                .AsEnumerable()
                .Where(b => b.AgeRestriction.ToString().ToLower() == command.ToLower())
                .Select(b => b.Title)
                .OrderBy(bt => bt)
                .ToList();

            return String.Join(Environment.NewLine, bookTitles);
        }

        public static string GetGoldenBooks(BookShopContext context)
        {
            List<string> bookTitles = context.Books
                .AsEnumerable()
                .Where(b => b.EditionType == EditionType.Gold && b.Copies < 5000)
                .OrderBy(b => b.BookId)
                .Select(b => b.Title)
                .ToList();

            return String.Join(Environment.NewLine, bookTitles);
        }

        public static string GetBooksByPrice(BookShopContext context)
        {
            var bookTitlesPrices = context.Books
                .AsEnumerable()
                .Where(b => b.Price > 40m)
                .Select(b => new { b.Title, b.Price })
                .OrderByDescending(b => b.Price)
                .ToList();

            StringBuilder sb = new StringBuilder();
            foreach (var item in bookTitlesPrices)
            {
                sb.AppendLine($"{item.Title} - ${item.Price:f2}");
            }
            return sb.ToString();
        }

        public static string GetBooksNotReleasedIn(BookShopContext context, int year)
        {
            var bookTitles = context.Books
                .AsEnumerable()
                .Where(b => b.ReleaseDate.Value.Year != year) // nullable
                .OrderBy(b => b.BookId)
                .Select(b => b.Title)
                .ToList();

            return String.Join(Environment.NewLine, bookTitles);
        }

        public static string GetBooksByCategory(BookShopContext context, string input)
        {
            string[] categories = input.ToLower().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            List<string> bookTitles = new List<string>();

            foreach (var cat in categories)
            {
                List<string> currCatBookTitles = context.Books
                    .Where(b => b.BookCategories.Any(bc => bc.Category.Name.ToLower() == cat))
                    .Select(b => b.Title)
                    .ToList();

                bookTitles.AddRange(currCatBookTitles);
            }

            bookTitles = bookTitles.OrderBy(b => b).ToList();

            return String.Join(Environment.NewLine, bookTitles);
        }

        public static string GetBooksReleasedBefore(BookShopContext context, string date)
        {
            DateTime myDate = DateTime.ParseExact(date, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
            var bookTitleEditionPrices = context.Books
                .Where(b => b.ReleaseDate.Value < myDate)
                .OrderByDescending(b => b.ReleaseDate)
                .Select(b => new { b.Title, b.EditionType, b.Price })
                .ToList();

            StringBuilder sb = new StringBuilder();
            foreach (var book in bookTitleEditionPrices)
            {
                sb.AppendLine($"{book.Title} - {book.EditionType} - ${book.Price:f2}");
            }
            return sb.ToString();
        }

        public static string GetAuthorNamesEndingIn(BookShopContext context, string input)
        {
            var authorsNames = context.Authors
                .Where(a => a.FirstName.EndsWith(input))
                .Select(a => new { a.FirstName, a.LastName })
                .OrderBy(a => a.FirstName)
                .ThenBy(a => a.LastName)
                .ToList();

            StringBuilder sb = new StringBuilder();
            foreach (var author in authorsNames)
            {
                sb.AppendLine($"{author.FirstName} {author.LastName}");
            }
            return sb.ToString();
        }

        public static string GetBookTitlesContaining(BookShopContext context, string input)
        {
            var bookTitles = context.Books
                .Where(b => b.Title.ToLower().Contains(input.ToLower()))
                .Select(b => b.Title)
                .OrderBy(bt => bt)
                .ToList();

            return String.Join(Environment.NewLine, bookTitles);
        }

        public static string GetBooksByAuthor(BookShopContext context, string input)
        {
            var booksTitleAuthor = context.Books
                .Where(b => b.Author.LastName.ToLower().StartsWith(input.ToLower()))
                .Select(b => new { b.BookId, b.Title, b.Author.FirstName, b.Author.LastName })
                .OrderBy(b => b.BookId)
                .ToList();

            StringBuilder sb = new StringBuilder();
            foreach (var book in booksTitleAuthor)
            {
                sb.AppendLine($"{book.Title} ({book.FirstName} {book.LastName})");
            }
            return sb.ToString();
        }

        public static int CountBooks(BookShopContext context, int lengthCheck)
        {
            var booksWithLongerTitle = context.Books
                .Where(b => b.Title.Length > lengthCheck)
                .Count();

            return booksWithLongerTitle;
        }

        public static string CountCopiesByAuthor(BookShopContext context)
        {
            var authorsCopies = context.Authors
                .Select(a => new
                {
                    FullName = a.FirstName + " " + a.LastName,
                    BookCopies = a.Books
                    //.Sum(b => b.Copies)
                    .Select(b => b.Copies)
                    .Sum()
                })
                .OrderByDescending(a => a.BookCopies)
                .ToList();

            StringBuilder sb = new StringBuilder();
            foreach (var ac in authorsCopies)
            {
                sb.AppendLine(ac.FullName + " - " + ac.BookCopies);
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetTotalProfitByCategory(BookShopContext context)
        {
            var bookCopiesPrice = context.Categories
                .Select(c => new
                {
                    c.Name,
                    CopiesByPrice = c.CategoryBooks
                        .Select(cbp => cbp.Book.Copies * cbp.Book.Price).Sum(),
                })
                .OrderByDescending(c => c.CopiesByPrice)
                .ThenBy(c => c.Name)
                .ToList();

            StringBuilder sb = new StringBuilder();
            foreach (var bcp in bookCopiesPrice)
            {
                sb.AppendLine($"{bcp.Name} ${bcp.CopiesByPrice:f2}");
            }
            return sb.ToString().TrimEnd();
        }

        public static string GetMostRecentBooks(BookShopContext context)
        {
            var catBooks = context.Categories
                .Select(c => new
                {
                    CategoryName = c.Name,
                    RecentBooks = c.CategoryBooks
                    .OrderByDescending(cb => cb.Book.ReleaseDate)
                    .Take(3)
                    .Select(cb => new
                    {
                        cb.Book.Title,
                        ReleaseYear = cb.Book.ReleaseDate.Value.Year
                    })
                    .ToList()
                })
                .OrderBy(c => c.CategoryName)
                .ToList();

            StringBuilder sb = new StringBuilder();
            foreach (var cb in catBooks)
            {
                sb.AppendLine($"--{cb.CategoryName}");
                foreach (var book in cb.RecentBooks)
                {
                    sb.AppendLine($"{book.Title} ({book.ReleaseYear})");
                }
            }
            return sb.ToString().TrimEnd();
        }

         public static void IncreasePrices(BookShopContext context)
         {
            var books = context.Books
                .Where(b => b.ReleaseDate.Value.Year < 2010)
                //.ToList()
                ;

            foreach (var book in books)
            {
                book.Price += 5;
            }
            context.SaveChanges();
        }

        public static int RemoveBooks(BookShopContext context)
        {
            var books = context.Books
                .Where(b => b.Copies < 4200);

            
            return books.Count();
        }
    }
}
