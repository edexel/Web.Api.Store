using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistance.Database.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlayThing",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Descripcíon = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    RetriccionEdad = table.Column<int>(type: "int", nullable: false),
                    Compania = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: false),
                    Imagen = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayThing", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "PlayThing",
                columns: new[] { "Id", "Compania", "Descripcíon", "Imagen", "Nombre", "Precio", "RetriccionEdad" },
                values: new object[,]
                {
                    { 1, "avión", "Juguete: patito de goma de la compania avión para mayores de 76 años", "", "patito de goma", 935.18m, 76 },
                    { 73, "osito de peluche", "Juguete: ¿Quién es Quién? de la compania osito de peluche para mayores de 20 años", "", "¿Quién es Quién?", 337.15m, 20 },
                    { 72, "tren", "Juguete: ¿Quién es Quién? de la compania tren para mayores de 0 años", "", "¿Quién es Quién?", 302.56m, 0 },
                    { 71, "bicicleta", "Juguete: UNO de la compania bicicleta para mayores de 31 años", "", "UNO", 758.89m, 31 },
                    { 70, "osito de peluche", "Juguete: avión de la compania osito de peluche para mayores de 24 años", "", "avión", 949.72m, 24 },
                    { 69, "bicicleta", "Juguete: Pictionary de la compania bicicleta para mayores de 40 años", "", "Pictionary", 155.56m, 40 },
                    { 68, "avión", "Juguete: ¿Quién es Quién? de la compania avión para mayores de 60 años", "", "¿Quién es Quién?", 373.41m, 60 },
                    { 67, "osito de peluche", "Juguete: tren de la compania osito de peluche para mayores de 74 años", "", "tren", 629.07m, 74 },
                    { 66, "bicicleta", "Juguete: pelota de la compania bicicleta para mayores de 40 años", "", "pelota", 72.02m, 40 },
                    { 65, "avión", "Juguete: UNO de la compania avión para mayores de 51 años", "", "UNO", 655.99m, 51 },
                    { 64, "pelota", "Juguete: cometa de la compania pelota para mayores de 97 años", "", "cometa", 707.03m, 97 },
                    { 63, "bicicleta", "Juguete: muñeca de la compania bicicleta para mayores de 13 años", "", "muñeca", 203.41m, 13 },
                    { 62, "tren", "Juguete: bicicleta de la compania tren para mayores de 73 años", "", "bicicleta", 291.52m, 73 },
                    { 61, "avión", "Juguete: tren de la compania avión para mayores de 15 años", "", "tren", 146.21m, 15 },
                    { 60, "cometa", "Juguete: avión de la compania cometa para mayores de 77 años", "", "avión", 841.10m, 77 },
                    { 59, "¿Quién es Quién?", "Juguete: muñeca de la compania ¿Quién es Quién? para mayores de 89 años", "", "muñeca", 653.45m, 89 },
                    { 58, "tren", "Juguete: bicicleta de la compania tren para mayores de 81 años", "", "bicicleta", 227.15m, 81 },
                    { 57, "avión", "Juguete: tren de la compania avión para mayores de 55 años", "", "tren", 149.64m, 55 },
                    { 56, "UNO", "Juguete: cometa de la compania UNO para mayores de 6 años", "", "cometa", 285.84m, 6 },
                    { 55, "Pictionary", "Juguete: Pictionary de la compania Pictionary para mayores de 82 años", "", "Pictionary", 1.16m, 82 },
                    { 54, "muñeca", "Juguete: patito de goma de la compania muñeca para mayores de 46 años", "", "patito de goma", 269.37m, 46 },
                    { 53, "cometa", "Juguete: UNO de la compania cometa para mayores de 82 años", "", "UNO", 974.20m, 82 },
                    { 74, "UNO", "Juguete: cometa de la compania UNO para mayores de 75 años", "", "cometa", 642.31m, 75 },
                    { 52, "tren", "Juguete: ¿Quién es Quién? de la compania tren para mayores de 65 años", "", "¿Quién es Quién?", 852.57m, 65 },
                    { 75, "osito de peluche", "Juguete: Parchís de la compania osito de peluche para mayores de 46 años", "", "Parchís", 996.78m, 46 },
                    { 77, "Pictionary", "Juguete: pelota de la compania Pictionary para mayores de 81 años", "", "pelota", 614.51m, 81 },
                    { 98, "tren", "Juguete: cometa de la compania tren para mayores de 89 años", "", "cometa", 480.73m, 89 },
                    { 97, "UNO", "Juguete: cometa de la compania UNO para mayores de 35 años", "", "cometa", 942.20m, 35 },
                    { 96, "patito de goma", "Juguete: UNO de la compania patito de goma para mayores de 12 años", "", "UNO", 625.61m, 12 },
                    { 95, "UNO", "Juguete: Parchís de la compania UNO para mayores de 56 años", "", "Parchís", 266.91m, 56 },
                    { 94, "muñeca", "Juguete: Pictionary de la compania muñeca para mayores de 68 años", "", "Pictionary", 742.31m, 68 },
                    { 93, "patito de goma", "Juguete: ¿Quién es Quién? de la compania patito de goma para mayores de 49 años", "", "¿Quién es Quién?", 891.98m, 49 },
                    { 92, "pelota", "Juguete: pelota de la compania pelota para mayores de 72 años", "", "pelota", 436.51m, 72 },
                    { 91, "bicicleta", "Juguete: pelota de la compania bicicleta para mayores de 48 años", "", "pelota", 56.13m, 48 },
                    { 90, "avión", "Juguete: Pictionary de la compania avión para mayores de 46 años", "", "Pictionary", 859.94m, 46 },
                    { 89, "osito de peluche", "Juguete: bicicleta de la compania osito de peluche para mayores de 82 años", "", "bicicleta", 477.02m, 82 },
                    { 88, "tren", "Juguete: avión de la compania tren para mayores de 72 años", "", "avión", 382.02m, 72 },
                    { 87, "pelota", "Juguete: tren de la compania pelota para mayores de 28 años", "", "tren", 962.85m, 28 },
                    { 86, "Parchís", "Juguete: Pictionary de la compania Parchís para mayores de 0 años", "", "Pictionary", 982.46m, 0 },
                    { 85, "osito de peluche", "Juguete: cometa de la compania osito de peluche para mayores de 20 años", "", "cometa", 84.02m, 20 },
                    { 84, "tren", "Juguete: bicicleta de la compania tren para mayores de 69 años", "", "bicicleta", 341.48m, 69 },
                    { 83, "Parchís", "Juguete: Pictionary de la compania Parchís para mayores de 17 años", "", "Pictionary", 195.71m, 17 }
                });

            migrationBuilder.InsertData(
                table: "PlayThing",
                columns: new[] { "Id", "Compania", "Descripcíon", "Imagen", "Nombre", "Precio", "RetriccionEdad" },
                values: new object[,]
                {
                    { 82, "muñeca", "Juguete: UNO de la compania muñeca para mayores de 22 años", "", "UNO", 16.93m, 22 },
                    { 81, "pelota", "Juguete: ¿Quién es Quién? de la compania pelota para mayores de 25 años", "", "¿Quién es Quién?", 461.55m, 25 },
                    { 80, "bicicleta", "Juguete: cometa de la compania bicicleta para mayores de 60 años", "", "cometa", 794.59m, 60 },
                    { 79, "bicicleta", "Juguete: UNO de la compania bicicleta para mayores de 19 años", "", "UNO", 715.37m, 19 },
                    { 78, "pelota", "Juguete: pelota de la compania pelota para mayores de 73 años", "", "pelota", 807.83m, 73 },
                    { 76, "Parchís", "Juguete: muñeca de la compania Parchís para mayores de 52 años", "", "muñeca", 250.58m, 52 },
                    { 51, "patito de goma", "Juguete: osito de peluche de la compania patito de goma para mayores de 20 años", "", "osito de peluche", 166.22m, 20 },
                    { 50, "muñeca", "Juguete: bicicleta de la compania muñeca para mayores de 14 años", "", "bicicleta", 168.60m, 14 },
                    { 49, "¿Quién es Quién?", "Juguete: tren de la compania ¿Quién es Quién? para mayores de 86 años", "", "tren", 427.42m, 86 },
                    { 22, "¿Quién es Quién?", "Juguete: ¿Quién es Quién? de la compania ¿Quién es Quién? para mayores de 69 años", "", "¿Quién es Quién?", 265.99m, 69 },
                    { 21, "cometa", "Juguete: cometa de la compania cometa para mayores de 1 años", "", "cometa", 479.72m, 1 },
                    { 20, "muñeca", "Juguete: ¿Quién es Quién? de la compania muñeca para mayores de 32 años", "", "¿Quién es Quién?", 977.00m, 32 },
                    { 19, "Pictionary", "Juguete: Pictionary de la compania Pictionary para mayores de 46 años", "", "Pictionary", 625.74m, 46 },
                    { 18, "¿Quién es Quién?", "Juguete: pelota de la compania ¿Quién es Quién? para mayores de 66 años", "", "pelota", 127.82m, 66 },
                    { 17, "¿Quién es Quién?", "Juguete: cometa de la compania ¿Quién es Quién? para mayores de 38 años", "", "cometa", 352.73m, 38 },
                    { 16, "osito de peluche", "Juguete: Parchís de la compania osito de peluche para mayores de 85 años", "", "Parchís", 775.49m, 85 },
                    { 15, "patito de goma", "Juguete: muñeca de la compania patito de goma para mayores de 28 años", "", "muñeca", 104.33m, 28 },
                    { 14, "Parchís", "Juguete: bicicleta de la compania Parchís para mayores de 93 años", "", "bicicleta", 417.99m, 93 },
                    { 13, "Parchís", "Juguete: UNO de la compania Parchís para mayores de 24 años", "", "UNO", 161.58m, 24 },
                    { 12, "¿Quién es Quién?", "Juguete: bicicleta de la compania ¿Quién es Quién? para mayores de 94 años", "", "bicicleta", 527.11m, 94 },
                    { 11, "UNO", "Juguete: ¿Quién es Quién? de la compania UNO para mayores de 51 años", "", "¿Quién es Quién?", 497.06m, 51 },
                    { 10, "patito de goma", "Juguete: cometa de la compania patito de goma para mayores de 17 años", "", "cometa", 561.66m, 17 },
                    { 9, "UNO", "Juguete: bicicleta de la compania UNO para mayores de 38 años", "", "bicicleta", 342.71m, 38 },
                    { 8, "Pictionary", "Juguete: patito de goma de la compania Pictionary para mayores de 97 años", "", "patito de goma", 807.53m, 97 },
                    { 7, "muñeca", "Juguete: osito de peluche de la compania muñeca para mayores de 78 años", "", "osito de peluche", 753.47m, 78 },
                    { 6, "avión", "Juguete: muñeca de la compania avión para mayores de 5 años", "", "muñeca", 277.11m, 5 },
                    { 5, "bicicleta", "Juguete: ¿Quién es Quién? de la compania bicicleta para mayores de 61 años", "", "¿Quién es Quién?", 712.46m, 61 },
                    { 4, "patito de goma", "Juguete: bicicleta de la compania patito de goma para mayores de 98 años", "", "bicicleta", 143.99m, 98 },
                    { 3, "pelota", "Juguete: tren de la compania pelota para mayores de 11 años", "", "tren", 706.39m, 11 },
                    { 2, "muñeca", "Juguete: patito de goma de la compania muñeca para mayores de 78 años", "", "patito de goma", 55.52m, 78 },
                    { 23, "avión", "Juguete: osito de peluche de la compania avión para mayores de 23 años", "", "osito de peluche", 930.48m, 23 },
                    { 24, "UNO", "Juguete: ¿Quién es Quién? de la compania UNO para mayores de 29 años", "", "¿Quién es Quién?", 578.71m, 29 },
                    { 25, "tren", "Juguete: ¿Quién es Quién? de la compania tren para mayores de 9 años", "", "¿Quién es Quién?", 109.08m, 9 },
                    { 26, "bicicleta", "Juguete: bicicleta de la compania bicicleta para mayores de 83 años", "", "bicicleta", 893.49m, 83 },
                    { 48, "bicicleta", "Juguete: bicicleta de la compania bicicleta para mayores de 66 años", "", "bicicleta", 363.24m, 66 },
                    { 47, "tren", "Juguete: cometa de la compania tren para mayores de 58 años", "", "cometa", 811.02m, 58 },
                    { 46, "cometa", "Juguete: patito de goma de la compania cometa para mayores de 49 años", "", "patito de goma", 180.10m, 49 },
                    { 45, "avión", "Juguete: muñeca de la compania avión para mayores de 10 años", "", "muñeca", 569.43m, 10 },
                    { 44, "tren", "Juguete: Pictionary de la compania tren para mayores de 49 años", "", "Pictionary", 664.44m, 49 },
                    { 43, "avión", "Juguete: UNO de la compania avión para mayores de 87 años", "", "UNO", 518.39m, 87 },
                    { 42, "bicicleta", "Juguete: Parchís de la compania bicicleta para mayores de 48 años", "", "Parchís", 844.11m, 48 },
                    { 41, "bicicleta", "Juguete: muñeca de la compania bicicleta para mayores de 85 años", "", "muñeca", 277.14m, 85 }
                });

            migrationBuilder.InsertData(
                table: "PlayThing",
                columns: new[] { "Id", "Compania", "Descripcíon", "Imagen", "Nombre", "Precio", "RetriccionEdad" },
                values: new object[,]
                {
                    { 40, "avión", "Juguete: Parchís de la compania avión para mayores de 71 años", "", "Parchís", 311.82m, 71 },
                    { 39, "¿Quién es Quién?", "Juguete: osito de peluche de la compania ¿Quién es Quién? para mayores de 45 años", "", "osito de peluche", 474.85m, 45 },
                    { 99, "UNO", "Juguete: patito de goma de la compania UNO para mayores de 97 años", "", "patito de goma", 917.48m, 97 },
                    { 38, "tren", "Juguete: cometa de la compania tren para mayores de 38 años", "", "cometa", 969.78m, 38 },
                    { 36, "muñeca", "Juguete: patito de goma de la compania muñeca para mayores de 3 años", "", "patito de goma", 528.89m, 3 },
                    { 35, "pelota", "Juguete: patito de goma de la compania pelota para mayores de 53 años", "", "patito de goma", 669.60m, 53 },
                    { 34, "tren", "Juguete: patito de goma de la compania tren para mayores de 64 años", "", "patito de goma", 493.63m, 64 },
                    { 33, "tren", "Juguete: avión de la compania tren para mayores de 19 años", "", "avión", 427.54m, 19 },
                    { 32, "pelota", "Juguete: ¿Quién es Quién? de la compania pelota para mayores de 11 años", "", "¿Quién es Quién?", 95.06m, 11 },
                    { 31, "¿Quién es Quién?", "Juguete: avión de la compania ¿Quién es Quién? para mayores de 65 años", "", "avión", 309.83m, 65 },
                    { 30, "bicicleta", "Juguete: tren de la compania bicicleta para mayores de 40 años", "", "tren", 826.89m, 40 },
                    { 29, "pelota", "Juguete: UNO de la compania pelota para mayores de 83 años", "", "UNO", 815.33m, 83 },
                    { 28, "Pictionary", "Juguete: pelota de la compania Pictionary para mayores de 4 años", "", "pelota", 373.36m, 4 },
                    { 27, "UNO", "Juguete: cometa de la compania UNO para mayores de 89 años", "", "cometa", 303.41m, 89 },
                    { 37, "osito de peluche", "Juguete: Pictionary de la compania osito de peluche para mayores de 54 años", "", "Pictionary", 432.07m, 54 },
                    { 100, "avión", "Juguete: Parchís de la compania avión para mayores de 70 años", "", "Parchís", 626.30m, 70 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlayThing_Id",
                table: "PlayThing",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlayThing");
        }
    }
}
