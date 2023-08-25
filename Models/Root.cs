namespace ChallengeMiduLibrosBlazor.Models;

public class Root
{
    public List<BookWrapper>? Library { get; set; }
}

public class BookWrapper
{
    public Book? Book { get; set; }
}

public class Book
{
    public string? Title { get; set; }
    public int? Pages { get; set; }
    public string? Genre { get; set; }
    public string? Cover { get; set; }
    public string? Synopsis { get; set; }
    public int? Year { get; set; }
    public string? ISBN { get; set; }
    public Author? Author { get; set; }
}

public class Author
{
    public string? Name { get; set; }
    public List<string>? OtherBooks { get; set; }
}
