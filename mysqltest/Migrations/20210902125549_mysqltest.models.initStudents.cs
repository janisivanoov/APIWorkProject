using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace mysqltest.Migrations
{
    public partial class mysqltestmodelsinitStudents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BirthDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Password = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 2, 15, 55, 48, 697, DateTimeKind.Local).AddTicks(2579), new DateTime(2021, 9, 2, 15, 55, 48, 700, DateTimeKind.Local).AddTicks(7979) });

            migrationBuilder.UpdateData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 2, 15, 55, 48, 700, DateTimeKind.Local).AddTicks(8606), new DateTime(2021, 9, 2, 15, 55, 48, 700, DateTimeKind.Local).AddTicks(8638) });

            migrationBuilder.UpdateData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 2, 15, 55, 48, 700, DateTimeKind.Local).AddTicks(8652), new DateTime(2021, 9, 2, 15, 55, 48, 700, DateTimeKind.Local).AddTicks(8655) });

            migrationBuilder.UpdateData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 2, 15, 55, 48, 700, DateTimeKind.Local).AddTicks(8660), new DateTime(2021, 9, 2, 15, 55, 48, 700, DateTimeKind.Local).AddTicks(8664) });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BirthDate", "CreatedDate", "FirstName", "LastName", "Password", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(1999, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 2, 15, 55, 48, 702, DateTimeKind.Local).AddTicks(7283), "Ali", "Tayari", null, new DateTime(2021, 9, 2, 15, 55, 48, 702, DateTimeKind.Local).AddTicks(7359) },
                    { 2, new DateTime(1963, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 2, 15, 55, 48, 702, DateTimeKind.Local).AddTicks(7447), "Dmitry", "Apraksin", null, new DateTime(2021, 9, 2, 15, 55, 48, 702, DateTimeKind.Local).AddTicks(7452) },
                    { 3, new DateTime(2004, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 2, 15, 55, 48, 702, DateTimeKind.Local).AddTicks(7459), "Ivan", "Ivanou", null, new DateTime(2021, 9, 2, 15, 55, 48, 702, DateTimeKind.Local).AddTicks(7462) },
                    { 4, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 2, 15, 55, 48, 702, DateTimeKind.Local).AddTicks(7467), "Petr", "Petrov", null, new DateTime(2021, 9, 2, 15, 55, 48, 702, DateTimeKind.Local).AddTicks(7473) },
                    { 5, new DateTime(1989, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 2, 15, 55, 48, 702, DateTimeKind.Local).AddTicks(7479), "Sidor", "Sidorov", null, new DateTime(2021, 9, 2, 15, 55, 48, 702, DateTimeKind.Local).AddTicks(7484) },
                    { 6, new DateTime(2000, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 2, 15, 55, 48, 702, DateTimeKind.Local).AddTicks(7491), "Pambos", "Boss", null, new DateTime(2021, 9, 2, 15, 55, 48, 702, DateTimeKind.Local).AddTicks(7496) },
                    { 7, new DateTime(1998, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 2, 15, 55, 48, 702, DateTimeKind.Local).AddTicks(7502), "Christos", "Christou", null, new DateTime(2021, 9, 2, 15, 55, 48, 702, DateTimeKind.Local).AddTicks(7507) },
                    { 8, new DateTime(1999, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 2, 15, 55, 48, 702, DateTimeKind.Local).AddTicks(7513), "Savvas", "Savvou", null, new DateTime(2021, 9, 2, 15, 55, 48, 702, DateTimeKind.Local).AddTicks(7518) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.UpdateData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
