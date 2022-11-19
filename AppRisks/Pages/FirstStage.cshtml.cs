using AppRisks.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AppRisks.Pages;

public class FirstStage : PageModel
{
    private readonly AppDbContext _context;
    public const string FirstStageSection1 = "Визначення можливих джерел появи ризиків";
    public const string FirstStageSection2 = "Ідентифікація потенційних ризикових подій";

    public FirstStage(AppDbContext context)
    {
        _context = context;
        ViewModel = new FirstStageViewModel();
    }

    public class FirstStageViewModel
    {
        public IList<RiskCategory>? Categories { get; set; }

        public int TotalValue { get; set; }
    }

    [BindProperty] 
    public FirstStageViewModel ViewModel { get; set; }

    [BindProperty] 
    public string FirstStageSection { get; set; } = FirstStageSection1;

    private void SetViewModelCategories()
    {
        var categories = _context.RiskCategories
            .Where(c => c.Section == FirstStageSection)
            .OrderBy(c => c.Id)
            .Include(c => c.Risks)
            .ToList();

        // Calculate summary for each category
        foreach (var category in categories)
        {
            category.Value = category.Risks.Sum(r => r.Value);
        }

        var totalValue = categories.Sum(c => c.Value);

        // Calculate percentage for each category
        foreach (var category in categories)
        {
            category.Percentage = category.Value * 100.0 / totalValue;
        }

        ViewModel.Categories = categories.ToList();
        ViewModel.TotalValue = totalValue;
    }
    
    public void OnGet()
    {
        SetViewModelCategories();
    }

    public IActionResult OnPostCategory()
    {
        SetViewModelCategories();
        return Page();
    }
    
    public async Task<IActionResult> OnPostValues()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        foreach (var category in ViewModel.Categories!)
        {
            var storedCategory = await _context.RiskCategories.FirstOrDefaultAsync(c => c.Id == category.Id);
            if (storedCategory != null)
            {
                storedCategory.Risks = category.Risks;
            }
        }

        await _context.SaveChangesAsync();
        SetViewModelCategories();

        return Page();
    }
}