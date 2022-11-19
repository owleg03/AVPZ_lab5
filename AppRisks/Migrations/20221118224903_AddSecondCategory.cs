using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppRisks.Migrations
{
    /// <inheritdoc />
    public partial class AddSecondCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "AdditionalPrice",
                table: "RiskExpertMarksEnumerable",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "EndPrice",
                table: "RiskExpertMarksEnumerable",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "PriceStatus",
                table: "RiskExpertMarksEnumerable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AdditionalPrice", "EndPrice", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "PriceStatus" },
                values: new object[] { 0.0, 0.0, 0.20589088926922361, 0.65794614969860865, 0.4231277966000786, 0.34527329900864745, 0.86034850959121256, 0.34967336272829941, 0.18130408844395585, 0.64615524460080154, 0.3855789188813572, 0.49524639788925751, 37.274854625393573, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AdditionalPrice", "EndPrice", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "PriceStatus" },
                values: new object[] { 0.0, 0.0, 0.12380236930051991, 0.92652212339464046, 0.61142111866056714, 0.061239506207874883, 0.095123298107197662, 0.15750519326230894, 0.65120042619226337, 0.40881270822565052, 0.47435175089346426, 0.20116934085365978, 90.512287184800073, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AdditionalPrice", "EndPrice", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "PriceStatus" },
                values: new object[] { 0.0, 0.0, 0.10637350222785702, 0.87905602726439569, 0.12713807194854565, 0.34852943811541204, 0.34665579761081033, 0.29378005060740064, 0.66459308340092815, 0.68736928431408972, 0.8156449998632499, 0.99322420238588915, 54.789918794136774, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AdditionalPrice", "EndPrice", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "PriceStatus" },
                values: new object[] { 0.0, 0.0, 0.65079262114819991, 0.56656553427970846, 0.61125978033387041, 0.30664533930941229, 0.26770128269011695, 0.77760927122925971, 0.82056738243738536, 0.26201327441272371, 0.88881404628753435, 0.073835942047944636, 83.954438039792961, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AdditionalPrice", "EndPrice", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "PriceStatus" },
                values: new object[] { 0.0, 0.0, 0.40885104569793096, 0.20654012312243875, 0.31258980119452884, 0.73591593513375209, 0.3591732347700588, 0.051681858761880473, 0.70973281203369709, 0.49738117943535964, 0.15499309417217999, 0.22745272158171737, 23.286520664823318, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AdditionalPrice", "EndPrice", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "PriceStatus" },
                values: new object[] { 0.0, 0.0, 0.28937930099911691, 0.46079767170339503, 0.29018639814252867, 0.72594429170895636, 0.77612096948961362, 0.3234060869328349, 0.89844235446415965, 0.66690334117231387, 0.82051003564928782, 0.95409576043209754, 62.612407616067543, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AdditionalPrice", "EndPrice", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "PriceStatus" },
                values: new object[] { 0.0, 0.0, 0.75186445142508063, 0.52241895074707323, 0.57960699108964842, 0.81492297815869219, 0.35376115129399355, 0.65261059412987965, 0.40476921368008167, 0.8629130080180476, 0.77030881974880094, 0.15680421632073394, 26.443040433814058, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AdditionalPrice", "EndPrice", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "PriceStatus" },
                values: new object[] { 0.0, 0.0, 0.74973145366200133, 0.33674585862466688, 0.75056875511703591, 0.44908161085164089, 0.64082797671712477, 0.77695358197403031, 0.46694947847656298, 0.83369478010666331, 0.40038888104342685, 0.48390510364726524, 7.4671848291146485, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AdditionalPrice", "EndPrice", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "PriceStatus" },
                values: new object[] { 0.0, 0.0, 0.98860992192771169, 0.41817151337802416, 0.067977101563138187, 0.94313983971714777, 0.11996338568380494, 0.66662585336574565, 0.22187518182497756, 0.57378010016126701, 0.75990500895345869, 0.51042505454270892, 29.789045528833757, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AdditionalPrice", "EndPrice", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "PriceStatus" },
                values: new object[] { 0.0, 0.0, 0.94560302717641176, 0.13809727976608632, 0.40062931908100119, 0.32244405030605572, 0.92533346756264956, 0.93467439935026442, 0.62920603274251186, 0.80635480456853559, 0.59595624127883118, 0.32877829495415156, 52.202957488813048, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AdditionalPrice", "EndPrice", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "PriceStatus" },
                values: new object[] { 0.0, 0.0, 0.50827044414418054, 0.35015330404596312, 0.1208360916702923, 0.25647061823754902, 0.21955824436519444, 0.23043216295397284, 0.8643792912934517, 0.62180893638824064, 0.17273254199686106, 0.87398381387766311, 41.892845490243388, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AdditionalPrice", "EndPrice", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "PriceStatus" },
                values: new object[] { 0.0, 0.0, 0.57812907101866062, 0.68599372659132618, 0.57736598338332301, 0.52077550231770997, 0.71153894224486347, 0.27888671020730049, 0.32958873112707843, 0.93928237420970995, 0.9677726668430765, 0.30269446677703338, 92.079359135109357, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AdditionalPrice", "EndPrice", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "PriceStatus" },
                values: new object[] { 0.0, 0.0, 0.49368716601984963, 0.61808074935965385, 0.52959365671915348, 0.84324691624302994, 0.10094308931648177, 0.79455223192044722, 0.2265352839632071, 0.70899773274148425, 0.90432852136902697, 0.04103075817828894, 82.299149697034295, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AdditionalPrice", "EndPrice", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "PriceStatus" },
                values: new object[] { 0.0, 0.0, 0.4259564875799825, 0.69947909112938789, 0.24551138992668864, 0.70822399170898986, 0.4117869586518601, 0.37293109812308878, 0.75948998921330901, 0.30167975926466717, 0.40441509806736131, 0.29820568218481702, 92.45585294660917, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AdditionalPrice", "EndPrice", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "PriceStatus" },
                values: new object[] { 0.0, 0.0, 0.37132439794898675, 0.29500370996473779, 0.32012107325509487, 0.96199854122044837, 0.1235539191292625, 0.82812806724826571, 0.067422734987947819, 0.9765312452588073, 0.71133458556735896, 0.62255554493673038, 42.943872564612981, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AdditionalPrice", "EndPrice", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "PriceStatus" },
                values: new object[] { 0.0, 0.0, 0.5103787880084607, 0.082053898299962569, 0.76820896709188102, 0.1225009802698237, 0.3471361019812027, 0.81967662155605825, 0.16156100667002871, 0.65473773992387352, 0.50234683914836231, 0.94534712589259062, 49.47999583995523, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AdditionalPrice", "EndPrice", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "PriceStatus" },
                values: new object[] { 0.0, 0.0, 0.58741507997945652, 0.4298744012241893, 0.0054098654459200368, 0.66185257706544109, 0.065741220668977474, 0.25785102492871381, 0.309954917963982, 0.08522285974046806, 0.18244704755061858, 0.22611076492261606, 58.027889067937387, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AdditionalPrice", "EndPrice", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "PriceStatus" },
                values: new object[] { 0.0, 0.0, 0.055304583352584258, 0.98608604052989968, 0.59708718610462963, 0.63070283788367698, 0.59168485333840937, 0.91504752118207011, 0.38082251510476239, 0.084365148627930764, 0.5992819078501781, 0.64008036353843556, 24.447418356634543, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AdditionalPrice", "EndPrice", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "PriceStatus" },
                values: new object[] { 0.0, 0.0, 0.1427962547246896, 0.48524755268202358, 0.012506103252344358, 0.64353927360316143, 0.63361185689547672, 0.77065304297796211, 0.86484841477828878, 0.44399795224515293, 0.75121915200503908, 0.81618741750431811, 11.170586548921936, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AdditionalPrice", "EndPrice", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "PriceStatus" },
                values: new object[] { 0.0, 0.0, 0.81048978250056358, 0.76346153445572995, 0.26135926213829519, 0.82500735816896187, 0.37276279714694061, 0.66667674931627197, 0.94902168583477409, 0.75931337472337768, 0.32901160058102064, 0.69149936443850857, 92.787345297295033, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AdditionalPrice", "EndPrice", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "PriceStatus" },
                values: new object[] { 0.0, 0.0, 0.30912623796482008, 0.45754055516635173, 0.10825765074661309, 0.21290134114633452, 0.35537589263422364, 0.84081292301081267, 0.6572315780160507, 0.056850672919020906, 0.063537909503279644, 0.90066665455045058, 79.05488968073908, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AdditionalPrice", "EndPrice", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "PriceStatus" },
                values: new object[] { 0.0, 0.0, 0.096164452498272768, 0.28483556075567273, 0.89051044519102063, 0.9470143792588942, 0.21817163281649965, 0.53298288065506105, 0.21325273034151826, 0.1079180022247257, 0.20757184132286233, 0.96722551715700089, 82.255255937940788, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AdditionalPrice", "EndPrice", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "PriceStatus" },
                values: new object[] { 0.0, 0.0, 0.50141052204772429, 0.89413369230409789, 0.72554751311596799, 0.36367688598584591, 0.30153935679166088, 0.40280283984048859, 0.87756622595375233, 0.91019572659079528, 0.77559935194320828, 0.077320712200692698, 50.96549190701689, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AdditionalPrice", "EndPrice", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "PriceStatus" },
                values: new object[] { 0.0, 0.0, 0.41214088758518841, 0.36871100718041461, 0.35908291914158741, 0.39663993154055288, 0.53147911666078718, 0.80186146597450314, 0.44442313628007424, 0.29854984019201669, 0.23014106882543817, 0.20278187446371598, 97.429307624584808, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AdditionalPrice", "EndPrice", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "PriceStatus" },
                values: new object[] { 0.0, 0.0, 0.27814773308971907, 0.72640533617142222, 0.9031729615362859, 0.79064834739591139, 0.63485515782720559, 0.28956071721481769, 0.58760332373465085, 0.18557663302503757, 0.44925909022552624, 0.3469664312694134, 70.117361022544472, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AdditionalPrice", "EndPrice", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "PriceStatus" },
                values: new object[] { 0.0, 0.0, 0.9315943197660973, 0.77688818122196557, 0.53774335319405897, 0.38181393769990868, 0.69752926244233626, 0.72607225655216145, 0.44635751711338478, 0.99188989669948247, 0.13541256476023866, 0.2865408576124876, 48.44854503654944, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AdditionalPrice", "EndPrice", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "PriceStatus" },
                values: new object[] { 0.0, 0.0, 0.89987092874406382, 0.85146829205452179, 0.30569481902788675, 0.98091653472701479, 0.17875051108531625, 0.74801870417498628, 0.42669444574136406, 0.55012896856324556, 0.35858752785658277, 0.0052455433609780444, 97.395137558908047, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AdditionalPrice", "EndPrice", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "PriceStatus" },
                values: new object[] { 0.0, 0.0, 0.11313928559852959, 0.15452502065786611, 0.45910914995069374, 0.22889907761682737, 0.48782795794806344, 0.88571913323675888, 0.049562756887254422, 0.52085391572769768, 0.18755148570201807, 0.47683255557811521, 84.66020266495579, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AdditionalPrice", "EndPrice", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "PriceStatus" },
                values: new object[] { 0.0, 0.0, 0.89635043566323302, 0.70702778499389352, 0.61052358129625572, 0.012707972520195399, 0.39518653408764515, 0.77235097195272084, 0.78472058346871087, 0.44976230527529892, 0.39529261293133844, 0.80496101295616163, 8.5301694481186843, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AdditionalPrice", "EndPrice", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "PriceStatus" },
                values: new object[] { 0.0, 0.0, 0.031173919042587372, 0.2932132636747703, 0.53927030909319762, 0.57471219207030377, 0.32390684437836725, 0.95728663798807667, 0.14900385597226629, 0.62560223946919558, 0.41936198848320472, 0.76768773721279826, 45.113363668016738, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AdditionalPrice", "EndPrice", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "PriceStatus" },
                values: new object[] { 0.0, 0.0, 0.29561451310684606, 0.1170178086286684, 0.93321824139965315, 0.098996143018243221, 0.9045435401534041, 0.055131388239169743, 0.88082269720873141, 0.67874873518986134, 0.4901342578771869, 0.13712441005167564, 92.948181762768783, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AdditionalPrice", "EndPrice", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "PriceStatus" },
                values: new object[] { 0.0, 0.0, 0.47103642093302112, 0.71731775804650322, 0.59323854823489397, 0.90021672093171079, 0.95886493111999216, 0.60753866557048175, 0.83582771939327394, 0.004943760859657198, 0.4352630364942851, 0.30051639423747045, 35.76069783469876, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AdditionalPrice", "EndPrice", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "PriceStatus" },
                values: new object[] { 0.0, 0.0, 0.10143875796381285, 0.94415677144521315, 0.063609425873433989, 0.87661784125018594, 0.17377280967040576, 0.022964903766168665, 0.84778064237366624, 0.63388116909915593, 0.12922604821073913, 0.4653262975530994, 82.413553540991231, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AdditionalPrice", "EndPrice", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "PriceStatus" },
                values: new object[] { 0.0, 0.0, 0.99188848344624547, 0.22239112228380875, 0.17730775384045105, 0.26880133576368537, 0.68523688188764442, 0.58901772846899636, 0.25204559280711103, 0.092082912049862076, 0.21074364477533614, 0.82095187110798185, 3.9523228558903001, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AdditionalPrice", "EndPrice", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "PriceStatus" },
                values: new object[] { 0.0, 0.0, 0.90874803423879236, 0.94176710584355028, 0.80593808221395569, 0.080348015573901921, 0.13641557600888621, 0.36405724141271323, 0.92055177967629587, 0.52518228731755734, 0.05814714063672044, 0.39397520810466979, 50.903457739407401, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AdditionalPrice", "EndPrice", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "PriceStatus" },
                values: new object[] { 0.0, 0.0, 0.13963568356592804, 0.69295833212101887, 0.64293172043184066, 0.52212149441117983, 0.70415933271124076, 0.21940126496000911, 0.75491239766687956, 0.62956136577856281, 0.57113098750809543, 0.99565317875683679, 98.181330383894419, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AdditionalPrice", "EndPrice", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "PriceStatus" },
                values: new object[] { 0.0, 0.0, 0.53748663132081975, 0.57009638512963223, 0.32285832505907497, 0.41497845973112613, 0.21339823553833348, 0.25831592866118869, 0.80693413641865641, 0.017791738267778356, 0.8388743682635188, 0.6703235386516897, 94.681364120998623, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AdditionalPrice", "EndPrice", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "PriceStatus" },
                values: new object[] { 0.0, 0.0, 0.641043888027375, 0.81908990908070323, 0.5269647859347919, 0.6241794244840948, 0.37842786796741146, 0.88734973255754257, 0.56055894420830099, 0.37274828336080035, 0.62296303722033763, 0.36660579496064205, 93.223013499167976, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AdditionalPrice", "EndPrice", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "PriceStatus" },
                values: new object[] { 0.0, 0.0, 0.14072524895123861, 0.60120824614992163, 0.16857919913900421, 0.017354965668574973, 0.31875151140564451, 0.82439250758024363, 0.35762790173621539, 0.99139542940180014, 0.88611280318368646, 0.51848448237839684, 21.195962012032965, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AdditionalPrice", "EndPrice", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "PriceStatus" },
                values: new object[] { 0.0, 0.0, 0.97804896248504247, 0.0050943979961757258, 0.25869858263262324, 0.10920896254729384, 0.51701926978967527, 0.73945606319260448, 0.36552379923831557, 0.043216470712239774, 0.2225446573694444, 0.4941611717559532, 16.879981190474414, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "AdditionalPrice", "EndPrice", "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "PriceStatus" },
                values: new object[] { 0.0, 0.0, 0.70806473282515758, 0.65026462469172785, 0.24969882747608541, 0.0011320858069849837, 0.1970131794861294, 0.759609695727962, 0.3699544232923071, 0.035458875238485454, 0.81574551477836921, 0.13356858644011527, 80.244919260060456, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdditionalPrice",
                table: "RiskExpertMarksEnumerable");

            migrationBuilder.DropColumn(
                name: "EndPrice",
                table: "RiskExpertMarksEnumerable");

            migrationBuilder.DropColumn(
                name: "PriceStatus",
                table: "RiskExpertMarksEnumerable");

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.4765444456016581, 0.097482560558088127, 0.15741023171540114, 0.58814966403476199, 0.75989513187756497, 0.49570122867996824, 0.88251444871849583, 0.2833155086318272, 0.83627690798490972, 0.86602561767611841, 1.4082684009579571 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.6357065074359397, 0.34159420636358218, 0.73638391067980524, 0.48497500482930689, 0.81951032805950008, 0.10823103990423644, 0.32068836980054882, 0.31349562677599707, 0.76989331703421449, 0.091509038169331092, 35.237060915387417 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.61934602653533777, 0.96020577578842126, 0.12748524366132052, 0.1147258329591021, 0.18657211036941879, 0.72652883563477733, 0.83828596165102542, 0.50890470403712862, 0.61077941871070807, 0.089284506990022106, 33.844315244261146 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.2789889703837396, 0.22461004200443402, 0.74760363637875948, 0.91071599042112228, 0.08791702358372866, 0.036113318069432854, 0.10842132842898355, 0.19519530713380917, 0.89672457551400975, 0.84194984121721261, 42.439976936686563 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.80666977392750905, 0.09553589031515286, 0.29564357849955047, 0.79799377685332007, 0.27937285125757216, 0.40367589741920207, 0.77699133245836793, 0.37665905598330895, 0.4224197071746657, 0.18623376440509309, 59.189526974476856 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.71579456746489467, 0.44867807056798226, 0.025350400134084072, 0.4543198486787533, 0.33041518472729348, 0.98271916409118443, 0.27267312289615997, 0.34501295539634846, 0.7830343664715369, 0.48442222193443873, 28.599434515380217 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.51750297960776936, 0.14018240913861135, 0.79726824170517163, 0.49632604914321299, 0.47525361791373422, 0.040829237444908739, 0.50336093774785451, 0.58808945533556189, 0.85131738483104946, 0.83692083817829888, 32.075610682167763 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.79270358104979155, 0.12273507988100729, 0.98015376076872673, 0.25682414912736651, 0.99578022914955555, 0.2878403323943427, 0.69154846291249239, 0.022153386757853055, 0.018022538472042715, 0.41678101289332536, 96.370709835855521 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.93318153952285166, 0.81764260058567129, 0.076357354088140372, 0.05630520814421025, 0.40627466589825056, 0.79920396081699208, 0.29578160670677267, 0.59140394827091169, 0.1136337593441491, 0.49023028238802835, 20.642435481052747 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.29105854204279247, 0.77975585395876923, 0.84543133208264298, 0.82058497447889533, 0.35589669669710955, 0.32524924943272249, 0.18863219652690033, 0.77132898897480517, 0.54850845872700149, 0.67727310992539547, 82.521826619284184 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.075696078752325868, 0.79978171018663036, 0.76100200187654188, 0.26241926991691078, 0.008979761290875854, 0.27236049070287682, 0.27978005407281126, 0.84843101577817359, 0.034710129093319275, 0.42346311841327489, 35.133895012164842 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.65333114016766902, 0.65474415658452667, 0.21677478585590393, 0.96264830073843044, 0.13590789912699885, 0.019905403286634038, 0.50685902656064485, 0.8882288465636744, 0.6802804502578117, 0.086410205712963317, 82.536429670042423 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.47719516069059764, 0.253670500924986, 0.85922413262504949, 0.50376706570130947, 0.46497493744465324, 0.32424173839483317, 0.65326537055124356, 0.74702737583059908, 0.81120984303792054, 0.16758211766559994, 54.318503656591979 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.10912258680147857, 0.38916223159756902, 0.9614094226460651, 0.48227199852224267, 0.71458057752643789, 0.65084950405308339, 0.78418395759776927, 0.11007810793533435, 0.45314279365712973, 0.58745624513972872, 52.785466996249433 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.25722816058244347, 0.79990430563859805, 0.1041679570403331, 0.71347557747647539, 0.068175783437644633, 0.50573680290385836, 0.88057594523628091, 0.85727119967347876, 0.34730774245562301, 0.17025699103544334, 63.291220541743073 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.8838385254904646, 0.59686642612177443, 0.2093370358878881, 0.40656058913150916, 0.74315493573489799, 0.69010794353303928, 0.75339472489372517, 0.83701163363737208, 0.0067811756105095045, 0.71568886981583801, 99.393713779086369 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.73242917383062001, 0.85071434010328562, 0.89177138465848027, 0.41729426474950004, 0.27521849132879228, 0.3528071347397751, 0.026578244474926072, 0.49078119277169807, 0.75272200375385923, 0.51056740370056175, 37.109075850226326 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.2448784181446384, 0.16039398058504017, 0.53276031414787972, 0.9270088852747117, 0.94500757824229464, 0.63878542903856339, 0.94142032472803339, 0.41697792522267307, 0.081348605040042932, 0.45192240124315963, 67.644864296641288 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.85472505542199317, 0.037809724835705549, 0.40035395806020535, 0.89613697735524833, 0.18213774713684738, 0.9784421304590708, 0.36941223389166122, 0.43351516005400403, 0.95756475891089143, 0.72059976976336315, 50.569881183553058 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.676592058890503, 0.58393966052189017, 0.61471034482196651, 0.90267129739335206, 0.28923263530379184, 0.72417395806855511, 0.032912450187932429, 0.32246458604467154, 0.21843811905213972, 0.55022894180495241, 50.830863285954017 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.074259094908272538, 0.10591850145896076, 0.59192173141385274, 0.48941903039660151, 0.0016083829628975588, 0.72524935021652448, 0.063745411300379695, 0.50894020118668248, 0.36271844184848012, 0.53785646412656418, 83.900322117973118 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.72438526772791989, 0.62847112310438724, 0.44372981747939888, 0.97306992394651493, 0.87074959958804654, 0.85335223133828997, 0.41656081045830817, 0.76787844533072902, 0.28897509640391517, 0.97034682759362023, 16.301818049932947 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.52272708424330472, 0.8262790190360475, 0.47956686189910336, 0.27422790118112872, 0.51628450560789263, 0.26411517506856275, 0.8316752424007906, 0.25223586612043958, 0.65691603947764698, 0.29638046057884493, 64.22508293974596 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.66762820403650447, 0.077922446386888389, 0.39192877662306569, 0.21874206185775313, 0.33089926878281761, 0.59751915106821263, 0.50994226403453669, 0.55010070194682736, 0.81403927996526493, 0.3360818238231208, 40.297048851907014 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.87563336986430473, 0.2136728228524436, 0.84567165540952105, 0.1255410671714331, 0.87763183530817512, 0.4746234607686497, 0.38714169995728465, 0.45587976576943789, 0.99416661928293582, 0.20250069661164194, 72.592466221367786 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.90198389457671202, 0.97963840792384793, 0.12954555528888478, 0.74332160678928738, 0.39860831968263155, 0.64690657524185102, 0.11393398963209667, 0.53944470689350943, 0.97337872699943162, 0.071796066754759691, 98.92010092246683 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.86796476238178211, 0.021993385532545817, 0.73528512058625417, 0.84238335826659883, 0.28656322914057786, 0.83680713020565189, 0.85978598467030509, 0.22507990496913866, 0.12453920300854859, 0.74562204367688989, 71.635344988631971 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.045689542453813514, 0.26443515773124371, 0.36999904184280508, 0.84361185088473867, 0.019854596145003622, 0.47382662130212116, 0.12376961236769746, 0.66542773184242321, 0.20207794744416951, 0.10171561652263361, 18.619883236253244 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.39609884996548028, 0.10753497085154895, 0.85207966111647393, 0.60974387542643416, 0.90953788956350579, 0.73426865470136504, 0.4558501206768748, 0.43187432056325192, 0.66989724413204887, 0.81483793031006557, 42.739179652919503 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.45383263633064064, 0.50592168392116599, 0.59384613509774298, 0.85355125314280988, 0.71487423140436135, 0.088951866635827659, 0.32822833191814027, 0.79155015809972473, 0.75198304947228145, 0.19128426678894916, 3.4409948276961311 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.96808763836405598, 0.61919454157020737, 0.84153433671637834, 0.88125988748490935, 0.36176175719049952, 0.50638849771768324, 0.76830510470839208, 0.39103958937766836, 0.084427606181687098, 0.43508337869553537, 8.9370599467619716 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.28994658816660424, 0.93714614243848382, 0.44203167060357429, 0.7563943685584692, 0.16707411863538701, 0.98773406222489368, 0.56601889499334535, 0.54314599116409612, 0.64109498154232547, 0.11982361934184327, 90.888063607228133 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.69343657456073649, 0.31307356971767697, 0.18626363701375914, 0.85795642980228159, 0.74487295542215726, 0.52699065624094099, 0.52841545194152229, 0.49698211978386353, 0.59437475824207242, 0.39439271939096765, 78.135256446355385 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.86121921529347067, 0.14743883067794705, 0.073617797483285341, 0.50046608124362835, 0.38591563540945617, 0.4714515828853677, 0.8834869434530922, 0.53471890133594713, 0.57350308112233639, 0.44907757133058435, 41.565618333584176 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.28067508709796452, 0.55697551003215173, 0.9408961941010473, 0.27507285283822269, 0.56553620243618186, 0.62002681259183379, 0.071041540482416621, 0.49913934749989475, 0.98558386917805041, 0.85288074513249768, 66.281976864995244 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.18730066681425661, 0.50132726044317588, 0.45462841397663201, 0.32724927010955163, 0.090536312905646898, 0.60453342120806153, 0.69065958895112067, 0.87321026906065213, 0.70213684148564492, 0.51671152228949147, 23.568459737705005 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.94967468750920636, 0.29191144879178099, 0.68053640373757018, 0.98047197544715503, 0.28131217870996095, 0.62945178285687664, 0.43252170962979664, 0.85521558105739282, 0.80628645021701772, 0.85383371656853646, 16.227916868195212 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.15544328077527092, 0.6397281683013768, 0.45027204396731157, 0.69663553258804056, 0.71358466058985559, 0.14417449464971055, 0.88392481393857181, 0.14975776800713969, 0.51628829128083953, 0.16625932853491021, 73.030149564075288 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.34083782765510384, 0.74855128126157311, 0.72762530271358361, 0.18440877890459173, 0.22767440152850382, 0.92756797376395528, 0.17647459442969038, 0.10091604273336996, 0.082584070956312816, 0.95034824179010524, 62.214633301954251 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.98911495897835378, 0.67205569353128158, 0.13111707027153741, 0.87759867365342437, 0.6859761712774517, 0.5239251277773167, 0.94786849183984956, 0.25868057293835289, 0.51007474370165429, 0.21565772482746115, 49.183179021461456 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.13894822569766996, 0.4507314411255916, 0.5766064577010348, 0.50326501600801499, 0.56105313431155446, 0.28538419454705621, 0.37081838636561382, 0.380378894080177, 0.71460920825892305, 0.11663949741681034, 94.355819949997326 });
        }
    }
}
