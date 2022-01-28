using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Finra.Infrastructure.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActiveTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Code = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActiveTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Code = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CurrencyTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Code = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrencyTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Exchanges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Code = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exchanges", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Industries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Code = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Industries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IssuingCompanies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    CountryId = table.Column<int>(type: "integer", nullable: false),
                    IndustryId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IssuingCompanies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IssuingCompanies_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IssuingCompanies_Industries_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Assets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ticket = table.Column<string>(type: "text", nullable: true),
                    Isin = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    BeginDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LotSize = table.Column<int>(type: "integer", nullable: false),
                    CurrencyTypeid = table.Column<int>(type: "integer", nullable: false),
                    ExchangeId = table.Column<int>(type: "integer", nullable: false),
                    IssuingCompanyId = table.Column<int>(type: "integer", nullable: false),
                    ActiveTypeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Assets_ActiveTypes_ActiveTypeId",
                        column: x => x.ActiveTypeId,
                        principalTable: "ActiveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Assets_CurrencyTypes_CurrencyTypeid",
                        column: x => x.CurrencyTypeid,
                        principalTable: "CurrencyTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Assets_Exchanges_ExchangeId",
                        column: x => x.ExchangeId,
                        principalTable: "Exchanges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Assets_IssuingCompanies_IssuingCompanyId",
                        column: x => x.IssuingCompanyId,
                        principalTable: "IssuingCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ActiveTypes",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { 1, "share", "Акция" },
                    { 2, "bond", "Облигация" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { 1, "ru", "Россия" },
                    { 2, "usa", "США" }
                });

            migrationBuilder.InsertData(
                table: "CurrencyTypes",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { 1, "rub", "RUB" },
                    { 2, "usd", "USD" }
                });

            migrationBuilder.InsertData(
                table: "Exchanges",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 1, "MISX", "Московская биржа" });

            migrationBuilder.InsertData(
                table: "Industries",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { 1, "it", "IT" },
                    { 2, null, "Технологии" },
                    { 3, null, "Добыча ископаемых" },
                    { 4, null, "Нефть и газ" },
                    { 5, null, "Телекоммуникации" },
                    { 6, null, "Финансы" }
                });

            migrationBuilder.InsertData(
                table: "IssuingCompanies",
                columns: new[] { "Id", "CountryId", "IndustryId", "Name" },
                values: new object[,]
                {
                    { 1, 1, 1, "Яндекс" },
                    { 6, 2, 2, "Apple" },
                    { 5, 1, 3, "Алроса" },
                    { 4, 1, 4, "Сургутнефтегаз" },
                    { 3, 1, 5, "МТС" },
                    { 2, 1, 6, "Сбербанк России" }
                });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "ActiveTypeId", "BeginDate", "CurrencyTypeid", "EndDate", "ExchangeId", "Isin", "IssuingCompanyId", "LotSize", "Name", "Ticket" },
                values: new object[] { 1, 1, new DateTime(2007, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 1, "RU0009029540", 2, 10, "Сбербанк России, акция обыкновенная", "SBER" });

            migrationBuilder.CreateIndex(
                name: "IX_Assets_ActiveTypeId",
                table: "Assets",
                column: "ActiveTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Assets_CurrencyTypeid",
                table: "Assets",
                column: "CurrencyTypeid");

            migrationBuilder.CreateIndex(
                name: "IX_Assets_ExchangeId",
                table: "Assets",
                column: "ExchangeId");

            migrationBuilder.CreateIndex(
                name: "IX_Assets_IssuingCompanyId",
                table: "Assets",
                column: "IssuingCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_IssuingCompanies_CountryId",
                table: "IssuingCompanies",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_IssuingCompanies_IndustryId",
                table: "IssuingCompanies",
                column: "IndustryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assets");

            migrationBuilder.DropTable(
                name: "ActiveTypes");

            migrationBuilder.DropTable(
                name: "CurrencyTypes");

            migrationBuilder.DropTable(
                name: "Exchanges");

            migrationBuilder.DropTable(
                name: "IssuingCompanies");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Industries");
        }
    }
}
