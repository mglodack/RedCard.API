using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using RedCard.API.Contexts;

namespace RedCard.API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20160814212913_Initial_Create")]
    partial class Initial_Create
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RedCard.API.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Country");

                    b.Property<string>("League");

                    b.Property<string>("Name");

                    b.Property<string>("Position");

                    b.Property<int>("RedCards");

                    b.Property<string>("Team");

                    b.Property<int>("YellowCards");

                    b.HasKey("Id");

                    b.ToTable("Players");
                });
        }
    }
}
