using Microsoft.EntityFrameworkCore.Migrations;

namespace Finra.Infrastructure.Migrations
{
    public partial class upd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assets_ActiveTypes_ActiveTypeId",
                table: "Assets");

            migrationBuilder.DropForeignKey(
                name: "FK_Assets_CurrencyTypes_CurrencyTypeId",
                table: "Assets");

            migrationBuilder.DropForeignKey(
                name: "FK_Assets_Exchanges_ExchangeId",
                table: "Assets");

            migrationBuilder.DropForeignKey(
                name: "FK_Assets_IssuingCompanies_IssuingCompanyId",
                table: "Assets");

            migrationBuilder.DropForeignKey(
                name: "FK_IssuingCompanies_Countries_CountryId",
                table: "IssuingCompanies");

            migrationBuilder.DropForeignKey(
                name: "FK_IssuingCompanies_Industries_IndustryId",
                table: "IssuingCompanies");

            migrationBuilder.RenameColumn(
                name: "CountryId",
                table: "IssuingCompanies",
                newName: "Countryid");

            migrationBuilder.RenameIndex(
                name: "IX_IssuingCompanies_CountryId",
                table: "IssuingCompanies",
                newName: "IX_IssuingCompanies_Countryid");

            migrationBuilder.RenameColumn(
                name: "CurrencyTypeId",
                table: "Assets",
                newName: "CurrencyTypeid");

            migrationBuilder.RenameIndex(
                name: "IX_Assets_CurrencyTypeId",
                table: "Assets",
                newName: "IX_Assets_CurrencyTypeid");

            migrationBuilder.AlterColumn<int>(
                name: "IndustryId",
                table: "IssuingCompanies",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Countryid",
                table: "IssuingCompanies",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IssuingCompanyId",
                table: "Assets",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ExchangeId",
                table: "Assets",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CurrencyTypeid",
                table: "Assets",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ActiveTypeId",
                table: "Assets",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_ActiveTypes_ActiveTypeId",
                table: "Assets",
                column: "ActiveTypeId",
                principalTable: "ActiveTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_CurrencyTypes_CurrencyTypeid",
                table: "Assets",
                column: "CurrencyTypeid",
                principalTable: "CurrencyTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_Exchanges_ExchangeId",
                table: "Assets",
                column: "ExchangeId",
                principalTable: "Exchanges",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_IssuingCompanies_IssuingCompanyId",
                table: "Assets",
                column: "IssuingCompanyId",
                principalTable: "IssuingCompanies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IssuingCompanies_Countries_Countryid",
                table: "IssuingCompanies",
                column: "Countryid",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IssuingCompanies_Industries_IndustryId",
                table: "IssuingCompanies",
                column: "IndustryId",
                principalTable: "Industries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assets_ActiveTypes_ActiveTypeId",
                table: "Assets");

            migrationBuilder.DropForeignKey(
                name: "FK_Assets_CurrencyTypes_CurrencyTypeid",
                table: "Assets");

            migrationBuilder.DropForeignKey(
                name: "FK_Assets_Exchanges_ExchangeId",
                table: "Assets");

            migrationBuilder.DropForeignKey(
                name: "FK_Assets_IssuingCompanies_IssuingCompanyId",
                table: "Assets");

            migrationBuilder.DropForeignKey(
                name: "FK_IssuingCompanies_Countries_Countryid",
                table: "IssuingCompanies");

            migrationBuilder.DropForeignKey(
                name: "FK_IssuingCompanies_Industries_IndustryId",
                table: "IssuingCompanies");

            migrationBuilder.RenameColumn(
                name: "Countryid",
                table: "IssuingCompanies",
                newName: "CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_IssuingCompanies_Countryid",
                table: "IssuingCompanies",
                newName: "IX_IssuingCompanies_CountryId");

            migrationBuilder.RenameColumn(
                name: "CurrencyTypeid",
                table: "Assets",
                newName: "CurrencyTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Assets_CurrencyTypeid",
                table: "Assets",
                newName: "IX_Assets_CurrencyTypeId");

            migrationBuilder.AlterColumn<int>(
                name: "IndustryId",
                table: "IssuingCompanies",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "CountryId",
                table: "IssuingCompanies",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "IssuingCompanyId",
                table: "Assets",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "ExchangeId",
                table: "Assets",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "CurrencyTypeId",
                table: "Assets",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "ActiveTypeId",
                table: "Assets",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_ActiveTypes_ActiveTypeId",
                table: "Assets",
                column: "ActiveTypeId",
                principalTable: "ActiveTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_CurrencyTypes_CurrencyTypeId",
                table: "Assets",
                column: "CurrencyTypeId",
                principalTable: "CurrencyTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_Exchanges_ExchangeId",
                table: "Assets",
                column: "ExchangeId",
                principalTable: "Exchanges",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_IssuingCompanies_IssuingCompanyId",
                table: "Assets",
                column: "IssuingCompanyId",
                principalTable: "IssuingCompanies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IssuingCompanies_Countries_CountryId",
                table: "IssuingCompanies",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IssuingCompanies_Industries_IndustryId",
                table: "IssuingCompanies",
                column: "IndustryId",
                principalTable: "Industries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
