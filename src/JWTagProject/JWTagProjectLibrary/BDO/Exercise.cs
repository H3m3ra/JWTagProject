using System.ComponentModel.DataAnnotations;

namespace JWTagProjectLibrary.BDO;

public class Exercise
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public string Description { get; set; }

    [Required]
    public Exam Exam { get; set; }

    public ICollection<Tag> Tags { get; set; }
}