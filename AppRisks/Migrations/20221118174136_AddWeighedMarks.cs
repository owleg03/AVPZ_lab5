using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppRisks.Migrations
{
    /// <inheritdoc />
    public partial class AddWeighedMarks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "ExpertMarkWeighed1",
                table: "RiskExpertMarksEnumerable",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ExpertMarkWeighed10",
                table: "RiskExpertMarksEnumerable",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ExpertMarkWeighed2",
                table: "RiskExpertMarksEnumerable",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ExpertMarkWeighed3",
                table: "RiskExpertMarksEnumerable",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ExpertMarkWeighed4",
                table: "RiskExpertMarksEnumerable",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ExpertMarkWeighed5",
                table: "RiskExpertMarksEnumerable",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ExpertMarkWeighed6",
                table: "RiskExpertMarksEnumerable",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ExpertMarkWeighed7",
                table: "RiskExpertMarksEnumerable",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ExpertMarkWeighed8",
                table: "RiskExpertMarksEnumerable",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ExpertMarkWeighed9",
                table: "RiskExpertMarksEnumerable",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "ExpertMarkWeighed1", "ExpertMarkWeighed10", "ExpertMarkWeighed2", "ExpertMarkWeighed3", "ExpertMarkWeighed4", "ExpertMarkWeighed5", "ExpertMarkWeighed6", "ExpertMarkWeighed7", "ExpertMarkWeighed8", "ExpertMarkWeighed9", "Price" },
                values: new object[] { 0.20816622117902428, 0.35516473663183024, 0.30328908608885996, 0.56035707846547589, 0.0560562210761264, 0.2735827353273268, 0.80477298364731553, 0.38840084875784764, 0.071484387542028238, 0.13118118174626403, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 97.138045363590152 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "ExpertMarkWeighed1", "ExpertMarkWeighed10", "ExpertMarkWeighed2", "ExpertMarkWeighed3", "ExpertMarkWeighed4", "ExpertMarkWeighed5", "ExpertMarkWeighed6", "ExpertMarkWeighed7", "ExpertMarkWeighed8", "ExpertMarkWeighed9", "Price" },
                values: new object[] { 0.12008921702958875, 0.28991668768648959, 0.37907227305039648, 0.84636481626524862, 0.37458556309617341, 0.66983539186198571, 0.55421488560044907, 0.57087055207180171, 0.28452169930659021, 0.40722238143457812, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 49.478628000473954 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "ExpertMarkWeighed1", "ExpertMarkWeighed10", "ExpertMarkWeighed2", "ExpertMarkWeighed3", "ExpertMarkWeighed4", "ExpertMarkWeighed5", "ExpertMarkWeighed6", "ExpertMarkWeighed7", "ExpertMarkWeighed8", "ExpertMarkWeighed9", "Price" },
                values: new object[] { 0.91929396122749352, 0.44335143577818181, 0.65684457212504543, 0.41687041550592352, 0.99183718225651862, 0.4180235266357869, 0.71712187204774824, 0.44101767083508137, 0.92947061248585305, 0.53202050785785215, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 35.323015053612373 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "ExpertMarkWeighed1", "ExpertMarkWeighed10", "ExpertMarkWeighed2", "ExpertMarkWeighed3", "ExpertMarkWeighed4", "ExpertMarkWeighed5", "ExpertMarkWeighed6", "ExpertMarkWeighed7", "ExpertMarkWeighed8", "ExpertMarkWeighed9", "Price" },
                values: new object[] { 0.94977899462269855, 0.47986607875745024, 0.78430599833567827, 0.8016144259219079, 0.59738048504395491, 0.58087613301877605, 0.19451086937976125, 0.42395184206663061, 0.89416712768990803, 0.87742414122781764, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 14.70527241996048 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "ExpertMarkWeighed1", "ExpertMarkWeighed10", "ExpertMarkWeighed2", "ExpertMarkWeighed3", "ExpertMarkWeighed4", "ExpertMarkWeighed5", "ExpertMarkWeighed6", "ExpertMarkWeighed7", "ExpertMarkWeighed8", "ExpertMarkWeighed9", "Price" },
                values: new object[] { 0.27943016298321999, 0.79561497788014512, 0.33450675504778038, 0.74347677411467405, 0.76661272832407179, 0.41865569168577288, 0.35521169647644024, 0.75996865279244852, 0.79346801254720511, 0.76177280469643349, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 26.940237640749586 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "ExpertMarkWeighed1", "ExpertMarkWeighed10", "ExpertMarkWeighed2", "ExpertMarkWeighed3", "ExpertMarkWeighed4", "ExpertMarkWeighed5", "ExpertMarkWeighed6", "ExpertMarkWeighed7", "ExpertMarkWeighed8", "ExpertMarkWeighed9", "Price" },
                values: new object[] { 0.86719659099909907, 0.5811442432676257, 0.26053265956529192, 0.012021855097339551, 0.12906131668005361, 0.86835461630390298, 0.047011779609083759, 0.98739783152132787, 0.5111416001468766, 0.1523069003433436, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 21.736514584074364 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "ExpertMarkWeighed1", "ExpertMarkWeighed10", "ExpertMarkWeighed2", "ExpertMarkWeighed3", "ExpertMarkWeighed4", "ExpertMarkWeighed5", "ExpertMarkWeighed6", "ExpertMarkWeighed7", "ExpertMarkWeighed8", "ExpertMarkWeighed9", "Price" },
                values: new object[] { 0.46803197653462625, 0.83618455479948273, 0.88428183205904998, 0.32763233128925606, 0.51077474100359266, 0.76648311050426765, 0.40039261487115019, 0.92289867692693461, 0.54972261146907353, 0.18793141697693216, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 66.241687632508231 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "ExpertMarkWeighed1", "ExpertMarkWeighed10", "ExpertMarkWeighed2", "ExpertMarkWeighed3", "ExpertMarkWeighed4", "ExpertMarkWeighed5", "ExpertMarkWeighed6", "ExpertMarkWeighed7", "ExpertMarkWeighed8", "ExpertMarkWeighed9", "Price" },
                values: new object[] { 0.73465467700055465, 0.33064013076963172, 0.83857698953745863, 0.37807004821143342, 0.30979614247234355, 0.96552364200060348, 0.94463997183365322, 0.97524247480440562, 0.74300972895103612, 0.2984774304969452, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 67.184686480147093 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "ExpertMarkWeighed1", "ExpertMarkWeighed10", "ExpertMarkWeighed2", "ExpertMarkWeighed3", "ExpertMarkWeighed4", "ExpertMarkWeighed5", "ExpertMarkWeighed6", "ExpertMarkWeighed7", "ExpertMarkWeighed8", "ExpertMarkWeighed9", "Price" },
                values: new object[] { 0.66780558916715027, 0.79550042683030642, 0.81748127250573854, 0.16777464038371814, 0.39806744827943474, 0.5608670514216656, 0.75484950438776388, 0.69896338223275267, 0.87515247912174443, 0.70151456882292651, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 81.568024732506387 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "ExpertMarkWeighed1", "ExpertMarkWeighed10", "ExpertMarkWeighed2", "ExpertMarkWeighed3", "ExpertMarkWeighed4", "ExpertMarkWeighed5", "ExpertMarkWeighed6", "ExpertMarkWeighed7", "ExpertMarkWeighed8", "ExpertMarkWeighed9", "Price" },
                values: new object[] { 0.18585640740222575, 0.51282255047404945, 0.81906899115694065, 0.79558823450275296, 0.57605455619220536, 0.87546565176980085, 0.92822850923513656, 0.74826060792612215, 0.37154890260199014, 0.22443585809207989, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 58.59333646428211 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "ExpertMarkWeighed1", "ExpertMarkWeighed10", "ExpertMarkWeighed2", "ExpertMarkWeighed3", "ExpertMarkWeighed4", "ExpertMarkWeighed5", "ExpertMarkWeighed6", "ExpertMarkWeighed7", "ExpertMarkWeighed8", "ExpertMarkWeighed9", "Price" },
                values: new object[] { 0.41212488338422315, 0.13907543979595349, 0.85044764578226784, 0.56119111404691313, 0.7965647071778087, 0.59621089014045714, 0.85417400758032525, 0.81168264723926808, 0.58648933463032193, 0.91921738610274184, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 57.67580119225719 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "ExpertMarkWeighed1", "ExpertMarkWeighed10", "ExpertMarkWeighed2", "ExpertMarkWeighed3", "ExpertMarkWeighed4", "ExpertMarkWeighed5", "ExpertMarkWeighed6", "ExpertMarkWeighed7", "ExpertMarkWeighed8", "ExpertMarkWeighed9", "Price" },
                values: new object[] { 0.10721566662203252, 0.19046468145721418, 0.52147097185875735, 0.51996022069273462, 0.19192015748063918, 0.10042616874810895, 0.36631851867637366, 0.71993293511740375, 0.15077651402821801, 0.53007061766561037, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 17.949470100827657 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "ExpertMarkWeighed1", "ExpertMarkWeighed10", "ExpertMarkWeighed2", "ExpertMarkWeighed3", "ExpertMarkWeighed4", "ExpertMarkWeighed5", "ExpertMarkWeighed6", "ExpertMarkWeighed7", "ExpertMarkWeighed8", "ExpertMarkWeighed9", "Price" },
                values: new object[] { 0.095609490907959782, 0.78752538200534272, 0.19461092817008641, 0.42966642998045734, 0.3996803118168204, 0.062456754414335069, 0.40978686997267677, 0.74136887898377068, 0.24354737935859061, 0.12824360263732137, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 76.981909251570286 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "ExpertMarkWeighed1", "ExpertMarkWeighed10", "ExpertMarkWeighed2", "ExpertMarkWeighed3", "ExpertMarkWeighed4", "ExpertMarkWeighed5", "ExpertMarkWeighed6", "ExpertMarkWeighed7", "ExpertMarkWeighed8", "ExpertMarkWeighed9", "Price" },
                values: new object[] { 0.10511529645173046, 0.46122461358344591, 0.93564870095090513, 0.61539561033576506, 0.83302881042196353, 0.83818954523977729, 0.83279053073697118, 0.17765927932761905, 0.92968735416517423, 0.72857654111683157, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 68.686991843674477 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "ExpertMarkWeighed1", "ExpertMarkWeighed10", "ExpertMarkWeighed2", "ExpertMarkWeighed3", "ExpertMarkWeighed4", "ExpertMarkWeighed5", "ExpertMarkWeighed6", "ExpertMarkWeighed7", "ExpertMarkWeighed8", "ExpertMarkWeighed9", "Price" },
                values: new object[] { 0.36800162568661465, 0.073483578273869532, 0.10773018337087004, 0.43106120169880568, 0.61563637098670076, 0.0207829403044969, 0.44933235011599304, 0.3869335058199983, 0.24313084092790638, 0.066094782014071041, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 8.9486218424054247 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "ExpertMarkWeighed1", "ExpertMarkWeighed10", "ExpertMarkWeighed2", "ExpertMarkWeighed3", "ExpertMarkWeighed4", "ExpertMarkWeighed5", "ExpertMarkWeighed6", "ExpertMarkWeighed7", "ExpertMarkWeighed8", "ExpertMarkWeighed9", "Price" },
                values: new object[] { 0.86180214397000243, 0.73171402645856065, 0.56228234979269509, 0.39327050303534195, 0.088409088150666393, 0.6686673837150876, 0.077237316710673576, 0.5041771205124036, 0.36810931020910975, 0.27479643569671319, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 38.069523840025219 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "ExpertMarkWeighed1", "ExpertMarkWeighed10", "ExpertMarkWeighed2", "ExpertMarkWeighed3", "ExpertMarkWeighed4", "ExpertMarkWeighed5", "ExpertMarkWeighed6", "ExpertMarkWeighed7", "ExpertMarkWeighed8", "ExpertMarkWeighed9", "Price" },
                values: new object[] { 0.77090008463907822, 0.82292724928057426, 0.097414405151026506, 0.72274498999014769, 0.25367675882686092, 0.91601661056573003, 0.61201576558687698, 0.91311607443335563, 0.54520180163613086, 0.092193309383000854, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 29.126535195648263 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "ExpertMarkWeighed1", "ExpertMarkWeighed10", "ExpertMarkWeighed2", "ExpertMarkWeighed3", "ExpertMarkWeighed4", "ExpertMarkWeighed5", "ExpertMarkWeighed6", "ExpertMarkWeighed7", "ExpertMarkWeighed8", "ExpertMarkWeighed9", "Price" },
                values: new object[] { 0.70839220943032732, 0.85905245639957561, 0.83412714819811407, 0.054942631852356594, 0.0026391986650448063, 0.6401334309541229, 0.33136680729454537, 0.6169328008695889, 0.092331684308710638, 0.40312489695341891, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 85.549920622862516 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "ExpertMarkWeighed1", "ExpertMarkWeighed10", "ExpertMarkWeighed2", "ExpertMarkWeighed3", "ExpertMarkWeighed4", "ExpertMarkWeighed5", "ExpertMarkWeighed6", "ExpertMarkWeighed7", "ExpertMarkWeighed8", "ExpertMarkWeighed9", "Price" },
                values: new object[] { 0.58328019228379546, 0.76444339190487043, 0.037701265256956495, 0.0050223752320338599, 0.10353347304329086, 0.36922494082308865, 0.89786536712129839, 0.047610790328670882, 0.75487979711415976, 0.40174045198462538, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 67.539398748540904 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "ExpertMarkWeighed1", "ExpertMarkWeighed10", "ExpertMarkWeighed2", "ExpertMarkWeighed3", "ExpertMarkWeighed4", "ExpertMarkWeighed5", "ExpertMarkWeighed6", "ExpertMarkWeighed7", "ExpertMarkWeighed8", "ExpertMarkWeighed9", "Price" },
                values: new object[] { 0.75448935632046277, 0.03781765532435688, 0.42712546686861386, 0.032650452125110196, 0.32093136039761305, 0.8944196131869836, 0.35830531526379428, 0.71637783365970453, 0.80612227797493397, 0.3939002418031744, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 92.401133040062788 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "ExpertMarkWeighed1", "ExpertMarkWeighed10", "ExpertMarkWeighed2", "ExpertMarkWeighed3", "ExpertMarkWeighed4", "ExpertMarkWeighed5", "ExpertMarkWeighed6", "ExpertMarkWeighed7", "ExpertMarkWeighed8", "ExpertMarkWeighed9", "Price" },
                values: new object[] { 0.9176266237645041, 0.70259170628687762, 0.31465367953048862, 0.77304368412127411, 0.80333185871442436, 0.60631562029083019, 0.46878314375896357, 0.82557342269680611, 0.21946568944220179, 0.87974988645284879, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 11.722548046339776 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "ExpertMarkWeighed1", "ExpertMarkWeighed10", "ExpertMarkWeighed2", "ExpertMarkWeighed3", "ExpertMarkWeighed4", "ExpertMarkWeighed5", "ExpertMarkWeighed6", "ExpertMarkWeighed7", "ExpertMarkWeighed8", "ExpertMarkWeighed9", "Price" },
                values: new object[] { 0.036085376529065738, 0.99419795521584686, 0.13865700230264322, 0.013743057452528573, 0.90409083117227285, 0.68905265948733585, 0.56833545190245627, 0.099394685317817366, 0.13606169775087984, 0.63208251262060688, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 25.126673397661236 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "ExpertMarkWeighed1", "ExpertMarkWeighed10", "ExpertMarkWeighed2", "ExpertMarkWeighed3", "ExpertMarkWeighed4", "ExpertMarkWeighed5", "ExpertMarkWeighed6", "ExpertMarkWeighed7", "ExpertMarkWeighed8", "ExpertMarkWeighed9", "Price" },
                values: new object[] { 0.29973097076084754, 0.036963830092384686, 0.662868522103088, 0.11466607938175577, 0.41703330577321063, 0.21799133956265582, 0.8326833193818749, 0.31340684795442875, 0.56785656940373874, 0.016024478704788292, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 3.283168111252599 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "ExpertMarkWeighed1", "ExpertMarkWeighed10", "ExpertMarkWeighed2", "ExpertMarkWeighed3", "ExpertMarkWeighed4", "ExpertMarkWeighed5", "ExpertMarkWeighed6", "ExpertMarkWeighed7", "ExpertMarkWeighed8", "ExpertMarkWeighed9", "Price" },
                values: new object[] { 0.77584954160375896, 0.6071663490688749, 0.15788525522651631, 0.29014723804738074, 0.26830653351568146, 0.99878517641457476, 0.62207022159373038, 0.41057222526873072, 0.62186356598123349, 0.59189749229193866, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 86.817405588967588 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "ExpertMarkWeighed1", "ExpertMarkWeighed10", "ExpertMarkWeighed2", "ExpertMarkWeighed3", "ExpertMarkWeighed4", "ExpertMarkWeighed5", "ExpertMarkWeighed6", "ExpertMarkWeighed7", "ExpertMarkWeighed8", "ExpertMarkWeighed9", "Price" },
                values: new object[] { 0.23679902705406464, 0.20110542117591579, 0.098325524902349914, 0.56589005654317481, 0.39642270551510872, 0.99777271936090173, 0.22723706433810886, 0.92939116080372541, 0.60593310638595654, 0.45548635201452159, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 67.310028893497503 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "ExpertMarkWeighed1", "ExpertMarkWeighed10", "ExpertMarkWeighed2", "ExpertMarkWeighed3", "ExpertMarkWeighed4", "ExpertMarkWeighed5", "ExpertMarkWeighed6", "ExpertMarkWeighed7", "ExpertMarkWeighed8", "ExpertMarkWeighed9", "Price" },
                values: new object[] { 0.33129453363881567, 0.11446308962602514, 0.57221553296676497, 0.90794163586131582, 0.93810800842476427, 0.75757888308724897, 0.42716438586409522, 0.24076549378922141, 0.13570759211014305, 0.80933037617608672, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 26.646731520487489 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "ExpertMarkWeighed1", "ExpertMarkWeighed10", "ExpertMarkWeighed2", "ExpertMarkWeighed3", "ExpertMarkWeighed4", "ExpertMarkWeighed5", "ExpertMarkWeighed6", "ExpertMarkWeighed7", "ExpertMarkWeighed8", "ExpertMarkWeighed9", "Price" },
                values: new object[] { 0.27655181904030013, 0.10008863124983669, 0.76420720228354855, 0.054674503363103755, 0.82318313854651759, 0.56111258646215278, 0.50396240102224399, 0.40244275812490837, 0.41207815584013407, 0.058893567421667514, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 52.503996569798652 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "ExpertMarkWeighed1", "ExpertMarkWeighed10", "ExpertMarkWeighed2", "ExpertMarkWeighed3", "ExpertMarkWeighed4", "ExpertMarkWeighed5", "ExpertMarkWeighed6", "ExpertMarkWeighed7", "ExpertMarkWeighed8", "ExpertMarkWeighed9", "Price" },
                values: new object[] { 0.37616933517382589, 0.27154418729458418, 0.89240283393674591, 0.14858348815522959, 0.61220222469155783, 0.84499832209405457, 0.7765225537421514, 0.46438780339075136, 0.89138418553674081, 0.49569378928423768, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 65.736935336921533 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "ExpertMarkWeighed1", "ExpertMarkWeighed10", "ExpertMarkWeighed2", "ExpertMarkWeighed3", "ExpertMarkWeighed4", "ExpertMarkWeighed5", "ExpertMarkWeighed6", "ExpertMarkWeighed7", "ExpertMarkWeighed8", "ExpertMarkWeighed9", "Price" },
                values: new object[] { 0.73340335663053846, 0.81254648588286293, 0.488437365917605, 0.79475290532028442, 0.75223102205445602, 0.87853925065497585, 0.49164203886732627, 0.17656110904483258, 0.63387165969655168, 0.34028942928763894, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 11.19949879621217 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "ExpertMarkWeighed1", "ExpertMarkWeighed10", "ExpertMarkWeighed2", "ExpertMarkWeighed3", "ExpertMarkWeighed4", "ExpertMarkWeighed5", "ExpertMarkWeighed6", "ExpertMarkWeighed7", "ExpertMarkWeighed8", "ExpertMarkWeighed9", "Price" },
                values: new object[] { 0.2496982149714595, 0.97506312327192124, 0.87469343727226445, 0.9527166661358295, 0.69556388123508806, 0.0078202685209518563, 0.8051210507885872, 0.80524932586395137, 0.052998573628422196, 0.47151784093979132, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 2.119514042125592 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "ExpertMarkWeighed1", "ExpertMarkWeighed10", "ExpertMarkWeighed2", "ExpertMarkWeighed3", "ExpertMarkWeighed4", "ExpertMarkWeighed5", "ExpertMarkWeighed6", "ExpertMarkWeighed7", "ExpertMarkWeighed8", "ExpertMarkWeighed9", "Price" },
                values: new object[] { 0.39818599163897672, 0.28044157038632589, 0.75615957842631765, 0.71534491354550789, 0.11678172205968052, 0.93636623176721145, 0.85487367343413234, 0.77199393080422862, 0.7736259045363495, 0.50922835181396708, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 21.695347476541627 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "ExpertMarkWeighed1", "ExpertMarkWeighed10", "ExpertMarkWeighed2", "ExpertMarkWeighed3", "ExpertMarkWeighed4", "ExpertMarkWeighed5", "ExpertMarkWeighed6", "ExpertMarkWeighed7", "ExpertMarkWeighed8", "ExpertMarkWeighed9", "Price" },
                values: new object[] { 0.35961889553285908, 0.84002245232885231, 0.028198047439840113, 0.03685969501227826, 0.77149270817341919, 0.83129691928836758, 0.66972089535284296, 0.25514564045624233, 0.06811760376473619, 0.15296521504342231, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 93.663127757448024 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "ExpertMarkWeighed1", "ExpertMarkWeighed10", "ExpertMarkWeighed2", "ExpertMarkWeighed3", "ExpertMarkWeighed4", "ExpertMarkWeighed5", "ExpertMarkWeighed6", "ExpertMarkWeighed7", "ExpertMarkWeighed8", "ExpertMarkWeighed9", "Price" },
                values: new object[] { 0.78748810317151519, 0.049526821130141507, 0.43696002014550528, 0.30534180402850375, 0.78956186921103322, 0.94738300106422091, 0.97486117377098014, 0.59138272501225031, 0.40424875497744772, 0.36696595797063958, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 79.545139219481982 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "ExpertMarkWeighed1", "ExpertMarkWeighed10", "ExpertMarkWeighed2", "ExpertMarkWeighed3", "ExpertMarkWeighed4", "ExpertMarkWeighed5", "ExpertMarkWeighed6", "ExpertMarkWeighed7", "ExpertMarkWeighed8", "ExpertMarkWeighed9", "Price" },
                values: new object[] { 0.70570041059493016, 0.788151411545993, 0.82095112750088195, 0.17773426199733833, 0.96125755848661965, 0.95256059120352943, 0.96813445425480049, 0.94193165990637528, 0.050267666753448514, 0.48227521933717055, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 92.64336902234443 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "ExpertMarkWeighed1", "ExpertMarkWeighed10", "ExpertMarkWeighed2", "ExpertMarkWeighed3", "ExpertMarkWeighed4", "ExpertMarkWeighed5", "ExpertMarkWeighed6", "ExpertMarkWeighed7", "ExpertMarkWeighed8", "ExpertMarkWeighed9", "Price" },
                values: new object[] { 0.21024604762449117, 0.86865124920570402, 0.68470104301972823, 0.73373571832144413, 0.50036693333333526, 0.48741133090397137, 0.16819813020521412, 0.013520782000434162, 0.62705434032915564, 0.45343562444066521, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 57.39443266832415 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "ExpertMarkWeighed1", "ExpertMarkWeighed10", "ExpertMarkWeighed2", "ExpertMarkWeighed3", "ExpertMarkWeighed4", "ExpertMarkWeighed5", "ExpertMarkWeighed6", "ExpertMarkWeighed7", "ExpertMarkWeighed8", "ExpertMarkWeighed9", "Price" },
                values: new object[] { 0.15975150535857385, 0.86188344547504925, 0.53208245971554902, 0.59934988522442512, 0.04907792294120783, 0.49153268981148268, 0.42381775876714722, 0.08806263044641871, 0.5690047288785044, 0.76859864096233055, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 19.833348326691425 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "ExpertMarkWeighed1", "ExpertMarkWeighed10", "ExpertMarkWeighed2", "ExpertMarkWeighed3", "ExpertMarkWeighed4", "ExpertMarkWeighed5", "ExpertMarkWeighed6", "ExpertMarkWeighed7", "ExpertMarkWeighed8", "ExpertMarkWeighed9", "Price" },
                values: new object[] { 0.77115906240524268, 0.0071164274967436825, 0.75375682848430903, 0.86750142091053872, 0.86003853304836253, 0.70185469891921648, 0.86958165148365629, 0.13847046690857223, 0.25372971537280709, 0.83394286937471884, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 49.842126802770892 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "ExpertMarkWeighed1", "ExpertMarkWeighed10", "ExpertMarkWeighed2", "ExpertMarkWeighed3", "ExpertMarkWeighed4", "ExpertMarkWeighed5", "ExpertMarkWeighed6", "ExpertMarkWeighed7", "ExpertMarkWeighed8", "ExpertMarkWeighed9", "Price" },
                values: new object[] { 0.92937379007336951, 0.85970606823594686, 0.90734176110319742, 0.77092961988930708, 0.74067951069971349, 0.098220461252380376, 0.10564778255612306, 0.32000759495340447, 0.68262164051056695, 0.13146333287982737, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 42.380126151563978 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "ExpertMarkWeighed1", "ExpertMarkWeighed10", "ExpertMarkWeighed2", "ExpertMarkWeighed3", "ExpertMarkWeighed4", "ExpertMarkWeighed5", "ExpertMarkWeighed6", "ExpertMarkWeighed7", "ExpertMarkWeighed8", "ExpertMarkWeighed9", "Price" },
                values: new object[] { 0.53880001320071003, 0.16907401372974751, 0.50479206223921758, 0.74577890085721643, 0.27008007695906744, 0.06807293842382478, 0.37011436236336426, 0.28108260032751942, 0.17159960792029916, 0.59396014227990701, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 48.034598961205852 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "ExpertMarkWeighed1", "ExpertMarkWeighed10", "ExpertMarkWeighed2", "ExpertMarkWeighed3", "ExpertMarkWeighed4", "ExpertMarkWeighed5", "ExpertMarkWeighed6", "ExpertMarkWeighed7", "ExpertMarkWeighed8", "ExpertMarkWeighed9", "Price" },
                values: new object[] { 0.53680188970925713, 0.17598002320210748, 0.44637905408566758, 0.4000976751700156, 0.36361796660921597, 0.82964112964689696, 0.16479014983719753, 0.35078416377919552, 0.47636441288461551, 0.38749605384565711, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 66.265863583170201 });

            migrationBuilder.UpdateData(
                table: "RiskExpertMarksEnumerable",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ExpertMark1", "ExpertMark10", "ExpertMark2", "ExpertMark3", "ExpertMark4", "ExpertMark5", "ExpertMark6", "ExpertMark7", "ExpertMark8", "ExpertMark9", "ExpertMarkWeighed1", "ExpertMarkWeighed10", "ExpertMarkWeighed2", "ExpertMarkWeighed3", "ExpertMarkWeighed4", "ExpertMarkWeighed5", "ExpertMarkWeighed6", "ExpertMarkWeighed7", "ExpertMarkWeighed8", "ExpertMarkWeighed9", "Price" },
                values: new object[] { 0.2396165078608935, 0.83726389721565941, 0.18261767458653377, 0.42694944812373448, 0.12490619539353687, 0.90927931394455908, 0.056108272301555129, 0.1379987819391898, 0.75957120817726131, 0.92703317879473313, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 63.29487442860956 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExpertMarkWeighed1",
                table: "RiskExpertMarksEnumerable");

            migrationBuilder.DropColumn(
                name: "ExpertMarkWeighed10",
                table: "RiskExpertMarksEnumerable");

            migrationBuilder.DropColumn(
                name: "ExpertMarkWeighed2",
                table: "RiskExpertMarksEnumerable");

            migrationBuilder.DropColumn(
                name: "ExpertMarkWeighed3",
                table: "RiskExpertMarksEnumerable");

            migrationBuilder.DropColumn(
                name: "ExpertMarkWeighed4",
                table: "RiskExpertMarksEnumerable");

            migrationBuilder.DropColumn(
                name: "ExpertMarkWeighed5",
                table: "RiskExpertMarksEnumerable");

            migrationBuilder.DropColumn(
                name: "ExpertMarkWeighed6",
                table: "RiskExpertMarksEnumerable");

            migrationBuilder.DropColumn(
                name: "ExpertMarkWeighed7",
                table: "RiskExpertMarksEnumerable");

            migrationBuilder.DropColumn(
                name: "ExpertMarkWeighed8",
                table: "RiskExpertMarksEnumerable");

            migrationBuilder.DropColumn(
                name: "ExpertMarkWeighed9",
                table: "RiskExpertMarksEnumerable");

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
    }
}
