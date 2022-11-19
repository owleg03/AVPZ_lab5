using System.ComponentModel.DataAnnotations;

namespace AppRisks.Models;

public class RiskExpertMarks
{
    public RiskExpertMarks()
    {
        var rand = new Random();
        ExpertMark1 = rand.NextDouble();
        ExpertMark2 = rand.NextDouble();
        ExpertMark3 = rand.NextDouble();
        ExpertMark4 = rand.NextDouble();
        ExpertMark5 = rand.NextDouble();
        ExpertMark6 = rand.NextDouble();
        ExpertMark7 = rand.NextDouble();
        ExpertMark8 = rand.NextDouble();
        ExpertMark9 = rand.NextDouble();
        ExpertMark10 = rand.NextDouble();
        Price = rand.NextDouble() * 100;
    }
    
    public int Id { get; set; }
    public Risk? Risk { get; set; }
    public int RiskId { get; set; }
    
    public RiskExpertMarksCategory? RiskExpertMarksCategory { get; set; }
    public int RiskExpertMarksCategoryId { get; set; }
    public double Price { get; set; }
    public double Summary { get; set; }
    
    [Range(0, 1)]
    public double ExpertMark1 { get; set; }
    
    [Range(0, 1)]
    public double ExpertMark2 { get; set; }
    
    [Range(0, 1)]
    public double ExpertMark3 { get; set; }
    
    [Range(0, 1)]
    public double ExpertMark4 { get; set; }
    
    [Range(0, 1)]
    public double ExpertMark5 { get; set; }
    
    [Range(0, 1)]
    public double ExpertMark6 { get; set; }
    
    [Range(0, 1)]
    public double ExpertMark7 { get; set; }
    
    [Range(0, 1)]
    public double ExpertMark8 { get; set; }
    
    [Range(0, 1)]
    public double ExpertMark9 { get; set; }
    
    [Range(0, 1)]
    public double ExpertMark10 { get; set; }
    public double ExpertMarkWeighed1 { get; set; }
    public double ExpertMarkWeighed2 { get; set; }
    public double ExpertMarkWeighed3 { get; set; }
    public double ExpertMarkWeighed4 { get; set; }
    public double ExpertMarkWeighed5 { get; set; }
    public double ExpertMarkWeighed6 { get; set; }
    public double ExpertMarkWeighed7 { get; set; }
    public double ExpertMarkWeighed8 { get; set; }
    public double ExpertMarkWeighed9 { get; set; }
    public double ExpertMarkWeighed10 { get; set; }
    public double Total { get; set; }
    public string? Status { get; set; }
    public double AdditionalPrice { get; set; }
    public double EndPrice { get; set; }
    public string? PriceStatus { get; set; }
}