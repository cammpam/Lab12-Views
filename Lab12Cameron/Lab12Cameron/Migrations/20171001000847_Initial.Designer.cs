﻿// <auto-generated />
using Lab12Cameron.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Lab12Cameron.Migrations
{
    [DbContext(typeof(Lab12CameronContext))]
    [Migration("20171001000847_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Lab12Cameron.Models.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Albums");

                    b.Property<DateTime>("FirstAlbum");

                    b.Property<string>("Hometown");

                    b.Property<string>("MC");

                    b.HasKey("ID");

                    b.ToTable("Student");
                });
#pragma warning restore 612, 618
        }
    }
}