﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebStore.DAL.Context;

namespace WebStore.Migrations
{
    [DbContext(typeof(WebStoreContext))]
    partial class WebStoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("WebStore.Domain.Entities.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("Order");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("WebStore.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BrandId");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Name");

                    b.Property<int>("Order");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("SectionId");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("SectionId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("WebStore.Domain.Entities.Section", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("Order");

                    b.Property<int?>("ParentId");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Sections");
                });

            modelBuilder.Entity("WebStore.Domain.Entities.Product", b =>
                {
                    b.HasOne("WebStore.Domain.Entities.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId");

                    b.HasOne("WebStore.Domain.Entities.Section", "Section")
                        .WithMany("Products")
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebStore.Domain.Entities.Section", b =>
                {
                    b.HasOne("WebStore.Domain.Entities.Section", "ParentSection")
                        .WithMany()
                        .HasForeignKey("ParentId");
                });
#pragma warning restore 612, 618
        }
    }
}
