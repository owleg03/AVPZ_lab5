﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AppRisks.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RiskCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<int>(type: "int", nullable: false),
                    Percentage = table.Column<double>(type: "float", nullable: false),
                    Section = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RiskCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RiskExpertMarksCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RiskExpertMarksCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Risks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<int>(type: "int", nullable: false),
                    RiskCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Risks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Risks_RiskCategories_RiskCategoryId",
                        column: x => x.RiskCategoryId,
                        principalTable: "RiskCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RiskExpertMarksEnumerable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RiskId = table.Column<int>(type: "int", nullable: false),
                    RiskExpertMarksCategoryId = table.Column<int>(type: "int", nullable: false),
                    ExpertCoef1 = table.Column<int>(type: "int", nullable: false),
                    ExpertCoef2 = table.Column<int>(type: "int", nullable: false),
                    ExpertCoef3 = table.Column<int>(type: "int", nullable: false),
                    ExpertCoef4 = table.Column<int>(type: "int", nullable: false),
                    ExpertCoef5 = table.Column<int>(type: "int", nullable: false),
                    ExpertCoef6 = table.Column<int>(type: "int", nullable: false),
                    ExpertCoef7 = table.Column<int>(type: "int", nullable: false),
                    ExpertCoef8 = table.Column<int>(type: "int", nullable: false),
                    ExpertCoef9 = table.Column<int>(type: "int", nullable: false),
                    ExpertCoef10 = table.Column<int>(type: "int", nullable: false),
                    ExpertMark1 = table.Column<double>(type: "float", nullable: false),
                    ExpertMark2 = table.Column<double>(type: "float", nullable: false),
                    ExpertMark3 = table.Column<double>(type: "float", nullable: false),
                    ExpertMark4 = table.Column<double>(type: "float", nullable: false),
                    ExpertMark5 = table.Column<double>(type: "float", nullable: false),
                    ExpertMark6 = table.Column<double>(type: "float", nullable: false),
                    ExpertMark7 = table.Column<double>(type: "float", nullable: false),
                    ExpertMark8 = table.Column<double>(type: "float", nullable: false),
                    ExpertMark9 = table.Column<double>(type: "float", nullable: false),
                    ExpertMark10 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RiskExpertMarksEnumerable", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RiskExpertMarksEnumerable_RiskExpertMarksCategories_RiskExpertMarksCategoryId",
                        column: x => x.RiskExpertMarksCategoryId,
                        principalTable: "RiskExpertMarksCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RiskExpertMarksEnumerable_Risks_RiskId",
                        column: x => x.RiskId,
                        principalTable: "Risks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "RiskCategories",
                columns: new[] { "Id", "Name", "Percentage", "Section", "Value" },
                values: new object[,]
                {
                    { 1, "Множина джерел появи технічних ризиків", 0.0, "Визначення можливих джерел появи ризиків", 0 },
                    { 2, "Множина джерел появи вартісних ризиків", 0.0, "Визначення можливих джерел появи ризиків", 0 },
                    { 3, "Множина джерел появи планових ризиків", 0.0, "Визначення можливих джерел появи ризиків", 0 },
                    { 4, "Множина джерел появи ризиків реалізації процесу управління програмним проектом", 0.0, "Визначення можливих джерел появи ризиків", 0 },
                    { 5, "Множина настання технічних ризикових подій", 0.0, "Ідентифікація потенційних ризикових подій", 0 },
                    { 6, "Множина настання вартісних ризикових подій", 0.0, "Ідентифікація потенційних ризикових подій", 0 },
                    { 7, "Множина настання планових ризикових подій", 0.0, "Ідентифікація потенційних ризикових подій", 0 },
                    { 8, "Множина настання ризикових подій реалізації процесу управління програмним проектом", 0.0, "Ідентифікація потенційних ризикових подій", 0 }
                });

            migrationBuilder.InsertData(
                table: "RiskExpertMarksCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Множина настання технічних ризикових подій" },
                    { 2, "Множина настання вартісних ризикових подій" },
                    { 3, "Множина настання планових ризикових подій" },
                    { 4, "Множина настання ризикових подій реалізації процесу управління програмним проектом" }
                });

            migrationBuilder.InsertData(
                table: "Risks",
                columns: new[] { "Id", "Content", "RiskCategoryId", "Value" },
                values: new object[,]
                {
                    { 1, "Функціональні характеристики ПЗ", 1, 1 },
                    { 2, "Характеристики якості ПЗ", 1, 1 },
                    { 3, "Характеристики надійності ПЗ", 1, 1 },
                    { 4, "Застосовність ПЗ", 1, 1 },
                    { 5, "Часова продуктивність ПЗ", 1, 1 },
                    { 6, "Супроводжуваність ПЗ", 1, 1 },
                    { 7, "Повторне використання компонент ПЗ", 1, 1 },
                    { 8, "Обмеження сумарного бюджету на програмний продукт", 2, 1 },
                    { 9, "Недоступна вартість реалізації програмного проекту", 2, 1 },
                    { 10, "Низька ступінь реалізму при оцінюванні витрат на програмний проект", 2, 1 },
                    { 11, "Властивості та можливості гнучкості внесення змін до планів життєвого циклу розроблення ПЗ", 3, 1 },
                    { 12, "Можливості порушення встановлених термінів реалізації етапів життєвого циклу розроблення ПЗ", 3, 1 },
                    { 13, "Низька ступінь реалізму при встановленні планів і етапів життєвого циклу розроблення ПЗ", 3, 1 },
                    { 14, "Хибна стратегія реалізації програмного проекту", 4, 1 },
                    { 15, "Неефективне планування проекту розроблення ПЗ", 4, 1 },
                    { 16, "Неякісне оцінювання програмного проекту", 4, 1 },
                    { 17, "Прогалини в документуванні етапів реалізації програмного проекту", 4, 1 },
                    { 18, "Промахи в прогнозуванні результатів реалізації програмного проекту", 4, 1 },
                    { 19, "Затримки у постачанні обладнання, необхідного для підтримки процесу розроблення ПЗ", 5, 1 },
                    { 20, "Затримки у постачанні інструментальних засобів, необхідних для підтримки процесу розроблення ПЗ", 5, 1 },
                    { 21, "Небажання команди виконавців використовувати інструментальні засоби для підтримки процесу розроблення ПЗ", 5, 1 },
                    { 22, "Формування запитів на більш потужні інструментальні засоби розроблення ПЗ", 5, 1 },
                    { 23, "Відмова команди виконавців від CASE-засобів розроблення ПЗ", 5, 1 },
                    { 24, "Неефективність програмного коду, згенерованого CASE-засобами розроблення ПЗ", 5, 1 },
                    { 25, "Неможливість інтеграції CASE-засобів з іншими інструментальними засобами для підтримки процесу розроблення ПЗ", 5, 1 },
                    { 26, "Недостатня продуктивність баз(и) даних для підтримки процесу розроблення ПЗ", 5, 1 },
                    { 27, "Програмні компоненти, які використовують повторно в ПЗ, мають дефекти та обмежені функціональні можливості", 5, 1 },
                    { 28, "Швидкість виявлення дефектів у програмному коді є нижчою від раніше запланованих термінів", 5, 1 },
                    { 29, "Поява дефектних системних компонент, які використовують для розроблення ПЗ", 5, 1 },
                    { 30, "Недо(пере)оцінювання витрат на реалізацію програмного проекту (надмірно низька вартість)", 6, 1 },
                    { 31, "Фінансові ускладнення у компанії-замовника ПЗ", 6, 1 },
                    { 32, "Фінансові ускладнення у компанії-розробника ПЗ", 6, 1 },
                    { 33, "Змен(збіль)шення бюджету програмного проекта з ініціативи компанії-замовника ПЗ під час його реалізації", 6, 1 },
                    { 34, "Висока вартість виконання повторних робіт, необхідних для зміни вимог до ПЗ", 6, 1 },
                    { 35, "Реорганізація структурних підрозділів у компанії-замовника ПЗ", 6, 1 },
                    { 36, "Реорганізація команди виконавців у компанії-розробника ПЗ", 6, 1 },
                    { 37, "Зміни графіка виконання робіт з боку замовника чи розробника ПЗ", 7, 1 },
                    { 38, "Порушення графіка виконання робіт з боку компанії-розробника ПЗ", 7, 1 },
                    { 39, "Потреба зміни користувацьких вимог до ПЗ з боку компанії-розробника ПЗ", 7, 1 },
                    { 40, "Потреба зміни функціональних вимог до ПЗ з боку компанії-розробника ПЗ", 7, 1 },
                    { 41, "Потреба виконання великої кількості повторних робіт, необхідних для зміни вимог до ПЗ", 7, 1 },
                    { 42, "Недо(пере)оцінювання тривалості етапів реалізації програмного проекту з боку компанії-замовника ПЗ", 7, 1 },
                    { 43, "Остаточний розмір ПЗ значно перевищує (менший від) заплановані(их) його характеристики", 7, 1 },
                    { 44, "Поява на ринку аналогічного ПЗ до виходу замовленого", 7, 1 },
                    { 45, "Поява на ринку більш конкурентоздатного ПЗ", 7, 1 },
                    { 46, "Низький моральний стан персоналу команди виконавців ПЗ", 8, 1 },
                    { 47, "Низька взаємодія між членами команди виконавців ПЗ", 8, 1 },
                    { 48, "Пасивність керівника (менеджера) програмного проекту", 8, 1 },
                    { 49, "Недостатня компетентність керівника (менеджера) програмного проекту", 8, 1 },
                    { 50, "Незадоволеність замовника результатами етапів реалізації програмного проекту", 8, 1 },
                    { 51, "Недостатня кількість фахівців у команді виконавців ПЗ з необхідним професійним рівнем", 8, 1 },
                    { 52, "Хвороба провідного виконавця в найкритичніший момент розроблення ПЗ", 8, 1 },
                    { 53, "Одночасна хвороба декількох виконавців підчас розроблення ПЗ", 8, 1 },
                    { 54, "Неможливість організації необхідного навчання персоналу команди виконавців ПЗ", 8, 1 },
                    { 55, "Зміна пріоритетів у процесі управління програмним проектом", 8, 1 },
                    { 56, "Недо(пере)оцінювання необхідної кількості розробників (підрядників і субпідрядників) на етапах життєвого циклу розроблення ПЗ", 8, 1 },
                    { 57, "Недостатнє (надмірне) документування результатів на етапах реалізації програмного проекту", 8, 1 },
                    { 58, "Нереалістичне прогнозування результатів на етапах реалізації програмного проекту", 8, 1 },
                    { 59, "Недостатній професійний рівень представників від компанії-замовника ПЗ", 8, 1 }
                });

            migrationBuilder.InsertData(
                table: "RiskExpertMarksEnumerable",
                columns: new[] { "Id", "ExpertCoef1", "ExpertCoef10", "ExpertCoef2", "ExpertCoef3", "ExpertCoef4", "ExpertCoef5", "ExpertCoef6", "ExpertCoef7", "ExpertCoef8", "ExpertCoef9", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "RiskExpertMarksCategoryId", "RiskId" },
                values: new object[,]
                {
                    { 1, 10, 10, 8, 8, 10, 10, 10, 8, 7, 10, 0.35380445722169307, 0.54236653905694432, 0.076550016525822717, 0.53784549339483112, 0.50956086978338411, 0.43650886699466851, 0.037724997702192509, 0.81481506773848733, 0.42587655101719513, 0.11353957450823871, 1, 19 },
                    { 2, 10, 10, 8, 8, 10, 10, 10, 8, 7, 10, 0.37198721675257163, 0.36272841848731452, 0.94511254786065269, 0.95999047372901591, 0.18912799206524733, 0.17708394561514451, 0.066334149690527866, 0.70220168286419771, 0.49576397490816781, 0.76756233876418567, 1, 20 },
                    { 3, 10, 10, 8, 8, 10, 10, 10, 8, 7, 10, 0.11505827129223223, 0.95307871470921401, 0.69790108311827348, 0.42063116407622714, 0.97708500360798356, 0.44848842760208107, 0.77858214759367084, 0.013692910711102901, 0.6112641450111771, 0.24241518526465955, 1, 21 },
                    { 4, 10, 10, 8, 8, 10, 10, 10, 8, 7, 10, 0.36381725873066606, 0.28337173347288358, 0.83192476416476302, 0.26587437878865006, 0.69723951352584201, 0.071020703858323708, 0.60033976185806825, 0.64389511165016955, 0.66182760296097687, 0.99052580656708, 1, 22 },
                    { 5, 10, 10, 8, 8, 10, 10, 10, 8, 7, 10, 0.72954868309249643, 0.92246436133164789, 0.5572994519284401, 0.62128446324038933, 0.87300359529588734, 0.73075459141469634, 0.34437156475162367, 0.88647123405757433, 0.99050657477426396, 0.61191722802598991, 1, 23 },
                    { 6, 10, 10, 8, 8, 10, 10, 10, 8, 7, 10, 0.52840899152759835, 0.16086172142319954, 0.10165002170436654, 0.62110713194069855, 0.81839356076655467, 0.79427179702733886, 0.51666724258058649, 0.70793028666098146, 0.76266925567196742, 0.63339272661809543, 1, 24 },
                    { 7, 10, 10, 8, 8, 10, 10, 10, 8, 7, 10, 0.62252595290175716, 0.019764474861934334, 0.67084343876936603, 0.28748377320804064, 0.51375507737034798, 0.77448095821561447, 0.056255246731237496, 0.026445062117048224, 0.98316542487571679, 0.6441686298000675, 1, 25 },
                    { 8, 10, 10, 8, 8, 10, 10, 10, 8, 7, 10, 0.27784022193049096, 0.83861113110929186, 0.37227942990271712, 0.085909467661357319, 0.6849899266908398, 0.28841482401291041, 0.28712590254423953, 0.20607612927597541, 0.41565105801744995, 0.096808715179176996, 1, 26 },
                    { 9, 10, 10, 8, 8, 10, 10, 10, 8, 7, 10, 0.61384149353939377, 0.98436378227910371, 0.67575808120717173, 0.082485564721867743, 0.92319204827640811, 0.7730250711692902, 0.5516929642047429, 0.59739301110125209, 0.23304435487847608, 0.55919659488843443, 1, 27 },
                    { 10, 10, 10, 8, 8, 10, 10, 10, 8, 7, 10, 0.94363434370754551, 0.22998336602070957, 0.60536003773327229, 0.24617947253575945, 0.9960382998938051, 0.99256521834307421, 0.43236638702916719, 0.060915802481054659, 0.45351452741724807, 0.81629471205658255, 1, 28 },
                    { 11, 10, 10, 8, 8, 10, 10, 10, 8, 7, 10, 0.82836011390563591, 0.464722192016637, 0.83970959882881602, 0.14879323608697348, 0.39108675974288576, 0.87315604759565979, 0.66825992215687025, 0.43575425900019038, 0.83796414469522407, 0.29384217086924613, 1, 29 },
                    { 12, 10, 8, 10, 7, 10, 8, 10, 10, 7, 8, 0.32268119722132538, 0.91111058880175155, 0.88762407637149321, 0.1427840281366235, 0.3123647167926249, 0.75872526776775884, 0.21703648226267747, 0.90328372539047441, 0.26400176668776987, 0.61184452866644212, 2, 30 },
                    { 13, 10, 8, 10, 7, 10, 8, 10, 10, 7, 8, 0.99468994420526491, 0.038570537809909822, 0.60209022474868745, 0.21407490515598715, 0.5445359584506031, 0.67924076945890499, 0.19434340571159436, 0.19109262050783304, 0.45151769132177799, 0.21699043139231855, 2, 31 },
                    { 14, 10, 8, 10, 7, 10, 8, 10, 10, 7, 8, 0.17829943854662789, 0.95011259619848876, 0.67737523866625882, 0.33562366495033125, 0.77429898058737534, 0.90717911120936723, 0.29967945429198894, 0.98986904836338119, 0.78427201040556493, 0.5670088184241876, 2, 32 },
                    { 15, 10, 8, 10, 7, 10, 8, 10, 10, 7, 8, 0.62764891205365303, 0.54631026044288811, 0.28344296239177902, 0.6669702951204145, 0.17673501120644308, 0.4989221966618218, 0.021093181366331759, 0.39610497643612863, 0.68827936228689357, 0.1740552528910484, 2, 33 },
                    { 16, 10, 8, 10, 7, 10, 8, 10, 10, 7, 8, 0.77298207019443599, 0.22221222211840341, 0.73943795466800855, 0.92030937598792739, 0.23071978338882315, 0.18501210718359551, 0.55958169577855132, 0.20645058839666741, 0.90328629894995061, 0.66737687863049588, 2, 34 },
                    { 17, 10, 8, 10, 7, 10, 8, 10, 10, 7, 8, 0.99279052755198494, 0.22263878082538158, 0.88281810380358017, 0.37927816269649117, 0.48780069483462574, 0.62859814227440558, 0.48006876697477308, 0.44791948924495917, 0.58244431211795322, 0.18928912929222796, 2, 35 },
                    { 18, 10, 8, 10, 7, 10, 8, 10, 10, 7, 8, 0.84851965822399567, 0.93554509782160367, 0.84538972627517128, 0.68340871215341126, 0.069744708082267071, 0.3798723945214999, 0.53653967050573936, 0.77963106458146225, 0.47146504656573929, 0.28025371978811797, 2, 36 },
                    { 19, 6, 6, 10, 6, 6, 7, 5, 10, 6, 6, 0.092035784174199997, 0.4666685384213074, 0.96028994275902801, 0.72692090662172715, 0.53134300310509253, 0.22239428631271196, 0.94369805105152305, 0.30761846570770413, 0.61391576972788287, 0.65003792490029166, 3, 37 },
                    { 20, 6, 6, 10, 6, 6, 7, 5, 10, 6, 6, 0.77097344769064602, 0.072529056878351428, 0.50440093541305764, 0.012042167700961781, 0.94499682110501115, 0.69231328588100183, 0.65000329663103551, 0.30122001830179534, 0.97473677621941168, 0.18518725473125053, 3, 38 },
                    { 21, 6, 6, 10, 6, 6, 7, 5, 10, 6, 6, 0.89384516072969311, 0.58042225834265426, 0.71157942944688968, 0.64665288206403082, 0.87297536693031363, 0.79258426720498554, 0.1509095039840328, 0.63514678195299445, 0.71437786785601631, 0.27190181350454723, 3, 39 },
                    { 22, 6, 6, 10, 6, 6, 7, 5, 10, 6, 6, 0.41633117303511202, 0.43925004582879834, 0.84168207580107102, 0.66338285325016588, 0.97293820815919407, 0.68541964431749014, 0.24226721271778395, 0.61112875302188896, 0.68359331551583635, 0.36454698734431334, 3, 40 },
                    { 23, 6, 6, 10, 6, 6, 7, 5, 10, 6, 6, 0.39771131403476168, 0.24200317043570285, 0.45699206351646504, 0.78495438804534146, 0.36336936464951786, 0.10120902880651672, 0.56911073756379371, 0.61685075832450909, 0.19471410579039838, 0.68541824444439181, 3, 41 },
                    { 24, 6, 6, 10, 6, 6, 7, 5, 10, 6, 6, 0.69446403042549154, 0.54646842155221209, 0.21052714339213074, 0.11474958558289172, 0.56589067137973459, 0.094395965469434184, 0.4831286342254596, 0.90288950731193185, 0.97792343848396324, 0.11739792306608188, 3, 42 },
                    { 25, 6, 6, 10, 6, 6, 7, 5, 10, 6, 6, 0.60892000337265983, 0.077496384165947729, 0.37621468717840445, 0.97427371248000794, 0.83998855098802938, 0.98490239633518262, 0.28512880719664724, 0.095887113019015979, 0.69070924841240156, 0.51552545372351655, 3, 43 },
                    { 26, 6, 6, 10, 6, 6, 7, 5, 10, 6, 6, 0.90566645303939852, 0.36073598762535253, 0.0065032860101075229, 0.10880985587690917, 0.8303695768155771, 0.19667404739162997, 0.60857146762483549, 0.88775572769016275, 0.62998165694560015, 0.86197764024505041, 3, 44 },
                    { 27, 6, 6, 10, 6, 6, 7, 5, 10, 6, 6, 0.86402982973301801, 0.40275672843922117, 0.48572723629738535, 0.43388277782116713, 0.19239529593683735, 0.44973316057465262, 0.61702259738225484, 0.35950491589529177, 0.48410906440845114, 0.8326141913729338, 3, 45 },
                    { 28, 9, 8, 8, 10, 8, 8, 7, 7, 10, 9, 0.30646092787715318, 0.54049172653248501, 0.56245291036607092, 0.34241674143107925, 0.65887075330335665, 0.66026096442887161, 0.98804502326480326, 0.47620955827615641, 0.35376919990749744, 0.59607182158967553, 4, 46 },
                    { 29, 9, 8, 8, 10, 8, 8, 7, 7, 10, 9, 0.75378773920865272, 0.72041065997288778, 0.34305222408397795, 0.69162062032800231, 0.61863333239187357, 0.071329495757306627, 0.18274293399066988, 0.5721445498491996, 0.64901306873081743, 0.67783841971179304, 4, 47 },
                    { 30, 9, 8, 8, 10, 8, 8, 7, 7, 10, 9, 0.75740830715466745, 0.63661630514387124, 0.68329151987517989, 0.51049976772610117, 0.18920409969324903, 0.58617605378231163, 0.81031683877884253, 0.37159670130038325, 0.62304049495647951, 0.17022904983953968, 4, 48 },
                    { 31, 9, 8, 8, 10, 8, 8, 7, 7, 10, 9, 0.38862590759550719, 0.84421409336670983, 0.27874989235968839, 0.60649546869613558, 0.062170254325724428, 0.38581867556944527, 0.50015255385608537, 0.36084676884777867, 0.77841337374493835, 0.32438364585926305, 4, 49 },
                    { 32, 9, 8, 8, 10, 8, 8, 7, 7, 10, 9, 0.11734313381250283, 0.61371491232310038, 0.88745187741011899, 0.12857025229029584, 0.28142441067042345, 0.081640395407447053, 0.75429624422874408, 0.6258211626682374, 0.0028636390764326114, 0.98077682212662565, 4, 50 },
                    { 33, 9, 8, 8, 10, 8, 8, 7, 7, 10, 9, 0.78557533072604557, 0.72223130941911162, 0.88033413004884342, 0.10878786700484877, 0.81070617807849299, 0.63117266420598173, 0.79415869793467542, 0.11961972014834221, 0.13059635060439001, 0.17545776032000016, 4, 51 },
                    { 34, 9, 8, 8, 10, 8, 8, 7, 7, 10, 9, 0.53267487467566699, 0.49669230140290843, 0.0094557654897774457, 0.21821322903163787, 0.9440911358027102, 0.43640902264958392, 0.12087658702749038, 0.23105357007826166, 0.24926871444079035, 0.041696962357496536, 4, 52 },
                    { 35, 9, 8, 8, 10, 8, 8, 7, 7, 10, 9, 0.70964003951355537, 0.019015736537460803, 0.16699225924665873, 0.98821846816401604, 0.67710368685476208, 0.14947112328558987, 0.66009572122233762, 0.22119360865334292, 0.21001148212829068, 0.98749898042138295, 4, 53 },
                    { 36, 9, 8, 8, 10, 8, 8, 7, 7, 10, 9, 0.87686583002574214, 0.45967414352819869, 0.31178869902967388, 0.34684699077270209, 0.18785731991904941, 0.81561727656672667, 0.13500541442313507, 0.28825800886050401, 0.10524853771779885, 0.67356008553830804, 4, 54 },
                    { 37, 9, 8, 8, 10, 8, 8, 7, 7, 10, 9, 0.010168585600887847, 0.58598059583997153, 0.69243861657375616, 0.082348025881755271, 0.54001818814323943, 0.46213011041057905, 0.19829534830915518, 0.71842861325315233, 0.31468987464068521, 0.7803118939701541, 4, 55 },
                    { 38, 9, 8, 8, 10, 8, 8, 7, 7, 10, 9, 0.52241754436382015, 0.12003579358394967, 0.34124257194456042, 0.74105216088112269, 0.38004593430124511, 0.31829965014056272, 0.34942995337446636, 0.22266182542327917, 0.7799140287251648, 0.53378800020925632, 4, 56 },
                    { 39, 9, 8, 8, 10, 8, 8, 7, 7, 10, 9, 0.72172340685095682, 0.16080844873081035, 0.0024640467006342703, 0.94835846326740891, 0.089002632932777215, 0.2585878159989079, 0.26208859654035055, 0.74327696393732978, 0.94617291406509141, 0.6342115949038224, 4, 57 },
                    { 40, 9, 8, 8, 10, 8, 8, 7, 7, 10, 9, 0.32965660627102467, 0.51924995346704728, 0.63199781105197461, 0.8679702007638691, 0.95621465425004626, 0.75141547185227509, 0.71112294438430246, 0.2940143166341378, 0.70484391772123023, 0.32406592015300195, 4, 58 },
                    { 41, 9, 8, 8, 10, 8, 8, 7, 7, 10, 9, 0.69796553973757847, 0.45476728502325192, 0.3393714045795434, 0.17896663987789019, 0.44465757190608635, 0.64212260993420323, 0.98536409220178156, 0.77411836447198845, 0.22467700114225309, 0.14380494264368637, 4, 59 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_RiskExpertMarksEnumerable_RiskExpertMarksCategoryId",
                table: "RiskExpertMarksEnumerable",
                column: "RiskExpertMarksCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskExpertMarksEnumerable_RiskId",
                table: "RiskExpertMarksEnumerable",
                column: "RiskId");

            migrationBuilder.CreateIndex(
                name: "IX_Risks_RiskCategoryId",
                table: "Risks",
                column: "RiskCategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RiskExpertMarksEnumerable");

            migrationBuilder.DropTable(
                name: "RiskExpertMarksCategories");

            migrationBuilder.DropTable(
                name: "Risks");

            migrationBuilder.DropTable(
                name: "RiskCategories");
        }
    }
}