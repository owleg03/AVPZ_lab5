using System.ComponentModel.DataAnnotations;

namespace AppRisks.Models;

public class RiskExpertMarksCategory
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public IList<RiskExpertMarks> RiskExpertMarksList { get; set; } = null!;
    public int Value { get; set; }
    public double Price { get; set; }
    
    [Range(0, 10)]
    public int ExpertCoef1 { get; set; }
    
    [Range(0, 10)]
    public int ExpertCoef2 { get; set; }
    
    [Range(0, 10)]
    public int ExpertCoef3 { get; set; }
    
    [Range(0, 10)]
    public int ExpertCoef4 { get; set; }
    
    [Range(0, 10)]
    public int ExpertCoef5 { get; set; }
    
    [Range(0, 10)]
    public int ExpertCoef6 { get; set; }
    
    [Range(0, 10)]
    public int ExpertCoef7 { get; set; }
    
    [Range(0, 10)]
    public int ExpertCoef8 { get; set; }
    
    [Range(0, 10)]
    public int ExpertCoef9 { get; set; }
    
    [Range(0, 10)]
    public int ExpertCoef10 { get; set; }
    
    public double ExpertMarkWeighedAverage1 { get; set; }
    
    public double ExpertMarkWeighedAverage2 { get; set; }
    
    public double ExpertMarkWeighedAverage3 { get; set; }
    
    public double ExpertMarkWeighedAverage4 { get; set; }
    
    public double ExpertMarkWeighedAverage5 { get; set; }
    
    public double ExpertMarkWeighedAverage6 { get; set; }
    
    public double ExpertMarkWeighedAverage7 { get; set; }
    
    public double ExpertMarkWeighedAverage8 { get; set; }
    
    public double ExpertMarkWeighedAverage9 { get; set; }
    public double ExpertMarkWeighedAverage10 { get; set; }

    public int Summary { get; set; }
    public double Total { get; set; }
    public double AdditionalPrice { get; set; }
    public double EndPrice { get; set; }
}