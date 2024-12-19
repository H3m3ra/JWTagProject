using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace JWTagProjectLibrary.BDO;

public class Tag
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public string Name { get; set; } = "";

    [Required]
    public string Description { get; set; } = "";

    [Required]
    public Color Color { get; set; }

    [ForeignKey(nameof(Exercise.Id))]
    public ICollection<Exercise> NavExcersises { get; set; }
}