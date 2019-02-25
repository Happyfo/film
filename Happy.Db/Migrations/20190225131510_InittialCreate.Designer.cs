﻿// <auto-generated />
using Happy.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Happy.Db.Migrations
{
    [DbContext(typeof(FilmContext))]
    [Migration("20190225131510_InittialCreate")]
    partial class InittialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Happy.Db.Filmtbl", b =>
                {
                    b.Property<int>("FilmId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("budget");

                    b.Property<string>("category");

                    b.Property<string>("title");

                    b.Property<string>("year");

                    b.HasKey("FilmId");

                    b.ToTable("Films");
                });
#pragma warning restore 612, 618
        }
    }
}
