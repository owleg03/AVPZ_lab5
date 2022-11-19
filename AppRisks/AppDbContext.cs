using AppRisks.Models;
using Microsoft.EntityFrameworkCore;

namespace AppRisks;

public class AppDbContext: DbContext
{
    public AppDbContext(DbContextOptions options): base(options) { }
    
    public DbSet<Risk> Risks { get; set; }  = null!;
    public DbSet<RiskCategory> RiskCategories { get; set; } = null!;
    public DbSet<RiskExpertMarks> RiskExpertMarksEnumerable { get; set; } = null!;
    public DbSet<RiskExpertMarksCategory> RiskExpertMarksCategories { get; set; } = null!;


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Risk categories
        modelBuilder.Entity<RiskCategory>().HasData(
            // Stage 1 table 1
            new RiskCategory
            {
                Id = 1,
                Name = "Множина джерел появи технічних ризиків",
                Percentage = 0,
                Section = "Визначення можливих джерел появи ризиків",
                Value = 0
            },
            new RiskCategory
            {
                Id = 2,
                Name = "Множина джерел появи вартісних ризиків",
                Percentage = 0,
                Section = "Визначення можливих джерел появи ризиків",
                Value = 0
            },
            new RiskCategory
            {
                Id = 3,
                Name = "Множина джерел появи планових ризиків",
                Percentage = 0,
                Section = "Визначення можливих джерел появи ризиків",
                Value = 0
            },
            new RiskCategory
            {
                Id = 4,
                Name = "Множина джерел появи ризиків реалізації процесу управління програмним проектом",
                Percentage = 0,
                Section = "Визначення можливих джерел появи ризиків",
                Value = 0
            },
            
            // Stage 1 table 2
            new RiskCategory
            {
                Id = 5,
                Name = "Множина настання технічних ризикових подій",
                Percentage = 0,
                Section = "Ідентифікація потенційних ризикових подій",
                Value = 0
            },
            new RiskCategory
            {
                Id = 6,
                Name = "Множина настання вартісних ризикових подій",
                Percentage = 0,
                Section = "Ідентифікація потенційних ризикових подій",
                Value = 0
            },
            new RiskCategory
            {
                Id = 7,
                Name = "Множина настання планових ризикових подій",
                Percentage = 0,
                Section = "Ідентифікація потенційних ризикових подій",
                Value = 0
            },
            new RiskCategory
            {
                Id = 8,
                Name = "Множина настання ризикових подій реалізації процесу управління програмним проектом",
                Percentage = 0,
                Section = "Ідентифікація потенційних ризикових подій",
                Value = 0
            }
        );
        
