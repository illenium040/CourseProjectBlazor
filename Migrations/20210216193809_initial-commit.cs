using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseProjectBlazor.Migrations
{
    public partial class initialcommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RamCooling",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT COLLATE NOCASE", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RamCooling", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RamFormFactor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT COLLATE NOCASE", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RamFormFactor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RamManufacturer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT COLLATE NOCASE", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RamManufacturer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RamType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT COLLATE NOCASE", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RamType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ram",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ManufacturerId = table.Column<int>(type: "INTEGER", nullable: false),
                    Model = table.Column<string>(type: "TEXT", nullable: true),
                    FormFactorId = table.Column<int>(type: "INTEGER", nullable: false),
                    TypeId = table.Column<int>(type: "INTEGER", nullable: false),
                    OneModuleSize = table.Column<int>(type: "INTEGER", nullable: false),
                    ModuleAmount = table.Column<int>(type: "INTEGER", nullable: false),
                    Frequency = table.Column<int>(type: "INTEGER", nullable: false),
                    Throughput = table.Column<int>(type: "INTEGER", nullable: false),
                    Latency = table.Column<int>(type: "INTEGER", nullable: false),
                    RasToCasDelay = table.Column<int>(type: "INTEGER", nullable: false),
                    RowPrechargeDelay = table.Column<int>(type: "INTEGER", nullable: false),
                    Voltage = table.Column<double>(type: "REAL", nullable: false),
                    CoolingId = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ram", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ram_RamCooling_CoolingId",
                        column: x => x.CoolingId,
                        principalTable: "RamCooling",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ram_RamFormFactor_FormFactorId",
                        column: x => x.FormFactorId,
                        principalTable: "RamFormFactor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ram_RamManufacturer_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "RamManufacturer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ram_RamType_TypeId",
                        column: x => x.TypeId,
                        principalTable: "RamType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ram_CoolingId",
                table: "Ram",
                column: "CoolingId");

            migrationBuilder.CreateIndex(
                name: "IX_Ram_FormFactorId",
                table: "Ram",
                column: "FormFactorId");

            migrationBuilder.CreateIndex(
                name: "IX_Ram_ManufacturerId",
                table: "Ram",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Ram_TypeId",
                table: "Ram",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RamCooling_Name",
                table: "RamCooling",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RamFormFactor_Name",
                table: "RamFormFactor",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RamManufacturer_Name",
                table: "RamManufacturer",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RamType_Name",
                table: "RamType",
                column: "Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ram");

            migrationBuilder.DropTable(
                name: "RamCooling");

            migrationBuilder.DropTable(
                name: "RamFormFactor");

            migrationBuilder.DropTable(
                name: "RamManufacturer");

            migrationBuilder.DropTable(
                name: "RamType");
        }
    }
}
