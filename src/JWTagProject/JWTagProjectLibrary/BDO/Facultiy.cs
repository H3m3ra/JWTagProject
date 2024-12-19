using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JWTagProjectLibrary.BDO;

public class Faculty
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public string Description { get; set; } = "";

    [ForeignKey(nameof(Exam.Id))]
    public ICollection<Exam> NavExams { get; set; }
}