        modelBuilder.Entity<Risk>().HasData(
            // Stage 1 table 1
            new Risk
            {
                Id = 1,
                Content = "Функціональні характеристики ПЗ",
                Value = 1,
                RiskCategoryId = 1
            },
            new Risk
            {
                Id = 2,
                Content = "Характеристики якості ПЗ",
                Value = 1,
                RiskCategoryId = 1
            },
            new Risk
            {
                Id = 3,
                Content = "Характеристики надійності ПЗ",
                Value = 1,
                RiskCategoryId = 1
            },
            new Risk
            {
                Id = 4,
                Content = "Застосовність ПЗ",
                Value = 1,
                RiskCategoryId = 1
            },
            new Risk
            {
                Id = 5,
                Content = "Часова продуктивність ПЗ",
                Value = 1,
                RiskCategoryId = 1
            },
            new Risk
            {
                Id = 6,
                Content = "Супроводжуваність ПЗ",
                Value = 1,
                RiskCategoryId = 1
            },
            new Risk
            {
                Id = 7,
                Content = "Повторне використання компонент ПЗ",
                Value = 1,
                RiskCategoryId = 1
            },
            new Risk
            {
                Id = 8,
                Content = "Обмеження сумарного бюджету на програмний продукт",
                Value = 1,
                RiskCategoryId = 2
            },
            new Risk
            {
                Id = 9,
                Content = "Недоступна вартість реалізації програмного проекту",
                Value = 1,
                RiskCategoryId = 2
            },
            new Risk
            {
                Id = 10,
                Content = "Низька ступінь реалізму при оцінюванні витрат на програмний проект",
                Value = 1,
                RiskCategoryId = 2
            },
            new Risk
            {
                Id = 11,
                Content = "Властивості та можливості гнучкості внесення змін до планів життєвого циклу розроблення ПЗ",
                Value = 1,
                RiskCategoryId = 3
            },
            new Risk
            {
                Id = 12,
                Content = "Можливості порушення встановлених термінів реалізації етапів життєвого циклу розроблення ПЗ",
                Value = 1,
                RiskCategoryId = 3
            },
            new Risk
            {
                Id = 13,
                Content = "Низька ступінь реалізму при встановленні планів і етапів життєвого циклу розроблення ПЗ",
                Value = 1,
                RiskCategoryId = 3
            },
            new Risk
            {
                Id = 14,
                Content = "Хибна стратегія реалізації програмного проекту",
                Value = 1,
                RiskCategoryId = 4
            },
            new Risk
            {
                Id = 15,
                Content = "Неефективне планування проекту розроблення ПЗ",
                Value = 1,
                RiskCategoryId = 4
            },
            new Risk
            {
                Id = 16,
                Content = "Неякісне оцінювання програмного проекту",
                Value = 1,
                RiskCategoryId = 4
            },
            new Risk
            {
                Id = 17,
                Content = "Прогалини в документуванні етапів реалізації програмного проекту",
                Value = 1,
                RiskCategoryId = 4
            },
            new Risk
            {
                Id = 18,
                Content = "Промахи в прогнозуванні результатів реалізації програмного проекту",
                Value = 1,
                RiskCategoryId = 4
            },
            
            // Stage 1 table 2
            new Risk
            {
                Id = 19,
                Content = "Затримки у постачанні обладнання, необхідного для підтримки процесу розроблення ПЗ",
                Value = 1,
                RiskCategoryId = 5
            },
            new Risk
            {
                Id = 20,
                Content = "Затримки у постачанні інструментальних засобів, необхідних для підтримки процесу розроблення ПЗ",
                Value = 1,
                RiskCategoryId = 5
            },
            new Risk
            {
                Id = 21,
                Content = "Небажання команди виконавців використовувати інструментальні засоби для підтримки процесу розроблення ПЗ",
                Value = 1,
                RiskCategoryId = 5
            },
            new Risk
             {
                Id = 22,
                Content = "Формування запитів на більш потужні інструментальні засоби розроблення ПЗ",
                Value = 1,
                RiskCategoryId = 5
            },
            new Risk
            {
                Id = 23,
                Content = "Відмова команди виконавців від CASE-засобів розроблення ПЗ",
                Value = 1,
                RiskCategoryId = 5
            },
            new Risk
            {
                Id = 24,
                Content = "Неефективність програмного коду, згенерованого CASE-засобами розроблення ПЗ",
                Value = 1,
                RiskCategoryId = 5
            },
            new Risk
            {
                Id = 25,
                Content = "Неможливість інтеграції CASE-засобів з іншими інструментальними засобами для підтримки процесу розроблення ПЗ",
                Value = 1,
                RiskCategoryId = 5
            },
            new Risk
            {
                Id = 26,
                Content = "Недостатня продуктивність баз(и) даних для підтримки процесу розроблення ПЗ",
                Value = 1,
                RiskCategoryId = 5
            },
            new Risk
            {
                Id = 27,
                Content = "Програмні компоненти, які використовують повторно в ПЗ, мають дефекти та обмежені функціональні можливості",
                Value = 1,
                RiskCategoryId = 5
            },
            new Risk
            {
                Id = 28,
                Content = "Швидкість виявлення дефектів у програмному коді є нижчою від раніше запланованих термінів",
                Value = 1,
                RiskCategoryId = 5
            },
            new Risk
            {
                Id = 29,
                Content = "Поява дефектних системних компонент, які використовують для розроблення ПЗ",
                Value = 1,
                RiskCategoryId = 5
            },
            new Risk
            {
                Id = 30,
                Content = "Недо(пере)оцінювання витрат на реалізацію програмного проекту (надмірно низька вартість)",
                Value = 1,
                RiskCategoryId = 6
            },
            new Risk
            {
                Id = 31,
                Content = "Фінансові ускладнення у компанії-замовника ПЗ",
                Value = 1,
                RiskCategoryId = 6
            },
            new Risk
            {
                Id = 32,
                Content = "Фінансові ускладнення у компанії-розробника ПЗ",
                Value = 1,
                RiskCategoryId = 6
            },
            new Risk
            {
                Id = 33,
                Content = "Змен(збіль)шення бюджету програмного проекта з ініціативи компанії-замовника ПЗ під час його реалізації",
                Value = 1,
                RiskCategoryId = 6
            },
            new Risk
            {
                Id = 34,
                Content = "Висока вартість виконання повторних робіт, необхідних для зміни вимог до ПЗ",
                Value = 1,
                RiskCategoryId = 6
            },
            new Risk
            {
                Id = 35,
                Content = "Реорганізація структурних підрозділів у компанії-замовника ПЗ",
                Value = 1,
                RiskCategoryId = 6
            },
            new Risk
            {
                Id = 36,
                Content = "Реорганізація команди виконавців у компанії-розробника ПЗ",
                Value = 1,
                RiskCategoryId = 6
            },
            new Risk
            {
                Id = 37,
                Content = "Зміни графіка виконання робіт з боку замовника чи розробника ПЗ",
                Value = 1,
                RiskCategoryId = 7
            },
            new Risk
            {
                Id = 38,
                Content = "Порушення графіка виконання робіт з боку компанії-розробника ПЗ",
                Value = 1,
                RiskCategoryId = 7
            },
            new Risk
            {
                Id = 39,
                Content = "Потреба зміни користувацьких вимог до ПЗ з боку компанії-розробника ПЗ",
                Value = 1,
                RiskCategoryId = 7
            },
            new Risk
            {
                Id = 40,
                Content = "Потреба зміни функціональних вимог до ПЗ з боку компанії-розробника ПЗ",
                Value = 1,
                RiskCategoryId = 7
            },
            new Risk
            {
                Id = 41,
                Content = "Потреба виконання великої кількості повторних робіт, необхідних для зміни вимог до ПЗ",
                Value = 1,
                RiskCategoryId = 7
            },
            new Risk
            {
                Id = 42,
                Content = "Недо(пере)оцінювання тривалості етапів реалізації програмного проекту з боку компанії-замовника ПЗ",
                Value = 1,
                RiskCategoryId = 7
            },
            new Risk
            {
                Id = 43,
                Content = "Остаточний розмір ПЗ значно перевищує (менший від) заплановані(их) його характеристики",
                Value = 1,
                RiskCategoryId = 7
            },
            new Risk
            {
                Id = 44,
                Content = "Поява на ринку аналогічного ПЗ до виходу замовленого",
                Value = 1,
                RiskCategoryId = 7
            },
            new Risk
            {
                Id = 45,
                Content = "Поява на ринку більш конкурентоздатного ПЗ",
                Value = 1,
                RiskCategoryId = 7
            },
            new Risk
            {
                Id = 46,
                Content = "Низький моральний стан персоналу команди виконавців ПЗ",
                Value = 1,
                RiskCategoryId = 8
            },
            new Risk
            {
                Id = 47,
                Content = "Низька взаємодія між членами команди виконавців ПЗ",
                Value = 1,
                RiskCategoryId = 8
            },
            new Risk
            {
                Id = 48,
                Content = "Пасивність керівника (менеджера) програмного проекту",
                Value = 1,
                RiskCategoryId = 8
            },
            new Risk
            {
                Id = 49,
                Content = "Недостатня компетентність керівника (менеджера) програмного проекту",
                Value = 1,
                RiskCategoryId = 8
            },
            new Risk
            {
                Id = 50,
                Content = "Незадоволеність замовника результатами етапів реалізації програмного проекту",
                Value = 1,
                RiskCategoryId = 8
            },
            new Risk
            {
                Id = 51,
                Content = "Недостатня кількість фахівців у команді виконавців ПЗ з необхідним професійним рівнем",
                Value = 1,
                RiskCategoryId = 8
            },
            new Risk
            {
                Id = 52,
                Content = "Хвороба провідного виконавця в найкритичніший момент розроблення ПЗ",
                Value = 1,
                RiskCategoryId = 8
            },
            new Risk
            {
                Id = 53,
                Content = "Одночасна хвороба декількох виконавців підчас розроблення ПЗ",
                Value = 1,
                RiskCategoryId = 8
            },
            new Risk
            {
                Id = 54,
                Content = "Неможливість організації необхідного навчання персоналу команди виконавців ПЗ",
                Value = 1,
                RiskCategoryId = 8
            },
            new Risk
            {
                Id = 55,
                Content = "Зміна пріоритетів у процесі управління програмним проектом",
                Value = 1,
                RiskCategoryId = 8
            },
            new Risk
            {
                Id = 56,
                Content = "Недо(пере)оцінювання необхідної кількості розробників (підрядників і субпідрядників) на етапах життєвого циклу розроблення ПЗ",
                Value = 1,
                RiskCategoryId = 8
            },
            new Risk
            {
                Id = 57,
                Content = "Недостатнє (надмірне) документування результатів на етапах реалізації програмного проекту",
                Value = 1,
                RiskCategoryId = 8
            },
            new Risk
            {
                Id = 58,
                Content = "Нереалістичне прогнозування результатів на етапах реалізації програмного проекту",
                Value = 1,
                RiskCategoryId = 8
            },
            new Risk
            {
                Id = 59,
                Content = "Недостатній професійний рівень представників від компанії-замовника ПЗ",
                Value = 1,
                RiskCategoryId = 8
            }
        );
        
