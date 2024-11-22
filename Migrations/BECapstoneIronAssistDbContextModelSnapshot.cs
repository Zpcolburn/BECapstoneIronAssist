﻿// <auto-generated />
using System;
using BECapstoneIronAssist;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BECapstoneIronAssist.Migrations
{
    [DbContext(typeof(BECapstoneIronAssistDbContext))]
    partial class BECapstoneIronAssistDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BECapstoneIronAssist.Models.Equipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("JobsiteId")
                        .HasColumnType("integer");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("JobsiteId");

                    b.ToTable("Equipment");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "The Cat 140 Motor Grader gives you more precise grading in a comfortable cab. With a range of technology options, you can improve grading accuracy and save on materials. With extended maintenance intervals, the 140 Motor Grader sets the pace for low operating costs, while maintaining productivity and efficiency.",
                            Image = "https://s7d2.scene7.com/is/image/Caterpillar/CM20191003-252bf-484fe?$cc-g$&fmt=pjpeg",
                            JobsiteId = 1,
                            Make = "Cat",
                            Model = "140 AWD",
                            Type = "Motor Grader"
                        },
                        new
                        {
                            Id = 2,
                            Description = "The Cat D5 succeeds the renowned D6N with superior performance, a fully automatic transmission and the broadest choice of technology features to help you get the most from your dozer. Nimble and responsive, it has power for dozing and finesse for grading.",
                            Image = "https://s7d2.scene7.com/is/image/Caterpillar/CM20181218-38347-48970?$cc-g$&fmt=pjpeg",
                            JobsiteId = 2,
                            Make = "Cat",
                            Model = "D5",
                            Type = "Dozer"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Why run two machines when one will do? Whether you're loading trucks, busting up blacktop, placing pipe, digging trenches, or moving materials, John Deere Backhoe Loaders are more than up to your toughest tasks. Designed with real-world customer input to provide the outstanding loader performance, backhoe trenching capability, and multifunction versatility you need with none of the extras you don't, these machines can help you get more done, get on to the next job, and look ahead to the big things in store for your operation.",
                            Image = "https://www.deere.com/assets/images/common/products/backhoes/410-p-tier/410p_backhoe_r4x001871_large_0761ae4bc0243aa4f8eb1ceaeb32dd202388291a.jpg",
                            JobsiteId = 3,
                            Make = "410",
                            Model = "John Deere",
                            Type = "Backhoe"
                        },
                        new
                        {
                            Id = 4,
                            Description = "The Cat® 306 CR Mini Excavator delivers maximum power and performance in a mini size to help you work in a wide range of applications.",
                            Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT9F3f1oHybwJ1Yb3WvNVk9bs8Rrljf-LI-4g&s",
                            JobsiteId = 4,
                            Make = "Cat",
                            Model = "306 CR",
                            Type = "Excavator"
                        },
                        new
                        {
                            Id = 5,
                            Description = "The Cat® 336 is a high-productivity, low-owning-and-operating cost excavator that will generate more prosperity for you and your business.",
                            Image = "https://s7d2.scene7.com/is/image/Caterpillar/CM20180212-41328-33143?wid=750&hei=600&op_sharpen=1&qlt=100",
                            JobsiteId = 1,
                            Make = "Cat",
                            Model = "336",
                            Type = "Excavator"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Be the solution you’re searching for as you power through obstacles in your path and adapt to the conditions at hand in the Kubota SVL97-2. Rugged terrain? No problem. The SVL97-2 and its 96.4 horsepower are ready to move ground and make sure you’re working in comfort and in confidence. Factor in its dominant tipping load, breakout force and advanced hydraulic system and we think you and the SVL97-2 are going to get along nicely. A workhorse, a go-getter, a friend-- the Kubota SVL97-2.",
                            Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTDMvAEl0NHmUmZ2jHJudSeXq0b7dtCOhsNXA&s",
                            JobsiteId = 4,
                            Make = "Kubota",
                            Model = "SVL97-2",
                            Type = "Track Loader"
                        },
                        new
                        {
                            Id = 7,
                            Description = "The Cat® CP11 Vibratory Soil Compactor features a padfoot drum and is ideally suited for cohesive and semi-cohesive soil applications. A reliable propel system improves performance and efficiency and compaction technology solutions help you reach target density faster.",
                            Image = "https://s7d2.scene7.com/is/image/Caterpillar/CM20210105-a8564-f105e",
                            JobsiteId = 3,
                            Make = "Cat",
                            Model = "CP11",
                            Type = "Vibratory Soil Compactor"
                        },
                        new
                        {
                            Id = 8,
                            Description = "The Cat® 740 EJ features a world-class cab design, re-engineered using global operator feedback to advance comfort and ease of operation. Enhancements include new controls, transmission-protection features, hoist-assist system, advanced automatic traction control system, stability-assist machine rollover warning system, and a fuel saving ECO mode.",
                            Image = "https://www.pon-cat.com/application/files/4115/3552/9792/CM20180618-58323-47147.jpg",
                            JobsiteId = 2,
                            Make = "Cat",
                            Model = "740 EJ",
                            Type = "Articulated Truck"
                        });
                });

            modelBuilder.Entity("BECapstoneIronAssist.Models.Jobsite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Jobsites");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Image = "https://media.bizj.us/view/img/12716500/parking-garage-2024-jim-bartoo38-copy*900xx5472-3078-0-285.jpg",
                            Location = "Nashville, TN",
                            Name = "Nashville Zoo",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            Image = "https://amconst-v1671219631.websitepro-cdn.com/wp-content/uploads/2022/06/Readyville-drone-images-5-scaled-e1697459492957-480x480.jpg",
                            Location = "Readyville, TN",
                            Name = "Readyville Fire Station",
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ6sJ2e1aN0fX7VM3luuMBqGtcZjxiojP99Tg&s",
                            Location = "Nashville, TN",
                            Name = "Opry Mills Hotel",
                            UserId = 1
                        },
                        new
                        {
                            Id = 4,
                            Image = "https://davidson.tennessee.edu/wp-content/uploads/sites/193/2020/01/Agriculture-block-image-aspect-ratio-300x360-aspect-ratio-300x360-1.jpg",
                            Location = "Nashville, TN",
                            Name = "TSU Farm",
                            UserId = 2
                        });
                });

            modelBuilder.Entity("BECapstoneIronAssist.Models.Report", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("Assign")
                        .HasColumnType("boolean");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("EquipmentId")
                        .IsRequired()
                        .HasColumnType("integer");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("boolean");

                    b.Property<int>("JobsiteId")
                        .HasColumnType("integer");

                    b.Property<int?>("JobsiteId1")
                        .HasColumnType("integer");

                    b.Property<string>("Priority")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ReportDate")
                        .HasColumnType("integer");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("EquipmentId");

                    b.HasIndex("JobsiteId");

                    b.HasIndex("JobsiteId1");

                    b.HasIndex("UserId");

                    b.ToTable("Reports");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Assign = false,
                            Description = "The cutting edges on the blade need to be flipped, and the ripper teeth need to be replaced.",
                            EquipmentId = 1,
                            Image = "https://test.com",
                            IsPublic = true,
                            JobsiteId = 2,
                            Priority = "Low",
                            ReportDate = 2009,
                            Status = "Backlog",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            Assign = false,
                            Description = "Thrown right track, needs to be put back on.",
                            EquipmentId = 2,
                            Image = "https://test.com",
                            IsPublic = true,
                            JobsiteId = 2,
                            Priority = "High",
                            ReportDate = 1998,
                            Status = "Backlog",
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            Assign = true,
                            Description = "Front bucket cylinder shaft bent.",
                            EquipmentId = 3,
                            Image = "https://test.com",
                            IsPublic = true,
                            JobsiteId = 3,
                            Priority = "High",
                            ReportDate = 1997,
                            Status = "Closed",
                            UserId = 2
                        },
                        new
                        {
                            Id = 4,
                            Assign = true,
                            Description = "Front glass broken, looks like from a rock.",
                            EquipmentId = 4,
                            Image = "https://test.com",
                            IsPublic = true,
                            JobsiteId = 4,
                            Priority = "low",
                            ReportDate = 1989,
                            Status = "Closed",
                            UserId = 2
                        });
                });

            modelBuilder.Entity("BECapstoneIronAssist.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Uid")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "colburn.zach7@gmail.com",
                            FirstName = "Zach",
                            LastName = "Colburn",
                            Role = "Operator",
                            Uid = "C0wunKp1sIQRM9YR48JnQPlNXt92"
                        },
                        new
                        {
                            Id = 2,
                            Email = "jane.smith@example.com",
                            FirstName = "Jane",
                            LastName = "Smith",
                            Role = "Mechanic",
                            Uid = "D1zpqWr2bJUPO7YP39LkWPqMYu64"
                        });
                });

            modelBuilder.Entity("EquipmentUser", b =>
                {
                    b.Property<int>("EquipmentId")
                        .HasColumnType("integer");

                    b.Property<int>("UsersId")
                        .HasColumnType("integer");

                    b.HasKey("EquipmentId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("EquipmentUser");
                });

            modelBuilder.Entity("BECapstoneIronAssist.Models.Equipment", b =>
                {
                    b.HasOne("BECapstoneIronAssist.Models.Jobsite", "Jobsite")
                        .WithMany("Equipment")
                        .HasForeignKey("JobsiteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Jobsite");
                });

            modelBuilder.Entity("BECapstoneIronAssist.Models.Jobsite", b =>
                {
                    b.HasOne("BECapstoneIronAssist.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("BECapstoneIronAssist.Models.Report", b =>
                {
                    b.HasOne("BECapstoneIronAssist.Models.Equipment", "Equipment")
                        .WithMany()
                        .HasForeignKey("EquipmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BECapstoneIronAssist.Models.Jobsite", "Jobsite")
                        .WithMany()
                        .HasForeignKey("JobsiteId");

                    b.HasOne("BECapstoneIronAssist.Models.Jobsite", null)
                        .WithMany("Reports")
                        .HasForeignKey("JobsiteId1");

                    b.HasOne("BECapstoneIronAssist.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipment");

                    b.Navigation("Jobsite");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EquipmentUser", b =>
                {
                    b.HasOne("BECapstoneIronAssist.Models.Equipment", null)
                        .WithMany()
                        .HasForeignKey("EquipmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BECapstoneIronAssist.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BECapstoneIronAssist.Models.Jobsite", b =>
                {
                    b.Navigation("Equipment");

                    b.Navigation("Reports");
                });
#pragma warning restore 612, 618
        }
    }
}