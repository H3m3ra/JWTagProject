using JWTagProjectLibrary.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var config = new ConfigurationBuilder()
    .AddUserSecrets<JWTagProjectDbContext>()
    .Build();

using (var context = new JWTagProjectDbContext())
{
    context.Database.SetConnectionString(config["ConnectionString"]);
    context.Database.Migrate();

    context.Tags.Add(new JWTagProjectLibrary.BDO.Tag()
    {
        Id = Guid.NewGuid(),
        Name = "LF11a",
        Description = "Lernfeld Tag."
    });
    foreach (var tag in context.Tags)
    {
        Console.WriteLine(tag);
    }
}