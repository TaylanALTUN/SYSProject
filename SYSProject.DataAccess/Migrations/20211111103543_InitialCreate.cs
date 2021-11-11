using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SYSProject.DataAccess.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SaleUnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BuyUnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BuyUnitPrice", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "Name", "SaleUnitPrice", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, 700m, 1L, new DateTime(2021, 11, 11, 13, 35, 42, 825, DateTimeKind.Local).AddTicks(7346), null, null, false, "Ürün1", 1000m, null, null },
                    { 2L, 400m, 1L, new DateTime(2021, 11, 11, 13, 35, 42, 826, DateTimeKind.Local).AddTicks(7411), null, null, false, "Ürün2", 500m, null, null },
                    { 3L, 5000m, 1L, new DateTime(2021, 11, 11, 13, 35, 42, 826, DateTimeKind.Local).AddTicks(7427), null, null, false, "Ürün3", 7000m, null, null },
                    { 4L, 2000m, 1L, new DateTime(2021, 11, 11, 13, 35, 42, 826, DateTimeKind.Local).AddTicks(7429), null, null, false, "Ürün4", 2800m, null, null },
                    { 5L, 6000m, 1L, new DateTime(2021, 11, 11, 13, 35, 42, 826, DateTimeKind.Local).AddTicks(7431), null, null, false, "Ürün5", 9000m, null, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "Email", "FirstName", "IsDeleted", "LastName", "PasswordHash", "PasswordSalt", "UpdatedBy", "UpdatedDate", "UserName" },
                values: new object[] { 1L, 1L, new DateTime(2021, 11, 11, 13, 35, 42, 830, DateTimeKind.Local).AddTicks(2122), null, null, "taylanaltun@gmail.com", "Taylan", false, "Altun", new byte[] { 160, 75, 104, 157, 147, 42, 66, 37, 212, 214, 7, 46, 148, 53, 200, 24, 15, 66, 85, 5, 134, 111, 227, 172, 221, 201, 153, 192, 1, 196, 251, 190, 80, 210, 34, 51, 248, 52, 30, 225, 138, 186, 154, 15, 21, 132, 125, 80, 222, 99, 207, 23, 119, 41, 49, 8, 89, 23, 108, 188, 186, 13, 146, 138 }, new byte[] { 67, 50, 197, 17, 167, 201, 177, 146, 112, 254, 181, 147, 60, 130, 4, 219, 76, 228, 177, 235, 57, 23, 19, 170, 215, 227, 77, 121, 75, 238, 8, 250, 185, 196, 116, 51, 4, 146, 146, 49, 155, 77, 212, 49, 34, 171, 76, 63, 232, 105, 110, 121, 83, 203, 22, 174, 215, 131, 168, 69, 143, 7, 105, 56, 191, 57, 116, 221, 142, 126, 36, 109, 186, 50, 178, 54, 205, 93, 235, 235, 102, 70, 100, 11, 11, 5, 119, 150, 72, 142, 30, 165, 213, 125, 201, 6, 187, 249, 241, 164, 171, 179, 43, 170, 114, 90, 193, 185, 62, 131, 110, 226, 67, 47, 41, 46, 197, 70, 136, 210, 7, 56, 42, 16, 164, 137, 202, 137 }, null, null, "Taylan" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
