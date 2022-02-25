using Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Persistance.Database.Configuration
{
    public class PlayThingConfiguration
    {
       
        public PlayThingConfiguration(EntityTypeBuilder<PlayThing> entityBuilder)
        {
            entityBuilder.HasIndex(x => x.Id);
            entityBuilder.Property(x => x.Nombre).IsRequired().HasMaxLength(50);
            entityBuilder.Property(x => x.Descripcíon).HasMaxLength(100);
            entityBuilder.Property(x => x.Compania).IsRequired().HasMaxLength(50);
            entityBuilder.Property(x => x.Precio).HasPrecision(5, 2);



            // Employee by default
            CreateToysDataByPopulate(entityBuilder);

        }

        public static void CreateToysDataByPopulate(EntityTypeBuilder<PlayThing>  entityBuilder)
        {
            var toys = new List<PlayThing>();
            var random = new Random();

                for (int i = 1; i < 101; i++)
                {

                    var nombre = GetRandomData("name");
                    var company = GetRandomData("name");
                    var edad = random.Next(0, 100);
                    var descripcion = "Juguete: "+ nombre + " de la compania " + company + " para mayores de " + edad + " años";

                toys.Add(new PlayThing
                {
                    Id = i,
                    Nombre = nombre,
                    Compania = company,
                    Descripcíon = descripcion,
                    RetriccionEdad = edad,
                    Precio = Convert.ToDecimal(GetRandomData("decimal")),
                    Imagen = ""
                }); ;
            }
            entityBuilder.HasData(toys);
        }

        public static string GetRandomData(string type)
        {
            string[] names = { "bicicleta", "tren", "muñeca", "pelota", "osito de peluche", "cometa", "patito de goma", "avión", "Pictionary", "Parchís", "¿Quién es Quién?", "UNO" };
            string[] company = { "Lego", "Mattel", "Nintendo", "Playmobil", "Hasbro"};

            Random random = new();
            string result = "";
            int index;

            switch (type)
            {
                case "name":
                    index = random.Next(0, names.Length);
                    result = names[index];
                    break;
                case "compania":
                    index = random.Next(0, company.Length);
                    result = company[index];
                    break;
                case "decimal":
                    result = Math.Round(new decimal(random.NextDouble()) * 1000, 2).ToString("0.00", System.Globalization.CultureInfo.InvariantCulture).ToString();
                    break;

            }
            return result;
        }
    }
}
