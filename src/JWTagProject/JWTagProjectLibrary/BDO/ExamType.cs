using System.ComponentModel.DataAnnotations;

namespace JWTagProjectLibrary.BDO;

public class ExamType
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public string Description { get; set; }

    public ICollection<Exam> NavExams { get; set; }
}