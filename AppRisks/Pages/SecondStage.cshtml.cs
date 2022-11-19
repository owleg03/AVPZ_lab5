using AppRisks.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AppRisks.Pages;

public class SecondStage : PageModel
{
    private readonly AppDbContext _context;
    public const string FirstStageSection1 = "Визначення ймовірності настання ризикових подій";
    public const string FirstStageSection2 = "Визначення частки можливих збитків від прояву ризику";

    public SecondStage(AppDbContext context)
    {
        _context = context;
        ViewModel = new SecondStageViewModel();
    }

    public class SecondStageViewModel
    {
        public IList<RiskExpertMarksCategory>? RiskExpertMarksCategories { get; set; }
    }

    [BindProperty] 
    public SecondStageViewModel? ViewModel { get; set; }
    
    [BindProperty] 
    public string FirstStageSection { get; set; } = FirstStageSection1;

    private void SetViewModelCategories()
    {
        ViewModel.RiskExpertMarksCategories = _context.RiskExpertMarksCategories
            .OrderBy(r => r.Id)
            .Include(r => r.RiskExpertMarksList)
            .ThenInclude(r => r.Risk)
            .ToList();

        if (FirstStageSection == FirstStageSection1)
        {
            foreach (var category in ViewModel.RiskExpertMarksCategories)
            {
                category.Value = category.RiskExpertMarksList.Sum(r => r.Risk.Value);
                category.Price = category.RiskExpertMarksList.Sum(r => r.Price);

                var expertCoef = new List<int>
                {
                    category.ExpertCoef1,
                    category.ExpertCoef2,
                    category.ExpertCoef3,
                    category.ExpertCoef4,
                    category.ExpertCoef5,
                    category.ExpertCoef6,
                    category.ExpertCoef7,
                    category.ExpertCoef8,
                    category.ExpertCoef9,
                    category.ExpertCoef10
                };
                category.Summary = expertCoef.Sum();

                foreach (var riskExpertMarks in category.RiskExpertMarksList)
                {
                    riskExpertMarks.ExpertMarkWeighed1 =
                        riskExpertMarks.Risk.Value * riskExpertMarks.ExpertMark1 * category.ExpertCoef1;
                    riskExpertMarks.ExpertMarkWeighed2 =
                        riskExpertMarks.Risk.Value * riskExpertMarks.ExpertMark2 * category.ExpertCoef2;
                    riskExpertMarks.ExpertMarkWeighed3 =
                        riskExpertMarks.Risk.Value * riskExpertMarks.ExpertMark3 * category.ExpertCoef3;
                    riskExpertMarks.ExpertMarkWeighed4 =
                        riskExpertMarks.Risk.Value * riskExpertMarks.ExpertMark4 * category.ExpertCoef4;
                    riskExpertMarks.ExpertMarkWeighed5 =
                        riskExpertMarks.Risk.Value * riskExpertMarks.ExpertMark5 * category.ExpertCoef5;
                    riskExpertMarks.ExpertMarkWeighed6 =
                        riskExpertMarks.Risk.Value * riskExpertMarks.ExpertMark6 * category.ExpertCoef6;
                    riskExpertMarks.ExpertMarkWeighed7 =
                        riskExpertMarks.Risk.Value * riskExpertMarks.ExpertMark7 * category.ExpertCoef7;
                    riskExpertMarks.ExpertMarkWeighed8 =
                        riskExpertMarks.Risk.Value * riskExpertMarks.ExpertMark8 * category.ExpertCoef8;
                    riskExpertMarks.ExpertMarkWeighed9 =
                        riskExpertMarks.Risk.Value * riskExpertMarks.ExpertMark9 * category.ExpertCoef9;
                    riskExpertMarks.ExpertMarkWeighed10 =
                        riskExpertMarks.Risk.Value * riskExpertMarks.ExpertMark10 * category.ExpertCoef10;

                    var expertMarks = new List<double>
                    {
                        riskExpertMarks.ExpertMark1,
                        riskExpertMarks.ExpertMark2,
                        riskExpertMarks.ExpertMark3,
                        riskExpertMarks.ExpertMark4,
                        riskExpertMarks.ExpertMark5,
                        riskExpertMarks.ExpertMark6,
                        riskExpertMarks.ExpertMark7,
                        riskExpertMarks.ExpertMark8,
                        riskExpertMarks.ExpertMark9,
                        riskExpertMarks.ExpertMark10,
                    };
                    riskExpertMarks.Summary = expertMarks.Average();
                    riskExpertMarks.Total =
                        (riskExpertMarks.ExpertMarkWeighed1 +
                         riskExpertMarks.ExpertMarkWeighed2 +
                         riskExpertMarks.ExpertMarkWeighed3 +
                         riskExpertMarks.ExpertMarkWeighed4 +
                         riskExpertMarks.ExpertMarkWeighed5 +
                         riskExpertMarks.ExpertMarkWeighed6 +
                         riskExpertMarks.ExpertMarkWeighed7 +
                         riskExpertMarks.ExpertMarkWeighed8 +
                         riskExpertMarks.ExpertMarkWeighed9 +
                         riskExpertMarks.ExpertMarkWeighed10) / category.Summary;
                }

                category.ExpertMarkWeighedAverage1 =
                    category.RiskExpertMarksList.Average(r => r.ExpertMarkWeighed1) / category.ExpertCoef1;
                category.ExpertMarkWeighedAverage2 =
                    category.RiskExpertMarksList.Average(r => r.ExpertMarkWeighed2) / category.ExpertCoef2;
                category.ExpertMarkWeighedAverage3 =
                    category.RiskExpertMarksList.Average(r => r.ExpertMarkWeighed3) / category.ExpertCoef3;
                category.ExpertMarkWeighedAverage4 =
                    category.RiskExpertMarksList.Average(r => r.ExpertMarkWeighed4) / category.ExpertCoef4;
                category.ExpertMarkWeighedAverage5 =
                    category.RiskExpertMarksList.Average(r => r.ExpertMarkWeighed5) / category.ExpertCoef5;
                category.ExpertMarkWeighedAverage6 =
                    category.RiskExpertMarksList.Average(r => r.ExpertMarkWeighed6) / category.ExpertCoef6;
                category.ExpertMarkWeighedAverage7 =
                    category.RiskExpertMarksList.Average(r => r.ExpertMarkWeighed7) / category.ExpertCoef7;
                category.ExpertMarkWeighedAverage8 =
                    category.RiskExpertMarksList.Average(r => r.ExpertMarkWeighed8) / category.ExpertCoef8;
                category.ExpertMarkWeighedAverage9 =
                    category.RiskExpertMarksList.Average(r => r.ExpertMarkWeighed9) / category.ExpertCoef9;
                category.ExpertMarkWeighedAverage10 =
                    category.RiskExpertMarksList.Average(r => r.ExpertMarkWeighed10) / category.ExpertCoef10;

                category.Total = category.RiskExpertMarksList.Average(r => r.Total);

                var avgProbablility = category.RiskExpertMarksList.Average(r => r.Total);

                foreach (var riskExpertMarks in category.RiskExpertMarksList)
                {
                    if (Math.Abs(riskExpertMarks.Total - avgProbablility) < 0.1)
                    {
                        riskExpertMarks.Status = "Середній";
                    }
                    else if (riskExpertMarks.Total < avgProbablility)
                    {
                        riskExpertMarks.Status = "Низький";
                    }
                    else
                    {
                        riskExpertMarks.Status = "Високий";
                    }
                }
            }
        }
        else
        {
            foreach (var category in ViewModel.RiskExpertMarksCategories)
            {
                category.Value = category.RiskExpertMarksList.Sum(r => r.Risk.Value);
                category.Price = category.RiskExpertMarksList.Sum(r => r.Price);
                
                var expertCoef = new List<int>
                {
                    category.ExpertCoef1,
                    category.ExpertCoef2,
                    category.ExpertCoef3,
                    category.ExpertCoef4,
                    category.ExpertCoef5,
                    category.ExpertCoef6,
                    category.ExpertCoef7,
                    category.ExpertCoef8,
                    category.ExpertCoef9,
                    category.ExpertCoef10
                };
                category.Summary = expertCoef.Sum();
                
                foreach (var riskExpertMarks in category.RiskExpertMarksList)
                { 
                    var expertMarks = new List<double>
                    {
                        riskExpertMarks.ExpertMark1,
                        riskExpertMarks.ExpertMark2,
                        riskExpertMarks.ExpertMark3,
                        riskExpertMarks.ExpertMark4,
                        riskExpertMarks.ExpertMark5,
                        riskExpertMarks.ExpertMark6,
                        riskExpertMarks.ExpertMark7,
                        riskExpertMarks.ExpertMark8,
                        riskExpertMarks.ExpertMark9,
                        riskExpertMarks.ExpertMark10,
                    };

                    riskExpertMarks.Summary = expertMarks.Average() * riskExpertMarks.Price;

                    riskExpertMarks.ExpertMarkWeighed1 = riskExpertMarks.ExpertMark1 * category.ExpertCoef1 *
                                                         riskExpertMarks.Risk!.Value;
                    riskExpertMarks.ExpertMarkWeighed2 = riskExpertMarks.ExpertMark2 * category.ExpertCoef2 *
                                                         riskExpertMarks.Risk!.Value;
                    riskExpertMarks.ExpertMarkWeighed3 = riskExpertMarks.ExpertMark3 * category.ExpertCoef3 *
                                                         riskExpertMarks.Risk!.Value;
                    riskExpertMarks.ExpertMarkWeighed4 = riskExpertMarks.ExpertMark4 * category.ExpertCoef4 *
                                                         riskExpertMarks.Risk!.Value;
                    riskExpertMarks.ExpertMarkWeighed5 = riskExpertMarks.ExpertMark5 * category.ExpertCoef5 *
                                                         riskExpertMarks.Risk!.Value;
                    riskExpertMarks.ExpertMarkWeighed6 = riskExpertMarks.ExpertMark6 * category.ExpertCoef6 *
                                                         riskExpertMarks.Risk!.Value;
                    riskExpertMarks.ExpertMarkWeighed7 = riskExpertMarks.ExpertMark7 * category.ExpertCoef7 *
                                                         riskExpertMarks.Risk!.Value;
                    riskExpertMarks.ExpertMarkWeighed8 = riskExpertMarks.ExpertMark8 * category.ExpertCoef8 *
                                                         riskExpertMarks.Risk!.Value;
                    riskExpertMarks.ExpertMarkWeighed9 = riskExpertMarks.ExpertMark9 * category.ExpertCoef9 *
                                                         riskExpertMarks.Risk!.Value;
                    riskExpertMarks.ExpertMarkWeighed10 = riskExpertMarks.ExpertMark10 * category.ExpertCoef10 *
                                                         riskExpertMarks.Risk!.Value;
                    
                    var expertMarksWeighed = new List<double>
                    {
                        riskExpertMarks.ExpertMarkWeighed1,
                        riskExpertMarks.ExpertMarkWeighed2,
                        riskExpertMarks.ExpertMarkWeighed3,
                        riskExpertMarks.ExpertMarkWeighed4,
                        riskExpertMarks.ExpertMarkWeighed5,
                        riskExpertMarks.ExpertMarkWeighed6,
                        riskExpertMarks.ExpertMarkWeighed7,
                        riskExpertMarks.ExpertMarkWeighed8,
                        riskExpertMarks.ExpertMarkWeighed9,
                        riskExpertMarks.ExpertMarkWeighed10,
                    };

                    riskExpertMarks.AdditionalPrice = riskExpertMarks.Risk.Value * expertMarksWeighed.Sum() /
                        category.Summary * riskExpertMarks.Price;
                    riskExpertMarks.EndPrice = riskExpertMarks.Risk.Value *
                        (riskExpertMarks.Price + riskExpertMarks.AdditionalPrice);
                }

                category.ExpertMarkWeighedAverage1 = category.RiskExpertMarksList.Average(r => r.ExpertMarkWeighed1) /
                                                     category.ExpertCoef1;
                category.ExpertMarkWeighedAverage2 = category.RiskExpertMarksList.Average(r => r.ExpertMarkWeighed2) /
                                                     category.ExpertCoef2;
                category.ExpertMarkWeighedAverage3 = category.RiskExpertMarksList.Average(r => r.ExpertMarkWeighed3) /
                                                     category.ExpertCoef3;
                category.ExpertMarkWeighedAverage4 = category.RiskExpertMarksList.Average(r => r.ExpertMarkWeighed4) /
                                                     category.ExpertCoef4;
                category.ExpertMarkWeighedAverage5 = category.RiskExpertMarksList.Average(r => r.ExpertMarkWeighed5) /
                                                     category.ExpertCoef5;
                category.ExpertMarkWeighedAverage6 = category.RiskExpertMarksList.Average(r => r.ExpertMarkWeighed6) /
                                                     category.ExpertCoef6;
                category.ExpertMarkWeighedAverage7 = category.RiskExpertMarksList.Average(r => r.ExpertMarkWeighed7) /
                                                     category.ExpertCoef7;
                category.ExpertMarkWeighedAverage8 = category.RiskExpertMarksList.Average(r => r.ExpertMarkWeighed8) /
                                                     category.ExpertCoef8;
                category.ExpertMarkWeighedAverage9 = category.RiskExpertMarksList.Average(r => r.ExpertMarkWeighed9) /
                                                     category.ExpertCoef9;
                category.ExpertMarkWeighedAverage10 = category.RiskExpertMarksList.Average(r => r.ExpertMarkWeighed10) /
                                                     category.ExpertCoef10;

                category.AdditionalPrice = category.RiskExpertMarksList.Sum(r => r.AdditionalPrice);
                category.EndPrice = category.Price + category.AdditionalPrice;
                
                var avgPrice = category.RiskExpertMarksList.Average(r => r.AdditionalPrice);
                foreach (var riskExpertMarks in category.RiskExpertMarksList)
                {
                    if (Math.Abs(riskExpertMarks.AdditionalPrice - avgPrice) < 10)
                    {
                        riskExpertMarks.PriceStatus = "Середній";
                    }
                    else if (riskExpertMarks.AdditionalPrice < avgPrice)
                    {
                        riskExpertMarks.PriceStatus = "Низький";
                    }
                    else
                    {
                        riskExpertMarks.PriceStatus = "Високий";
                    }
                }
            }
        }
    }

