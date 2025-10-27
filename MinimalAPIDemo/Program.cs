using MinimalAPIDemo.Models;

var builder = WebApplication.CreateBuilder(args);

// Add Swagger services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Enable Swagger only in development mode
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Fake data in memory
List<Book> books =
[
    new Book { Id = 1, Title = "1984", Author = "George Orwell", Year = 1949 },
    new Book { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", Year = 1960 },
    new Book { Id = 3, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Year = 1925 }
];

// GET all books
app.MapGet("/books", () =>
{
    return Results.Ok(books);
});

// Get book by ID
app.MapGet("/books/{id}", (int id) =>
{
    var book = books.FirstOrDefault(b => b.Id == id);
    return book is not null ? Results.Ok(book) : Results.NotFound();
});

// Post store a new book
app.MapPost("/books", (Book newBook) =>
{   
    newBook.Id = books.Max(b => b.Id) + 1;
    books.Add(newBook);
    return Results.Created($"/books/{newBook.Id}", newBook);
});

app.MapPut("/books/{id}", (int id, Book updatedBook) =>
{
    var existingBook = books.FirstOrDefault(b => b.Id == id);
    if (existingBook is null)
        return Results.NotFound($"Book with ID {id} not found.");

    existingBook.Title = updatedBook.Title;
    existingBook.Author = updatedBook.Author;
    existingBook.Year = updatedBook.Year;

    return Results.Ok(existingBook);
});

app.Run();
