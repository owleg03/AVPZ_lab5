namespace AppRisks.Models;

public class RiskCategory
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public IList<Risk> Risks { get; set; } = null!;
    public int Value { get; set; }
    public double Percentage { get; set; }
    public string? Section { get; set; }
}