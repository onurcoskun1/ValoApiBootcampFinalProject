// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Valorant.DataAccess.Data;

#nullable disable

namespace Valorant.DataAccess.Migrations
{
    [DbContext(typeof(ValorantDbContext))]
    partial class ValorantDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Valorant.Entities.Agent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CodeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Origin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Race")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RealName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Agents");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CodeName = "Jett",
                            Gender = "Female",
                            ImageUrl = "http://placehold.it/300x300",
                            Origin = "South Korea",
                            Race = "Radiant",
                            RealName = "Sunwoo Han",
                            Role = "Duelist"
                        },
                        new
                        {
                            Id = 2,
                            CodeName = "Phoenix",
                            Gender = "Male",
                            ImageUrl = "http://placehold.it/300x300",
                            Origin = "United Kingdom",
                            Race = "Radiant",
                            RealName = "Jamie Adeyemi",
                            Role = "Duelist"
                        },
                        new
                        {
                            Id = 3,
                            CodeName = "Fade",
                            Gender = "Female",
                            ImageUrl = "http://placehold.it/300x300",
                            Origin = "Turkey",
                            Race = "Radiant",
                            RealName = "Unknown",
                            Role = "İnitiator"
                        });
                });

            modelBuilder.Entity("Valorant.Entities.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AgentId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AgentId");

                    b.ToTable("Skills");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AgentId = 3,
                            Description = "Send forward a prowler that chases the first enemy or trail it sees, nearsighting its target on impact.",
                            Name = "Prowler"
                        },
                        new
                        {
                            Id = 2,
                            AgentId = 3,
                            Description = "Throw a knot of fear that ruptures on impact with the ground, holding enemies in place and afflicting them with deafness and decay.",
                            Name = "Seize"
                        },
                        new
                        {
                            Id = 3,
                            AgentId = 3,
                            Description = "Throw a watcher that lashes out on impact with the ground, revealing enemies in its line of sight and creating trails to them.",
                            Name = "Haunt"
                        },
                        new
                        {
                            Id = 4,
                            AgentId = 3,
                            Description = "Unleash a wave of nightmare energy, afflicting caught enemies with trails, deafeness, and decay.",
                            Name = "Nightfall"
                        });
                });

            modelBuilder.Entity("Valorant.Entities.Weapon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.HasKey("Id");

                    b.ToTable("Weapons");
                });

            modelBuilder.Entity("Valorant.Entities.Skill", b =>
                {
                    b.HasOne("Valorant.Entities.Agent", "Agent")
                        .WithMany("Skills")
                        .HasForeignKey("AgentId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Agent");
                });

            modelBuilder.Entity("Valorant.Entities.Agent", b =>
                {
                    b.Navigation("Skills");
                });
#pragma warning restore 612, 618
        }
    }
}
