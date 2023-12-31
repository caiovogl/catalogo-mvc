﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using catalogo.Models;

#nullable disable

namespace catalogo.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20231201173448_criacaoBDSqlite")]
    partial class criacaoBDSqlite
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("catalogo.Models.ControleCadastro", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("endereco")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("senha")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Cadastro");
                });
#pragma warning restore 612, 618
        }
    }
}
