using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JWTagProjectLibrary.BDO;

public class Exercise
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public string Description { get; set; }

    [Required]
    public Exam Exam { get; set; }

    [ForeignKey(nameof(Tag.Id))]
    public ICollection<Tag> Tags { get; set; }
}