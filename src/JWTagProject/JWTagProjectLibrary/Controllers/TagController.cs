using JWTagProjectLibrary.BDO;
using JWTagProjectLibrary.Data;
using System.Drawing;

namespace JWTagProjectLibrary.Controllers;

public class TagController
{
    private JWTagProjectDbContext _context;

    public TagController(JWTagProjectDbContext context)
    {
        _context = context;
    }

    public void Add(string name, Color color, string description = "")
    {
        _context.Tags.Add(new Tag()
        {
            Id = Guid.NewGuid(),
            Name = name,
            Color = color,
            Description = description
        });
    }
}