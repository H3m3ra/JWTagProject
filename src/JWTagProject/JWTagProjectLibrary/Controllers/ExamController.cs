using JWTagProjectLibrary.BDO;
using JWTagProjectLibrary.Data;

namespace JWTagProjectLibrary.Controllers;

public class ExamController
{
    private JWTagProjectDbContext _context;

    public ExamController(JWTagProjectDbContext context)
    {
        _context = context;
    }

    public void Add(int quarter, int year, ExamType type, Faculty faculty, string description="")
    {
        _context.Exams.Add(new Exam()
        {
            Id = Guid.NewGuid(),
            Quarter = quarter,
            Year = year,
            Description = description,
            Type = type,
            Faculty = faculty
        });
    }
}