using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppRisks.Migrations
{
    /// <inheritdoc />
    public partial class MoveExpertCoef : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExpertCoef1",
                table: "RiskExpertMarksEnumerable");

            migrationBuilder.DropColumn(
                name: "ExpertCoef10",
                table: "RiskExpertMarksEnumerable");

            migrationBuilder.DropColumn(
                name: "ExpertCoef2",
                table: "RiskExpertMarksEnumerable");

            migrationBuilder.DropColumn(
                name: "ExpertCoef3",
                table: "RiskExpertMarksEnumerable");

            migrationBuilder.DropColumn(
                name: "ExpertCoef4",
                table: "RiskExpertMarksEnumerable");

            migrationBuilder.DropColumn(
                name: "ExpertCoef5",
                table: "RiskExpertMarksEnumerable");

            migrationBuilder.DropColumn(
                name: "ExpertCoef6",
                table: "RiskExpertMarksEnumerable");

            migrationBuilder.DropColumn(
                name: "ExpertCoef7",
                table: "RiskExpertMarksEnumerable");

            migrationBuilder.DropColumn(
                name: "ExpertCoef8",
                table: "RiskExpertMarksEnumerable");

            migrationBuilder.DropColumn(
                name: "ExpertCoef9",
                table: "RiskExpertMarksEnumerable");

            migrationBuilder.AddColumn<int>(
                name: "ExpertCoef1",
                table: "RiskExpertMarksCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ExpertCoef10",
                table: "RiskExpertMarksCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ExpertCoef2",
                table: "RiskExpertMarksCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ExpertCoef3",
                table: "RiskExpertMarksCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ExpertCoef4",
                table: "RiskExpertMarksCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ExpertCoef5",
                table: "RiskExpertMarksCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ExpertCoef6",
                table: "RiskExpertMarksCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ExpertCoef7",
                table: "RiskExpertMarksCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ExpertCoef8",
                table: "RiskExpertMarksCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ExpertCoef9",
                table: "RiskExpertMarksCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ExpertCoef1", "ExpertCoef10", "ExpertCoef2", "ExpertCoef3", "ExpertCoef4", "ExpertCoef5", "ExpertCoef6", "ExpertCoef7", "ExpertCoef8", "ExpertCoef9" },
                values: new object[] { 10, 10, 8, 8, 10, 10, 10, 8, 7, 10 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExpertCoef1", "ExpertCoef10", "ExpertCoef2", "ExpertCoef3", "ExpertCoef4", "ExpertCoef5", "ExpertCoef6", "ExpertCoef7", "ExpertCoef8", "ExpertCoef9" },
                values: new object[] { 10, 8, 10, 7, 10, 8, 10, 10, 7, 8 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ExpertCoef1", "ExpertCoef10", "ExpertCoef2", "ExpertCoef3", "ExpertCoef4", "ExpertCoef5", "ExpertCoef6", "ExpertCoef7", "ExpertCoef8", "ExpertCoef9" },
                values: new object[] { 6, 6, 10, 6, 6, 7, 5, 10, 6, 6 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksCategories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ExpertCoef1", "ExpertCoef10", "ExpertCoef2", "ExpertCoef3", "ExpertCoef4", "ExpertCoef5", "ExpertCoef6", "ExpertCoef7", "ExpertCoef8", "ExpertCoef9" },
                values: new object[] { 9, 8, 8, 10, 8, 8, 7, 7, 10, 9 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 0.70411581986488148, 0.34350088069905393, 0.76364562763407406, 0.79478205686280179, 0.33500653612383136, 0.2942067910597308, 0.84630236837810535, 0.78997261748842373, 0.22995995048857676, 0.52485056726401835 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 0.31913413981225414, 0.25187426352232167, 0.87581384123599981, 0.6050023242656688, 0.64728466082997937, 0.88921015621372634, 0.023808038646576102, 0.6392991899263768, 0.21610501545257221, 0.63525602875412635 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 0.16220820082523602, 0.75739859206891158, 0.6038879663198129, 0.6932748336324982, 0.31383520281690813, 0.5831353936431708, 0.027769101587805878, 0.23615243300123601, 0.41564410199860402, 0.3722474945788673 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 0.24692968205050647, 0.23233829703637354, 0.62729832722313206, 0.28179315314047937, 0.24824909637880155, 0.96378926528642128, 0.51920323093997001, 0.2018350672283481, 0.54636133926459995, 0.93216924587177996 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 0.33288746830815052, 0.62751513149853888, 0.70525082217391977, 0.068679844636105547, 0.49036394965225738, 0.013861783459889976, 0.71641235527089087, 0.43931874154022588, 0.94523522014631134, 0.12833167744626195 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 0.53073612866702469, 0.51835729551871812, 0.93882246369393518, 0.55555827083129072, 0.12946559771940369, 0.12770017689147339, 0.86666133143215263, 0.8575075238440365, 0.51303395235189941, 0.67663314858075752 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 0.94151035439405106, 0.10251840698379666, 0.1544861593562139, 0.039964651667061424, 0.61552234240769743, 0.75630255208806529, 0.13715573238496059, 0.47457298117527791, 0.62307434869694067, 0.08614361165697737 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 0.92984638117607454, 0.45881363910971029, 0.85845835961701344, 0.93372827837634298, 0.87627734424105119, 0.11491733745704513, 0.85747708486080454, 0.69259482895555091, 0.8594508046472642, 0.81958578523692416 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 0.61351356978973748, 0.46638301123557169, 0.02098348510095227, 0.73319045211081968, 0.51698679176324103, 0.45829532149465269, 0.93697070104873414, 0.56769454938844088, 0.98130456431680291, 0.35854011078097081 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 0.48849826343348701, 0.48865985606852547, 0.27637891341941234, 0.93782893784956867, 0.84429980552189088, 0.78285337780387509, 0.51937336166098036, 0.93626971616076016, 0.96700532122048644, 0.95923256008906599 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 0.050513677952254143, 0.29750995539536196, 0.47090453105803254, 0.21443782109269149, 0.011394183933417845, 0.38729846707745441, 0.041352648780340284, 0.30527001958589117, 0.16473769869841093, 0.93867018640878463 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 0.83781585565080841, 0.8597833746307546, 0.33638236139700051, 0.51065506621293044, 0.39984593356712317, 0.59975879971829482, 0.63850333984057328, 0.8837168397188464, 0.62500323818453363, 0.78979457430611 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 0.92993187493170082, 0.50547084648126295, 0.48404098569745013, 0.50924041635933759, 0.59011274102422406, 0.1957651947599276, 0.77652368881216682, 0.28096211331885856, 0.94749081453522133, 0.46621995332029287 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 0.76635194074028767, 0.88970472498892261, 0.99846529285333574, 0.035444065592401208, 0.5418933191416041, 0.92800774063185798, 0.45584096806941032, 0.32678052212386555, 0.87512825697454966, 0.76186627393653206 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 0.79400536488098139, 0.59204564238874835, 0.93598694617786249, 0.33989781994200152, 0.32066255091008389, 0.18606235458291454, 0.91713199239493526, 0.77059314910348709, 0.28130978814735552, 0.079809546550066446 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 0.57169664906627826, 0.46638412439274834, 0.051589545548574534, 0.48267869343626368, 0.82930520640125138, 0.34940377007072387, 0.77665688727364179, 0.20068470564630903, 0.5431388716691059, 0.47560513160376316 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 0.034782619859019537, 0.097392629264060004, 0.22199634333423868, 0.4071948083784781, 0.13021558805760824, 0.54372538158654393, 0.17324305813884877, 0.7730282766043084, 0.84989296479316923, 0.8715594877402898 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 0.024932629205858259, 0.38438830843595961, 0.032661368832503035, 0.81882441963932051, 0.38886369827127532, 0.90135653933840287, 0.6491092446150073, 0.56369617279478212, 0.14956769981222706, 0.85570981282051195 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 0.33074906882408994, 0.68372494805314787, 0.87643498667356967, 0.10475247747477845, 0.19293372285232602, 0.97599446792804845, 0.71718314619181578, 0.28863739724191717, 0.92243400977428602, 0.14726415609593446 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 0.6113555222665672, 0.67176676482378517, 0.33863100204531071, 0.42565030318626762, 0.076674802369933182, 0.55530686033048871, 0.81041418331833026, 0.2337523489262473, 0.49487775430842684, 0.40081851453262973 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 0.02343247675280169, 0.74428054385920894, 0.21798784556111739, 0.51066825626807244, 0.66039744374326281, 0.93667093550181846, 0.35450487335807934, 0.11344419193704403, 0.32303728008234656, 0.33044795423376705 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 0.67896187973349031, 0.74361897576096403, 0.17919253488614062, 0.19642740927137436, 0.16849137354866439, 0.75821983551947081, 0.10417974538311214, 0.80175763887091589, 0.95747135813234119, 0.91953124641732165 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 0.85560213160904108, 0.62950885154172609, 0.17577493166577296, 0.27544936476893023, 0.0097301049170681608, 0.78312251552752554, 0.43505185145569214, 0.22169164154148024, 0.40759583091798834, 0.0038574466345708824 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 0.90033868627957148, 0.28959213642029502, 0.098526964364932912, 0.7049661157151309, 0.095385001652882107, 0.9227606901798816, 0.16701492550137054, 0.82738348329193234, 0.65402322744017694, 0.52608308150081207 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 0.43430647073471784, 0.89078585826929868, 0.54724553606671156, 0.051267795716263498, 0.37229917223380582, 0.86395766593009227, 0.39390074516795714, 0.24725924759918894, 0.53797517639302872, 0.11708171395880151 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 0.94967239542942117, 0.37811303347321057, 0.31639056622331874, 0.007230622772705142, 0.13499831740623747, 0.91534058009626762, 0.48436865455736366, 0.17499407969380698, 0.24632209384001569, 0.17450896650599845 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 0.9403979174536915, 0.73050553751435243, 0.36737259770047492, 0.99466871238766563, 0.19855825689053197, 0.15822601701443917, 0.94506216879983074, 0.25193949185557363, 0.36865829933610272, 0.67880100164566792 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 0.88659871052615802, 0.5243784386767546, 0.69389499143438027, 0.32885440302568625, 0.19530492175213188, 0.3385091000393694, 0.13604269491026044, 0.13557153152687584, 0.34582474010432773, 0.2551772490949249 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 0.25734550009118462, 0.56431237759737396, 0.91872818999959804, 0.89640049735592786, 0.90502405669111718, 0.98354168174924173, 0.59412387136411471, 0.41464963930390597, 0.19288132878856212, 0.86776573615556962 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 0.26548672945442164, 0.91860219952983735, 0.3139284861915409, 0.99357158214521812, 0.77594239037093748, 0.50701019338603348, 0.78608870605181591, 0.7629092264862597, 0.47899609092751938, 0.77843430448198769 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 0.77880678510365253, 0.38082919044147312, 0.15987115220929449, 0.20195000195851009, 0.59280911665452074, 0.96437711936263848, 0.91708039317820023, 0.68078782319839037, 0.44553416476990748, 0.22405613745771191 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 0.68071624015248711, 0.86042724160485484, 0.82862845119808204, 0.77888575710696328, 0.0056764377646427722, 0.5251883072578758, 0.50883171257895232, 0.51287845517202624, 0.43209184217003371, 0.45420225538957315 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 0.072919430518489814, 0.56327754666804553, 0.32074073265215752, 0.69291287025170667, 0.035312421239103498, 0.1412998152622571, 0.91161779556554723, 0.40822214601003026, 0.038590239644472057, 0.0085376914795942671 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 0.27353351002900073, 0.97023489375497818, 0.19607749129661589, 0.708272622916852, 0.44840746990071845, 0.94863772413209568, 0.98093275397330226, 0.99486981451489898, 0.064426993548740374, 0.70823701516960258 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 0.72922603824519439, 0.63566736570011795, 0.72663639620977871, 0.43299898451755037, 0.14005592391230615, 0.00034274016283553088, 0.35040206368839755, 0.40525591878115819, 0.36967316510646087, 0.33189651021402899 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 0.56402185260873527, 0.9926598370393287, 0.30066935725611221, 0.23962663408766449, 0.04711849429650472, 0.73772161237142986, 0.28459832043931188, 0.61891884507601702, 0.29768242477245044, 0.14728166382065699 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 0.97380261343404328, 0.61911554625835452, 0.21887319605926714, 0.34728500804620244, 0.090308050965371534, 0.23662902296498201, 0.77403334655412825, 0.68331395863587652, 0.27728121917507975, 0.062469247298905128 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 0.81583053412237538, 0.90910105366866545, 0.93351799774401378, 0.55410245807486203, 0.082855800308512695, 0.59212609894620583, 0.76830245824066523, 0.33997088803625353, 0.45622362445399145, 0.94086040976194618 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 0.84572775585684823, 0.21874912854281192, 0.49928249557804183, 0.07141295955332172, 0.92968565798258884, 0.31497140751754982, 0.92571911733302548, 0.73576943614494938, 0.80480221507281291, 0.19231851140031941 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 0.67768207228843402, 0.69246725654545771, 0.42456505050108606, 0.51480572881969122, 0.52700574206019202, 0.43939577659133688, 0.47231565891956395, 0.66492525034061423, 0.11565855527180768, 0.078699389307677503 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 0.35556397529232964, 0.8212024766665359, 0.76371134435032328, 0.39775851167162624, 0.52658671920851918, 0.67529084613612766, 0.89661852783051998, 0.49964315385541513, 0.76881950077561323, 0.65065566876016945 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExpertCoef1",
                table: "RiskExpertMarksCategories");

            migrationBuilder.DropColumn(
                name: "ExpertCoef10",
                table: "RiskExpertMarksCategories");

            migrationBuilder.DropColumn(
                name: "ExpertCoef2",
                table: "RiskExpertMarksCategories");

            migrationBuilder.DropColumn(
                name: "ExpertCoef3",
                table: "RiskExpertMarksCategories");

            migrationBuilder.DropColumn(
                name: "ExpertCoef4",
                table: "RiskExpertMarksCategories");

            migrationBuilder.DropColumn(
                name: "ExpertCoef5",
                table: "RiskExpertMarksCategories");

            migrationBuilder.DropColumn(
                name: "ExpertCoef6",
                table: "RiskExpertMarksCategories");

            migrationBuilder.DropColumn(
                name: "ExpertCoef7",
                table: "RiskExpertMarksCategories");

            migrationBuilder.DropColumn(
                name: "ExpertCoef8",
                table: "RiskExpertMarksCategories");

            migrationBuilder.DropColumn(
                name: "ExpertCoef9",
                table: "RiskExpertMarksCategories");

            migrationBuilder.AddColumn<int>(
                name: "ExpertCoef1",
                table: "RiskExpertMarksEnumerable",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ExpertCoef10",
                table: "RiskExpertMarksEnumerable",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ExpertCoef2",
                table: "RiskExpertMarksEnumerable",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ExpertCoef3",
                table: "RiskExpertMarksEnumerable",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ExpertCoef4",
                table: "RiskExpertMarksEnumerable",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ExpertCoef5",
                table: "RiskExpertMarksEnumerable",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ExpertCoef6",
                table: "RiskExpertMarksEnumerable",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ExpertCoef7",
                table: "RiskExpertMarksEnumerable",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ExpertCoef8",
                table: "RiskExpertMarksEnumerable",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ExpertCoef9",
                table: "RiskExpertMarksEnumerable",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ExpertCoef1", "ExpertCoef10", "ExpertCoef2", "ExpertCoef3", "ExpertCoef4", "ExpertCoef5", "ExpertCoef6", "ExpertCoef7", "ExpertCoef8", "ExpertCoef9", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 10, 10, 8, 8, 10, 10, 10, 8, 7, 10, 0.35380445722169307, 0.54236653905694432, 0.076550016525822717, 0.53784549339483112, 0.50956086978338411, 0.43650886699466851, 0.037724997702192509, 0.81481506773848733, 0.42587655101719513, 0.11353957450823871 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExpertCoef1", "ExpertCoef10", "ExpertCoef2", "ExpertCoef3", "ExpertCoef4", "ExpertCoef5", "ExpertCoef6", "ExpertCoef7", "ExpertCoef8", "ExpertCoef9", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 10, 10, 8, 8, 10, 10, 10, 8, 7, 10, 0.37198721675257163, 0.36272841848731452, 0.94511254786065269, 0.95999047372901591, 0.18912799206524733, 0.17708394561514451, 0.066334149690527866, 0.70220168286419771, 0.49576397490816781, 0.76756233876418567 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ExpertCoef1", "ExpertCoef10", "ExpertCoef2", "ExpertCoef3", "ExpertCoef4", "ExpertCoef5", "ExpertCoef6", "ExpertCoef7", "ExpertCoef8", "ExpertCoef9", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 10, 10, 8, 8, 10, 10, 10, 8, 7, 10, 0.11505827129223223, 0.95307871470921401, 0.69790108311827348, 0.42063116407622714, 0.97708500360798356, 0.44848842760208107, 0.77858214759367084, 0.013692910711102901, 0.6112641450111771, 0.24241518526465955 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ExpertCoef1", "ExpertCoef10", "ExpertCoef2", "ExpertCoef3", "ExpertCoef4", "ExpertCoef5", "ExpertCoef6", "ExpertCoef7", "ExpertCoef8", "ExpertCoef9", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 10, 10, 8, 8, 10, 10, 10, 8, 7, 10, 0.36381725873066606, 0.28337173347288358, 0.83192476416476302, 0.26587437878865006, 0.69723951352584201, 0.071020703858323708, 0.60033976185806825, 0.64389511165016955, 0.66182760296097687, 0.99052580656708 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ExpertCoef1", "ExpertCoef10", "ExpertCoef2", "ExpertCoef3", "ExpertCoef4", "ExpertCoef5", "ExpertCoef6", "ExpertCoef7", "ExpertCoef8", "ExpertCoef9", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 10, 10, 8, 8, 10, 10, 10, 8, 7, 10, 0.72954868309249643, 0.92246436133164789, 0.5572994519284401, 0.62128446324038933, 0.87300359529588734, 0.73075459141469634, 0.34437156475162367, 0.88647123405757433, 0.99050657477426396, 0.61191722802598991 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ExpertCoef1", "ExpertCoef10", "ExpertCoef2", "ExpertCoef3", "ExpertCoef4", "ExpertCoef5", "ExpertCoef6", "ExpertCoef7", "ExpertCoef8", "ExpertCoef9", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 10, 10, 8, 8, 10, 10, 10, 8, 7, 10, 0.52840899152759835, 0.16086172142319954, 0.10165002170436654, 0.62110713194069855, 0.81839356076655467, 0.79427179702733886, 0.51666724258058649, 0.70793028666098146, 0.76266925567196742, 0.63339272661809543 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ExpertCoef1", "ExpertCoef10", "ExpertCoef2", "ExpertCoef3", "ExpertCoef4", "ExpertCoef5", "ExpertCoef6", "ExpertCoef7", "ExpertCoef8", "ExpertCoef9", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 10, 10, 8, 8, 10, 10, 10, 8, 7, 10, 0.62252595290175716, 0.019764474861934334, 0.67084343876936603, 0.28748377320804064, 0.51375507737034798, 0.77448095821561447, 0.056255246731237496, 0.026445062117048224, 0.98316542487571679, 0.6441686298000675 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ExpertCoef1", "ExpertCoef10", "ExpertCoef2", "ExpertCoef3", "ExpertCoef4", "ExpertCoef5", "ExpertCoef6", "ExpertCoef7", "ExpertCoef8", "ExpertCoef9", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 10, 10, 8, 8, 10, 10, 10, 8, 7, 10, 0.27784022193049096, 0.83861113110929186, 0.37227942990271712, 0.085909467661357319, 0.6849899266908398, 0.28841482401291041, 0.28712590254423953, 0.20607612927597541, 0.41565105801744995, 0.096808715179176996 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ExpertCoef1", "ExpertCoef10", "ExpertCoef2", "ExpertCoef3", "ExpertCoef4", "ExpertCoef5", "ExpertCoef6", "ExpertCoef7", "ExpertCoef8", "ExpertCoef9", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 10, 10, 8, 8, 10, 10, 10, 8, 7, 10, 0.61384149353939377, 0.98436378227910371, 0.67575808120717173, 0.082485564721867743, 0.92319204827640811, 0.7730250711692902, 0.5516929642047429, 0.59739301110125209, 0.23304435487847608, 0.55919659488843443 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ExpertCoef1", "ExpertCoef10", "ExpertCoef2", "ExpertCoef3", "ExpertCoef4", "ExpertCoef5", "ExpertCoef6", "ExpertCoef7", "ExpertCoef8", "ExpertCoef9", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 10, 10, 8, 8, 10, 10, 10, 8, 7, 10, 0.94363434370754551, 0.22998336602070957, 0.60536003773327229, 0.24617947253575945, 0.9960382998938051, 0.99256521834307421, 0.43236638702916719, 0.060915802481054659, 0.45351452741724807, 0.81629471205658255 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ExpertCoef1", "ExpertCoef10", "ExpertCoef2", "ExpertCoef3", "ExpertCoef4", "ExpertCoef5", "ExpertCoef6", "ExpertCoef7", "ExpertCoef8", "ExpertCoef9", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 10, 10, 8, 8, 10, 10, 10, 8, 7, 10, 0.82836011390563591, 0.464722192016637, 0.83970959882881602, 0.14879323608697348, 0.39108675974288576, 0.87315604759565979, 0.66825992215687025, 0.43575425900019038, 0.83796414469522407, 0.29384217086924613 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ExpertCoef1", "ExpertCoef10", "ExpertCoef2", "ExpertCoef3", "ExpertCoef4", "ExpertCoef5", "ExpertCoef6", "ExpertCoef7", "ExpertCoef8", "ExpertCoef9", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 10, 8, 10, 7, 10, 8, 10, 10, 7, 8, 0.32268119722132538, 0.91111058880175155, 0.88762407637149321, 0.1427840281366235, 0.3123647167926249, 0.75872526776775884, 0.21703648226267747, 0.90328372539047441, 0.26400176668776987, 0.61184452866644212 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ExpertCoef1", "ExpertCoef10", "ExpertCoef2", "ExpertCoef3", "ExpertCoef4", "ExpertCoef5", "ExpertCoef6", "ExpertCoef7", "ExpertCoef8", "ExpertCoef9", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 10, 8, 10, 7, 10, 8, 10, 10, 7, 8, 0.99468994420526491, 0.038570537809909822, 0.60209022474868745, 0.21407490515598715, 0.5445359584506031, 0.67924076945890499, 0.19434340571159436, 0.19109262050783304, 0.45151769132177799, 0.21699043139231855 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ExpertCoef1", "ExpertCoef10", "ExpertCoef2", "ExpertCoef3", "ExpertCoef4", "ExpertCoef5", "ExpertCoef6", "ExpertCoef7", "ExpertCoef8", "ExpertCoef9", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 10, 8, 10, 7, 10, 8, 10, 10, 7, 8, 0.17829943854662789, 0.95011259619848876, 0.67737523866625882, 0.33562366495033125, 0.77429898058737534, 0.90717911120936723, 0.29967945429198894, 0.98986904836338119, 0.78427201040556493, 0.5670088184241876 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ExpertCoef1", "ExpertCoef10", "ExpertCoef2", "ExpertCoef3", "ExpertCoef4", "ExpertCoef5", "ExpertCoef6", "ExpertCoef7", "ExpertCoef8", "ExpertCoef9", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 10, 8, 10, 7, 10, 8, 10, 10, 7, 8, 0.62764891205365303, 0.54631026044288811, 0.28344296239177902, 0.6669702951204145, 0.17673501120644308, 0.4989221966618218, 0.021093181366331759, 0.39610497643612863, 0.68827936228689357, 0.1740552528910484 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ExpertCoef1", "ExpertCoef10", "ExpertCoef2", "ExpertCoef3", "ExpertCoef4", "ExpertCoef5", "ExpertCoef6", "ExpertCoef7", "ExpertCoef8", "ExpertCoef9", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 10, 8, 10, 7, 10, 8, 10, 10, 7, 8, 0.77298207019443599, 0.22221222211840341, 0.73943795466800855, 0.92030937598792739, 0.23071978338882315, 0.18501210718359551, 0.55958169577855132, 0.20645058839666741, 0.90328629894995061, 0.66737687863049588 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ExpertCoef1", "ExpertCoef10", "ExpertCoef2", "ExpertCoef3", "ExpertCoef4", "ExpertCoef5", "ExpertCoef6", "ExpertCoef7", "ExpertCoef8", "ExpertCoef9", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 10, 8, 10, 7, 10, 8, 10, 10, 7, 8, 0.99279052755198494, 0.22263878082538158, 0.88281810380358017, 0.37927816269649117, 0.48780069483462574, 0.62859814227440558, 0.48006876697477308, 0.44791948924495917, 0.58244431211795322, 0.18928912929222796 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ExpertCoef1", "ExpertCoef10", "ExpertCoef2", "ExpertCoef3", "ExpertCoef4", "ExpertCoef5", "ExpertCoef6", "ExpertCoef7", "ExpertCoef8", "ExpertCoef9", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 10, 8, 10, 7, 10, 8, 10, 10, 7, 8, 0.84851965822399567, 0.93554509782160367, 0.84538972627517128, 0.68340871215341126, 0.069744708082267071, 0.3798723945214999, 0.53653967050573936, 0.77963106458146225, 0.47146504656573929, 0.28025371978811797 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ExpertCoef1", "ExpertCoef10", "ExpertCoef2", "ExpertCoef3", "ExpertCoef4", "ExpertCoef5", "ExpertCoef6", "ExpertCoef7", "ExpertCoef8", "ExpertCoef9", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 6, 6, 10, 6, 6, 7, 5, 10, 6, 6, 0.092035784174199997, 0.4666685384213074, 0.96028994275902801, 0.72692090662172715, 0.53134300310509253, 0.22239428631271196, 0.94369805105152305, 0.30761846570770413, 0.61391576972788287, 0.65003792490029166 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ExpertCoef1", "ExpertCoef10", "ExpertCoef2", "ExpertCoef3", "ExpertCoef4", "ExpertCoef5", "ExpertCoef6", "ExpertCoef7", "ExpertCoef8", "ExpertCoef9", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 6, 6, 10, 6, 6, 7, 5, 10, 6, 6, 0.77097344769064602, 0.072529056878351428, 0.50440093541305764, 0.012042167700961781, 0.94499682110501115, 0.69231328588100183, 0.65000329663103551, 0.30122001830179534, 0.97473677621941168, 0.18518725473125053 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ExpertCoef1", "ExpertCoef10", "ExpertCoef2", "ExpertCoef3", "ExpertCoef4", "ExpertCoef5", "ExpertCoef6", "ExpertCoef7", "ExpertCoef8", "ExpertCoef9", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 6, 6, 10, 6, 6, 7, 5, 10, 6, 6, 0.89384516072969311, 0.58042225834265426, 0.71157942944688968, 0.64665288206403082, 0.87297536693031363, 0.79258426720498554, 0.1509095039840328, 0.63514678195299445, 0.71437786785601631, 0.27190181350454723 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ExpertCoef1", "ExpertCoef10", "ExpertCoef2", "ExpertCoef3", "ExpertCoef4", "ExpertCoef5", "ExpertCoef6", "ExpertCoef7", "ExpertCoef8", "ExpertCoef9", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 6, 6, 10, 6, 6, 7, 5, 10, 6, 6, 0.41633117303511202, 0.43925004582879834, 0.84168207580107102, 0.66338285325016588, 0.97293820815919407, 0.68541964431749014, 0.24226721271778395, 0.61112875302188896, 0.68359331551583635, 0.36454698734431334 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ExpertCoef1", "ExpertCoef10", "ExpertCoef2", "ExpertCoef3", "ExpertCoef4", "ExpertCoef5", "ExpertCoef6", "ExpertCoef7", "ExpertCoef8", "ExpertCoef9", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 6, 6, 10, 6, 6, 7, 5, 10, 6, 6, 0.39771131403476168, 0.24200317043570285, 0.45699206351646504, 0.78495438804534146, 0.36336936464951786, 0.10120902880651672, 0.56911073756379371, 0.61685075832450909, 0.19471410579039838, 0.68541824444439181 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ExpertCoef1", "ExpertCoef10", "ExpertCoef2", "ExpertCoef3", "ExpertCoef4", "ExpertCoef5", "ExpertCoef6", "ExpertCoef7", "ExpertCoef8", "ExpertCoef9", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 6, 6, 10, 6, 6, 7, 5, 10, 6, 6, 0.69446403042549154, 0.54646842155221209, 0.21052714339213074, 0.11474958558289172, 0.56589067137973459, 0.094395965469434184, 0.4831286342254596, 0.90288950731193185, 0.97792343848396324, 0.11739792306608188 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ExpertCoef1", "ExpertCoef10", "ExpertCoef2", "ExpertCoef3", "ExpertCoef4", "ExpertCoef5", "ExpertCoef6", "ExpertCoef7", "ExpertCoef8", "ExpertCoef9", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 6, 6, 10, 6, 6, 7, 5, 10, 6, 6, 0.60892000337265983, 0.077496384165947729, 0.37621468717840445, 0.97427371248000794, 0.83998855098802938, 0.98490239633518262, 0.28512880719664724, 0.095887113019015979, 0.69070924841240156, 0.51552545372351655 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ExpertCoef1", "ExpertCoef10", "ExpertCoef2", "ExpertCoef3", "ExpertCoef4", "ExpertCoef5", "ExpertCoef6", "ExpertCoef7", "ExpertCoef8", "ExpertCoef9", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 6, 6, 10, 6, 6, 7, 5, 10, 6, 6, 0.90566645303939852, 0.36073598762535253, 0.0065032860101075229, 0.10880985587690917, 0.8303695768155771, 0.19667404739162997, 0.60857146762483549, 0.88775572769016275, 0.62998165694560015, 0.86197764024505041 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ExpertCoef1", "ExpertCoef10", "ExpertCoef2", "ExpertCoef3", "ExpertCoef4", "ExpertCoef5", "ExpertCoef6", "ExpertCoef7", "ExpertCoef8", "ExpertCoef9", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 6, 6, 10, 6, 6, 7, 5, 10, 6, 6, 0.86402982973301801, 0.40275672843922117, 0.48572723629738535, 0.43388277782116713, 0.19239529593683735, 0.44973316057465262, 0.61702259738225484, 0.35950491589529177, 0.48410906440845114, 0.8326141913729338 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ExpertCoef1", "ExpertCoef10", "ExpertCoef2", "ExpertCoef3", "ExpertCoef4", "ExpertCoef5", "ExpertCoef6", "ExpertCoef7", "ExpertCoef8", "ExpertCoef9", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 9, 8, 8, 10, 8, 8, 7, 7, 10, 9, 0.30646092787715318, 0.54049172653248501, 0.56245291036607092, 0.34241674143107925, 0.65887075330335665, 0.66026096442887161, 0.98804502326480326, 0.47620955827615641, 0.35376919990749744, 0.59607182158967553 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ExpertCoef1", "ExpertCoef10", "ExpertCoef2", "ExpertCoef3", "ExpertCoef4", "ExpertCoef5", "ExpertCoef6", "ExpertCoef7", "ExpertCoef8", "ExpertCoef9", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 9, 8, 8, 10, 8, 8, 7, 7, 10, 9, 0.75378773920865272, 0.72041065997288778, 0.34305222408397795, 0.69162062032800231, 0.61863333239187357, 0.071329495757306627, 0.18274293399066988, 0.5721445498491996, 0.64901306873081743, 0.67783841971179304 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ExpertCoef1", "ExpertCoef10", "ExpertCoef2", "ExpertCoef3", "ExpertCoef4", "ExpertCoef5", "ExpertCoef6", "ExpertCoef7", "ExpertCoef8", "ExpertCoef9", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 9, 8, 8, 10, 8, 8, 7, 7, 10, 9, 0.75740830715466745, 0.63661630514387124, 0.68329151987517989, 0.51049976772610117, 0.18920409969324903, 0.58617605378231163, 0.81031683877884253, 0.37159670130038325, 0.62304049495647951, 0.17022904983953968 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ExpertCoef1", "ExpertCoef10", "ExpertCoef2", "ExpertCoef3", "ExpertCoef4", "ExpertCoef5", "ExpertCoef6", "ExpertCoef7", "ExpertCoef8", "ExpertCoef9", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 9, 8, 8, 10, 8, 8, 7, 7, 10, 9, 0.38862590759550719, 0.84421409336670983, 0.27874989235968839, 0.60649546869613558, 0.062170254325724428, 0.38581867556944527, 0.50015255385608537, 0.36084676884777867, 0.77841337374493835, 0.32438364585926305 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ExpertCoef1", "ExpertCoef10", "ExpertCoef2", "ExpertCoef3", "ExpertCoef4", "ExpertCoef5", "ExpertCoef6", "ExpertCoef7", "ExpertCoef8", "ExpertCoef9", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 9, 8, 8, 10, 8, 8, 7, 7, 10, 9, 0.11734313381250283, 0.61371491232310038, 0.88745187741011899, 0.12857025229029584, 0.28142441067042345, 0.081640395407447053, 0.75429624422874408, 0.6258211626682374, 0.0028636390764326114, 0.98077682212662565 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ExpertCoef1", "ExpertCoef10", "ExpertCoef2", "ExpertCoef3", "ExpertCoef4", "ExpertCoef5", "ExpertCoef6", "ExpertCoef7", "ExpertCoef8", "ExpertCoef9", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 9, 8, 8, 10, 8, 8, 7, 7, 10, 9, 0.78557533072604557, 0.72223130941911162, 0.88033413004884342, 0.10878786700484877, 0.81070617807849299, 0.63117266420598173, 0.79415869793467542, 0.11961972014834221, 0.13059635060439001, 0.17545776032000016 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ExpertCoef1", "ExpertCoef10", "ExpertCoef2", "ExpertCoef3", "ExpertCoef4", "ExpertCoef5", "ExpertCoef6", "ExpertCoef7", "ExpertCoef8", "ExpertCoef9", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 9, 8, 8, 10, 8, 8, 7, 7, 10, 9, 0.53267487467566699, 0.49669230140290843, 0.0094557654897774457, 0.21821322903163787, 0.9440911358027102, 0.43640902264958392, 0.12087658702749038, 0.23105357007826166, 0.24926871444079035, 0.041696962357496536 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ExpertCoef1", "ExpertCoef10", "ExpertCoef2", "ExpertCoef3", "ExpertCoef4", "ExpertCoef5", "ExpertCoef6", "ExpertCoef7", "ExpertCoef8", "ExpertCoef9", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 9, 8, 8, 10, 8, 8, 7, 7, 10, 9, 0.70964003951355537, 0.019015736537460803, 0.16699225924665873, 0.98821846816401604, 0.67710368685476208, 0.14947112328558987, 0.66009572122233762, 0.22119360865334292, 0.21001148212829068, 0.98749898042138295 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ExpertCoef1", "ExpertCoef10", "ExpertCoef2", "ExpertCoef3", "ExpertCoef4", "ExpertCoef5", "ExpertCoef6", "ExpertCoef7", "ExpertCoef8", "ExpertCoef9", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 9, 8, 8, 10, 8, 8, 7, 7, 10, 9, 0.87686583002574214, 0.45967414352819869, 0.31178869902967388, 0.34684699077270209, 0.18785731991904941, 0.81561727656672667, 0.13500541442313507, 0.28825800886050401, 0.10524853771779885, 0.67356008553830804 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ExpertCoef1", "ExpertCoef10", "ExpertCoef2", "ExpertCoef3", "ExpertCoef4", "ExpertCoef5", "ExpertCoef6", "ExpertCoef7", "ExpertCoef8", "ExpertCoef9", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 9, 8, 8, 10, 8, 8, 7, 7, 10, 9, 0.010168585600887847, 0.58598059583997153, 0.69243861657375616, 0.082348025881755271, 0.54001818814323943, 0.46213011041057905, 0.19829534830915518, 0.71842861325315233, 0.31468987464068521, 0.7803118939701541 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ExpertCoef1", "ExpertCoef10", "ExpertCoef2", "ExpertCoef3", "ExpertCoef4", "ExpertCoef5", "ExpertCoef6", "ExpertCoef7", "ExpertCoef8", "ExpertCoef9", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 9, 8, 8, 10, 8, 8, 7, 7, 10, 9, 0.52241754436382015, 0.12003579358394967, 0.34124257194456042, 0.74105216088112269, 0.38004593430124511, 0.31829965014056272, 0.34942995337446636, 0.22266182542327917, 0.7799140287251648, 0.53378800020925632 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ExpertCoef1", "ExpertCoef10", "ExpertCoef2", "ExpertCoef3", "ExpertCoef4", "ExpertCoef5", "ExpertCoef6", "ExpertCoef7", "ExpertCoef8", "ExpertCoef9", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 9, 8, 8, 10, 8, 8, 7, 7, 10, 9, 0.72172340685095682, 0.16080844873081035, 0.0024640467006342703, 0.94835846326740891, 0.089002632932777215, 0.2585878159989079, 0.26208859654035055, 0.74327696393732978, 0.94617291406509141, 0.6342115949038224 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ExpertCoef1", "ExpertCoef10", "ExpertCoef2", "ExpertCoef3", "ExpertCoef4", "ExpertCoef5", "ExpertCoef6", "ExpertCoef7", "ExpertCoef8", "ExpertCoef9", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 9, 8, 8, 10, 8, 8, 7, 7, 10, 9, 0.32965660627102467, 0.51924995346704728, 0.63199781105197461, 0.8679702007638691, 0.95621465425004626, 0.75141547185227509, 0.71112294438430246, 0.2940143166341378, 0.70484391772123023, 0.32406592015300195 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ExpertCoef1", "ExpertCoef10", "ExpertCoef2", "ExpertCoef3", "ExpertCoef4", "ExpertCoef5", "ExpertCoef6", "ExpertCoef7", "ExpertCoef8", "ExpertCoef9", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9" },
                values: new object[] { 9, 8, 8, 10, 8, 8, 7, 7, 10, 9, 0.69796553973757847, 0.45476728502325192, 0.3393714045795434, 0.17896663987789019, 0.44465757190608635, 0.64212260993420323, 0.98536409220178156, 0.77411836447198845, 0.22467700114225309, 0.14380494264368637 });
        }
    }
}
