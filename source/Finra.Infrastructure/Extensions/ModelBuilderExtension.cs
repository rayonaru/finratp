using System;
using Finra.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Finra.Infrastructure.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CurrencyType>().HasData(
                new CurrencyType { Id = 1, Name = "RUB", Code = "rub" },
                new CurrencyType { Id = 2, Name = "USD", Code = "usd" }
            );

            modelBuilder.Entity<ActiveType>().HasData(
                new ActiveType { Id = 1, Name = "Акция", Code = "share" },
                new ActiveType { Id = 2, Name = "Облигация", Code = "bond" }
            );

            modelBuilder.Entity<Country>().HasData(
                new Country { Id = 1, Name = "Россия", Code = "ru" },
                new Country { Id = 2, Name = "США", Code = "usa" }
            );

            modelBuilder.Entity<Exchange>().HasData(
                new Exchange { Id = 1, Name = "Московская биржа", Code = "MISX" }
            );

            modelBuilder.Entity<Industry>().HasData(
                new Industry { Id = 1, Name = "IT", Code = "it" },
                new Industry { Id = 2, Name = "Технологии" },
                new Industry { Id = 3, Name = "Добыча ископаемых" },
                new Industry { Id = 4, Name = "Нефть и газ" },
                new Industry { Id = 5, Name = "Телекоммуникации" },
                new Industry { Id = 6, Name = "Финансы" }
            );

            modelBuilder.Entity<IssuingCompany>().HasData(
                new IssuingCompany { Id = 1, Name = "Яндекс", CountryId = 1, IndustryId = 1 },
                new IssuingCompany { Id = 2, Name = "Сбербанк России", CountryId = 1, IndustryId = 6 },
                new IssuingCompany { Id = 3, Name = "МТС", CountryId = 1, IndustryId = 5 },
                new IssuingCompany { Id = 4, Name = "Сургутнефтегаз", CountryId = 1, IndustryId = 4 },
                new IssuingCompany { Id = 5, Name = "Алроса", CountryId = 1, IndustryId = 3 },
                new IssuingCompany { Id = 6, Name = "Apple", CountryId = 2, IndustryId = 2 }
            );

            modelBuilder.Entity<Asset>().HasData(
                new Asset { Id = 1, Ticket = "SBER", Isin = "RU0009029540", Name = "Сбербанк России, акция обыкновенная", BeginDate = new DateTime(2007, 7, 20), LotSize = 10, ActiveTypeId = 1, IssuingCompanyId = 2, ExchangeId = 1, CurrencyTypeid = 1 }
            );
        }
    }
}