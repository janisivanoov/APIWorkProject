using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace mysqltest.Migrations
{
    public partial class mysqltestmodelsinitStudentClubs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentClubs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ClubId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentClubs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentClubs_Clubs_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Clubs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentClubs_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 2, 16, 2, 6, 181, DateTimeKind.Local).AddTicks(9968), new DateTime(2021, 9, 2, 16, 2, 6, 185, DateTimeKind.Local).AddTicks(9131) });

            migrationBuilder.UpdateData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 2, 16, 2, 6, 185, DateTimeKind.Local).AddTicks(9672), new DateTime(2021, 9, 2, 16, 2, 6, 185, DateTimeKind.Local).AddTicks(9699) });

            migrationBuilder.UpdateData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 2, 16, 2, 6, 185, DateTimeKind.Local).AddTicks(9715), new DateTime(2021, 9, 2, 16, 2, 6, 185, DateTimeKind.Local).AddTicks(9719) });

            migrationBuilder.UpdateData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 2, 16, 2, 6, 185, DateTimeKind.Local).AddTicks(9724), new DateTime(2021, 9, 2, 16, 2, 6, 185, DateTimeKind.Local).AddTicks(9728) });

            migrationBuilder.InsertData(
                table: "StudentClubs",
                columns: new[] { "Id", "ClubId", "StudentId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 12, 2, 6 },
                    { 11, 2, 5 },
                    { 10, 4, 3 },
                    { 13, 1, 7 },
                    { 8, 2, 7 },
                    { 7, 1, 6 },
                    { 6, 2, 5 },
                    { 5, 3, 4 },
                    { 4, 4, 3 },
                    { 3, 3, 2 },
                    { 2, 2, 1 },
                    { 9, 3, 8 }
                });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 2, 16, 2, 6, 187, DateTimeKind.Local).AddTicks(5851), new DateTime(2021, 9, 2, 16, 2, 6, 187, DateTimeKind.Local).AddTicks(5891) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 2, 16, 2, 6, 187, DateTimeKind.Local).AddTicks(5964), new DateTime(2021, 9, 2, 16, 2, 6, 187, DateTimeKind.Local).AddTicks(5968) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 2, 16, 2, 6, 187, DateTimeKind.Local).AddTicks(5974), new DateTime(2021, 9, 2, 16, 2, 6, 187, DateTimeKind.Local).AddTicks(5977) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 2, 16, 2, 6, 187, DateTimeKind.Local).AddTicks(5984), new DateTime(2021, 9, 2, 16, 2, 6, 187, DateTimeKind.Local).AddTicks(5988) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 2, 16, 2, 6, 187, DateTimeKind.Local).AddTicks(5992), new DateTime(2021, 9, 2, 16, 2, 6, 187, DateTimeKind.Local).AddTicks(5996) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 2, 16, 2, 6, 187, DateTimeKind.Local).AddTicks(6001), new DateTime(2021, 9, 2, 16, 2, 6, 187, DateTimeKind.Local).AddTicks(6004) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 2, 16, 2, 6, 187, DateTimeKind.Local).AddTicks(6009), new DateTime(2021, 9, 2, 16, 2, 6, 187, DateTimeKind.Local).AddTicks(6012) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 2, 16, 2, 6, 187, DateTimeKind.Local).AddTicks(6017), new DateTime(2021, 9, 2, 16, 2, 6, 187, DateTimeKind.Local).AddTicks(6020) });

            migrationBuilder.CreateIndex(
                name: "IX_StudentClubs_ClubId",
                table: "StudentClubs",
                column: "ClubId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentClubs_StudentId",
                table: "StudentClubs",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentClubs");

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

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 2, 15, 55, 48, 702, DateTimeKind.Local).AddTicks(7283), new DateTime(2021, 9, 2, 15, 55, 48, 702, DateTimeKind.Local).AddTicks(7359) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 2, 15, 55, 48, 702, DateTimeKind.Local).AddTicks(7447), new DateTime(2021, 9, 2, 15, 55, 48, 702, DateTimeKind.Local).AddTicks(7452) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 2, 15, 55, 48, 702, DateTimeKind.Local).AddTicks(7459), new DateTime(2021, 9, 2, 15, 55, 48, 702, DateTimeKind.Local).AddTicks(7462) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 2, 15, 55, 48, 702, DateTimeKind.Local).AddTicks(7467), new DateTime(2021, 9, 2, 15, 55, 48, 702, DateTimeKind.Local).AddTicks(7473) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 2, 15, 55, 48, 702, DateTimeKind.Local).AddTicks(7479), new DateTime(2021, 9, 2, 15, 55, 48, 702, DateTimeKind.Local).AddTicks(7484) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 2, 15, 55, 48, 702, DateTimeKind.Local).AddTicks(7491), new DateTime(2021, 9, 2, 15, 55, 48, 702, DateTimeKind.Local).AddTicks(7496) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 2, 15, 55, 48, 702, DateTimeKind.Local).AddTicks(7502), new DateTime(2021, 9, 2, 15, 55, 48, 702, DateTimeKind.Local).AddTicks(7507) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 2, 15, 55, 48, 702, DateTimeKind.Local).AddTicks(7513), new DateTime(2021, 9, 2, 15, 55, 48, 702, DateTimeKind.Local).AddTicks(7518) });
        }
    }
}
