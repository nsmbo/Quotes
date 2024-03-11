using Quotes;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

var quotesList = new QuotesList();

app.MapGet("/", () =>
{
    return quotesList.GetRandomQuote();
});

app.Run();
