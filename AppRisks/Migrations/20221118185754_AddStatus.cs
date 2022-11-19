using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppRisks.Migrations
{
    /// <inheritdoc />
    public partial class AddStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Status",
                table: "RiskExpertMarksEnumerable",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Total",
                table: "RiskExpertMarksCategories",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Total",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Total",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Total",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Total",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.157538429029216, 0.45730413938130166, 0.2229158883671688, 0.8311548944416195, 0.91821978255281023, 0.31953357804770111, 0.025169686646124401, 0.32537604057115377, 0.45077894267238583, 0.5614230972998181, 17.931118337084527, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.80657485189887679, 0.19673489740513395, 0.76748836221507821, 0.24145661726430745, 0.31904596881032721, 0.1318754241964083, 0.39410135156377302, 0.97055803776708793, 0.017981058955512275, 0.48424885606342427, 0.077203949970361396, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.2681270176085192, 0.2918623971333062, 0.62576284245748359, 0.69931746607355061, 0.82750232189018713, 0.54553474374841715, 0.83141611885577815, 0.078800033833180017, 0.75831056072067904, 0.94832771423381856, 6.0617084011544424, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.72770987894934469, 0.057599996335092385, 0.85389450821087576, 0.32995475412760744, 0.55840880366444623, 0.88714888758352073, 0.28805661819246631, 0.16519710730540116, 0.75297628295826113, 0.42596998431253175, 9.8495115564723683, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.97096776948097374, 0.32197765820501978, 0.19434290253838871, 0.49775187340032345, 0.52111551392115441, 0.94796671544717814, 0.12501347804203167, 0.22900603239281625, 0.75364089066252538, 0.23074524875842217, 60.261720680039708, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.78010863358111648, 0.10928241539795136, 0.96550564450030463, 0.0084458055194763793, 0.87591982193372719, 0.28221633316510197, 0.83960038848984353, 0.83736040998761918, 0.38358721259409634, 0.17217554321622175, 21.127042515594098, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.238584800682903, 0.62384891556092448, 0.045989087932855499, 0.46420293388109835, 0.24791066383247173, 0.75444740055414772, 0.61509524637137869, 0.87626650730392996, 0.53776096868431189, 0.085046820472281959, 65.042978627721553, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.9608608372986055, 0.32291984276848773, 0.88940391447433065, 0.27495095487181442, 0.17080325370329985, 0.60302158567312392, 0.071224708129308478, 0.9130017240593683, 0.2302001218181412, 0.90294200793432211, 4.7187107671330057, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.39009051305614628, 0.060456998756257985, 0.10242880776229923, 0.40192442730258626, 0.896544330546584, 0.87954130038272238, 0.75305832188417798, 0.024773848490638462, 0.9942528286034561, 0.2924106340894449, 24.93724011306384, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.66189289487874192, 0.9581171924973817, 0.65124415779098133, 0.56993017634698528, 0.029979724757829063, 0.30712279112492236, 0.94977542854570507, 0.39199199226038062, 0.17222676108858992, 0.55971533128015882, 43.200909335320404, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.83565649536920239, 0.67928901628291549, 0.17516165676004092, 0.28461399525134468, 0.77293072892946701, 0.29079772077305777, 0.32515417292900672, 0.25743185503660704, 0.26314303432057706, 0.62917017271281861, 16.199487763529962, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.78904281582620694, 0.0055213994148901602, 0.56513411065084784, 0.93499475272293653, 0.85276799332296638, 0.26814097353115818, 0.66247520468959831, 0.14485458677109375, 0.99998492619941703, 0.59461986797678024, 97.409502332269128, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.93746784108837677, 0.81916357029582765, 0.25020711393198136, 0.62968169425516274, 0.31739287769831093, 0.84010106526565065, 0.88472680286729921, 0.11735891826946387, 0.23049197345494887, 0.8608487035379393, 22.170079927074514, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.72365988505331702, 0.12562769498081061, 0.68099018623494156, 0.42170868682269569, 0.73588673029898166, 0.21285433590738834, 0.074250347167324926, 0.11270121815372003, 0.28128162978065063, 0.70809586832692983, 84.446575975407811, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.22884599330354849, 0.56504146256355103, 0.52875308931519227, 0.89359576193021995, 0.83251513276244693, 0.073525465941459256, 0.2599901018392724, 0.25910916701558362, 0.407960131400535, 0.26668613657570039, 0.81249477113395363, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.95027192646210412, 0.12504836014432541, 0.75590074836842935, 0.68429938537300894, 0.20819619608662943, 0.82452092313539294, 0.89395529858344014, 0.034125115874023559, 0.64729846355300857, 0.18241834872537144, 71.85487335610614, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.36257743189585179, 0.12107103313037659, 0.25959396076428098, 0.44429971950434088, 0.091148838796456078, 0.40156276788405021, 0.18130494737341174, 0.7721769094229689, 0.37716639493290438, 0.37208191830775883, 79.055058932558154, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.69050720683721534, 0.4598704854784994, 0.66659319178889231, 0.40139680237570485, 0.10917536920728121, 0.12335678527652405, 0.20127463757751551, 0.77106491489347373, 0.32167219779389067, 0.7220140616473234, 38.266522649804671, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.22799851879981725, 0.92642078794206839, 0.58555345365387912, 0.73587385514204873, 0.34293271504607947, 0.12847106217334536, 0.8391285028756037, 0.25804007855594602, 0.39414747133498296, 0.80776510133164625, 16.634131409810916, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.24231009332558051, 0.73954637308490456, 0.71141242270265526, 0.92188428498430797, 0.17253270126545284, 0.98750820677627194, 0.25957435734582746, 0.720980029804974, 0.45982638035477719, 0.61500120314614726, 61.907040024225545, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.81655307482115758, 0.42587950617266124, 0.85916485828144651, 0.7542531242652003, 0.033359814267528876, 0.930649356054152, 0.54794289750024228, 0.17867202370264912, 0.075220522443955606, 0.87027391213741423, 67.086356987916915, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.70901012609124325, 0.56487201286456834, 0.63331259021466724, 0.21620850272184156, 0.80450320194824587, 0.56480281608873706, 0.83817072438193341, 0.27889448161037933, 0.54435270599958063, 0.24826398960950968, 56.500139421144105, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.7773734317942278, 0.52521156414823755, 0.26266698440553515, 0.20141829480919704, 0.93444467745054105, 0.68050314151772728, 0.30178254049978859, 0.66218162646928846, 0.13939586169025187, 0.025578000211027407, 44.864969012317054, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.01564625027516453, 0.17645971148003481, 0.91698190269020419, 0.67823100155873761, 0.78162057061598245, 0.65101199058890202, 0.0026938234074925793, 0.26031251194093863, 0.68460351816493159, 0.66214696909755155, 33.882398604908012, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.44490210271389496, 0.98787638645151932, 0.69995817768366864, 0.065670199761925674, 0.10479789625666491, 0.051522267211779105, 0.86100771628281991, 0.82260160032272989, 0.25952049690428436, 0.89676050011437602, 38.725766408155707, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.5020616042935756, 0.59653235667560889, 0.53564859422402433, 0.070553409493413821, 0.09513507874382432, 0.035508194873874244, 0.30036037326179255, 0.569082927090658, 0.73375921479613815, 0.63790732248312154, 70.076670922327878, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.36834156454418621, 0.2895238449633335, 0.076258603076811204, 0.26948160609084815, 0.90189794192497064, 0.076077573810880095, 0.98911730244528484, 0.45373282801565418, 0.03969338566777092, 0.91234205528519718, 14.151852278462995, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.83851115043151425, 0.01559109345358789, 0.91038306158976012, 0.31134940615110573, 0.75319575296682995, 0.32401152732616145, 0.61501156009855729, 0.0050685477196300566, 0.52828206514394593, 0.79890992452294785, 22.478010296016414, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.55408161080076901, 0.65815981291052805, 0.16218991259066395, 0.18037787104122149, 0.50343613100149909, 0.30346807868252568, 0.079397241838159549, 0.044398269196305518, 0.36453429099202628, 0.52221989114367973, 58.387399581908163, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.36301860256826757, 0.057304795158132249, 0.29624017751290388, 0.61091350750884166, 0.2685340057992166, 0.86049575799735556, 0.88707291494488805, 0.14754670713531115, 0.34016921936518485, 0.67146862910303373, 11.866500781154842, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.069614212487827287, 0.4890924499306023, 0.95630740744928455, 0.52065768469780138, 0.88433106379622162, 0.32906720641281872, 0.89140053715350809, 0.78401673325838561, 0.9019683612677003, 0.21094477657694577, 47.346828209771871, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.37131899662690038, 0.8783016711742182, 0.6769115638678348, 0.068492525660482695, 0.79395283766601821, 0.89449396641435985, 0.050229278907802599, 0.11835510283891248, 0.029270066211650958, 0.60584106933962745, 26.839532522732558, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.74178945207473646, 0.59586024148185157, 0.58376107025567003, 0.86618815862167553, 0.69611572636658503, 0.15730196890809589, 0.17512944629349514, 0.90262130389425033, 0.67543512519502635, 0.52852902516647271, 53.465147339276733, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.073017470774985327, 0.37291471117735586, 0.12371631155640628, 0.47216581134317481, 0.88152326741213083, 0.76249283026698711, 0.96570396061987152, 0.78989514919723647, 0.16389707827611266, 0.7555947837225897, 29.832344192163539, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.83249879833569007, 0.23353268063764088, 0.20973687207964786, 0.3140442615690594, 0.26885319805600305, 0.20418160370098482, 0.94813357733161041, 0.46067374124519078, 0.96570825298342733, 0.13555713250350165, 96.837101895009084, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.60262182483252791, 0.90025848788406782, 0.64905327686725589, 0.96519455405541266, 0.23184996772378663, 0.052775514143836744, 0.75398060072674755, 0.57435322405451161, 0.075719690830712616, 0.50057678043940024, 92.063862570840513, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.79677252394159936, 0.50082463954240508, 0.97137868631320345, 0.51638207366754985, 0.66034011638039536, 0.8962306845921989, 0.79595360266194082, 0.94767787503949918, 0.2472673398268197, 0.75649394072788401, 24.799767097601912, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.68470288276641911, 0.97812287410981058, 0.68944578355668362, 0.5489981640221131, 0.94226597431631032, 0.39882828386767244, 0.89186644941126203, 0.21064045251427166, 0.7882517732757538, 0.56134976562426164, 0.79207456454425396, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.095132898973479874, 0.57514283066049321, 0.12067191622471174, 0.95820285757247625, 0.0078221891871500526, 0.7794660561862945, 0.25627909122537451, 0.055033827145955061, 0.015184549748391785, 0.88237709910257911, 50.497538205481305, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.48612529493762691, 0.072655085805870212, 0.92600010339626482, 0.92302824559181762, 0.26996089074573226, 0.84909421609532842, 0.14194484771920712, 0.74484796285409749, 0.74090696546985024, 0.69742388907039832, 27.029804030446581, 0.0 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.90057081259672533, 0.69997398942884059, 0.42562987877970238, 0.66352682645523897, 0.56127698510267476, 0.4645182260408125, 0.20809778469991957, 0.29921203031171473, 0.34967033937403924, 0.33278787325672787, 64.324421145838627, 0.0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "RiskExpertMarksEnumerable");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "RiskExpertMarksCategories");

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.050213926790997121, 0.57833744693321154, 0.79379503066817247, 0.12825133520952869, 0.59386575671621777, 0.24733112148038416, 0.097741830210055669, 0.93878099560557171, 0.56942277290697196, 0.98434465657711812, 36.725582199736237 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.49321232167228113, 0.44599479635570149, 0.076304980174168757, 0.71822544437319036, 0.20124776008152012, 0.53227886772226063, 0.43607271528941038, 0.86319812313034772, 0.60370814001581286, 0.83327445066046046, 36.087539775431843 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.91862838945690206, 0.23010805496220776, 0.87822056722858255, 0.048742434056848638, 0.76832443603432221, 0.57041235006440039, 0.090579503114042725, 0.62812141509771435, 0.48029633336788391, 0.1663591405335797, 28.643086280145724 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.48181899733308409, 0.27804299720586523, 0.76548864983579901, 0.33342408406304624, 0.4824302405944686, 0.18027198880040529, 0.25929400829720406, 0.87129672229201838, 0.55903570761394772, 0.043236706473011921, 11.995047172416129 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.27565653819720337, 0.16283069504391956, 0.82079545076727589, 0.94471312819185949, 0.53172176287761796, 0.66386335534107388, 0.30794589717384901, 0.47794631313550084, 0.81900762911456904, 0.73105154121666494, 14.146554692583335 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.98180715354703574, 0.36777158821026557, 0.45159014663766295, 0.60943001692799448, 0.89641100504856575, 0.013818566316252112, 0.80664367740885645, 0.41297469943563725, 0.79296751678041966, 0.99202475141411028, 7.8620892895004175 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.2520982651464948, 0.28367276717227574, 0.063832740482093753, 0.10257551114444607, 0.26308881080266155, 0.34104409175312445, 0.40283177411188298, 0.35369863548190561, 0.46802388896824665, 0.37384717736444517, 59.100033700195397 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.84428630984849917, 0.56406048492787597, 0.61379251783214805, 0.14089221745590153, 0.99694127875769434, 0.24766701893528742, 0.10363171836941054, 0.95822756367060269, 0.43337009129950743, 0.179170579110283, 66.991159301294729 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.033021415968581991, 0.41763061548529723, 0.94497700364903148, 0.064003240512900628, 0.88664867188057206, 0.89242736556230196, 0.92737229609336236, 0.56231801519534075, 0.63695206648512137, 0.57561473971058619, 92.999603748874165 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.56092555551967493, 0.40714017753806553, 0.82926157602288986, 0.49868128950147983, 0.97937491807310328, 0.32272016462681696, 0.45488730991717263, 0.20494604130431948, 0.32275961320190416, 0.86579207693975391, 81.373039816620405 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.52881229062902024, 0.41973337665969235, 0.56146398473048542, 0.35235879076115362, 0.13125712086875074, 0.66662004148139509, 0.01689200977931038, 0.86158369974201532, 0.24730936214218013, 0.39973512435562519, 72.853384485523591 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.62039871382400791, 0.20813955244707116, 0.46517090205625422, 0.0015682121115752068, 0.31389790934697204, 0.3316223703216945, 0.24210636754616, 0.36061362329475477, 0.44458871466392713, 0.89140156177769669, 67.224072921045149 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.25663090464054428, 0.00086611551249715646, 0.82469797540146295, 0.16090569120835274, 0.13323346143166581, 0.47842571669423495, 0.84484217112877824, 0.64433002985896959, 0.19357119681898272, 0.018463464815208441, 91.238033446697642 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.92990323648676088, 0.5298822205317778, 0.38105374052870999, 0.4755168514953414, 0.71258504652843102, 0.52140948633176709, 0.72499277216355495, 0.26890329958208359, 0.59548324151403986, 0.53537578209553838, 11.230744427127636 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.13548403457354685, 0.061897284118960005, 0.10528296513623625, 0.64111303633624173, 0.86227048026590603, 0.9196716914131754, 0.29835564207017495, 0.93339003596302084, 0.65383861741652971, 0.21059436242724827, 41.16096100019594 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.36279419672350222, 0.72922675304756024, 0.78269208692786318, 0.20332841523495471, 0.041042234803744582, 0.060587861930606723, 0.12078972947195843, 0.92400206806052532, 0.77953196945551095, 0.13896559392115704, 25.256833829899016 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.95765056785455183, 0.45669563830612026, 0.59280181650999908, 0.32607419267857429, 0.18754720385318202, 0.884619035274535, 0.93949641216193236, 0.45828163795976873, 0.48360664893487315, 0.51875962739195314, 73.107234905496412 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.95473274111474793, 0.99432997415599578, 0.88246089246231718, 0.96421724607583292, 0.72182100210144373, 0.13334121294182055, 0.67127184355696756, 0.94646952690185338, 0.78841910818144079, 0.58567053484920784, 45.550974183117688 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.064567868616540514, 0.49288125312637443, 0.91096335737158296, 0.38547219295495749, 0.31385716170432154, 0.35534535849380755, 0.59893833875418601, 0.58141424027776634, 0.2558364816950961, 0.49750570462172394, 9.4684098601222182 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.82967882877159727, 0.2991910749442398, 0.87449629224060721, 0.4072967784819731, 0.93458933743275374, 0.34129755666192274, 0.95215321324850177, 0.85384814157536959, 0.88172706321797778, 0.89789523504157132, 30.014625291907425 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.15851302545551238, 0.22434163494310699, 0.38518836386933475, 0.73772200289425494, 0.18680714193922021, 0.62275203354146447, 0.25153910227114906, 0.75223304493127574, 0.93874828298752011, 0.95124434965591398, 49.157248839437692 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.23238603832602411, 0.74863283765127953, 0.98459652580686186, 0.58339887225975662, 0.030055802181119695, 0.56510150983271423, 0.43708991390631713, 0.7387500935203517, 0.43607465844047311, 0.84138582889449609, 56.946281065732165 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.17702184490969353, 0.58058458142896363, 0.83813160442068868, 0.74509934076221507, 0.99488351583600054, 0.43610735126540323, 0.65060582299887115, 0.69728227648231067, 0.23164148154264608, 0.86310153631179787, 40.311538926678622 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.60343116713358624, 0.43853745043476977, 0.15981042534188716, 0.46490674062386306, 0.94980036432469817, 0.62673590519219224, 0.9091684115668095, 0.95062936390682851, 0.14273514933398801, 0.74286726741109377, 5.049630883276679 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.81606477883633699, 0.86772118510062146, 0.99812833174875382, 0.29109526794766705, 0.19407934281524153, 0.017584666970292595, 0.86731607152355383, 0.52640791703151057, 0.17040463193629851, 0.016208013774837493, 94.446091066615296 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.64755723928405073, 0.53983598518846276, 0.98891206412739296, 0.86286997557962375, 0.18446980640545507, 0.77974269736198609, 0.65229168744754484, 0.57255183264300558, 0.68471461427813241, 0.77013166842475889, 2.8630832819511842 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.90855384028010044, 0.083528775813640266, 0.9548895316562489, 0.98695128042461067, 0.060298660237211754, 0.9169050301095536, 0.99943631268298594, 0.50782513882018621, 0.64690952063185725, 0.41491700164525047, 30.454411006361724 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.57401823245947059, 0.23915287905902372, 0.6099091959640035, 0.47129869341142161, 0.53278821133197352, 0.91995234907551782, 0.32609417952523567, 0.18420829566934149, 0.80803398894207268, 0.55299580218251654, 80.943385150347751 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.34424057198580449, 0.33435254561738248, 0.47059176013916915, 0.72655562381719963, 0.42052621595864226, 0.27572992881981218, 0.82462828925612186, 0.45381895037295938, 0.95738461799904517, 0.83569576978155857, 95.468270913406002 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.006461009027923903, 0.45853614134388354, 0.79191102294599935, 0.83481567047213823, 0.061627342905807625, 0.30195332983679002, 0.84713432196577998, 0.44783577735981872, 0.3374003074498344, 0.71345661680673156, 56.978027357537229 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.057842843845917424, 0.85652103217127484, 0.91660026886733759, 0.4982071808069658, 0.79551195414396136, 0.24322712453269046, 0.68337106626792754, 0.8646299071776371, 0.61501697453742554, 0.93670978032855101, 56.782972495373777 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.30752266102118708, 0.26941385180516364, 0.82126913241752331, 0.14658408489648844, 0.15818453174853253, 0.79876129941975516, 0.47653100015437855, 0.12732365807143831, 0.60856916822249951, 0.22307269827740261, 98.515930223765466 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.13590187846337232, 0.99570789727229891, 0.58446547943733085, 0.91505397479615957, 0.026759222741441935, 0.28629261545785012, 0.033242715790457344, 0.080815354424745744, 0.43990370938657275, 0.78108910913887186, 22.597117246247191 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.0063048861879906326, 0.73088945543847306, 0.14538238196628295, 0.26438532411619287, 0.67011045017756088, 0.70894131780373182, 0.32173783440524095, 0.11891131860392123, 0.40837389900298637, 0.32790584578501825, 25.572044541125049 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.7180598624061364, 0.81345374523230374, 0.94218480249784653, 0.59831988720120899, 0.139932584950474, 0.52170686759494445, 0.041729788178662908, 0.41432937517279267, 0.255450133514598, 0.91018992605504179, 85.768567855095412 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.042959267357738917, 0.7165735168298023, 0.37970532979688765, 0.4467623245612401, 0.22663132567877942, 0.70826345968671345, 0.80067093273783074, 0.38043864495393342, 0.162187756313802, 0.87907279845192166, 9.2897781114194657 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.20980170194133796, 0.27976292895417132, 0.04462922889376586, 0.76315546701342463, 0.43683877689150541, 0.8326239447144772, 0.9123867613128297, 0.57856428637953616, 0.87163706708361921, 0.83315181856464404, 33.287085632528388 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.14353461877408125, 0.54680620611281416, 0.66560736757316974, 0.60517998449044752, 0.75359871153850067, 0.15703089223540423, 0.6587740560106492, 0.50309336461067555, 0.46305372340863871, 0.71743320755724249, 11.722671373211902 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.6285821298005273, 0.84937428577262963, 0.27442211002026773, 0.15251495082171995, 0.54146306416516854, 0.7112439481746351, 0.66046525016187041, 0.46413933771833693, 0.74037121568812247, 0.13438790067834316, 20.872464846366622 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.74245967447732264, 0.85163627573276723, 0.57893098086571793, 0.098390537636694142, 0.26973943708989134, 0.45715307917295689, 0.29393404028570835, 0.29809278581758769, 0.79213571042219011, 0.66137838271274041, 2.6146189435152012 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price" },
                values: new object[] { 0.58216829076341292, 0.35358400536715662, 0.94118497771488485, 0.7621508619863997, 0.5960567818701239, 0.59032255554543722, 0.35717095198562243, 0.86349351684247799, 0.50450156696940684, 0.45626625562211121, 26.038113168554833 });
        }
    }
}
