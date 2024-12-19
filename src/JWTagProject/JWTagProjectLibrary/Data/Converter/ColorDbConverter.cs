using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Drawing;

namespace JWTagProjectLibrary.Data.Converter;

public class ColorDbConverter : ValueConverter<Color, string>
{
    public ColorDbConverter(): base(
        v => $"#{v.R}{v.G}{v.B}",
        s => Color.FromArgb(int.Parse(s.Substring(1, 2)), int.Parse(s.Substring(3, 2)), int.Parse(s.Substring(5, 2)))
    )
    {

    }
}