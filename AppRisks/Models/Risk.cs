using System.ComponentModel.DataAnnotations;

namespace AppRisks.Models;

public class Risk
{
    public int Id { get; set; }
    public string? Content { get; set; }
    
    [Range(0, 1, ErrorMessage = "Поле вага може мати лише значення 0 або 1")]
    public int Value { get; set; }

    public RiskCategory? RiskCategory { get; set; }
    public int RiskCategoryId { get; set; }
}