        // Stage 2
        modelBuilder.Entity<RiskExpertMarksCategory>().HasData(
            new RiskExpertMarksCategory
            {
                Id = 1,
                ExpertCoef1 = 10,
                ExpertCoef2 = 8,
                ExpertCoef3 = 8,
                ExpertCoef4 = 10,
                ExpertCoef5 = 10,
                ExpertCoef6 = 10,
                ExpertCoef7 = 8,
                ExpertCoef8 = 7,
                ExpertCoef9 = 10,
                ExpertCoef10 = 10,
                Name = "Множина настання технічних ризикових подій"
            },
            new RiskExpertMarksCategory
            {
                Id = 2,
                ExpertCoef1 = 10,
                ExpertCoef2 = 10,
                ExpertCoef3 = 7,
                ExpertCoef4 = 10,
                ExpertCoef5 = 8,
                ExpertCoef6 = 10,
                ExpertCoef7 = 10,
                ExpertCoef8 = 7,
                ExpertCoef9 = 8,
                ExpertCoef10 = 8,
                Name = "Множина настання вартісних ризикових подій"
            },
            new RiskExpertMarksCategory
            {
                Id = 3,
                ExpertCoef1 = 6,
                ExpertCoef2 = 10,
                ExpertCoef3 = 6,
                ExpertCoef4 = 6,
                ExpertCoef5 = 7,
                ExpertCoef6 = 5,
                ExpertCoef7 = 10,
                ExpertCoef8 = 6,
                ExpertCoef9 = 6,
                ExpertCoef10 = 6,
                Name = "Множина настання планових ризикових подій"
            },
            new RiskExpertMarksCategory
            {
                Id = 4,
                ExpertCoef1 = 9,
                ExpertCoef2 = 8,
                ExpertCoef3 = 10,
                ExpertCoef4 = 8,
                ExpertCoef5 = 8,
                ExpertCoef6 = 7,
                ExpertCoef7 = 7,
                ExpertCoef8 = 10,
                ExpertCoef9 = 9,
                ExpertCoef10 = 8,
                Name = "Множина настання ризикових подій реалізації процесу управління програмним проектом"
            }
        ); 
        
