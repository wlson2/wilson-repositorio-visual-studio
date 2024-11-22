using LiteDB;
using litedb_sample;

using (var db = new LiteDatabase(@"MyData.db"))
{
    var books = db.GetCollection<Book>("books");
    var booksToInsert = new List<Book>();

    var book = new Book
    {
        Title = "The Past",
        Author = "jhon k",
        Year = 1949
    };
    books.Insert(book);

    var book2 = new Book
    {
        Title = "The Present",
        Author = "Carl Sagan",
        Year = 2024
    };
    booksToInsert.Add(book2);
    var book3 = new Book
    {
        Title = "The Future",
        Author = "Henry Cavil",
        Year = 2030
    };
    booksToInsert.Add(book3);

    books.InsertBulk(booksToInsert);
} 