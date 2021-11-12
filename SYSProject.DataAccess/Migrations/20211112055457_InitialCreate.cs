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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    { 1L, 700m, 1L, new DateTime(2021, 11, 12, 8, 54, 56, 965, DateTimeKind.Local).AddTicks(8373), null, null, false, "Ürün1", 1000m, null, null },
                    { 2L, 400m, 1L, new DateTime(2021, 11, 12, 8, 54, 56, 966, DateTimeKind.Local).AddTicks(8485), null, null, false, "Ürün2", 500m, null, null },
                    { 3L, 5000m, 1L, new DateTime(2021, 11, 12, 8, 54, 56, 966, DateTimeKind.Local).AddTicks(8502), null, null, false, "Ürün3", 7000m, null, null },
                    { 4L, 2000m, 1L, new DateTime(2021, 11, 12, 8, 54, 56, 966, DateTimeKind.Local).AddTicks(8505), null, null, false, "Ürün4", 2800m, null, null },
                    { 5L, 6000m, 1L, new DateTime(2021, 11, 12, 8, 54, 56, 966, DateTimeKind.Local).AddTicks(8507), null, null, false, "Ürün5", 9000m, null, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "Email", "FirstName", "IsDeleted", "LastName", "PasswordHash", "PasswordSalt", "UpdatedBy", "UpdatedDate", "UserName" },
                values: new object[] { 1L, 1L, new DateTime(2021, 11, 12, 8, 54, 56, 970, DateTimeKind.Local).AddTicks(1764), null, null, "taylanaltun@gmail.com", "Taylan", false, "Altun", new byte[] { 245, 106, 60, 78, 197, 150, 140, 156, 186, 49, 63, 99, 155, 204, 238, 139, 10, 66, 148, 133, 229, 117, 41, 44, 99, 194, 85, 210, 16, 42, 87, 57, 170, 17, 29, 26, 6, 204, 1, 37, 150, 55, 62, 77, 64, 147, 205, 51, 179, 228, 23, 251, 197, 172, 160, 9, 139, 30, 255, 202, 113, 76, 160, 88 }, new byte[] { 159, 84, 64, 156, 2, 80, 199, 86, 207, 206, 251, 169, 217, 36, 125, 13, 132, 199, 144, 11, 53, 182, 170, 32, 50, 161, 45, 224, 110, 245, 187, 43, 142, 215, 140, 81, 28, 248, 178, 40, 20, 160, 35, 161, 138, 224, 43, 19, 113, 128, 124, 120, 32, 212, 173, 3, 30, 211, 104, 210, 89, 84, 201, 12, 4, 43, 183, 97, 208, 245, 234, 167, 249, 239, 192, 84, 47, 243, 33, 124, 181, 193, 205, 221, 2, 201, 172, 44, 23, 236, 136, 87, 168, 117, 44, 198, 178, 77, 227, 74, 144, 175, 63, 116, 56, 210, 191, 165, 69, 142, 164, 155, 75, 245, 136, 40, 112, 92, 43, 193, 116, 156, 223, 187, 97, 42, 41, 204 }, null, null, "Taylan" });
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
