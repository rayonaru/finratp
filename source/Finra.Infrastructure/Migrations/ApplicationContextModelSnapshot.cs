// <auto-generated />
using System;
using Finra.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Finra.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Finra.Core.Models.ActiveType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Code")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ActiveTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Code = "share",
                            Name = "Акция"
                        },
                        new
                        {
                            Id = 2,
                            Code = "bond",
                            Name = "Облигация"
                        });
                });

            modelBuilder.Entity("Finra.Core.Models.Asset", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ActiveTypeId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("BeginDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("CurrencyTypeid")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("ExchangeId")
                        .HasColumnType("integer");

                    b.Property<string>("Isin")
                        .HasColumnType("text");

                    b.Property<int>("IssuingCompanyId")
                        .HasColumnType("integer");

                    b.Property<int>("LotSize")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Ticket")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ActiveTypeId");

                    b.HasIndex("CurrencyTypeid");

                    b.HasIndex("ExchangeId");

                    b.HasIndex("IssuingCompanyId");

                    b.ToTable("Assets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ActiveTypeId = 1,
                            BeginDate = new DateTime(2007, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CurrencyTypeid = 1,
                            ExchangeId = 1,
                            Isin = "RU0009029540",
                            IssuingCompanyId = 2,
                            LotSize = 10,
                            Name = "Сбербанк России, акция обыкновенная",
                            Ticket = "SBER"
                        });
                });

            modelBuilder.Entity("Finra.Core.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Code")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Code = "ru",
                            Name = "Россия"
                        },
                        new
                        {
                            Id = 2,
                            Code = "usa",
                            Name = "США"
                        });
                });

            modelBuilder.Entity("Finra.Core.Models.CurrencyType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Code")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("CurrencyTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Code = "rub",
                            Name = "RUB"
                        },
                        new
                        {
                            Id = 2,
                            Code = "usd",
                            Name = "USD"
                        });
                });

            modelBuilder.Entity("Finra.Core.Models.Exchange", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Code")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Exchanges");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Code = "MISX",
                            Name = "Московская биржа"
                        });
                });

            modelBuilder.Entity("Finra.Core.Models.Industry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Code")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Industries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Code = "it",
                            Name = "IT"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Технологии"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Добыча ископаемых"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Нефть и газ"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Телекоммуникации"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Финансы"
                        });
                });

            modelBuilder.Entity("Finra.Core.Models.IssuingCompany", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CountryId")
                        .HasColumnType("integer");

                    b.Property<int>("IndustryId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("IndustryId");

                    b.ToTable("IssuingCompanies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryId = 1,
                            IndustryId = 1,
                            Name = "Яндекс"
                        },
                        new
                        {
                            Id = 2,
                            CountryId = 1,
                            IndustryId = 6,
                            Name = "Сбербанк России"
                        },
                        new
                        {
                            Id = 3,
                            CountryId = 1,
                            IndustryId = 5,
                            Name = "МТС"
                        },
                        new
                        {
                            Id = 4,
                            CountryId = 1,
                            IndustryId = 4,
                            Name = "Сургутнефтегаз"
                        },
                        new
                        {
                            Id = 5,
                            CountryId = 1,
                            IndustryId = 3,
                            Name = "Алроса"
                        },
                        new
                        {
                            Id = 6,
                            CountryId = 2,
                            IndustryId = 2,
                            Name = "Apple"
                        });
                });

            modelBuilder.Entity("Finra.Core.Models.Asset", b =>
                {
                    b.HasOne("Finra.Core.Models.ActiveType", "ActiveType")
                        .WithMany("Assets")
                        .HasForeignKey("ActiveTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Finra.Core.Models.CurrencyType", "CurrencyType")
                        .WithMany("Assets")
                        .HasForeignKey("CurrencyTypeid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Finra.Core.Models.Exchange", "Exchange")
                        .WithMany("Assets")
                        .HasForeignKey("ExchangeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Finra.Core.Models.IssuingCompany", "IssuingCompany")
                        .WithMany("Assets")
                        .HasForeignKey("IssuingCompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ActiveType");

                    b.Navigation("CurrencyType");

                    b.Navigation("Exchange");

                    b.Navigation("IssuingCompany");
                });

            modelBuilder.Entity("Finra.Core.Models.IssuingCompany", b =>
                {
                    b.HasOne("Finra.Core.Models.Country", "Country")
                        .WithMany("IssuingCompanies")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Finra.Core.Models.Industry", "Industry")
                        .WithMany("IssuingCompanies")
                        .HasForeignKey("IndustryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");

                    b.Navigation("Industry");
                });

            modelBuilder.Entity("Finra.Core.Models.ActiveType", b =>
                {
                    b.Navigation("Assets");
                });

            modelBuilder.Entity("Finra.Core.Models.Country", b =>
                {
                    b.Navigation("IssuingCompanies");
                });

            modelBuilder.Entity("Finra.Core.Models.CurrencyType", b =>
                {
                    b.Navigation("Assets");
                });

            modelBuilder.Entity("Finra.Core.Models.Exchange", b =>
                {
                    b.Navigation("Assets");
                });

            modelBuilder.Entity("Finra.Core.Models.Industry", b =>
                {
                    b.Navigation("IssuingCompanies");
                });

            modelBuilder.Entity("Finra.Core.Models.IssuingCompany", b =>
                {
                    b.Navigation("Assets");
                });
#pragma warning restore 612, 618
        }
    }
}
