﻿// <auto-generated />
using System;
using BuscaDadosCVM.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BuscaDadosCVM.Migrations
{
    [DbContext(typeof(BuscaDadosCVMContext))]
    partial class BuscaDadosCVMContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BuscaDadosCVM.Models.Taxa", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("CAPTC_DIA");

                    b.Property<string>("CNPJ_FUNDO");

                    b.Property<DateTime>("DT_COMPTC");

                    b.Property<decimal>("NR_COTST");

                    b.Property<decimal>("RESG_DIA");

                    b.Property<decimal>("VL_PATRIM_LIQ");

                    b.Property<decimal>("VL_QUOTA");

                    b.Property<decimal>("VL_TOTAL");

                    b.HasKey("id");

                    b.ToTable("Taxa");
                });
#pragma warning restore 612, 618
        }
    }
}
