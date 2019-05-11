﻿// <auto-generated />
using System;
using KrakenNotes.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KrakenNotes.Data.Migrations
{
    [DbContext(typeof(KrakenNotesContext))]
    partial class KrakenNotesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KrakenNotes.Data.Models.Note", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnName("content")
                        .IsUnicode(false);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnName("date_created");

                    b.Property<DateTime>("LastModified")
                        .HasColumnName("last_modified");

                    b.Property<string>("Title")
                        .HasColumnName("title")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<int>("UserId")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Notes");
                });

            modelBuilder.Entity("KrakenNotes.Data.Models.NoteTag", b =>
                {
                    b.Property<int>("NoteId");

                    b.Property<int>("TagId");

                    b.HasKey("NoteId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("NoteTags");
                });

            modelBuilder.Entity("KrakenNotes.Data.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .HasColumnName("title")
                        .HasMaxLength(50);

                    b.Property<int>("UserId")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("KrakenNotes.Data.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ColorMode")
                        .HasColumnName("color_mode");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnName("first_name")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Image")
                        .HasColumnName("image");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnName("last_name")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnName("password")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnName("username")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("KrakenNotes.Data.Models.Note", b =>
                {
                    b.HasOne("KrakenNotes.Data.Models.User", "User")
                        .WithMany("Notes")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_Note_User")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KrakenNotes.Data.Models.NoteTag", b =>
                {
                    b.HasOne("KrakenNotes.Data.Models.Note", "Note")
                        .WithMany("NoteTags")
                        .HasForeignKey("NoteId")
                        .HasConstraintName("FK_Note_NoteTag");

                    b.HasOne("KrakenNotes.Data.Models.Tag", "Tag")
                        .WithMany("NoteTags")
                        .HasForeignKey("TagId")
                        .HasConstraintName("FK_Tag_NoteTag");
                });

            modelBuilder.Entity("KrakenNotes.Data.Models.Tag", b =>
                {
                    b.HasOne("KrakenNotes.Data.Models.User", "User")
                        .WithMany("Tags")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_Tag_User")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}