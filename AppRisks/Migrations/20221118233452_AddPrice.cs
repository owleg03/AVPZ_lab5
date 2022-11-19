using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppRisks.Migrations
{
    /// <inheritdoc />
    public partial class AddPrice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "AdditionalPrice",
                table: "RiskExpertMarksCategories",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "EndPrice",
                table: "RiskExpertMarksCategories",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AdditionalPrice", "EndPrice" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AdditionalPrice", "EndPrice" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AdditionalPrice", "EndPrice" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksCategories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AdditionalPrice", "EndPrice" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.035174910558078309, 0.76182665834105101, 0.80583608225952297, 0.46327213084329588, 0.98252219520759354, 0.15036548248431558, 0.26935853645396046, 0.45617133828519496, 0.39103279997450557, 0.77639585516620946, 75.363463939913899 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.23450571096327677, 0.84646338915944364, 0.74825040336710913, 0.74062939214779933, 0.22555132171715853, 0.94452605556325886, 0.90564712042510631, 0.33202561090224481, 0.3257768757853079, 0.066997094002192559, 36.216641849907248 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.89815767751876363, 0.61601019265079127, 0.58550640619191174, 0.75925432858277275, 0.50232228310526816, 0.57577594665965992, 0.2304759320608315, 0.5099380485331898, 0.10303167405701663, 0.095300141482022815, 20.271584232990236 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.71167903695659063, 0.85856364013872866, 0.24184503553083359, 0.77409497761297186, 0.68905671700257953, 0.060772011379177315, 0.23546342346913274, 0.76619645371039813, 0.76575423583451518, 0.4627027017469677, 52.445662746139888 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.74294003829608923, 0.59160043331223999, 0.41201561572744372, 0.80855816652416168, 0.94030806291175084, 0.54588415041107596, 0.88191853970895828, 0.94625756660660354, 0.91281314725483109, 0.91345972864016112, 9.5984823756795183 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.65445782526561502, 0.1444094530518899, 0.88455310684839172, 0.074180808293603295, 0.40703813786830023, 0.34458155640786492, 0.47518649353125542, 0.75720573002665525, 0.30938073701425028, 0.76053554483008023, 46.447038225645144 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.96245865187606261, 0.083885880817057834, 0.05588202772175721, 0.2165996935421779, 0.60775774186839071, 0.73979617570035106, 0.76095991943344821, 0.17904319522491574, 0.046104754551762994, 0.81788753114983237, 50.538508953676455 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.48734876847723074, 0.50046827175673136, 0.16874369673410683, 0.21051945149812534, 0.5226870095589925, 0.13319817422545366, 0.15151292599401989, 0.49425163025866437, 0.85928499286220583, 0.68463214595800193, 61.52932992185427 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.59143516582005429, 0.39700366996541114, 0.78338625899281022, 0.90529870235423149, 0.96597017057863466, 0.17811939716609582, 0.10502556649880412, 0.27089089918176434, 0.8894112467894022, 0.71352366645357213, 62.804219917242257 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.027085318868870778, 0.43851090638157908, 0.52119723723963474, 0.7380247115087486, 0.56229425324205984, 0.63357178193508523, 0.095580593437908035, 0.39885332538319362, 0.9316661011133438, 0.73372361846636669, 5.4565072124622693 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.018942453664160808, 0.60419163701461476, 0.78395173523614592, 0.31041678449113608, 0.37689919167886443, 0.060410004176147836, 0.07189533029465045, 0.59050231789481622, 0.54844282716109694, 0.41099712973042724, 77.957117600536336 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.35100358073721838, 0.2057369821832481, 0.05827723847268973, 0.9139113755080408, 0.22256872363344438, 0.4947641242298384, 0.90925673514111316, 0.57199498998696541, 0.44207571857127304, 0.62259679843125071, 92.038459082934523 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.91891854655387195, 0.76158332324232902, 0.56714023990048235, 0.93035978542945796, 0.097535088350928167, 0.59862070869988815, 0.63486249511007919, 0.76446116657799057, 0.93179994621664131, 0.35435445646058961, 57.136187648747807 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.23129263697381497, 0.51310631675063423, 0.76590157301460104, 0.35713791798854444, 0.61605842932261723, 0.53420607379098084, 0.063423185568432738, 0.49729793651651044, 0.2037116205803724, 0.03948852889284693, 50.379981766246992 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.015076449639830569, 0.89763565953498381, 0.72946200222072366, 0.89126129718326985, 0.015515716957373971, 0.98533597410655727, 0.26534723687632267, 0.89043343837399691, 0.086971935793649036, 0.50991521082439462, 0.89539672577927387 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.74225691422825013, 0.2212651006846954, 0.17549262725239723, 0.90806036319281336, 0.70205224151674694, 0.89062238228006707, 0.45395578020231064, 0.47519996819147203, 0.086132308956089476, 0.42343936496367229, 14.313430758974032 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.6135458901815859, 0.0005584391061491667, 0.96487134739918889, 0.93578437454795593, 0.97712833965621282, 0.85139833274794585, 0.55686347987088858, 0.30364414803791651, 0.21423206687344909, 0.12373460149457505, 43.269027960737894 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.062934503110708029, 0.72836102809587033, 0.9936364721782901, 0.97358195568359995, 0.67370240043483887, 0.094975715556423812, 0.51511199738233526, 0.88289959768313386, 0.038741174972642289, 0.50497841801587262, 14.501639740450667 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.035409659581757458, 0.9692001504907336, 0.5099469222165316, 0.81429436508173103, 0.2294585918301083, 0.21111272786104041, 0.2922842604841619, 0.1190162857010526, 0.36006632324087817, 0.2618413880910776, 75.572348137687044 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.80836694865896164, 0.14235409267696675, 0.15295871690429808, 0.85964318249894534, 0.88691307955797083, 0.918375905138062, 0.56038674556911749, 0.46196728214110505, 0.53358669795985703, 0.76718833189714297, 21.667472567727387 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.50606985832405971, 0.98569855697095321, 0.83833976262583609, 0.9205829933270846, 0.43602189616206311, 0.54518218715603717, 0.054443551883639141, 0.42813288689157303, 0.5506246051310234, 0.72852811472757173, 51.717098329609279 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.0040805703227504431, 0.52485920976389744, 0.21606422478297171, 0.48167012025964351, 0.77013869906547305, 0.86045734591737222, 0.10631977024814121, 0.47074536407318168, 0.088168447678528605, 0.031553077636609306, 63.661684368787398 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.37816858018537547, 0.26465719311063507, 0.72706459922979105, 0.21422412272189184, 0.38323406174281316, 0.12583863126725814, 0.34648911382781955, 0.09816483374122853, 0.36035588627018023, 0.40343744215218047, 23.625903706119367 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.11489251529492983, 0.68830813441560068, 0.93697744555746643, 0.42345865111630598, 0.31957710524681726, 0.32653627381116979, 0.39340399742954368, 0.13297465518042628, 0.51007348851465872, 0.43058868674188966, 27.513863719258147 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.22045979090018719, 0.30932588479196144, 0.50809301387561734, 0.34428306822595212, 0.090503855399675204, 0.95993797249584367, 0.45159875578747755, 0.56566944718947454, 0.046142015505671763, 0.89105423488504321, 31.851466398885929 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.23721433829086436, 0.30692397875251776, 0.84063053794795994, 0.39531984134428644, 0.14016761381194809, 0.50676236890110715, 0.36946005423998451, 0.01137809838842363, 0.43641579393804031, 0.26278193048686305, 90.943105762553856 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.93931140371312727, 0.3553870762865351, 0.061662530242067026, 0.62484073289674857, 0.4852599432155682, 0.26559683574570925, 0.13266904839767879, 0.72458691540448994, 0.99876737347731748, 0.099372655665034615, 6.9075906307815789 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.073097283469427676, 0.59003755723024953, 0.66284609216117463, 0.07998914426163839, 0.28624331838890182, 0.51245507443921168, 0.74139675475378786, 0.86297177163417949, 0.93874602299392984, 0.26764764721011391, 1.958439938828338 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.13483868412982758, 0.053821674019367771, 0.75163949390719131, 0.56772554150815036, 0.34369866157779227, 0.99662111859305025, 0.073625758217892745, 0.3094065620170694, 0.9881791713235657, 0.27699909041026904, 97.530691659091758 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.93609573870054319, 0.9824284142573696, 0.53674721572780415, 0.36610831297064639, 0.94995425619390927, 0.035004852634977213, 0.39724386041292103, 0.040918981574475044, 0.91260389766165106, 0.94010547652976983, 27.368334717868635 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.13073976764591477, 0.40243545051049734, 0.55520777415248856, 0.12771182199773079, 0.29105968229066503, 0.20378567470653031, 0.82627617309122448, 0.72492365617114007, 0.032318363768515601, 0.27152833517451169, 48.406763565094948 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.39284941254134054, 0.85460040059704634, 0.47644753439335119, 0.092270751741901802, 0.29687378294431976, 0.29752380831548253, 0.72646714761727216, 0.63120144838896208, 0.52564532359710858, 0.68184449710748285, 25.24027096744782 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.51897214672334746, 0.096657579429446638, 0.89317656312170635, 0.17577332655216604, 0.30606906828861336, 0.55162747906083298, 0.76176448800656038, 0.64280069569568321, 0.19386181494517885, 0.68201434687670048, 28.967035593529101 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.31727835315044428, 0.64931141334740006, 0.61663696367059262, 0.85320659983792746, 0.99915556106023296, 0.28774021847429199, 0.99703503957245887, 0.57308611353785188, 0.36307490340068849, 0.63695684715383072, 29.804546457194881 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.10194898467802405, 0.37589096645060249, 0.58941848260416285, 0.21274049612143953, 0.79879324309555566, 0.29031234069854439, 0.054235541555592404, 0.24995958425001796, 0.85689110457270368, 0.7147821084205217, 0.71631499243854924 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.060562012443497459, 0.08019813947381238, 0.24081387393942488, 0.8194755310695514, 0.7175263718331879, 0.055083055823321625, 0.89639665456767359, 0.22103101956679627, 0.099756416636199274, 0.18532606730552903, 48.729985845973623 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.74880741274742779, 0.60638200351084814, 0.23175377795844121, 0.92489257143186976, 0.2976198403691096, 0.39300018308399753, 0.33613390758924766, 0.72572621471850463, 0.41138038311489744, 0.67357235936669035, 28.784745496049101 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.9626059283976135, 0.51085037558649438, 0.16743128495903392, 0.007969816553375586, 0.84660685114904533, 0.29591571643138725, 0.89797456609667792, 0.32649454968008973, 0.20573008706914708, 0.56183653199892991, 45.128233166206208 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.30800851838980137, 0.070449434228634034, 0.71147325549151585, 0.37183534467922474, 0.56743423360016387, 0.40421622561670711, 0.098619246690206164, 0.5931140192769554, 0.91993791194532137, 0.91506710468251062, 22.716676524353417 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.018555478454457708, 0.40652186077810681, 0.8656338997940809, 0.30773891747434712, 0.18781874188896563, 0.39145668478835671, 0.75457170005463703, 0.8344200893338295, 0.60629257129205649, 0.11087389713307882, 62.762996657110627 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.51065100121480955, 0.59725838981397406, 0.2218944988345205, 0.87439062927194067, 0.54572730220984533, 0.37877107324222137, 0.78254946046263096, 0.8347540060176647, 0.39369955286657543, 0.336896461436751, 64.6861749880389 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdditionalPrice",
                table: "RiskExpertMarksCategories");

            migrationBuilder.DropColumn(
                name: "EndPrice",
                table: "RiskExpertMarksCategories");

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.20589088926922361, 0.65794614969860865, 0.4231277966000786, 0.34527329900864745, 0.86034850959121256, 0.34967336272829941, 0.18130408844395585, 0.64615524460080154, 0.3855789188813572, 0.49524639788925751, 37.274854625393573 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.12380236930051991, 0.92652212339464046, 0.61142111866056714, 0.061239506207874883, 0.095123298107197662, 0.15750519326230894, 0.65120042619226337, 0.40881270822565052, 0.47435175089346426, 0.20116934085365978, 90.512287184800073 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.10637350222785702, 0.87905602726439569, 0.12713807194854565, 0.34852943811541204, 0.34665579761081033, 0.29378005060740064, 0.66459308340092815, 0.68736928431408972, 0.8156449998632499, 0.99322420238588915, 54.789918794136774 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.65079262114819991, 0.56656553427970846, 0.61125978033387041, 0.30664533930941229, 0.26770128269011695, 0.77760927122925971, 0.82056738243738536, 0.26201327441272371, 0.88881404628753435, 0.073835942047944636, 83.954438039792961 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.40885104569793096, 0.20654012312243875, 0.31258980119452884, 0.73591593513375209, 0.3591732347700588, 0.051681858761880473, 0.70973281203369709, 0.49738117943535964, 0.15499309417217999, 0.22745272158171737, 23.286520664823318 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.28937930099911691, 0.46079767170339503, 0.29018639814252867, 0.72594429170895636, 0.77612096948961362, 0.3234060869328349, 0.89844235446415965, 0.66690334117231387, 0.82051003564928782, 0.95409576043209754, 62.612407616067543 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.75186445142508063, 0.52241895074707323, 0.57960699108964842, 0.81492297815869219, 0.35376115129399355, 0.65261059412987965, 0.40476921368008167, 0.8629130080180476, 0.77030881974880094, 0.15680421632073394, 26.443040433814058 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.74973145366200133, 0.33674585862466688, 0.75056875511703591, 0.44908161085164089, 0.64082797671712477, 0.77695358197403031, 0.46694947847656298, 0.83369478010666331, 0.40038888104342685, 0.48390510364726524, 7.4671848291146485 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.98860992192771169, 0.41817151337802416, 0.067977101563138187, 0.94313983971714777, 0.11996338568380494, 0.66662585336574565, 0.22187518182497756, 0.57378010016126701, 0.75990500895345869, 0.51042505454270892, 29.789045528833757 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.94560302717641176, 0.13809727976608632, 0.40062931908100119, 0.32244405030605572, 0.92533346756264956, 0.93467439935026442, 0.62920603274251186, 0.80635480456853559, 0.59595624127883118, 0.32877829495415156, 52.202957488813048 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.50827044414418054, 0.35015330404596312, 0.1208360916702923, 0.25647061823754902, 0.21955824436519444, 0.23043216295397284, 0.8643792912934517, 0.62180893638824064, 0.17273254199686106, 0.87398381387766311, 41.892845490243388 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.57812907101866062, 0.68599372659132618, 0.57736598338332301, 0.52077550231770997, 0.71153894224486347, 0.27888671020730049, 0.32958873112707843, 0.93928237420970995, 0.9677726668430765, 0.30269446677703338, 92.079359135109357 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.49368716601984963, 0.61808074935965385, 0.52959365671915348, 0.84324691624302994, 0.10094308931648177, 0.79455223192044722, 0.2265352839632071, 0.70899773274148425, 0.90432852136902697, 0.04103075817828894, 82.299149697034295 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.4259564875799825, 0.69947909112938789, 0.24551138992668864, 0.70822399170898986, 0.4117869586518601, 0.37293109812308878, 0.75948998921330901, 0.30167975926466717, 0.40441509806736131, 0.29820568218481702, 92.45585294660917 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.37132439794898675, 0.29500370996473779, 0.32012107325509487, 0.96199854122044837, 0.1235539191292625, 0.82812806724826571, 0.067422734987947819, 0.9765312452588073, 0.71133458556735896, 0.62255554493673038, 42.943872564612981 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.5103787880084607, 0.082053898299962569, 0.76820896709188102, 0.1225009802698237, 0.3471361019812027, 0.81967662155605825, 0.16156100667002871, 0.65473773992387352, 0.50234683914836231, 0.94534712589259062, 49.47999583995523 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.58741507997945652, 0.4298744012241893, 0.0054098654459200368, 0.66185257706544109, 0.065741220668977474, 0.25785102492871381, 0.309954917963982, 0.08522285974046806, 0.18244704755061858, 0.22611076492261606, 58.027889067937387 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.055304583352584258, 0.98608604052989968, 0.59708718610462963, 0.63070283788367698, 0.59168485333840937, 0.91504752118207011, 0.38082251510476239, 0.084365148627930764, 0.5992819078501781, 0.64008036353843556, 24.447418356634543 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.1427962547246896, 0.48524755268202358, 0.012506103252344358, 0.64353927360316143, 0.63361185689547672, 0.77065304297796211, 0.86484841477828878, 0.44399795224515293, 0.75121915200503908, 0.81618741750431811, 11.170586548921936 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.81048978250056358, 0.76346153445572995, 0.26135926213829519, 0.82500735816896187, 0.37276279714694061, 0.66667674931627197, 0.94902168583477409, 0.75931337472337768, 0.32901160058102064, 0.69149936443850857, 92.787345297295033 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.30912623796482008, 0.45754055516635173, 0.10825765074661309, 0.21290134114633452, 0.35537589263422364, 0.84081292301081267, 0.6572315780160507, 0.056850672919020906, 0.063537909503279644, 0.90066665455045058, 79.05488968073908 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.096164452498272768, 0.28483556075567273, 0.89051044519102063, 0.9470143792588942, 0.21817163281649965, 0.53298288065506105, 0.21325273034151826, 0.1079180022247257, 0.20757184132286233, 0.96722551715700089, 82.255255937940788 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.50141052204772429, 0.89413369230409789, 0.72554751311596799, 0.36367688598584591, 0.30153935679166088, 0.40280283984048859, 0.87756622595375233, 0.91019572659079528, 0.77559935194320828, 0.077320712200692698, 50.96549190701689 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.41214088758518841, 0.36871100718041461, 0.35908291914158741, 0.39663993154055288, 0.53147911666078718, 0.80186146597450314, 0.44442313628007424, 0.29854984019201669, 0.23014106882543817, 0.20278187446371598, 97.429307624584808 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.27814773308971907, 0.72640533617142222, 0.9031729615362859, 0.79064834739591139, 0.63485515782720559, 0.28956071721481769, 0.58760332373465085, 0.18557663302503757, 0.44925909022552624, 0.3469664312694134, 70.117361022544472 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.9315943197660973, 0.77688818122196557, 0.53774335319405897, 0.38181393769990868, 0.69752926244233626, 0.72607225655216145, 0.44635751711338478, 0.99188989669948247, 0.13541256476023866, 0.2865408576124876, 48.44854503654944 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.89987092874406382, 0.85146829205452179, 0.30569481902788675, 0.98091653472701479, 0.17875051108531625, 0.74801870417498628, 0.42669444574136406, 0.55012896856324556, 0.35858752785658277, 0.0052455433609780444, 97.395137558908047 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.11313928559852959, 0.15452502065786611, 0.45910914995069374, 0.22889907761682737, 0.48782795794806344, 0.88571913323675888, 0.049562756887254422, 0.52085391572769768, 0.18755148570201807, 0.47683255557811521, 84.66020266495579 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.89635043566323302, 0.70702778499389352, 0.61052358129625572, 0.012707972520195399, 0.39518653408764515, 0.77235097195272084, 0.78472058346871087, 0.44976230527529892, 0.39529261293133844, 0.80496101295616163, 8.5301694481186843 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.031173919042587372, 0.2932132636747703, 0.53927030909319762, 0.57471219207030377, 0.32390684437836725, 0.95728663798807667, 0.14900385597226629, 0.62560223946919558, 0.41936198848320472, 0.76768773721279826, 45.113363668016738 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.29561451310684606, 0.1170178086286684, 0.93321824139965315, 0.098996143018243221, 0.9045435401534041, 0.055131388239169743, 0.88082269720873141, 0.67874873518986134, 0.4901342578771869, 0.13712441005167564, 92.948181762768783 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.47103642093302112, 0.71731775804650322, 0.59323854823489397, 0.90021672093171079, 0.95886493111999216, 0.60753866557048175, 0.83582771939327394, 0.004943760859657198, 0.4352630364942851, 0.30051639423747045, 35.76069783469876 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.10143875796381285, 0.94415677144521315, 0.063609425873433989, 0.87661784125018594, 0.17377280967040576, 0.022964903766168665, 0.84778064237366624, 0.63388116909915593, 0.12922604821073913, 0.4653262975530994, 82.413553540991231 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.99188848344624547, 0.22239112228380875, 0.17730775384045105, 0.26880133576368537, 0.68523688188764442, 0.58901772846899636, 0.25204559280711103, 0.092082912049862076, 0.21074364477533614, 0.82095187110798185, 3.9523228558903001 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.90874803423879236, 0.94176710584355028, 0.80593808221395569, 0.080348015573901921, 0.13641557600888621, 0.36405724141271323, 0.92055177967629587, 0.52518228731755734, 0.05814714063672044, 0.39397520810466979, 50.903457739407401 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.13963568356592804, 0.69295833212101887, 0.64293172043184066, 0.52212149441117983, 0.70415933271124076, 0.21940126496000911, 0.75491239766687956, 0.62956136577856281, 0.57113098750809543, 0.99565317875683679, 98.181330383894419 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.53748663132081975, 0.57009638512963223, 0.32285832505907497, 0.41497845973112613, 0.21339823553833348, 0.25831592866118869, 0.80693413641865641, 0.017791738267778356, 0.8388743682635188, 0.6703235386516897, 94.681364120998623 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.641043888027375, 0.81908990908070323, 0.5269647859347919, 0.6241794244840948, 0.37842786796741146, 0.88734973255754257, 0.56055894420830099, 0.37274828336080035, 0.62296303722033763, 0.36660579496064205, 93.223013499167976 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.14072524895123861, 0.60120824614992163, 0.16857919913900421, 0.017354965668574973, 0.31875151140564451, 0.82439250758024363, 0.35762790173621539, 0.99139542940180014, 0.88611280318368646, 0.51848448237839684, 21.195962012032965 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.97804896248504247, 0.0050943979961757258, 0.25869858263262324, 0.10920896254729384, 0.51701926978967527, 0.73945606319260448, 0.36552379923831557, 0.043216470712239774, 0.2225446573694444, 0.4941611717559532, 16.879981190474414 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.70806473282515758, 0.65026462469172785, 0.24969882747608541, 0.0011320858069849837, 0.1970131794861294, 0.759609695727962, 0.3699544232923071, 0.035458875238485454, 0.81574551477836921, 0.13356858644011527, 80.244919260060456 });
        }
    }
}
