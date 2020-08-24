using Microsoft.EntityFrameworkCore.Migrations;

namespace RestApiTemplate.Infrastructure.Migrations
{
    public partial class InitialSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Games" },
                    { 2, "Heroes" },
                    { 3, "Movies" },
                    { 4, "Television" },
                    { 5, "Other" }
                });

            migrationBuilder.InsertData(
                table: "Feature",
                columns: new[] { "FeatureId", "FeatureName" },
                values: new object[,]
                {
                    { 10, "Texture Variant" },
                    { 9, "Outfit Variant" },
                    { 8, "Multipack" },
                    { 7, "Metallic" },
                    { 6, "Glow" },
                    { 5, "Glitter" },
                    { 4, "Flocked" },
                    { 3, "Exclusive" },
                    { 2, "Colour Variant" },
                    { 1, "Chase" }
                });

            migrationBuilder.InsertData(
                table: "License",
                columns: new[] { "LicenseId", "LicenseName" },
                values: new object[,]
                {
                    { 1, "DC" },
                    { 2, "Marvel" },
                    { 3, "Mr Robot" },
                    { 4, "Star Wars" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Feature",
                keyColumn: "FeatureId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Feature",
                keyColumn: "FeatureId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Feature",
                keyColumn: "FeatureId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Feature",
                keyColumn: "FeatureId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Feature",
                keyColumn: "FeatureId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Feature",
                keyColumn: "FeatureId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Feature",
                keyColumn: "FeatureId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Feature",
                keyColumn: "FeatureId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Feature",
                keyColumn: "FeatureId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Feature",
                keyColumn: "FeatureId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "License",
                keyColumn: "LicenseId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "License",
                keyColumn: "LicenseId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "License",
                keyColumn: "LicenseId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "License",
                keyColumn: "LicenseId",
                keyValue: 4);
        }
    }
}