        modelBuilder.Entity<RiskExpertMarks>().HasData(
            new RiskExpertMarks
            {
                Id = 1,
                RiskId = 19,
                RiskExpertMarksCategoryId = 1
            },
            new RiskExpertMarks
            {
                Id = 2,
                RiskId = 20,
                RiskExpertMarksCategoryId = 1
            },
            new RiskExpertMarks
            {
                Id = 3,
                RiskId = 21,
                RiskExpertMarksCategoryId = 1
            },
            new RiskExpertMarks
            {
                Id = 4,
                RiskId = 22,
                RiskExpertMarksCategoryId = 1
            },
            new RiskExpertMarks
            {
                Id = 5,
                RiskId = 23,
                RiskExpertMarksCategoryId = 1
            },
            new RiskExpertMarks
            {
                Id = 6,
                RiskId = 24,
                RiskExpertMarksCategoryId = 1
            },
            new RiskExpertMarks
            {
                Id = 7,
                RiskId = 25,
                RiskExpertMarksCategoryId = 1
            },
            new RiskExpertMarks
            {
                Id = 8,
                RiskId = 26,
                RiskExpertMarksCategoryId = 1
            },
            new RiskExpertMarks
            {
                Id = 9,
                RiskId = 27,
                RiskExpertMarksCategoryId = 1
            },
            new RiskExpertMarks
            {
                Id = 10,
                RiskId = 28,
                RiskExpertMarksCategoryId = 1
            },
            new RiskExpertMarks
            {
                Id = 11,
                RiskId = 29,
                RiskExpertMarksCategoryId = 1
            },
            
            // Next category
            new RiskExpertMarks
            {
                Id = 12,
                RiskId = 30,
                RiskExpertMarksCategoryId = 2
            },
            new RiskExpertMarks
            {
                Id = 13,
                RiskId = 31,
                RiskExpertMarksCategoryId = 2
            },
            new RiskExpertMarks
            {
                Id = 14,
                RiskId = 32,
                RiskExpertMarksCategoryId = 2
            },
            new RiskExpertMarks
            {
                Id = 15,
                RiskId = 33,
                RiskExpertMarksCategoryId = 2
            },
            new RiskExpertMarks
            {
                Id = 16,
                RiskId = 34,
                RiskExpertMarksCategoryId = 2
            },
            new RiskExpertMarks
            {
                Id = 17,
                RiskId = 35,
                RiskExpertMarksCategoryId = 2
            },
            new RiskExpertMarks
            {
                Id = 18,
                RiskId = 36,
                RiskExpertMarksCategoryId = 2
            },
            
            // Next category
            new RiskExpertMarks
            {
                Id = 19,
                RiskId = 37,
                RiskExpertMarksCategoryId = 3
            },
            new RiskExpertMarks
            {
                Id = 20,
                RiskId = 38,
                RiskExpertMarksCategoryId = 3
            },
            new RiskExpertMarks
            {
                Id = 21,
                RiskId = 39,
                RiskExpertMarksCategoryId = 3
            },
            new RiskExpertMarks
            {
                Id = 22,
                RiskId = 40,
                RiskExpertMarksCategoryId = 3
            },
            new RiskExpertMarks
            {
                Id = 23,
                RiskId = 41,
                RiskExpertMarksCategoryId = 3
            },
            new RiskExpertMarks
            {
                Id = 24,
                RiskId = 42,
                RiskExpertMarksCategoryId = 3
            },
            new RiskExpertMarks
            {
                Id = 25,
                RiskId = 43,
                RiskExpertMarksCategoryId = 3
            },
            new RiskExpertMarks
            {
                Id = 26,
                RiskId = 44,
                RiskExpertMarksCategoryId = 3
            },
            new RiskExpertMarks
            {
                Id = 27,
                RiskId = 45,
                RiskExpertMarksCategoryId = 3
            },
            
            // Next category
            new RiskExpertMarks
            {
                Id = 28,
                RiskId = 46,
                RiskExpertMarksCategoryId = 4
            },
            new RiskExpertMarks
            {
                Id = 29,
                RiskId = 47,
                RiskExpertMarksCategoryId = 4
            },
            new RiskExpertMarks
            {
                Id = 30,
                RiskId = 48,
                RiskExpertMarksCategoryId = 4
            },
            new RiskExpertMarks
            {
                Id = 31,
                RiskId = 49,
                RiskExpertMarksCategoryId = 4
            },
            new RiskExpertMarks
            {
                Id = 32,
                RiskId = 50,
                RiskExpertMarksCategoryId = 4
            },
            new RiskExpertMarks
            {
                Id = 33,
                RiskId = 51,
                RiskExpertMarksCategoryId = 4
            },
            new RiskExpertMarks
            {
                Id = 34,
                RiskId = 52,
                RiskExpertMarksCategoryId = 4
            },
            new RiskExpertMarks
            {
                Id = 35,
                RiskId = 53,
                RiskExpertMarksCategoryId = 4
            },
            new RiskExpertMarks
            {
                Id = 36,
                RiskId = 54,
                RiskExpertMarksCategoryId = 4
            },
            new RiskExpertMarks
            {
                Id = 37,
                RiskId = 55,
                RiskExpertMarksCategoryId = 4
            },
            new RiskExpertMarks
            {
                Id = 38,
                RiskId = 56,
                RiskExpertMarksCategoryId = 4
            },
            new RiskExpertMarks
            {
                Id = 39,
                RiskId = 57,
                RiskExpertMarksCategoryId = 4
            },
            new RiskExpertMarks
            {
                Id = 40,
                RiskId = 58,
                RiskExpertMarksCategoryId = 4
            },
            new RiskExpertMarks
            {
                Id = 41,
                RiskId = 59,
                RiskExpertMarksCategoryId = 4
            }
        );
    }
}