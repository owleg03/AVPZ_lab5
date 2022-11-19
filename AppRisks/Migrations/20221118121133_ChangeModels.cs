using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppRisks.Migrations
{
    /// <inheritdoc />
    public partial class ChangeModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "RiskExpertMarksEnumerable",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Summary",
                table: "RiskExpertMarksEnumerable",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "RiskExpertMarksCategories",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "Value",
                table: "RiskExpertMarksCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Price", "Value" },
                values: new object[] { 0.0, 0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Price", "Value" },
                values: new object[] { 0.0, 0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Price", "Value" },
                values: new object[] { 0.0, 0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksCategories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Price", "Value" },
                values: new object[] { 0.0, 0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Summary" },
                values: new object[] { 0.4339198076297649, 0.54410330993907108, 0.82497743074046959, 0.48958542247678194, 0.88810157490703023, 0.49708118332864437, 0.018390160739709782, 0.15098760039883352, 0.1593983159936051, 0.88345969069296459, 51.334260279095588, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Summary" },
                values: new object[] { 0.82529792271120839, 0.95611826566698266, 0.7648491631024239, 0.68220406758949348, 0.94618530013734348, 0.15317555981009734, 0.3212623972437918, 0.88946633071002501, 0.34444460038351188, 0.87487986095461934, 10.548102661803259, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Summary" },
                values: new object[] { 0.18657569362816795, 0.036325692667876441, 0.58456638555455676, 0.46195864286506738, 0.60323350665953657, 0.234480952025379, 0.60266391528763608, 0.39129509697462428, 0.62523943607872956, 0.7556244516898093, 79.445653398416397, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Summary" },
                values: new object[] { 0.073091328171246639, 0.59267216810084666, 0.10350673066238203, 0.006645676633398323, 0.86043627573014381, 0.67563511081480332, 0.2771440730710637, 0.044490943757413803, 0.56466015780508083, 0.24298078019563085, 33.791020477906777, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Summary" },
                values: new object[] { 0.988324572184758, 0.94641771354560889, 0.69971643299700159, 0.3252112079486158, 0.26381083708992759, 0.21695632266216236, 0.22939580108563318, 0.08224460983281312, 0.54896190130713651, 0.047678473257270593, 43.49013071544119, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Summary" },
                values: new object[] { 0.88337548906547936, 0.22778149290991201, 0.59560732340029132, 0.98885072032879828, 0.00037936890421119696, 0.4475751347987561, 0.61844702642141658, 0.022272408197234417, 0.75853226239057003, 0.80911359471981636, 97.892272633983097, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Summary" },
                values: new object[] { 0.37260483551930967, 0.93615776226086544, 0.016486231901501669, 0.84350074231936245, 0.67125182346588386, 0.1061048858580862, 0.76543217256793417, 0.22580190326705563, 0.27291104950156087, 0.77919552594267416, 69.974577941407674, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Summary" },
                values: new object[] { 0.58382103722561773, 0.014578046877769757, 0.51953186490355618, 0.46769609329235406, 0.065895163910311028, 0.27527268125455862, 0.081986648419718922, 0.84657370177808777, 0.50567398761165583, 0.41835316504438136, 30.889888377376952, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Summary" },
                values: new object[] { 0.80138691454788147, 0.31336320367319404, 0.77641125730562732, 0.73997622126522911, 0.42758095201169255, 0.8012343044892728, 0.1820571053740111, 0.29559112710044155, 0.1317221620954202, 0.76267810494039967, 95.253470889296949, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Summary" },
                values: new object[] { 0.47958256853782388, 0.8238378334196198, 0.27653588478992241, 0.95402000256917918, 0.31710586599486446, 0.061870338293880889, 0.48995806439818457, 0.94934219443908074, 0.58531077167981072, 0.23137716905646621, 46.834492846719222, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Summary" },
                values: new object[] { 0.57727895937179363, 0.47953254070486728, 0.57737183658141011, 0.41996665782904907, 0.61512958552507369, 0.90364887650023895, 0.32130236930096912, 0.02197019546836676, 0.11477568125533055, 0.65596769691344725, 41.191563376639174, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Summary" },
                values: new object[] { 0.84838508417430503, 0.21348481637319272, 0.36828388918460453, 0.32267384073100391, 0.32788088806753957, 0.34656216286649166, 0.62993322392446882, 0.11003496014355985, 0.78403343691491678, 0.63721369773280634, 93.877369883125695, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Summary" },
                values: new object[] { 0.96141901132156316, 0.70107523866669752, 0.21517616834274245, 0.4176553911453269, 0.37071019333746624, 0.79377222582734708, 0.52149118724811705, 0.83883224179358151, 0.11158064275467905, 0.39845386640915559, 24.274886328081013, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Summary" },
                values: new object[] { 0.25720010934825921, 0.2163990280850463, 0.95268392950325731, 0.53080512432102744, 0.95296337691144495, 0.88261929038076115, 0.7672903304004981, 0.73247441275621994, 0.80385838053306446, 0.80669325219766763, 27.785446865282925, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Summary" },
                values: new object[] { 0.43921621325099147, 0.56417728984702731, 0.45151526237155437, 0.67082575101348807, 0.84278758488058914, 0.98456950835638202, 0.95103167280090228, 0.60838795029370651, 0.97099104730024843, 0.68511549552069706, 18.219197903496408, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Summary" },
                values: new object[] { 0.081486723449303189, 0.012863283431060468, 0.19851049885780503, 0.51341959546807114, 0.39432727856378036, 0.97366632104794748, 0.37275554420872103, 0.49437722941588835, 0.13614604493980098, 0.017281578465556557, 25.548514790895428, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Summary" },
                values: new object[] { 0.75005287515354413, 0.38913845156638438, 0.079965662850165709, 0.62212091871470199, 0.043987962328759012, 0.99388171948131443, 0.80697964953200019, 0.86497945381866093, 0.65905264579648237, 0.41959258779732778, 76.37236638488227, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Summary" },
                values: new object[] { 0.40221355948804915, 0.33288049741765047, 0.45783184759009776, 0.49363976780781005, 0.57717316426789, 0.25792720804011404, 0.64440288531290346, 0.80683420217965818, 0.34655643751188769, 0.75165790759719542, 77.438319073444163, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Summary" },
                values: new object[] { 0.27798916554987219, 0.80127560091579353, 0.65640190340636684, 0.18636810543726801, 0.41636925248623113, 0.176023060735229, 0.60613896712419357, 0.84892731107206565, 0.44303474322052716, 0.91717826791909141, 18.428789671824465, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Summary" },
                values: new object[] { 0.36533762816058912, 0.32195223027285291, 0.19147752743224189, 0.28591660151851794, 0.52376122367978639, 0.27460787106416329, 0.896077503493656, 0.8133082386691658, 0.75257165241547042, 0.3341249223277144, 15.435878368470558, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Summary" },
                values: new object[] { 0.97227235117969513, 0.76641225257067658, 0.98984084630816671, 0.6299124171870617, 0.8800377797535559, 0.81466995492728655, 0.00060973667213837235, 0.61350319959375099, 0.86744261015123081, 0.014275301687914799, 90.510270157678377, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Summary" },
                values: new object[] { 0.59914330864917209, 0.46460499178414905, 0.96876243949309448, 0.88001428049866592, 0.35333507143830312, 0.24529394202104049, 0.47016832971427969, 0.50305524897010467, 0.32516789952027836, 0.89002203806229696, 93.586288281635504, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Summary" },
                values: new object[] { 0.19596189461264746, 0.50378263243251897, 0.96772210636347222, 0.12488009912166176, 0.31578672649357931, 0.042499930758222559, 0.81648018437528624, 0.17987401896875521, 0.14273765586183329, 0.52836448790266888, 84.891999843727604, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Summary" },
                values: new object[] { 0.55397809497489059, 0.53543535133451714, 0.4624656077693915, 0.55995945678123304, 0.24880228669606996, 0.21597413274435895, 0.41025696996116945, 0.60139971941209747, 0.48389698291745331, 0.18684432842466703, 94.875111945086232, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Summary" },
                values: new object[] { 0.99322174231336224, 0.027836852133759749, 0.26955616800350468, 0.8670299892776937, 0.53550071985236858, 0.35946699629671308, 0.75406673198248997, 0.24143046607788365, 0.27195556573570046, 0.41569256059678072, 87.731440352228702, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Summary" },
                values: new object[] { 0.60643862161170581, 0.62061199199394101, 0.57671936626383447, 0.74424115517839584, 0.69841941735486457, 0.13323918562622394, 0.38516702423981553, 0.80226764611238333, 0.5473213000992635, 0.37945451270817365, 60.404677515927695, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Summary" },
                values: new object[] { 0.3265168722114633, 0.72950296030957695, 0.27523936384606995, 0.83147831181886855, 0.4297007239259576, 0.52453782640764024, 0.67721910649208394, 0.046935526941169758, 0.59246297547369786, 0.83105490404435967, 80.784769485328496, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Summary" },
                values: new object[] { 0.072123204192030332, 0.22025186596785418, 0.038839652454314866, 0.78835760020434331, 0.42733555435986303, 0.96704154342213811, 0.90247541186005198, 0.95136835699708722, 0.34186048802154667, 0.15859541068487881, 13.811802330442035, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Summary" },
                values: new object[] { 0.18802042146382736, 0.062413001610537311, 0.78409497445771181, 0.06452176979366353, 0.36468852369149118, 0.062914142429006614, 0.11599899941240432, 0.91548597714757463, 0.95127213781854059, 0.94725799697181845, 95.175343981086229, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Summary" },
                values: new object[] { 0.78960201369170524, 0.46682351978481951, 0.77637298827864343, 0.89562295077417942, 0.31253524254443943, 0.70193658010385418, 0.10478141782939243, 0.70838335486736226, 0.52111139356364355, 0.20724946425611934, 22.24241902147449, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Summary" },
                values: new object[] { 0.28984772061829522, 0.49943330472996028, 0.73558669064084936, 0.84225530799556103, 0.7426197533001736, 0.55936376185743286, 0.34240937899821122, 0.88812528835734506, 0.70638738081504737, 0.89296103220758904, 52.625026971708131, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Summary" },
                values: new object[] { 0.79793104377637802, 0.020991484687175266, 0.3579311477705942, 0.97184928990528141, 0.82980164883477159, 0.84407015825427756, 0.45821565111412987, 0.047956271404946405, 0.67280377279103254, 0.95235187889161688, 23.245541984318187, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Summary" },
                values: new object[] { 0.27930772172134521, 0.44411398827135662, 0.94334076366122532, 0.96799421785408291, 0.73656590056045212, 0.27546845118783203, 0.38187190875596277, 0.71491016367536309, 0.56317803101742103, 0.69031879158766607, 66.441602557536896, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Summary" },
                values: new object[] { 0.9590438418467665, 0.23910834032222927, 0.77702952977329476, 0.040791007304743054, 0.61233301521395034, 0.031940794794243277, 0.2134354877575112, 0.54185195159731603, 0.6378252490113836, 0.58370952956427946, 96.897877026093965, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Summary" },
                values: new object[] { 0.04836746847157547, 0.025052338905329874, 0.71398882350942094, 0.33129209041283381, 0.89210352421558581, 0.87347849172433467, 0.80465271872629929, 0.86007618503928418, 0.38325472253978254, 0.50427003898516465, 63.025443058900109, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Summary" },
                values: new object[] { 0.10731301499641044, 0.035125466726869892, 0.226681027882085, 0.7159852711776924, 0.046847725210754421, 0.96010492562100214, 0.90479206026143721, 0.25023185983712526, 0.67114525701028283, 0.51106939223540127, 95.73576475018433, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Summary" },
                values: new object[] { 0.56017801985367799, 0.30019797857152952, 0.70493883700385696, 0.85708660778001655, 0.64907534666948918, 0.99950173033400935, 0.45861561107675131, 0.55688292739833367, 0.17442059002367827, 0.89806822156150878, 72.446484648242944, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Summary" },
                values: new object[] { 0.30930153791470305, 0.4517330728881791, 0.66116214977915877, 0.98487842422701921, 0.98106133029368692, 0.73436454644621063, 0.85014560560373109, 0.91290748661887666, 0.51397093258716919, 0.49050766765169751, 55.834853788710859, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Summary" },
                values: new object[] { 0.84365573600549559, 0.13516255487417117, 0.60130197170332511, 0.73524749485868912, 0.90616656654373107, 0.6568054296659549, 0.93012787243748118, 0.088606570040584809, 0.19383281935641261, 0.64004010285748869, 63.486768945880378, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Summary" },
                values: new object[] { 0.87809592848661167, 0.36732300310565069, 0.41813677368519486, 0.2822909909137864, 0.80204483655984871, 0.15699103226686262, 0.5596064793841552, 0.049259070301649555, 0.87367295031813486, 0.38444279837918938, 97.991917953898778, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Summary" },
                values: new object[] { 0.47017017074930856, 0.56936700898095238, 0.044864731218208331, 0.17162737700787056, 0.49790182773681757, 0.3132106000718704, 0.51840912161130093, 0.21804240740268532, 0.91930879870689541, 0.97673508387936081, 87.951001858838779, 0.0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "RiskExpertMarksEnumerable");

            migrationBuilder.DropColumn(
                name: "Summary",
                table: "RiskExpertMarksEnumerable");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "RiskExpertMarksCategories");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "RiskExpertMarksCategories");

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
    }
}
