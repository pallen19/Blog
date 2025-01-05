using Blog.Core.Postgres;
using Blog.Core.Services;
using Microsoft.EntityFrameworkCore;
using Refit;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// builder.Services.AddRefitClient<IBlog>()
//     .ConfigureHttpClient(c => c.BaseAddress = new Uri("https://jsonplaceholder.typicode.com"));
/*
 var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Blogs>(opt => opt.UseInMemoryDatabase("Blogs"));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
var app = builder.Build();
*/
var blogs = app.MapGroup("/blogs");

app.MapGet("/todoitems", async (BlogDbContext db) =>
    await db.Blogs.ToListAsync());

// app.MapGet("/todoitems/complete", async (BlogDbContext db) =>
//     await db.Blogs.Where(t => t.IsComplete).ToListAsync());
//
// app.MapGet("/todoitems/{id}", async (int id, TodoDb db) =>
//     await db.Blogs.FindAsync(id)
//         is Todo todo
//             ? Results.Ok(todo)
//             : Results.NotFound());
//
// app.MapPost("/todoitems", async (Blogs todo, Blogs db) =>
// {
//     db.Blogs.Add(todo);
//     await db.SaveChangesAsync();
//
//     return Results.Created($"/todoitems/{todo.Id}", todo);
// });
//
// app.MapPut("/todoitems/{id}", async (int id, Blogs inputBlogs, Blogs db) =>
// {
//     var todo = await db.Blogs.FindAsync(id);
//
//     if (todo is null) return Results.NotFound();
//
//     todo.Name = inputTodo.Name;
//     todo.IsComplete = inputTodo.IsComplete;
//
//    await db.SaveChangesAsync();
//  return Results.NoContent();
// });

// app.MapDelete("/todoitems/{id}", async (int id, Blogs db) =>
// {
//     if (await db.Blogs.FindAsync(id) is Todo todo)
//     {
//         db.Blogs.Remove(todo);
//         await db.SaveChangesAsync();
//         return Results.NoContent();
//     }
//
//     return Results.NotFound();
// });
//
app.Run();
