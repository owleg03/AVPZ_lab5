using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppRisks.Migrations
{
    /// <inheritdoc />
    public partial class ChangeStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "RiskExpertMarksEnumerable",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.4765444456016581, 0.097482560558088127, 0.15741023171540114, 0.58814966403476199, 0.75989513187756497, 0.49570122867996824, 0.88251444871849583, 0.2833155086318272, 0.83627690798490972, 0.86602561767611841, 1.4082684009579571, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.6357065074359397, 0.34159420636358218, 0.73638391067980524, 0.48497500482930689, 0.81951032805950008, 0.10823103990423644, 0.32068836980054882, 0.31349562677599707, 0.76989331703421449, 0.091509038169331092, 35.237060915387417, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.61934602653533777, 0.96020577578842126, 0.12748524366132052, 0.1147258329591021, 0.18657211036941879, 0.72652883563477733, 0.83828596165102542, 0.50890470403712862, 0.61077941871070807, 0.089284506990022106, 33.844315244261146, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.2789889703837396, 0.22461004200443402, 0.74760363637875948, 0.91071599042112228, 0.08791702358372866, 0.036113318069432854, 0.10842132842898355, 0.19519530713380917, 0.89672457551400975, 0.84194984121721261, 42.439976936686563, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.80666977392750905, 0.09553589031515286, 0.29564357849955047, 0.79799377685332007, 0.27937285125757216, 0.40367589741920207, 0.77699133245836793, 0.37665905598330895, 0.4224197071746657, 0.18623376440509309, 59.189526974476856, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.71579456746489467, 0.44867807056798226, 0.025350400134084072, 0.4543198486787533, 0.33041518472729348, 0.98271916409118443, 0.27267312289615997, 0.34501295539634846, 0.7830343664715369, 0.48442222193443873, 28.599434515380217, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.51750297960776936, 0.14018240913861135, 0.79726824170517163, 0.49632604914321299, 0.47525361791373422, 0.040829237444908739, 0.50336093774785451, 0.58808945533556189, 0.85131738483104946, 0.83692083817829888, 32.075610682167763, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.79270358104979155, 0.12273507988100729, 0.98015376076872673, 0.25682414912736651, 0.99578022914955555, 0.2878403323943427, 0.69154846291249239, 0.022153386757853055, 0.018022538472042715, 0.41678101289332536, 96.370709835855521, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.93318153952285166, 0.81764260058567129, 0.076357354088140372, 0.05630520814421025, 0.40627466589825056, 0.79920396081699208, 0.29578160670677267, 0.59140394827091169, 0.1136337593441491, 0.49023028238802835, 20.642435481052747, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.29105854204279247, 0.77975585395876923, 0.84543133208264298, 0.82058497447889533, 0.35589669669710955, 0.32524924943272249, 0.18863219652690033, 0.77132898897480517, 0.54850845872700149, 0.67727310992539547, 82.521826619284184, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.075696078752325868, 0.79978171018663036, 0.76100200187654188, 0.26241926991691078, 0.008979761290875854, 0.27236049070287682, 0.27978005407281126, 0.84843101577817359, 0.034710129093319275, 0.42346311841327489, 35.133895012164842, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.65333114016766902, 0.65474415658452667, 0.21677478585590393, 0.96264830073843044, 0.13590789912699885, 0.019905403286634038, 0.50685902656064485, 0.8882288465636744, 0.6802804502578117, 0.086410205712963317, 82.536429670042423, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.47719516069059764, 0.253670500924986, 0.85922413262504949, 0.50376706570130947, 0.46497493744465324, 0.32424173839483317, 0.65326537055124356, 0.74702737583059908, 0.81120984303792054, 0.16758211766559994, 54.318503656591979, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.10912258680147857, 0.38916223159756902, 0.9614094226460651, 0.48227199852224267, 0.71458057752643789, 0.65084950405308339, 0.78418395759776927, 0.11007810793533435, 0.45314279365712973, 0.58745624513972872, 52.785466996249433, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.25722816058244347, 0.79990430563859805, 0.1041679570403331, 0.71347557747647539, 0.068175783437644633, 0.50573680290385836, 0.88057594523628091, 0.85727119967347876, 0.34730774245562301, 0.17025699103544334, 63.291220541743073, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.8838385254904646, 0.59686642612177443, 0.2093370358878881, 0.40656058913150916, 0.74315493573489799, 0.69010794353303928, 0.75339472489372517, 0.83701163363737208, 0.0067811756105095045, 0.71568886981583801, 99.393713779086369, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.73242917383062001, 0.85071434010328562, 0.89177138465848027, 0.41729426474950004, 0.27521849132879228, 0.3528071347397751, 0.026578244474926072, 0.49078119277169807, 0.75272200375385923, 0.51056740370056175, 37.109075850226326, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.2448784181446384, 0.16039398058504017, 0.53276031414787972, 0.9270088852747117, 0.94500757824229464, 0.63878542903856339, 0.94142032472803339, 0.41697792522267307, 0.081348605040042932, 0.45192240124315963, 67.644864296641288, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.85472505542199317, 0.037809724835705549, 0.40035395806020535, 0.89613697735524833, 0.18213774713684738, 0.9784421304590708, 0.36941223389166122, 0.43351516005400403, 0.95756475891089143, 0.72059976976336315, 50.569881183553058, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.676592058890503, 0.58393966052189017, 0.61471034482196651, 0.90267129739335206, 0.28923263530379184, 0.72417395806855511, 0.032912450187932429, 0.32246458604467154, 0.21843811905213972, 0.55022894180495241, 50.830863285954017, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.074259094908272538, 0.10591850145896076, 0.59192173141385274, 0.48941903039660151, 0.0016083829628975588, 0.72524935021652448, 0.063745411300379695, 0.50894020118668248, 0.36271844184848012, 0.53785646412656418, 83.900322117973118, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.72438526772791989, 0.62847112310438724, 0.44372981747939888, 0.97306992394651493, 0.87074959958804654, 0.85335223133828997, 0.41656081045830817, 0.76787844533072902, 0.28897509640391517, 0.97034682759362023, 16.301818049932947, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.52272708424330472, 0.8262790190360475, 0.47956686189910336, 0.27422790118112872, 0.51628450560789263, 0.26411517506856275, 0.8316752424007906, 0.25223586612043958, 0.65691603947764698, 0.29638046057884493, 64.22508293974596, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.66762820403650447, 0.077922446386888389, 0.39192877662306569, 0.21874206185775313, 0.33089926878281761, 0.59751915106821263, 0.50994226403453669, 0.55010070194682736, 0.81403927996526493, 0.3360818238231208, 40.297048851907014, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.87563336986430473, 0.2136728228524436, 0.84567165540952105, 0.1255410671714331, 0.87763183530817512, 0.4746234607686497, 0.38714169995728465, 0.45587976576943789, 0.99416661928293582, 0.20250069661164194, 72.592466221367786, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.90198389457671202, 0.97963840792384793, 0.12954555528888478, 0.74332160678928738, 0.39860831968263155, 0.64690657524185102, 0.11393398963209667, 0.53944470689350943, 0.97337872699943162, 0.071796066754759691, 98.92010092246683, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.86796476238178211, 0.021993385532545817, 0.73528512058625417, 0.84238335826659883, 0.28656322914057786, 0.83680713020565189, 0.85978598467030509, 0.22507990496913866, 0.12453920300854859, 0.74562204367688989, 71.635344988631971, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.045689542453813514, 0.26443515773124371, 0.36999904184280508, 0.84361185088473867, 0.019854596145003622, 0.47382662130212116, 0.12376961236769746, 0.66542773184242321, 0.20207794744416951, 0.10171561652263361, 18.619883236253244, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.39609884996548028, 0.10753497085154895, 0.85207966111647393, 0.60974387542643416, 0.90953788956350579, 0.73426865470136504, 0.4558501206768748, 0.43187432056325192, 0.66989724413204887, 0.81483793031006557, 42.739179652919503, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.45383263633064064, 0.50592168392116599, 0.59384613509774298, 0.85355125314280988, 0.71487423140436135, 0.088951866635827659, 0.32822833191814027, 0.79155015809972473, 0.75198304947228145, 0.19128426678894916, 3.4409948276961311, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.96808763836405598, 0.61919454157020737, 0.84153433671637834, 0.88125988748490935, 0.36176175719049952, 0.50638849771768324, 0.76830510470839208, 0.39103958937766836, 0.084427606181687098, 0.43508337869553537, 8.9370599467619716, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.28994658816660424, 0.93714614243848382, 0.44203167060357429, 0.7563943685584692, 0.16707411863538701, 0.98773406222489368, 0.56601889499334535, 0.54314599116409612, 0.64109498154232547, 0.11982361934184327, 90.888063607228133, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.69343657456073649, 0.31307356971767697, 0.18626363701375914, 0.85795642980228159, 0.74487295542215726, 0.52699065624094099, 0.52841545194152229, 0.49698211978386353, 0.59437475824207242, 0.39439271939096765, 78.135256446355385, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.86121921529347067, 0.14743883067794705, 0.073617797483285341, 0.50046608124362835, 0.38591563540945617, 0.4714515828853677, 0.8834869434530922, 0.53471890133594713, 0.57350308112233639, 0.44907757133058435, 41.565618333584176, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.28067508709796452, 0.55697551003215173, 0.9408961941010473, 0.27507285283822269, 0.56553620243618186, 0.62002681259183379, 0.071041540482416621, 0.49913934749989475, 0.98558386917805041, 0.85288074513249768, 66.281976864995244, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.18730066681425661, 0.50132726044317588, 0.45462841397663201, 0.32724927010955163, 0.090536312905646898, 0.60453342120806153, 0.69065958895112067, 0.87321026906065213, 0.70213684148564492, 0.51671152228949147, 23.568459737705005, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.94967468750920636, 0.29191144879178099, 0.68053640373757018, 0.98047197544715503, 0.28131217870996095, 0.62945178285687664, 0.43252170962979664, 0.85521558105739282, 0.80628645021701772, 0.85383371656853646, 16.227916868195212, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.15544328077527092, 0.6397281683013768, 0.45027204396731157, 0.69663553258804056, 0.71358466058985559, 0.14417449464971055, 0.88392481393857181, 0.14975776800713969, 0.51628829128083953, 0.16625932853491021, 73.030149564075288, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.34083782765510384, 0.74855128126157311, 0.72762530271358361, 0.18440877890459173, 0.22767440152850382, 0.92756797376395528, 0.17647459442969038, 0.10091604273336996, 0.082584070956312816, 0.95034824179010524, 62.214633301954251, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.98911495897835378, 0.67205569353128158, 0.13111707027153741, 0.87759867365342437, 0.6859761712774517, 0.5239251277773167, 0.94786849183984956, 0.25868057293835289, 0.51007474370165429, 0.21565772482746115, 49.183179021461456, null });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "Price", "Status" },
                values: new object[] { 0.13894822569766996, 0.4507314411255916, 0.5766064577010348, 0.50326501600801499, 0.56105313431155446, 0.28538419454705621, 0.37081838636561382, 0.380378894080177, 0.71460920825892305, 0.11663949741681034, 94.355819949997326, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Status",
                table: "RiskExpertMarksEnumerable",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}
