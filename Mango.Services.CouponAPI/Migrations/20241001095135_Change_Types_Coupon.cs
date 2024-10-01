using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Mango.Services.CouponAPI.Migrations
{
    /// <inheritdoc />
    public partial class Change_Types_Coupon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdated",
                table: "Coupons",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            // Drop the primary key constraint
            migrationBuilder.DropPrimaryKey(
                name: "PK_Coupons",
                table: "Coupons");
            
            // Drop the old CouponId column
            migrationBuilder.DropColumn(
                name: "CouponId",
                table: "Coupons");

            // Recreate the CouponId column with the IDENTITY property
            migrationBuilder.AddColumn<int>(
                name: "CouponId",
                table: "Coupons",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");  // This adds the IDENTITY property

            // Recreate the primary key constraint on the new CouponId column
            migrationBuilder.AddPrimaryKey(
                name: "PK_Coupons",
                table: "Coupons",
                column: "CouponId");

            migrationBuilder.InsertData(
                table: "Coupons",
                columns: new[] { "CouponId", "CouponCode", "DiscountAmount", "LastUpdated", "MinAmount" },
                values: new object[,]
                {
                    { 1, "0001", 20.0, null, 20 },
                    { 2, "0002", 10.0, null, 15 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "CouponId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "CouponId",
                keyValue: 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdated",
                table: "Coupons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            // Drop the primary key constraint on the recreated column
            migrationBuilder.DropPrimaryKey(
                name: "PK_Coupons",
                table: "Coupons");

            // Drop the new CouponId column
            migrationBuilder.DropColumn(
                name: "CouponId",
                table: "Coupons");

            // Recreate the original CouponId column with the original type (e.g., int)
            migrationBuilder.AddColumn<int>(
                name: "CouponId",
                table: "Coupons",
                nullable: false)
                .Annotation("SqlServer:Identity", "1, 1");  // Re-add IDENTITY property if it was present

            // Re-add the primary key constraint
            migrationBuilder.AddPrimaryKey(
                name: "PK_Coupons",
                table: "Coupons",
                column: "CouponId");
            //migrationBuilder.AlterColumn<string>(
            //    name: "CouponId",
            //    table: "Coupons",
            //    type: "nvarchar(450)",
            //    nullable: false,
            //    oldClrType: typeof(int),
            //    oldType: "int")
            //    .OldAnnotation("SqlServer:Identity", "1, 1");
        }
    }
}
