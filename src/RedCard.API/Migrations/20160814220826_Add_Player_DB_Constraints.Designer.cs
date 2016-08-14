using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using RedCard.API.Contexts;

namespace RedCard.API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20160814220826_Add_Player_DB_Constraints")]
    partial class Add_Player_DB_Constraints
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
