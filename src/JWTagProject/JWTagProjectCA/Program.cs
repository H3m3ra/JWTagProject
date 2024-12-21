using JWTagProjectLibrary.Controllers;
using JWTagProjectLibrary.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Drawing;

var config = new ConfigurationBuilder()
    .AddUserSecrets<JWTagProjectDbContext>()
    .Build();

var services = new ServiceCollection()
    .AddDbContext<JWTagProjectDbContext>(options =>
        options.UseSqlite(config["ConnectionString"])
    );

using (var context = new JWTagProjectDbContext())
{
    context.Database.SetConnectionString(config["ConnectionString"]);
    Console.WriteLine(context.Database.GetConnectionString());
    context.Database.Migrate();


    var tc = new TagController(context);

    tc.Add("LF10a", Color.Red, "Lernfeld Tag.");
    context.SaveChanges();

    foreach (var tag in context.Tags.Select(t => t).ToList())
    {
        Console.WriteLine(tag.Name);
    }
}