    public void OnGet()
    {
        SetViewModelCategories();
    }

    public IActionResult OnPostCategory()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }
        
        SetViewModelCategories();
        return Page();
    }
    
    public async Task<IActionResult> OnPostValues()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }
        
        foreach (var category in ViewModel.RiskExpertMarksCategories)
        {
            foreach (var riskExpertMarks in category.RiskExpertMarksList)
            {
                var storedExpertMarks =
                    await _context.RiskExpertMarksEnumerable.FirstOrDefaultAsync(r => r.Id == riskExpertMarks.Id);
                if (storedExpertMarks != null)
                {
                    storedExpertMarks.ExpertMark1 = riskExpertMarks.ExpertMark1;
                    storedExpertMarks.ExpertMark2 = riskExpertMarks.ExpertMark2;
                    storedExpertMarks.ExpertMark3 = riskExpertMarks.ExpertMark3;
                    storedExpertMarks.ExpertMark4 = riskExpertMarks.ExpertMark4;
                    storedExpertMarks.ExpertMark5 = riskExpertMarks.ExpertMark5;
                    storedExpertMarks.ExpertMark6 = riskExpertMarks.ExpertMark6;
                    storedExpertMarks.ExpertMark7 = riskExpertMarks.ExpertMark7;
                    storedExpertMarks.ExpertMark8 = riskExpertMarks.ExpertMark8;
                    storedExpertMarks.ExpertMark9 = riskExpertMarks.ExpertMark9;
                    storedExpertMarks.ExpertMark10 = riskExpertMarks.ExpertMark10;
                }
            }
        }

        await _context.SaveChangesAsync();
        SetViewModelCategories();
        
        return Page();
    }
}