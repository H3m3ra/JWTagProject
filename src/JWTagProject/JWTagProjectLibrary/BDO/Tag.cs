using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace JWTagProjectLibrary.BDO;

public class Tag
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public string Description { get; set; } = "";

    [Required]
    public Color Color { get; set; }
   
    public ICollection<Exercise> NavExcersises { get; set; }
}