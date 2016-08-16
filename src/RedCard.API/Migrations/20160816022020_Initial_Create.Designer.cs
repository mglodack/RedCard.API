using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using RedCard.API.Contexts;

namespace RedCard.API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20160816022020_Initial_Create")]
    partial class Initial_Create
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431");

            modelBuilder.Entity("RedCard.API.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Country")
                        .IsRequired();

                    b.Property<string>("League")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Position")
                        .IsRequired();

                    b.Property<int>("RedCards");

                    b.Property<string>("Team")
                        .IsRequired();

                    b.Property<int>("YellowCards");

                    b.HasKey("Id");

                    b.HasAlternateKey("Name");

                    b.ToTable("Players");
                });
        }
    }
}
