using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppRisks.Migrations
{
    /// <inheritdoc />
    public partial class AddWeighedMarksAverage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Total",
                table: "RiskExpertMarksEnumerable",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ExpertMarkWeighedAverage1",
                table: "RiskExpertMarksCategories",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ExpertMarkWeighedAverage10",
                table: "RiskExpertMarksCategories",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ExpertMarkWeighedAverage2",
                table: "RiskExpertMarksCategories",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ExpertMarkWeighedAverage3",
                table: "RiskExpertMarksCategories",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ExpertMarkWeighedAverage4",
                table: "RiskExpertMarksCategories",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ExpertMarkWeighedAverage5",
                table: "RiskExpertMarksCategories",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ExpertMarkWeighedAverage6",
                table: "RiskExpertMarksCategories",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ExpertMarkWeighedAverage7",
                table: "RiskExpertMarksCategories",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ExpertMarkWeighedAverage8",
                table: "RiskExpertMarksCategories",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ExpertMarkWeighedAverage9",
                table: "RiskExpertMarksCategories",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ExpertMarkWeighedAverage1", "ExpertMarkWeighedAverage10", "ExpertMarkWeighedAverage2", "ExpertMarkWeighedAverage3", "ExpertMarkWeighedAverage4", "ExpertMarkWeighedAverage5", "ExpertMarkWeighedAverage6", "ExpertMarkWeighedAverage7", "ExpertMarkWeighedAverage8", "ExpertMarkWeighedAverage9" },
                values: new object[] { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExpertMarkWeighedAverage1", "ExpertMarkWeighedAverage10", "ExpertMarkWeighedAverage2", "ExpertMarkWeighedAverage3", "ExpertMarkWeighedAverage4", "ExpertMarkWeighedAverage5", "ExpertMarkWeighedAverage6", "ExpertMarkWeighedAverage7", "ExpertMarkWeighedAverage8", "ExpertMarkWeighedAverage9" },
                values: new object[] { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ExpertMarkWeighedAverage1", "ExpertMarkWeighedAverage10", "ExpertMarkWeighedAverage2", "ExpertMarkWeighedAverage3", "ExpertMarkWeighedAverage4", "ExpertMarkWeighedAverage5", "ExpertMarkWeighedAverage6", "ExpertMarkWeighedAverage7", "ExpertMarkWeighedAverage8", "ExpertMarkWeighedAverage9" },
                values: new object[] { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksCategories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ExpertMarkWeighedAverage1", "ExpertMarkWeighedAverage10", "ExpertMarkWeighedAverage2", "ExpertMarkWeighedAverage3", "ExpertMarkWeighedAverage4", "ExpertMarkWeighedAverage5", "ExpertMarkWeighedAverage6", "ExpertMarkWeighedAverage7", "ExpertMarkWeighedAverage8", "ExpertMarkWeighedAverage9" },
                values: new object[] { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Total" },
                values: new object[] { 0.050213926790997121, 0.57833744693321154, 0.79379503066817247, 0.12825133520952869, 0.59386575671621777, 0.24733112148038416, 0.097741830210055669, 0.93878099560557171, 0.56942277290697196, 0.98434465657711812, 36.725582199736237, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Total" },
                values: new object[] { 0.49321232167228113, 0.44599479635570149, 0.076304980174168757, 0.71822544437319036, 0.20124776008152012, 0.53227886772226063, 0.43607271528941038, 0.86319812313034772, 0.60370814001581286, 0.83327445066046046, 36.087539775431843, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Total" },
                values: new object[] { 0.91862838945690206, 0.23010805496220776, 0.87822056722858255, 0.048742434056848638, 0.76832443603432221, 0.57041235006440039, 0.090579503114042725, 0.62812141509771435, 0.48029633336788391, 0.1663591405335797, 28.643086280145724, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Total" },
                values: new object[] { 0.48181899733308409, 0.27804299720586523, 0.76548864983579901, 0.33342408406304624, 0.4824302405944686, 0.18027198880040529, 0.25929400829720406, 0.87129672229201838, 0.55903570761394772, 0.043236706473011921, 11.995047172416129, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Total" },
                values: new object[] { 0.27565653819720337, 0.16283069504391956, 0.82079545076727589, 0.94471312819185949, 0.53172176287761796, 0.66386335534107388, 0.30794589717384901, 0.47794631313550084, 0.81900762911456904, 0.73105154121666494, 14.146554692583335, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Total" },
                values: new object[] { 0.98180715354703574, 0.36777158821026557, 0.45159014663766295, 0.60943001692799448, 0.89641100504856575, 0.013818566316252112, 0.80664367740885645, 0.41297469943563725, 0.79296751678041966, 0.99202475141411028, 7.8620892895004175, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Total" },
                values: new object[] { 0.2520982651464948, 0.28367276717227574, 0.063832740482093753, 0.10257551114444607, 0.26308881080266155, 0.34104409175312445, 0.40283177411188298, 0.35369863548190561, 0.46802388896824665, 0.37384717736444517, 59.100033700195397, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Total" },
                values: new object[] { 0.84428630984849917, 0.56406048492787597, 0.61379251783214805, 0.14089221745590153, 0.99694127875769434, 0.24766701893528742, 0.10363171836941054, 0.95822756367060269, 0.43337009129950743, 0.179170579110283, 66.991159301294729, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Total" },
                values: new object[] { 0.033021415968581991, 0.41763061548529723, 0.94497700364903148, 0.064003240512900628, 0.88664867188057206, 0.89242736556230196, 0.92737229609336236, 0.56231801519534075, 0.63695206648512137, 0.57561473971058619, 92.999603748874165, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Total" },
                values: new object[] { 0.56092555551967493, 0.40714017753806553, 0.82926157602288986, 0.49868128950147983, 0.97937491807310328, 0.32272016462681696, 0.45488730991717263, 0.20494604130431948, 0.32275961320190416, 0.86579207693975391, 81.373039816620405, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Total" },
                values: new object[] { 0.52881229062902024, 0.41973337665969235, 0.56146398473048542, 0.35235879076115362, 0.13125712086875074, 0.66662004148139509, 0.01689200977931038, 0.86158369974201532, 0.24730936214218013, 0.39973512435562519, 72.853384485523591, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Total" },
                values: new object[] { 0.62039871382400791, 0.20813955244707116, 0.46517090205625422, 0.0015682121115752068, 0.31389790934697204, 0.3316223703216945, 0.24210636754616, 0.36061362329475477, 0.44458871466392713, 0.89140156177769669, 67.224072921045149, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Total" },
                values: new object[] { 0.25663090464054428, 0.00086611551249715646, 0.82469797540146295, 0.16090569120835274, 0.13323346143166581, 0.47842571669423495, 0.84484217112877824, 0.64433002985896959, 0.19357119681898272, 0.018463464815208441, 91.238033446697642, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Total" },
                values: new object[] { 0.92990323648676088, 0.5298822205317778, 0.38105374052870999, 0.4755168514953414, 0.71258504652843102, 0.52140948633176709, 0.72499277216355495, 0.26890329958208359, 0.59548324151403986, 0.53537578209553838, 11.230744427127636, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Total" },
                values: new object[] { 0.13548403457354685, 0.061897284118960005, 0.10528296513623625, 0.64111303633624173, 0.86227048026590603, 0.9196716914131754, 0.29835564207017495, 0.93339003596302084, 0.65383861741652971, 0.21059436242724827, 41.16096100019594, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Total" },
                values: new object[] { 0.36279419672350222, 0.72922675304756024, 0.78269208692786318, 0.20332841523495471, 0.041042234803744582, 0.060587861930606723, 0.12078972947195843, 0.92400206806052532, 0.77953196945551095, 0.13896559392115704, 25.256833829899016, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Total" },
                values: new object[] { 0.95765056785455183, 0.45669563830612026, 0.59280181650999908, 0.32607419267857429, 0.18754720385318202, 0.884619035274535, 0.93949641216193236, 0.45828163795976873, 0.48360664893487315, 0.51875962739195314, 73.107234905496412, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Total" },
                values: new object[] { 0.95473274111474793, 0.99432997415599578, 0.88246089246231718, 0.96421724607583292, 0.72182100210144373, 0.13334121294182055, 0.67127184355696756, 0.94646952690185338, 0.78841910818144079, 0.58567053484920784, 45.550974183117688, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Total" },
                values: new object[] { 0.064567868616540514, 0.49288125312637443, 0.91096335737158296, 0.38547219295495749, 0.31385716170432154, 0.35534535849380755, 0.59893833875418601, 0.58141424027776634, 0.2558364816950961, 0.49750570462172394, 9.4684098601222182, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Total" },
                values: new object[] { 0.82967882877159727, 0.2991910749442398, 0.87449629224060721, 0.4072967784819731, 0.93458933743275374, 0.34129755666192274, 0.95215321324850177, 0.85384814157536959, 0.88172706321797778, 0.89789523504157132, 30.014625291907425, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Total" },
                values: new object[] { 0.15851302545551238, 0.22434163494310699, 0.38518836386933475, 0.73772200289425494, 0.18680714193922021, 0.62275203354146447, 0.25153910227114906, 0.75223304493127574, 0.93874828298752011, 0.95124434965591398, 49.157248839437692, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Total" },
                values: new object[] { 0.23238603832602411, 0.74863283765127953, 0.98459652580686186, 0.58339887225975662, 0.030055802181119695, 0.56510150983271423, 0.43708991390631713, 0.7387500935203517, 0.43607465844047311, 0.84138582889449609, 56.946281065732165, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Total" },
                values: new object[] { 0.17702184490969353, 0.58058458142896363, 0.83813160442068868, 0.74509934076221507, 0.99488351583600054, 0.43610735126540323, 0.65060582299887115, 0.69728227648231067, 0.23164148154264608, 0.86310153631179787, 40.311538926678622, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Total" },
                values: new object[] { 0.60343116713358624, 0.43853745043476977, 0.15981042534188716, 0.46490674062386306, 0.94980036432469817, 0.62673590519219224, 0.9091684115668095, 0.95062936390682851, 0.14273514933398801, 0.74286726741109377, 5.049630883276679, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Total" },
                values: new object[] { 0.81606477883633699, 0.86772118510062146, 0.99812833174875382, 0.29109526794766705, 0.19407934281524153, 0.017584666970292595, 0.86731607152355383, 0.52640791703151057, 0.17040463193629851, 0.016208013774837493, 94.446091066615296, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Total" },
                values: new object[] { 0.64755723928405073, 0.53983598518846276, 0.98891206412739296, 0.86286997557962375, 0.18446980640545507, 0.77974269736198609, 0.65229168744754484, 0.57255183264300558, 0.68471461427813241, 0.77013166842475889, 2.8630832819511842, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Total" },
                values: new object[] { 0.90855384028010044, 0.083528775813640266, 0.9548895316562489, 0.98695128042461067, 0.060298660237211754, 0.9169050301095536, 0.99943631268298594, 0.50782513882018621, 0.64690952063185725, 0.41491700164525047, 30.454411006361724, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Total" },
                values: new object[] { 0.57401823245947059, 0.23915287905902372, 0.6099091959640035, 0.47129869341142161, 0.53278821133197352, 0.91995234907551782, 0.32609417952523567, 0.18420829566934149, 0.80803398894207268, 0.55299580218251654, 80.943385150347751, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Total" },
                values: new object[] { 0.34424057198580449, 0.33435254561738248, 0.47059176013916915, 0.72655562381719963, 0.42052621595864226, 0.27572992881981218, 0.82462828925612186, 0.45381895037295938, 0.95738461799904517, 0.83569576978155857, 95.468270913406002, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Total" },
                values: new object[] { 0.006461009027923903, 0.45853614134388354, 0.79191102294599935, 0.83481567047213823, 0.061627342905807625, 0.30195332983679002, 0.84713432196577998, 0.44783577735981872, 0.3374003074498344, 0.71345661680673156, 56.978027357537229, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Total" },
                values: new object[] { 0.057842843845917424, 0.85652103217127484, 0.91660026886733759, 0.4982071808069658, 0.79551195414396136, 0.24322712453269046, 0.68337106626792754, 0.8646299071776371, 0.61501697453742554, 0.93670978032855101, 56.782972495373777, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Total" },
                values: new object[] { 0.30752266102118708, 0.26941385180516364, 0.82126913241752331, 0.14658408489648844, 0.15818453174853253, 0.79876129941975516, 0.47653100015437855, 0.12732365807143831, 0.60856916822249951, 0.22307269827740261, 98.515930223765466, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Total" },
                values: new object[] { 0.13590187846337232, 0.99570789727229891, 0.58446547943733085, 0.91505397479615957, 0.026759222741441935, 0.28629261545785012, 0.033242715790457344, 0.080815354424745744, 0.43990370938657275, 0.78108910913887186, 22.597117246247191, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Total" },
                values: new object[] { 0.0063048861879906326, 0.73088945543847306, 0.14538238196628295, 0.26438532411619287, 0.67011045017756088, 0.70894131780373182, 0.32173783440524095, 0.11891131860392123, 0.40837389900298637, 0.32790584578501825, 25.572044541125049, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Total" },
                values: new object[] { 0.7180598624061364, 0.81345374523230374, 0.94218480249784653, 0.59831988720120899, 0.139932584950474, 0.52170686759494445, 0.041729788178662908, 0.41432937517279267, 0.255450133514598, 0.91018992605504179, 85.768567855095412, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Total" },
                values: new object[] { 0.042959267357738917, 0.7165735168298023, 0.37970532979688765, 0.4467623245612401, 0.22663132567877942, 0.70826345968671345, 0.80067093273783074, 0.38043864495393342, 0.162187756313802, 0.87907279845192166, 9.2897781114194657, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Total" },
                values: new object[] { 0.20980170194133796, 0.27976292895417132, 0.04462922889376586, 0.76315546701342463, 0.43683877689150541, 0.8326239447144772, 0.9123867613128297, 0.57856428637953616, 0.87163706708361921, 0.83315181856464404, 33.287085632528388, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Total" },
                values: new object[] { 0.14353461877408125, 0.54680620611281416, 0.66560736757316974, 0.60517998449044752, 0.75359871153850067, 0.15703089223540423, 0.6587740560106492, 0.50309336461067555, 0.46305372340863871, 0.71743320755724249, 11.722671373211902, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Total" },
                values: new object[] { 0.6285821298005273, 0.84937428577262963, 0.27442211002026773, 0.15251495082171995, 0.54146306416516854, 0.7112439481746351, 0.66046525016187041, 0.46413933771833693, 0.74037121568812247, 0.13438790067834316, 20.872464846366622, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Total" },
                values: new object[] { 0.74245967447732264, 0.85163627573276723, 0.57893098086571793, 0.098390537636694142, 0.26973943708989134, 0.45715307917295689, 0.29393404028570835, 0.29809278581758769, 0.79213571042219011, 0.66137838271274041, 2.6146189435152012, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Total" },
                values: new object[] { 0.58216829076341292, 0.35358400536715662, 0.94118497771488485, 0.7621508619863997, 0.5960567818701239, 0.59032255554543722, 0.35717095198562243, 0.86349351684247799, 0.50450156696940684, 0.45626625562211121, 26.038113168554833, 0.0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Total",
                table: "RiskExpertMarksEnumerable");

            migrationBuilder.DropColumn(
                name: "ExpertMarkWeighedAverage1",
                table: "RiskExpertMarksCategories");

            migrationBuilder.DropColumn(
                name: "ExpertMarkWeighedAverage10",
                table: "RiskExpertMarksCategories");

            migrationBuilder.DropColumn(
                name: "ExpertMarkWeighedAverage2",
                table: "RiskExpertMarksCategories");

            migrationBuilder.DropColumn(
                name: "ExpertMarkWeighedAverage3",
                table: "RiskExpertMarksCategories");

            migrationBuilder.DropColumn(
                name: "ExpertMarkWeighedAverage4",
                table: "RiskExpertMarksCategories");

            migrationBuilder.DropColumn(
                name: "ExpertMarkWeighedAverage5",
                table: "RiskExpertMarksCategories");

            migrationBuilder.DropColumn(
                name: "ExpertMarkWeighedAverage6",
                table: "RiskExpertMarksCategories");

            migrationBuilder.DropColumn(
                name: "ExpertMarkWeighedAverage7",
                table: "RiskExpertMarksCategories");

            migrationBuilder.DropColumn(
                name: "ExpertMarkWeighedAverage8",
                table: "RiskExpertMarksCategories");

            migrationBuilder.DropColumn(
                name: "ExpertMarkWeighedAverage9",
                table: "RiskExpertMarksCategories");

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.20816622117902428, 0.35516473663183024, 0.30328908608885996, 0.56035707846547589, 0.0560562210761264, 0.2735827353273268, 0.80477298364731553, 0.38840084875784764, 0.071484387542028238, 0.13118118174626403, 97.138045363590152 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.12008921702958875, 0.28991668768648959, 0.37907227305039648, 0.84636481626524862, 0.37458556309617341, 0.66983539186198571, 0.55421488560044907, 0.57087055207180171, 0.28452169930659021, 0.40722238143457812, 49.478628000473954 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.91929396122749352, 0.44335143577818181, 0.65684457212504543, 0.41687041550592352, 0.99183718225651862, 0.4180235266357869, 0.71712187204774824, 0.44101767083508137, 0.92947061248585305, 0.53202050785785215, 35.323015053612373 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.94977899462269855, 0.47986607875745024, 0.78430599833567827, 0.8016144259219079, 0.59738048504395491, 0.58087613301877605, 0.19451086937976125, 0.42395184206663061, 0.89416712768990803, 0.87742414122781764, 14.70527241996048 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.27943016298321999, 0.79561497788014512, 0.33450675504778038, 0.74347677411467405, 0.76661272832407179, 0.41865569168577288, 0.35521169647644024, 0.75996865279244852, 0.79346801254720511, 0.76177280469643349, 26.940237640749586 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.86719659099909907, 0.5811442432676257, 0.26053265956529192, 0.012021855097339551, 0.12906131668005361, 0.86835461630390298, 0.047011779609083759, 0.98739783152132787, 0.5111416001468766, 0.1523069003433436, 21.736514584074364 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.46803197653462625, 0.83618455479948273, 0.88428183205904998, 0.32763233128925606, 0.51077474100359266, 0.76648311050426765, 0.40039261487115019, 0.92289867692693461, 0.54972261146907353, 0.18793141697693216, 66.241687632508231 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.73465467700055465, 0.33064013076963172, 0.83857698953745863, 0.37807004821143342, 0.30979614247234355, 0.96552364200060348, 0.94463997183365322, 0.97524247480440562, 0.74300972895103612, 0.2984774304969452, 67.184686480147093 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.66780558916715027, 0.79550042683030642, 0.81748127250573854, 0.16777464038371814, 0.39806744827943474, 0.5608670514216656, 0.75484950438776388, 0.69896338223275267, 0.87515247912174443, 0.70151456882292651, 81.568024732506387 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.18585640740222575, 0.51282255047404945, 0.81906899115694065, 0.79558823450275296, 0.57605455619220536, 0.87546565176980085, 0.92822850923513656, 0.74826060792612215, 0.37154890260199014, 0.22443585809207989, 58.59333646428211 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.41212488338422315, 0.13907543979595349, 0.85044764578226784, 0.56119111404691313, 0.7965647071778087, 0.59621089014045714, 0.85417400758032525, 0.81168264723926808, 0.58648933463032193, 0.91921738610274184, 57.67580119225719 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.10721566662203252, 0.19046468145721418, 0.52147097185875735, 0.51996022069273462, 0.19192015748063918, 0.10042616874810895, 0.36631851867637366, 0.71993293511740375, 0.15077651402821801, 0.53007061766561037, 17.949470100827657 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.095609490907959782, 0.78752538200534272, 0.19461092817008641, 0.42966642998045734, 0.3996803118168204, 0.062456754414335069, 0.40978686997267677, 0.74136887898377068, 0.24354737935859061, 0.12824360263732137, 76.981909251570286 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.10511529645173046, 0.46122461358344591, 0.93564870095090513, 0.61539561033576506, 0.83302881042196353, 0.83818954523977729, 0.83279053073697118, 0.17765927932761905, 0.92968735416517423, 0.72857654111683157, 68.686991843674477 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.36800162568661465, 0.073483578273869532, 0.10773018337087004, 0.43106120169880568, 0.61563637098670076, 0.0207829403044969, 0.44933235011599304, 0.3869335058199983, 0.24313084092790638, 0.066094782014071041, 8.9486218424054247 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.86180214397000243, 0.73171402645856065, 0.56228234979269509, 0.39327050303534195, 0.088409088150666393, 0.6686673837150876, 0.077237316710673576, 0.5041771205124036, 0.36810931020910975, 0.27479643569671319, 38.069523840025219 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.77090008463907822, 0.82292724928057426, 0.097414405151026506, 0.72274498999014769, 0.25367675882686092, 0.91601661056573003, 0.61201576558687698, 0.91311607443335563, 0.54520180163613086, 0.092193309383000854, 29.126535195648263 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.70839220943032732, 0.85905245639957561, 0.83412714819811407, 0.054942631852356594, 0.0026391986650448063, 0.6401334309541229, 0.33136680729454537, 0.6169328008695889, 0.092331684308710638, 0.40312489695341891, 85.549920622862516 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.58328019228379546, 0.76444339190487043, 0.037701265256956495, 0.0050223752320338599, 0.10353347304329086, 0.36922494082308865, 0.89786536712129839, 0.047610790328670882, 0.75487979711415976, 0.40174045198462538, 67.539398748540904 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.75448935632046277, 0.03781765532435688, 0.42712546686861386, 0.032650452125110196, 0.32093136039761305, 0.8944196131869836, 0.35830531526379428, 0.71637783365970453, 0.80612227797493397, 0.3939002418031744, 92.401133040062788 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.9176266237645041, 0.70259170628687762, 0.31465367953048862, 0.77304368412127411, 0.80333185871442436, 0.60631562029083019, 0.46878314375896357, 0.82557342269680611, 0.21946568944220179, 0.87974988645284879, 11.722548046339776 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.036085376529065738, 0.99419795521584686, 0.13865700230264322, 0.013743057452528573, 0.90409083117227285, 0.68905265948733585, 0.56833545190245627, 0.099394685317817366, 0.13606169775087984, 0.63208251262060688, 25.126673397661236 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.29973097076084754, 0.036963830092384686, 0.662868522103088, 0.11466607938175577, 0.41703330577321063, 0.21799133956265582, 0.8326833193818749, 0.31340684795442875, 0.56785656940373874, 0.016024478704788292, 3.283168111252599 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.77584954160375896, 0.6071663490688749, 0.15788525522651631, 0.29014723804738074, 0.26830653351568146, 0.99878517641457476, 0.62207022159373038, 0.41057222526873072, 0.62186356598123349, 0.59189749229193866, 86.817405588967588 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.23679902705406464, 0.20110542117591579, 0.098325524902349914, 0.56589005654317481, 0.39642270551510872, 0.99777271936090173, 0.22723706433810886, 0.92939116080372541, 0.60593310638595654, 0.45548635201452159, 67.310028893497503 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.33129453363881567, 0.11446308962602514, 0.57221553296676497, 0.90794163586131582, 0.93810800842476427, 0.75757888308724897, 0.42716438586409522, 0.24076549378922141, 0.13570759211014305, 0.80933037617608672, 26.646731520487489 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.27655181904030013, 0.10008863124983669, 0.76420720228354855, 0.054674503363103755, 0.82318313854651759, 0.56111258646215278, 0.50396240102224399, 0.40244275812490837, 0.41207815584013407, 0.058893567421667514, 52.503996569798652 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.37616933517382589, 0.27154418729458418, 0.89240283393674591, 0.14858348815522959, 0.61220222469155783, 0.84499832209405457, 0.7765225537421514, 0.46438780339075136, 0.89138418553674081, 0.49569378928423768, 65.736935336921533 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.73340335663053846, 0.81254648588286293, 0.488437365917605, 0.79475290532028442, 0.75223102205445602, 0.87853925065497585, 0.49164203886732627, 0.17656110904483258, 0.63387165969655168, 0.34028942928763894, 11.19949879621217 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.2496982149714595, 0.97506312327192124, 0.87469343727226445, 0.9527166661358295, 0.69556388123508806, 0.0078202685209518563, 0.8051210507885872, 0.80524932586395137, 0.052998573628422196, 0.47151784093979132, 2.119514042125592 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.39818599163897672, 0.28044157038632589, 0.75615957842631765, 0.71534491354550789, 0.11678172205968052, 0.93636623176721145, 0.85487367343413234, 0.77199393080422862, 0.7736259045363495, 0.50922835181396708, 21.695347476541627 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.35961889553285908, 0.84002245232885231, 0.028198047439840113, 0.03685969501227826, 0.77149270817341919, 0.83129691928836758, 0.66972089535284296, 0.25514564045624233, 0.06811760376473619, 0.15296521504342231, 93.663127757448024 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.78748810317151519, 0.049526821130141507, 0.43696002014550528, 0.30534180402850375, 0.78956186921103322, 0.94738300106422091, 0.97486117377098014, 0.59138272501225031, 0.40424875497744772, 0.36696595797063958, 79.545139219481982 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.70570041059493016, 0.788151411545993, 0.82095112750088195, 0.17773426199733833, 0.96125755848661965, 0.95256059120352943, 0.96813445425480049, 0.94193165990637528, 0.050267666753448514, 0.48227521933717055, 92.64336902234443 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.21024604762449117, 0.86865124920570402, 0.68470104301972823, 0.73373571832144413, 0.50036693333333526, 0.48741133090397137, 0.16819813020521412, 0.013520782000434162, 0.62705434032915564, 0.45343562444066521, 57.39443266832415 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.15975150535857385, 0.86188344547504925, 0.53208245971554902, 0.59934988522442512, 0.04907792294120783, 0.49153268981148268, 0.42381775876714722, 0.08806263044641871, 0.5690047288785044, 0.76859864096233055, 19.833348326691425 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.77115906240524268, 0.0071164274967436825, 0.75375682848430903, 0.86750142091053872, 0.86003853304836253, 0.70185469891921648, 0.86958165148365629, 0.13847046690857223, 0.25372971537280709, 0.83394286937471884, 49.842126802770892 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.92937379007336951, 0.85970606823594686, 0.90734176110319742, 0.77092961988930708, 0.74067951069971349, 0.098220461252380376, 0.10564778255612306, 0.32000759495340447, 0.68262164051056695, 0.13146333287982737, 42.380126151563978 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.53880001320071003, 0.16907401372974751, 0.50479206223921758, 0.74577890085721643, 0.27008007695906744, 0.06807293842382478, 0.37011436236336426, 0.28108260032751942, 0.17159960792029916, 0.59396014227990701, 48.034598961205852 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.53680188970925713, 0.17598002320210748, 0.44637905408566758, 0.4000976751700156, 0.36361796660921597, 0.82964112964689696, 0.16479014983719753, 0.35078416377919552, 0.47636441288461551, 0.38749605384565711, 66.265863583170201 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.2396165078608935, 0.83726389721565941, 0.18261767458653377, 0.42694944812373448, 0.12490619539353687, 0.90927931394455908, 0.056108272301555129, 0.1379987819391898, 0.75957120817726131, 0.92703317879473313, 63.29487442860956 });
        }
    }
}
