using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppRisks.Migrations
{
    /// <inheritdoc />
    public partial class AddSummaryToRiskExpertMarkCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Summary",
                table: "RiskExpertMarksCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Summary",
                value: 0);

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Summary",
                value: 0);

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Summary",
                value: 0);

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Summary",
                value: 0);

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.58498322927366675, 0.17098971629967596, 0.3966129548492997, 0.49190184873368303, 0.79404969134118686, 0.33723320942018109, 0.53337138730832334, 0.0089359019509619442, 0.13140224738473316, 0.67113654549977331, 43.563762961287352 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.82842223145432359, 0.82179840865941989, 0.42648748437279904, 0.72305523854481624, 0.49755796879659531, 0.21864917611156087, 0.49428470781138734, 0.49567723400644781, 0.6851494989840069, 0.49004512005025869, 37.836752496622786 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.44765378831718616, 0.44890569114759526, 0.61999448697031256, 0.048040480073383129, 0.59540377980361492, 0.9588796227770473, 0.7576585075865595, 0.92219156592111062, 0.31678804744826705, 0.19800028608824316, 75.059635709234684 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.68669959355047128, 0.90677889072543783, 0.85488665652158224, 0.024867115028991971, 0.39688647316834669, 0.47021344981649871, 0.65437293273133157, 0.71464849590641488, 0.11813811564997245, 0.48876562588273798, 18.766273337095406 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.89143595272745435, 0.63251093571243944, 0.40501573320733231, 0.89318289104003767, 0.60291480089612548, 0.10379798316023836, 0.56160778766417252, 0.30674898256930849, 0.59909669612553451, 0.83394277740506606, 3.9773320475636087 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.52756219483614808, 0.98977011199211284, 0.41246421913792175, 0.68783171511367536, 0.18582837095341953, 0.65942768732670287, 0.099069565764842271, 0.60398223926223527, 0.089050458252833975, 0.73461244276986526, 51.96433090648145 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.11307285059554639, 0.12421975298724819, 0.39536144111932114, 0.82449654018719232, 0.90264398218702624, 0.55574678591657045, 0.10816055133512625, 0.49821303244006609, 0.62675285669475378, 0.53763637773617345, 92.447467887803725 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.83678068644193171, 0.073949932885167824, 0.012879797583455588, 0.82742827810530795, 0.83842885231875308, 0.56649525010721713, 0.93217997899356553, 0.073057345382414707, 0.66731118020974156, 0.26788911673393934, 94.142631548649121 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.016454005376101533, 0.47429152019354115, 0.21247140062407832, 0.63955073207123425, 0.34817486457226476, 0.47127779626428346, 0.31264201120965684, 0.049871633378498648, 0.15161376401199289, 0.71447026452110962, 79.467952810736634 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.76709087480302629, 0.059463293741008005, 0.78055544516520237, 0.88261371791323351, 0.85925828962833006, 0.11829932438734114, 0.17366865007126286, 0.66223255603470776, 0.70033164500138734, 0.49872233614278705, 40.389492726537647 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.47490776457176809, 0.41139384145957281, 0.39570513420499809, 0.6488950453824488, 0.014353711048873175, 0.84238924018274597, 0.98962492021992654, 0.20527473812545471, 0.59140132938121404, 0.15639070671281441, 17.531949240436862 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.71369316386375714, 0.84514815768427143, 0.88028407366333006, 0.82453962187257779, 0.0021238161757096696, 0.23066433552897636, 0.81525303943775351, 0.19537597612870161, 0.67992606021947499, 0.52876138516095972, 52.109064836264317 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.75540889183979454, 0.82004791727829052, 0.037781098587834849, 0.31024901554665985, 0.47026538446885269, 0.13585702431789137, 0.60865312220768919, 0.68935352740874078, 0.80355716933801291, 0.18395767965992293, 15.714975876673808 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.0064565339356668083, 0.7172359735667212, 0.48715188368294116, 0.75875970589524144, 0.31589921544120503, 0.8562024499810601, 0.61379279592500513, 0.54510570724265861, 0.48467749994748155, 0.25753132756598307, 72.366751878107138 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.94271313081603769, 0.08530757595346683, 0.040212444093698063, 0.93122756547237795, 0.24853112495072982, 0.86000997673009849, 0.39662409541756827, 0.5724203944118581, 0.47105279503323405, 0.31500287924631609, 3.9477855952404717 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.84054621413826269, 0.021270623687387857, 0.75098828706092235, 0.61548084680829618, 0.12919064973086536, 0.64210558669173867, 0.33772177065228737, 0.98242314624506821, 0.43793972349417609, 0.097230578218767127, 74.307924614916345 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.16569620193564438, 0.5093456470266301, 0.69256422813422258, 0.72079462873059952, 0.4222583626958718, 0.42368258951931603, 0.56351184805317256, 0.25542340859171908, 0.23578857339659764, 0.41589731372585892, 86.685831933345298 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.34161701862248095, 0.083778267858793387, 0.90690845048289381, 0.41954068665830047, 0.5109120154278981, 0.16728407083689278, 0.39256741585590826, 0.64816274732334189, 0.0026239713842303169, 0.066694147017657524, 42.699638956832821 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.85946724463578938, 0.48432316577370726, 0.59130659350081738, 0.72412851313501747, 0.039018791256653085, 0.88405251005684493, 0.78083037158676227, 0.29890259006689013, 0.26167486713951915, 0.34527454908294564, 84.121423479486197 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.46585688594558483, 0.96163344629583081, 0.77977969525255131, 0.99849334264251721, 0.46777673453571122, 0.892042132964741, 0.55088694209638955, 0.87397909407582342, 0.57134093868182911, 0.15170863573464977, 35.98745152126196 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.68533247505227934, 0.54511492182322652, 0.96458676208955063, 0.89480549889052785, 0.54472851016705937, 0.83970540943515148, 0.3813498446850625, 0.047267178540681964, 0.89522218465023828, 0.76061290693171391, 42.027049771132454 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.94757818721932907, 0.19446949840457772, 0.35724942796016501, 0.56503093389716685, 0.14516600624068354, 0.092368466462482202, 0.30560915582297465, 0.97102418565986959, 0.67081717012310327, 0.29007105510046105, 98.445329523509542 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.31693999303430831, 0.36307520341971444, 0.11638120198129842, 0.028009435645721892, 0.18865172045273493, 0.73159617346916261, 0.025066625138326137, 0.55656271448518835, 0.95311646222953716, 0.25731532979114702, 12.042233917818645 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.50829103473649173, 0.076579843841483419, 0.12621302161886805, 0.080392350575520632, 0.56161829027398524, 0.18836281325591042, 0.84697158908979286, 0.21994209625982664, 0.94294766781294848, 0.4547640205017468, 92.627196704020733 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.2162176339701084, 0.063418110672874506, 0.41963973115136066, 0.86761096218362921, 0.15568291601455375, 0.55399767894209517, 0.68559047649856797, 0.86229997656529422, 0.9196358814102974, 0.16150380675166298, 35.971458135956482 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.64684446788814776, 0.058462685415228921, 0.95777324886257875, 0.66237791066391871, 0.87209512275979251, 0.93022067006647402, 0.8898737326685533, 0.78893621854394502, 0.64234641526496661, 0.71064387934318152, 94.503441608644792 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.12482479306686978, 0.2235641846486579, 0.98191278980497632, 0.12543320546584924, 0.6900970590078308, 0.36718105068540152, 0.62131868315529692, 0.2388760809466367, 0.62384391312213616, 0.52415489208008403, 37.336069061699796 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.022827068636111836, 0.91981812875587954, 0.54893065554884468, 0.48524891950406401, 0.32482787213582531, 0.19671540446056757, 0.42536374864738224, 0.025549961164177182, 0.52491762595466696, 0.7095287580476678, 66.412317343830722 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.42535250354555487, 0.76737694139793411, 0.85184403364875005, 0.60744293350458267, 0.81305938578576287, 0.83953687980427338, 0.54985111628977545, 0.38297593954317233, 0.80903210253278035, 0.076745800742850978, 91.853221050425034 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.6765450584631052, 0.45488490073448218, 0.95755230503363087, 0.23911251992343019, 0.73626637795390792, 0.013140477211030621, 0.37622013988771597, 0.046672351236185072, 0.28439793862190998, 0.64202846719693907, 18.168226000707111 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.11121815375320776, 0.20004919802660714, 0.88574899350221481, 0.080242042284279558, 0.25786314509103259, 0.70109664841954888, 0.60240360406880533, 0.79302145712705741, 0.73039631113601855, 0.82513960590390389, 74.063690379604864 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.046355806893729201, 0.42487120353804542, 0.96967153640999848, 0.78335021490575352, 0.18881188601276122, 0.48485996860094582, 0.1331033162651224, 0.3920043108159792, 0.78085636978595263, 0.48017797996190803, 9.6071439520647459 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.30817646754836991, 0.80332241631792889, 0.52522649945405653, 0.92176083082378624, 0.071890078140339986, 0.67397809100858974, 0.98189605370439281, 0.49022215485493392, 0.58737560880087791, 0.53488322175099878, 28.916150692343258 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.56125611661431851, 0.96018482174737663, 0.75997535632860092, 0.44770781645162061, 0.070161136798144619, 0.42291238195423619, 0.71861353670796158, 0.42948660150776297, 0.8054472368593083, 0.78670983822926166, 48.817559881759351 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.4251312330163155, 0.1447194763669567, 0.65369353940196184, 0.18360621521351894, 0.51593490927370822, 0.95366864033527621, 0.21858921225942141, 0.51893468322778635, 0.92004079322544396, 0.11235531376292107, 18.604939738170557 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.42852784238981045, 0.056597763889924435, 0.11848788247043385, 0.66163281299025523, 0.43073010289096303, 0.33144761460909145, 0.21381410375605647, 0.73484841335918616, 0.046612940620437748, 0.32604490979975109, 88.52129015314874 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.99308196851372144, 0.69073200296224202, 0.23951307257273502, 0.72197895410309909, 0.039391699164541438, 0.46141002359305272, 0.86017310645278411, 0.12185125043633571, 0.27128700696197683, 0.83175228473413365, 21.686008860411143 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.63984269404800698, 0.014836782854007136, 0.23652993663874755, 0.86507066868369131, 0.15622456414065711, 0.83873948847712021, 0.47210259241674357, 0.40339422116057777, 0.96604248522744163, 0.17635790955349828, 36.89810062556802 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.63177278503810963, 0.22384068870429097, 0.34110010030969329, 0.5955884939717988, 0.44332267705735096, 0.24799198685599821, 0.71925499942076321, 0.048566784758747761, 0.51632000335568529, 0.94632397268062562, 15.626271483442888 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.83020903136672586, 0.0676437613722769, 0.36750440070608636, 0.23697257183618947, 0.092728322341317893, 0.1159440880645729, 0.83159910004544191, 0.28307600928040499, 0.49864064611278214, 0.3496635394265436, 66.434477306565114 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.33665448480227667, 0.59414863232901494, 0.6522036951835638, 0.18787299628266341, 0.7807589579658949, 0.58478036025494651, 0.84935374996278334, 0.63474907483875298, 0.063462948342927428, 0.20620838247093631, 83.506961199073672 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Summary",
                table: "RiskExpertMarksCategories");

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.4339198076297649, 0.54410330993907108, 0.82497743074046959, 0.48958542247678194, 0.88810157490703023, 0.49708118332864437, 0.018390160739709782, 0.15098760039883352, 0.1593983159936051, 0.88345969069296459, 51.334260279095588 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.82529792271120839, 0.95611826566698266, 0.7648491631024239, 0.68220406758949348, 0.94618530013734348, 0.15317555981009734, 0.3212623972437918, 0.88946633071002501, 0.34444460038351188, 0.87487986095461934, 10.548102661803259 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.18657569362816795, 0.036325692667876441, 0.58456638555455676, 0.46195864286506738, 0.60323350665953657, 0.234480952025379, 0.60266391528763608, 0.39129509697462428, 0.62523943607872956, 0.7556244516898093, 79.445653398416397 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.073091328171246639, 0.59267216810084666, 0.10350673066238203, 0.006645676633398323, 0.86043627573014381, 0.67563511081480332, 0.2771440730710637, 0.044490943757413803, 0.56466015780508083, 0.24298078019563085, 33.791020477906777 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.988324572184758, 0.94641771354560889, 0.69971643299700159, 0.3252112079486158, 0.26381083708992759, 0.21695632266216236, 0.22939580108563318, 0.08224460983281312, 0.54896190130713651, 0.047678473257270593, 43.49013071544119 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.88337548906547936, 0.22778149290991201, 0.59560732340029132, 0.98885072032879828, 0.00037936890421119696, 0.4475751347987561, 0.61844702642141658, 0.022272408197234417, 0.75853226239057003, 0.80911359471981636, 97.892272633983097 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.37260483551930967, 0.93615776226086544, 0.016486231901501669, 0.84350074231936245, 0.67125182346588386, 0.1061048858580862, 0.76543217256793417, 0.22580190326705563, 0.27291104950156087, 0.77919552594267416, 69.974577941407674 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.58382103722561773, 0.014578046877769757, 0.51953186490355618, 0.46769609329235406, 0.065895163910311028, 0.27527268125455862, 0.081986648419718922, 0.84657370177808777, 0.50567398761165583, 0.41835316504438136, 30.889888377376952 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.80138691454788147, 0.31336320367319404, 0.77641125730562732, 0.73997622126522911, 0.42758095201169255, 0.8012343044892728, 0.1820571053740111, 0.29559112710044155, 0.1317221620954202, 0.76267810494039967, 95.253470889296949 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.47958256853782388, 0.8238378334196198, 0.27653588478992241, 0.95402000256917918, 0.31710586599486446, 0.061870338293880889, 0.48995806439818457, 0.94934219443908074, 0.58531077167981072, 0.23137716905646621, 46.834492846719222 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.57727895937179363, 0.47953254070486728, 0.57737183658141011, 0.41996665782904907, 0.61512958552507369, 0.90364887650023895, 0.32130236930096912, 0.02197019546836676, 0.11477568125533055, 0.65596769691344725, 41.191563376639174 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.84838508417430503, 0.21348481637319272, 0.36828388918460453, 0.32267384073100391, 0.32788088806753957, 0.34656216286649166, 0.62993322392446882, 0.11003496014355985, 0.78403343691491678, 0.63721369773280634, 93.877369883125695 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.96141901132156316, 0.70107523866669752, 0.21517616834274245, 0.4176553911453269, 0.37071019333746624, 0.79377222582734708, 0.52149118724811705, 0.83883224179358151, 0.11158064275467905, 0.39845386640915559, 24.274886328081013 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.25720010934825921, 0.2163990280850463, 0.95268392950325731, 0.53080512432102744, 0.95296337691144495, 0.88261929038076115, 0.7672903304004981, 0.73247441275621994, 0.80385838053306446, 0.80669325219766763, 27.785446865282925 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.43921621325099147, 0.56417728984702731, 0.45151526237155437, 0.67082575101348807, 0.84278758488058914, 0.98456950835638202, 0.95103167280090228, 0.60838795029370651, 0.97099104730024843, 0.68511549552069706, 18.219197903496408 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.081486723449303189, 0.012863283431060468, 0.19851049885780503, 0.51341959546807114, 0.39432727856378036, 0.97366632104794748, 0.37275554420872103, 0.49437722941588835, 0.13614604493980098, 0.017281578465556557, 25.548514790895428 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.75005287515354413, 0.38913845156638438, 0.079965662850165709, 0.62212091871470199, 0.043987962328759012, 0.99388171948131443, 0.80697964953200019, 0.86497945381866093, 0.65905264579648237, 0.41959258779732778, 76.37236638488227 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.40221355948804915, 0.33288049741765047, 0.45783184759009776, 0.49363976780781005, 0.57717316426789, 0.25792720804011404, 0.64440288531290346, 0.80683420217965818, 0.34655643751188769, 0.75165790759719542, 77.438319073444163 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.27798916554987219, 0.80127560091579353, 0.65640190340636684, 0.18636810543726801, 0.41636925248623113, 0.176023060735229, 0.60613896712419357, 0.84892731107206565, 0.44303474322052716, 0.91717826791909141, 18.428789671824465 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.36533762816058912, 0.32195223027285291, 0.19147752743224189, 0.28591660151851794, 0.52376122367978639, 0.27460787106416329, 0.896077503493656, 0.8133082386691658, 0.75257165241547042, 0.3341249223277144, 15.435878368470558 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.97227235117969513, 0.76641225257067658, 0.98984084630816671, 0.6299124171870617, 0.8800377797535559, 0.81466995492728655, 0.00060973667213837235, 0.61350319959375099, 0.86744261015123081, 0.014275301687914799, 90.510270157678377 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.59914330864917209, 0.46460499178414905, 0.96876243949309448, 0.88001428049866592, 0.35333507143830312, 0.24529394202104049, 0.47016832971427969, 0.50305524897010467, 0.32516789952027836, 0.89002203806229696, 93.586288281635504 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.19596189461264746, 0.50378263243251897, 0.96772210636347222, 0.12488009912166176, 0.31578672649357931, 0.042499930758222559, 0.81648018437528624, 0.17987401896875521, 0.14273765586183329, 0.52836448790266888, 84.891999843727604 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.55397809497489059, 0.53543535133451714, 0.4624656077693915, 0.55995945678123304, 0.24880228669606996, 0.21597413274435895, 0.41025696996116945, 0.60139971941209747, 0.48389698291745331, 0.18684432842466703, 94.875111945086232 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.99322174231336224, 0.027836852133759749, 0.26955616800350468, 0.8670299892776937, 0.53550071985236858, 0.35946699629671308, 0.75406673198248997, 0.24143046607788365, 0.27195556573570046, 0.41569256059678072, 87.731440352228702 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.60643862161170581, 0.62061199199394101, 0.57671936626383447, 0.74424115517839584, 0.69841941735486457, 0.13323918562622394, 0.38516702423981553, 0.80226764611238333, 0.5473213000992635, 0.37945451270817365, 60.404677515927695 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.3265168722114633, 0.72950296030957695, 0.27523936384606995, 0.83147831181886855, 0.4297007239259576, 0.52453782640764024, 0.67721910649208394, 0.046935526941169758, 0.59246297547369786, 0.83105490404435967, 80.784769485328496 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.072123204192030332, 0.22025186596785418, 0.038839652454314866, 0.78835760020434331, 0.42733555435986303, 0.96704154342213811, 0.90247541186005198, 0.95136835699708722, 0.34186048802154667, 0.15859541068487881, 13.811802330442035 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.18802042146382736, 0.062413001610537311, 0.78409497445771181, 0.06452176979366353, 0.36468852369149118, 0.062914142429006614, 0.11599899941240432, 0.91548597714757463, 0.95127213781854059, 0.94725799697181845, 95.175343981086229 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.78960201369170524, 0.46682351978481951, 0.77637298827864343, 0.89562295077417942, 0.31253524254443943, 0.70193658010385418, 0.10478141782939243, 0.70838335486736226, 0.52111139356364355, 0.20724946425611934, 22.24241902147449 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.28984772061829522, 0.49943330472996028, 0.73558669064084936, 0.84225530799556103, 0.7426197533001736, 0.55936376185743286, 0.34240937899821122, 0.88812528835734506, 0.70638738081504737, 0.89296103220758904, 52.625026971708131 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.79793104377637802, 0.020991484687175266, 0.3579311477705942, 0.97184928990528141, 0.82980164883477159, 0.84407015825427756, 0.45821565111412987, 0.047956271404946405, 0.67280377279103254, 0.95235187889161688, 23.245541984318187 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.27930772172134521, 0.44411398827135662, 0.94334076366122532, 0.96799421785408291, 0.73656590056045212, 0.27546845118783203, 0.38187190875596277, 0.71491016367536309, 0.56317803101742103, 0.69031879158766607, 66.441602557536896 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.9590438418467665, 0.23910834032222927, 0.77702952977329476, 0.040791007304743054, 0.61233301521395034, 0.031940794794243277, 0.2134354877575112, 0.54185195159731603, 0.6378252490113836, 0.58370952956427946, 96.897877026093965 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.04836746847157547, 0.025052338905329874, 0.71398882350942094, 0.33129209041283381, 0.89210352421558581, 0.87347849172433467, 0.80465271872629929, 0.86007618503928418, 0.38325472253978254, 0.50427003898516465, 63.025443058900109 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.10731301499641044, 0.035125466726869892, 0.226681027882085, 0.7159852711776924, 0.046847725210754421, 0.96010492562100214, 0.90479206026143721, 0.25023185983712526, 0.67114525701028283, 0.51106939223540127, 95.73576475018433 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.56017801985367799, 0.30019797857152952, 0.70493883700385696, 0.85708660778001655, 0.64907534666948918, 0.99950173033400935, 0.45861561107675131, 0.55688292739833367, 0.17442059002367827, 0.89806822156150878, 72.446484648242944 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.30930153791470305, 0.4517330728881791, 0.66116214977915877, 0.98487842422701921, 0.98106133029368692, 0.73436454644621063, 0.85014560560373109, 0.91290748661887666, 0.51397093258716919, 0.49050766765169751, 55.834853788710859 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.84365573600549559, 0.13516255487417117, 0.60130197170332511, 0.73524749485868912, 0.90616656654373107, 0.6568054296659549, 0.93012787243748118, 0.088606570040584809, 0.19383281935641261, 0.64004010285748869, 63.486768945880378 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.87809592848661167, 0.36732300310565069, 0.41813677368519486, 0.2822909909137864, 0.80204483655984871, 0.15699103226686262, 0.5596064793841552, 0.049259070301649555, 0.87367295031813486, 0.38444279837918938, 97.991917953898778 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.47017017074930856, 0.56936700898095238, 0.044864731218208331, 0.17162737700787056, 0.49790182773681757, 0.3132106000718704, 0.51840912161130093, 0.21804240740268532, 0.91930879870689541, 0.97673508387936081, 87.951001858838779 });
        }
    }
}
