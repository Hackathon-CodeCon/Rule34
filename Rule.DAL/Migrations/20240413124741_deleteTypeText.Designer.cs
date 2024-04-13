﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Rule.DAL.Context;

#nullable disable

namespace Rule.DAL.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    [Migration("20240413124741_deleteTypeText")]
    partial class deleteTypeText
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Rule.DAL.Entities.Foundations", b =>
                {
                    b.Property<byte>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<byte>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1500)
                        .HasColumnType("nvarchar(1500)");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Foundations");
                });

            modelBuilder.Entity("Rule.DAL.Entities.Pictures", b =>
                {
                    b.Property<byte>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<byte>("Id"));

                    b.Property<byte?>("FoundationsId")
                        .HasColumnType("tinyint");

                    b.Property<byte[]>("Picture")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte?>("UsersId")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.HasIndex("FoundationsId");

                    b.HasIndex("UsersId");

                    b.ToTable("Pictures");
                });

            modelBuilder.Entity("Rule.DAL.Entities.PicturesPost", b =>
                {
                    b.Property<byte>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<byte>("Id"));

                    b.Property<byte[]>("Pictures")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte?>("PostsId")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.HasIndex("PostsId");

                    b.ToTable("PicturesPosts");
                });

            modelBuilder.Entity("Rule.DAL.Entities.Posts", b =>
                {
                    b.Property<byte>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<byte>("Id"));

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1500)
                        .HasColumnType("nvarchar(1500)");

                    b.Property<int?>("FinishSum")
                        .HasColumnType("int");

                    b.Property<byte>("FoundationsId")
                        .HasColumnType("tinyint");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<byte>("StatusPostId")
                        .HasColumnType("tinyint");

                    b.Property<byte>("TypePostId")
                        .HasColumnType("tinyint");

                    b.Property<byte>("UsersId")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.HasIndex("FoundationsId");

                    b.HasIndex("StatusPostId");

                    b.HasIndex("TypePostId");

                    b.HasIndex("UsersId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("Rule.DAL.Entities.StatusPost", b =>
                {
                    b.Property<byte>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<byte>("Id"));

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("StatusPosts");
                });

            modelBuilder.Entity("Rule.DAL.Entities.TypePost", b =>
                {
                    b.Property<byte>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<byte>("Id"));

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("TypePosts");
                });

            modelBuilder.Entity("Rule.DAL.Entities.Users", b =>
                {
                    b.Property<byte>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<byte>("Id"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Phone")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Rule.DAL.Entities.Pictures", b =>
                {
                    b.HasOne("Rule.DAL.Entities.Foundations", null)
                        .WithMany("Pictures")
                        .HasForeignKey("FoundationsId");

                    b.HasOne("Rule.DAL.Entities.Users", null)
                        .WithMany("Pictures")
                        .HasForeignKey("UsersId");
                });

            modelBuilder.Entity("Rule.DAL.Entities.PicturesPost", b =>
                {
                    b.HasOne("Rule.DAL.Entities.Posts", null)
                        .WithMany("PicturesPosts")
                        .HasForeignKey("PostsId");
                });

            modelBuilder.Entity("Rule.DAL.Entities.Posts", b =>
                {
                    b.HasOne("Rule.DAL.Entities.Foundations", "Foundations")
                        .WithMany()
                        .HasForeignKey("FoundationsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Rule.DAL.Entities.StatusPost", "StatusPost")
                        .WithMany()
                        .HasForeignKey("StatusPostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Rule.DAL.Entities.TypePost", "TypePost")
                        .WithMany()
                        .HasForeignKey("TypePostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Rule.DAL.Entities.Users", "Users")
                        .WithMany("Posts")
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Foundations");

                    b.Navigation("StatusPost");

                    b.Navigation("TypePost");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Rule.DAL.Entities.Foundations", b =>
                {
                    b.Navigation("Pictures");
                });

            modelBuilder.Entity("Rule.DAL.Entities.Posts", b =>
                {
                    b.Navigation("PicturesPosts");
                });

            modelBuilder.Entity("Rule.DAL.Entities.Users", b =>
                {
                    b.Navigation("Pictures");

                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}
