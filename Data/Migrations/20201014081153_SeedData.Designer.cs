﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using applestore.Data.EF;

namespace applestore.Data.Migrations
{
    [DbContext(typeof(AppleDbContext))]
    [Migration("20201014081153_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("applestore.Data.Entity.AppConfig", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("key")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("value")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("AppConfigs");

                    b.HasData(
                        new
                        {
                            id = 1,
                            key = "Home",
                            value = "This is a home page Apple Store!"
                        },
                        new
                        {
                            id = 2,
                            key = "Search",
                            value = "This is a search page Apple Store!"
                        },
                        new
                        {
                            id = 3,
                            key = "Product",
                            value = "This is a product page Apple Store!"
                        });
                });

            modelBuilder.Entity("applestore.Data.Entity.Cart", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("created")
                        .HasColumnType("timestamp without time zone");

                    b.Property<decimal>("price")
                        .HasColumnType("numeric");

                    b.Property<int>("productId")
                        .HasColumnType("integer");

                    b.Property<int>("quantity")
                        .HasColumnType("integer");

                    b.Property<Guid>("userId")
                        .HasColumnType("uuid");

                    b.HasKey("id");

                    b.HasIndex("productId");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("applestore.Data.Entity.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("isPublic")
                        .HasColumnType("boolean");

                    b.Property<int?>("parentId")
                        .HasColumnType("integer");

                    b.Property<int>("sortOrder")
                        .HasColumnType("integer");

                    b.Property<int>("status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasDefaultValue(1);

                    b.HasKey("id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            id = 1,
                            isPublic = true,
                            sortOrder = 1,
                            status = 1
                        },
                        new
                        {
                            id = 2,
                            isPublic = true,
                            sortOrder = 1,
                            status = 1
                        },
                        new
                        {
                            id = 3,
                            isPublic = true,
                            sortOrder = 1,
                            status = 1
                        },
                        new
                        {
                            id = 4,
                            isPublic = true,
                            sortOrder = 1,
                            status = 1
                        });
                });

