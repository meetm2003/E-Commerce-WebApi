﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ecommerce.Model;

#nullable disable

namespace ecommerce.Migrations
{
    [DbContext(typeof(EcommDbContext))]
    [Migration("20240410065719_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ecommerce.Model.Order", b =>
                {
                    b.Property<int>("O_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("O_Id"));

                    b.Property<int>("O_Price")
                        .HasColumnType("int");

                    b.Property<int>("O_Qty")
                        .HasColumnType("int");

                    b.Property<int>("P_Id")
                        .HasColumnType("int");

                    b.Property<int>("U_Id")
                        .HasColumnType("int");

                    b.HasKey("O_Id");

                    b.HasIndex("P_Id");

                    b.HasIndex("U_Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ecommerce.Model.Product", b =>
                {
                    b.Property<int>("P_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("P_Id"));

                    b.Property<string>("P_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("P_Pass")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("P_Price")
                        .HasColumnType("int");

                    b.Property<int>("P_Qty")
                        .HasColumnType("int");

                    b.HasKey("P_Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ecommerce.Model.User", b =>
                {
                    b.Property<int>("U_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("U_Id"));

                    b.Property<string>("U_Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("U_Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("U_Mob_Num")
                        .HasColumnType("int");

                    b.Property<string>("U_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("U_Pass")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("U_Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ecommerce.Model.Order", b =>
                {
                    b.HasOne("ecommerce.Model.Product", "Product")
                        .WithMany("Orders")
                        .HasForeignKey("P_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ecommerce.Model.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("U_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ecommerce.Model.Product", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("ecommerce.Model.User", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
