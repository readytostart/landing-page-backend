using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using StartToReadyLandingPage.Models;
using StartToReadyLandingPage.Models.Enums;

namespace StartToReadyLandingPage.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20170917155135_WebApi_With_EFCore.Models.ApplicationContextAzure")]
    partial class WebApi_With_EFCoreModelsApplicationContextAzure
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StartToReadyLandingPage.Models.Lead", b =>
                {
                    b.Property<string>("Email")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Email")
                        .HasMaxLength(50);

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnName("Cidade")
                        .HasMaxLength(50);

                    b.Property<bool>("EhAluno")
                        .HasColumnName("EhAluno")
                        .HasColumnType("bit");

                    b.Property<int>("Empresa")
                        .HasColumnName("Empresa")
                        .HasColumnType("int");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnName("Estado")
                        .HasMaxLength(2);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("Nome")
                        .HasMaxLength(50);

                    b.Property<string>("Profissao")
                        .IsRequired()
                        .HasColumnName("Profissao")
                        .HasMaxLength(50);

                    b.HasKey("Email");

                    b.ToTable("lead");
                });
        }
    }
}
