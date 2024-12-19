﻿using System.ComponentModel.DataAnnotations;

namespace JWTagProjectLibrary.BDO;

public class Exam
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public int Quarter { get; set; }

    [Required]
    public int Year { get; set; }

    [Required]
    public string Description { get; set; } = "";

    [Required]
    public ExamType Type { get; set; }

    [Required]
    public Faculty Faculty { get; set; }

    public ICollection<Exercise> NavExercises { get; set; }
}