            modelBuilder.Entity("applestore.Data.Entity.CategoryTranslation", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("brief")
                        .HasColumnType("character varying(500)")
                        .HasMaxLength(500);

                    b.Property<int>("categoryId")
                        .HasColumnType("integer");

                    b.Property<int>("languageId")
                        .HasColumnType("integer")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("character varying(200)")
                        .HasMaxLength(200);

                    b.Property<string>("seoAlias")
                        .IsRequired()
                        .HasColumnType("character varying(200)")
                        .HasMaxLength(200);

                    b.Property<string>("title")
                        .HasColumnType("character varying(200)")
                        .HasMaxLength(200);

                    b.HasKey("id");

                    b.HasIndex("categoryId");

                    b.HasIndex("languageId");

                    b.ToTable("CategoryTranslations");

                    b.HasData(
                        new
                        {
                            id = 1,
                            brief = "Smartphone Apple",
                            categoryId = 1,
                            languageId = 1,
                            name = "iPhone",
                            seoAlias = "iphone",
                            title = "Smartphone"
                        },
                        new
                        {
                            id = 2,
                            brief = "Điện thoại thông minh Apple",
                            categoryId = 1,
                            languageId = 2,
                            name = "Điện thoại",
                            seoAlias = "dien-thoai",
                            title = "Điện thoại thông minh"
                        },
                        new
                        {
                            id = 3,
                            brief = "Tablet Apple",
                            categoryId = 2,
                            languageId = 1,
                            name = "iPad",
                            seoAlias = "ipad",
                            title = "Tablet"
                        },
                        new
                        {
                            id = 4,
                            brief = "Máy tính bảng thông minh Apple",
                            categoryId = 2,
                            languageId = 2,
                            name = "Máy tính bảng",
                            seoAlias = "may-tinh-bang",
                            title = "Máy tính bảng thông minh"
                        },
                        new
                        {
                            id = 5,
                            brief = "Macbook Apple",
                            categoryId = 3,
                            languageId = 1,
                            name = "Macbook",
                            seoAlias = "macbook",
                            title = "Macbook"
                        },
                        new
                        {
                            id = 6,
                            brief = "Máy tính xách tay Apple",
                            categoryId = 3,
                            languageId = 2,
                            name = "Máy tính xách tay",
                            seoAlias = "may-tinh-xach-tay",
                            title = "Máy tính xách tay"
                        },
                        new
                        {
                            id = 7,
                            brief = "Apple Watch",
                            categoryId = 4,
                            languageId = 1,
                            name = "Watch",
                            seoAlias = "apple-watch",
                            title = "Apple Watch"
                        },
                        new
                        {
                            id = 8,
                            brief = "Đồng hồ thông minh Apple",
                            categoryId = 4,
                            languageId = 2,
                            name = "Đồng hồ",
                            seoAlias = "dong-ho",
                            title = "Đồng hồ thông minh"
                        });
                });

            modelBuilder.Entity("applestore.Data.Entity.Contact", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("character varying(200)")
                        .HasMaxLength(200);

                    b.Property<string>("message")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("character varying(200)")
                        .HasMaxLength(200);

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("character varying(200)")
                        .HasMaxLength(200);

                    b.Property<int>("status")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("applestore.Data.Entity.Language", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasMaxLength(5)
                        .IsUnicode(false)
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("isDefault")
                        .HasColumnType("boolean");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("character varying(20)")
                        .HasMaxLength(20);

                    b.HasKey("id");

                    b.ToTable("Languages");

                    b.HasData(
                        new
                        {
                            id = 1,
                            isDefault = true,
                            name = "English"
                        },
                        new
                        {
                            id = 2,
                            isDefault = false,
                            name = "Vietnamese"
                        });
                });

            modelBuilder.Entity("applestore.Data.Entity.Order", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("created")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("shippingAddress")
                        .HasColumnType("text");

                    b.Property<string>("shippingEmail")
                        .HasColumnType("text");

                    b.Property<string>("shippingName")
                        .HasColumnType("text");

                    b.Property<string>("shippingPhone")
                        .HasColumnType("text");

                    b.Property<int>("status")
                        .HasColumnType("integer");

                    b.Property<Guid>("userId")
                        .HasColumnType("uuid");

                    b.HasKey("id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("applestore.Data.Entity.OrderLine", b =>
                {
                    b.Property<int>("orderId")
                        .HasColumnType("integer");

                    b.Property<int>("productId")
                        .HasColumnType("integer");

                    b.Property<decimal>("price")
                        .HasColumnType("numeric");

                    b.Property<int>("quantity")
                        .HasColumnType("integer");

                    b.HasKey("orderId", "productId");

                    b.HasIndex("productId");

                    b.ToTable("OrderLines");
                });

            modelBuilder.Entity("applestore.Data.Entity.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValue(new DateTime(2020, 10, 14, 8, 11, 52, 788, DateTimeKind.Utc).AddTicks(3284));

                    b.Property<decimal>("originalPrice")
                        .HasColumnType("numeric");

                    b.Property<decimal>("price")
                        .HasColumnType("numeric");

                    b.Property<string>("seoAlias")
                        .HasColumnType("text");

                    b.Property<int>("stock")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasDefaultValue(0);

                    b.Property<int>("viewCount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasDefaultValue(0);

                    b.HasKey("id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            id = 1,
                            created = new DateTime(2020, 10, 14, 8, 11, 52, 850, DateTimeKind.Utc).AddTicks(3330),
                            originalPrice = 800m,
                            price = 868m,
                            seoAlias = "iphone-11-promax",
                            stock = 100,
                            viewCount = 0
                        });
                });

            modelBuilder.Entity("applestore.Data.Entity.ProductInCategory", b =>
                {
                    b.Property<int>("categoryId")
                        .HasColumnType("integer");

                    b.Property<int>("productId")
                        .HasColumnType("integer");

                    b.HasKey("categoryId", "productId");

                    b.HasIndex("productId");

                    b.ToTable("ProductInCategories");

                    b.HasData(
                        new
                        {
                            categoryId = 1,
                            productId = 1
                        });
                });

            modelBuilder.Entity("applestore.Data.Entity.ProductTranslation", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("brief")
                        .HasColumnType("text");

                    b.Property<int>("languageId")
                        .HasColumnType("integer")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("character varying(200)")
                        .HasMaxLength(200);

                    b.Property<int>("productId")
                        .HasColumnType("integer");

                    b.Property<string>("seoAlias")
                        .IsRequired()
                        .HasColumnType("character varying(200)")
                        .HasMaxLength(200);

                    b.Property<string>("title")
                        .HasColumnType("character varying(500)")
                        .HasMaxLength(500);

                    b.HasKey("id");

                    b.HasIndex("languageId");

                    b.HasIndex("productId");

                    b.ToTable("ProductTranslations");

                    b.HasData(
                        new
                        {
                            id = 1,
                            brief = "Smartphone Apple",
                            languageId = 1,
                            name = "iPhone 11 Pro Max",
                            productId = 1,
                            seoAlias = "iphone-11-promax",
                            title = "Smartphone Apple"
                        },
                        new
                        {
                            id = 2,
                            brief = "Điện thoại thông minh Apple",
                            languageId = 2,
                            name = "iPhone 11 Pro Max",
                            productId = 1,
                            seoAlias = "iphone-11-promax",
                            title = "Điện thoại thông minh Apple"
                        });
                });

            modelBuilder.Entity("applestore.Data.Entity.Promotion", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ProductCategoryIds")
                        .HasColumnType("text");

                    b.Property<bool>("applyForAll")
                        .HasColumnType("boolean");

                    b.Property<decimal>("discountAmount")
                        .HasColumnType("numeric");

                    b.Property<int?>("discountPercent")
                        .HasColumnType("integer");

                    b.Property<DateTime>("endTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("productIds")
                        .HasColumnType("text");

                    b.Property<DateTime>("startTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("status")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.ToTable("Promotions");
                });

            modelBuilder.Entity("applestore.Data.Entity.Transaction", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<decimal>("amount")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("created")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("externalTransactionId")
                        .HasColumnType("text");

                    b.Property<decimal>("fee")
                        .HasColumnType("numeric");

                    b.Property<string>("message")
                        .HasColumnType("text");

                    b.Property<string>("provider")
                        .HasColumnType("text");

                    b.Property<string>("result")
                        .HasColumnType("text");

                    b.Property<int>("status")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("applestore.Data.Entity.Cart", b =>
                {
                    b.HasOne("applestore.Data.Entity.Product", "product")
                        .WithMany("carts")
                        .HasForeignKey("productId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("applestore.Data.Entity.CategoryTranslation", b =>
                {
                    b.HasOne("applestore.Data.Entity.Category", "category")
                        .WithMany("categoryTranslations")
                        .HasForeignKey("categoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("applestore.Data.Entity.Language", "language")
                        .WithMany("categoryTranslations")
                        .HasForeignKey("languageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("applestore.Data.Entity.OrderLine", b =>
                {
                    b.HasOne("applestore.Data.Entity.Order", "order")
                        .WithMany("orderLines")
                        .HasForeignKey("orderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("applestore.Data.Entity.Product", "product")
                        .WithMany("orderLines")
                        .HasForeignKey("productId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("applestore.Data.Entity.ProductInCategory", b =>
                {
                    b.HasOne("applestore.Data.Entity.Category", "category")
                        .WithMany("productInCategories")
                        .HasForeignKey("categoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("applestore.Data.Entity.Product", "product")
                        .WithMany("productInCategories")
                        .HasForeignKey("productId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("applestore.Data.Entity.ProductTranslation", b =>
                {
                    b.HasOne("applestore.Data.Entity.Language", "language")
                        .WithMany("productTranslations")
                        .HasForeignKey("languageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("applestore.Data.Entity.Product", "product")
                        .WithMany("productTranslations")
                        .HasForeignKey("productId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
