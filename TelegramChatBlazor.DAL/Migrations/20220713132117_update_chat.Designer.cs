﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TelegramChatBlazor.DAL.Context;

#nullable disable

namespace TelegramChatBlazor.DAL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220713132117_update_chat")]
    partial class update_chat
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TelegramChatBlazor.DAL.Entities.Answer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<long>("CategoryId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullAnswer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Answers");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CategoryId = 1L,
                            CreatedAt = new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(959),
                            FullAnswer = "Hello-bye",
                            ShortName = "Hi"
                        },
                        new
                        {
                            Id = 2L,
                            CategoryId = 1L,
                            CreatedAt = new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(970),
                            FullAnswer = "Hello how are you?",
                            ShortName = "Hi how"
                        },
                        new
                        {
                            Id = 3L,
                            CategoryId = 1L,
                            CreatedAt = new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(979),
                            FullAnswer = "Hey!How do you do? I'm ready to talk to you and answer your questions. ",
                            ShortName = "Чем могу помочь ?"
                        },
                        new
                        {
                            Id = 4L,
                            CategoryId = 1L,
                            CreatedAt = new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(987),
                            FullAnswer = "How do I get a demo version?https://globalforexforum.com/threads/elon-musk-ea-demo.340/",
                            ShortName = "Подпишись на канал с результатами"
                        },
                        new
                        {
                            Id = 5L,
                            CategoryId = 1L,
                            CreatedAt = new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(996),
                            FullAnswer = "Okay, thanks for the request ! If you have any new questions about ELM_EA, please let me know. I am online and ready to help you 24/5",
                            ShortName = "Спасибо за ваш запрос"
                        });
                });

            modelBuilder.Entity("TelegramChatBlazor.DAL.Entities.Attachment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("MessageId")
                        .HasColumnType("bigint");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MessageId");

                    b.ToTable("Attachments");
                });

            modelBuilder.Entity("TelegramChatBlazor.DAL.Entities.Bot", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Bots");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreateAt = new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(580),
                            Name = "Jironimo",
                            Token = "5536982597:AAHGE_tYhVLViVvUzlnFpelX7aSv0H4kbp8",
                            UserName = "JironimoBot"
                        },
                        new
                        {
                            Id = 2L,
                            CreateAt = new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(638),
                            Name = "TelegramBotBlazor",
                            Token = "5493821109:AAGpCZCpURP2dn1yM_wEdAQCdA21avI5ggM",
                            UserName = "TelegramBotBlazorBot"
                        });
                });

            modelBuilder.Entity("TelegramChatBlazor.DAL.Entities.Category", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedAt = new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(874),
                            Name = "Hello-bye"
                        },
                        new
                        {
                            Id = 2L,
                            CreatedAt = new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(885),
                            Name = "Продажа"
                        },
                        new
                        {
                            Id = 3L,
                            CreatedAt = new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(894),
                            Name = "Брокеры"
                        },
                        new
                        {
                            Id = 4L,
                            CreatedAt = new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(902),
                            Name = "Hello-bye"
                        },
                        new
                        {
                            Id = 5L,
                            CreatedAt = new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(911),
                            Name = "Продажа"
                        },
                        new
                        {
                            Id = 6L,
                            CreatedAt = new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(920),
                            Name = "Брокеры"
                        },
                        new
                        {
                            Id = 7L,
                            CreatedAt = new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(928),
                            Name = "Hello-bye"
                        },
                        new
                        {
                            Id = 8L,
                            CreatedAt = new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(936),
                            Name = "Продажа"
                        },
                        new
                        {
                            Id = 9L,
                            CreatedAt = new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(944),
                            Name = "Брокеры"
                        });
                });

            modelBuilder.Entity("TelegramChatBlazor.DAL.Entities.Chat", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint");

                    b.Property<string>("BotAvatar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("BotId")
                        .HasColumnType("bigint");

                    b.Property<string>("BotUserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PartnerAvatar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PartnerLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PartnerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PartnerUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("TelegramChatId")
                        .HasColumnType("bigint");

                    b.Property<string>("languageCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BotId");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Chat");
                });

            modelBuilder.Entity("TelegramChatBlazor.DAL.Entities.Color", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("ColorHex")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Colors");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            ColorHex = "#FFFFFF"
                        },
                        new
                        {
                            Id = 2L,
                            ColorHex = "#3C95FF"
                        },
                        new
                        {
                            Id = 3L,
                            ColorHex = "#FFCE31"
                        },
                        new
                        {
                            Id = 4L,
                            ColorHex = "#25CC62"
                        },
                        new
                        {
                            Id = 5L,
                            ColorHex = "#ED4C5C"
                        },
                        new
                        {
                            Id = 6L,
                            ColorHex = "#9C4CED"
                        },
                        new
                        {
                            Id = 7L,
                            ColorHex = "#4CEDED"
                        },
                        new
                        {
                            Id = 8L,
                            ColorHex = "#ED4CB6"
                        });
                });

            modelBuilder.Entity("TelegramChatBlazor.DAL.Entities.Filter", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<bool>("Archived")
                        .HasColumnType("bit");

                    b.Property<string>("ColorHex")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Mailing")
                        .HasColumnType("bit");

                    b.Property<bool>("Readed")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Filters");
                });

            modelBuilder.Entity("TelegramChatBlazor.DAL.Entities.Language", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("languageCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Languages");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Name = "Bulgarian",
                            languageCode = "bg"
                        },
                        new
                        {
                            Id = 2L,
                            Name = "Czech",
                            languageCode = "cs"
                        },
                        new
                        {
                            Id = 3L,
                            Name = "Bulgarian",
                            languageCode = "bg"
                        },
                        new
                        {
                            Id = 4L,
                            Name = "Danish",
                            languageCode = "da"
                        },
                        new
                        {
                            Id = 5L,
                            Name = "German",
                            languageCode = "el"
                        },
                        new
                        {
                            Id = 6L,
                            Name = "Greek",
                            languageCode = "cs"
                        },
                        new
                        {
                            Id = 7L,
                            Name = "English",
                            languageCode = "en"
                        },
                        new
                        {
                            Id = 8L,
                            Name = "EnglishBritish",
                            languageCode = "en-GB"
                        },
                        new
                        {
                            Id = 9L,
                            Name = "EnglishAmerican",
                            languageCode = "en-US"
                        },
                        new
                        {
                            Id = 10L,
                            Name = "Spanish",
                            languageCode = "es"
                        },
                        new
                        {
                            Id = 11L,
                            Name = "Estonian",
                            languageCode = "et"
                        },
                        new
                        {
                            Id = 12L,
                            Name = "Finnish",
                            languageCode = "fi"
                        },
                        new
                        {
                            Id = 13L,
                            Name = "French",
                            languageCode = "fr"
                        },
                        new
                        {
                            Id = 14L,
                            Name = "Hungarian",
                            languageCode = "hu"
                        },
                        new
                        {
                            Id = 15L,
                            Name = "Indonesian",
                            languageCode = "id"
                        },
                        new
                        {
                            Id = 16L,
                            Name = "Italian",
                            languageCode = "it"
                        },
                        new
                        {
                            Id = 17L,
                            Name = "Japanese",
                            languageCode = "ja"
                        },
                        new
                        {
                            Id = 18L,
                            Name = "Lithuanian",
                            languageCode = "lt"
                        },
                        new
                        {
                            Id = 19L,
                            Name = "Latvian",
                            languageCode = "lv"
                        },
                        new
                        {
                            Id = 20L,
                            Name = "Dutch",
                            languageCode = "nl"
                        },
                        new
                        {
                            Id = 21L,
                            Name = "Polish",
                            languageCode = "pl"
                        },
                        new
                        {
                            Id = 22L,
                            Name = "Portuguese",
                            languageCode = "pt"
                        },
                        new
                        {
                            Id = 23L,
                            Name = "PortugueseBrazilian",
                            languageCode = "pt-BR"
                        },
                        new
                        {
                            Id = 24L,
                            Name = "Romanian",
                            languageCode = "ro"
                        },
                        new
                        {
                            Id = 25L,
                            Name = "Russian",
                            languageCode = "ru"
                        },
                        new
                        {
                            Id = 26L,
                            Name = "Slovak",
                            languageCode = "sk"
                        },
                        new
                        {
                            Id = 27L,
                            Name = "Slovenian",
                            languageCode = "sl"
                        },
                        new
                        {
                            Id = 28L,
                            Name = "Swedish",
                            languageCode = "sv"
                        },
                        new
                        {
                            Id = 29L,
                            Name = "Turkish",
                            languageCode = "tr"
                        },
                        new
                        {
                            Id = 30L,
                            Name = "Chinese",
                            languageCode = "zh"
                        });
                });

            modelBuilder.Entity("TelegramChatBlazor.DAL.Entities.Manager", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastOnline")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Managers");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreateAt = new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(717),
                            Email = "testEmail@gmail.com",
                            ImgPath = "https://ps.w.org/user-avatar-reloaded/assets/icon-256x256.png?rev=2540745",
                            LastOnline = new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(719),
                            Name = "Alex Yesipov"
                        },
                        new
                        {
                            Id = 2L,
                            CreateAt = new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(731),
                            Email = "testEmail2@gmail.com",
                            ImgPath = "https://w7.pngwing.com/pngs/340/946/png-transparent-avatar-user-computer-icons-software-developer-avatar-child-face-heroes.png",
                            LastOnline = new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(733),
                            Name = "Alex Ivanov"
                        },
                        new
                        {
                            Id = 3L,
                            CreateAt = new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(741),
                            Email = "testEmail3@gmail.com",
                            ImgPath = "https://www.kindpng.com/picc/m/163-1636340_user-avatar-icon-avatar-transparent-user-icon-png.png",
                            LastOnline = new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(743),
                            Name = "Kate Yesipova"
                        },
                        new
                        {
                            Id = 4L,
                            CreateAt = new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(753),
                            Email = "testEmail4@gmail.com",
                            ImgPath = "https://image.pngaaa.com/345/1582345-middle.png",
                            LastOnline = new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(754),
                            Name = "Alex Pupkin"
                        },
                        new
                        {
                            Id = 5L,
                            CreateAt = new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(763),
                            Email = "testEmail@gmail.com",
                            ImgPath = "https://ps.w.org/user-avatar-reloaded/assets/icon-256x256.png?rev=2540745",
                            LastOnline = new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(765),
                            Name = "Alex Yesipov"
                        },
                        new
                        {
                            Id = 6L,
                            CreateAt = new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(775),
                            Email = "testEmail2@gmail.com",
                            ImgPath = "https://w7.pngwing.com/pngs/340/946/png-transparent-avatar-user-computer-icons-software-developer-avatar-child-face-heroes.png",
                            LastOnline = new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(776),
                            Name = "Alex Ivanov"
                        },
                        new
                        {
                            Id = 7L,
                            CreateAt = new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(785),
                            Email = "testEmail3@gmail.com",
                            ImgPath = "https://www.kindpng.com/picc/m/163-1636340_user-avatar-icon-avatar-transparent-user-icon-png.png",
                            LastOnline = new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(787),
                            Name = "Kate Yesipova"
                        },
                        new
                        {
                            Id = 8L,
                            CreateAt = new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(855),
                            Email = "testEmail4@gmail.com",
                            ImgPath = "https://image.pngaaa.com/345/1582345-middle.png",
                            LastOnline = new DateTime(2022, 7, 13, 16, 21, 16, 865, DateTimeKind.Local).AddTicks(857),
                            Name = "Alex Pupkin"
                        });
                });

            modelBuilder.Entity("TelegramChatBlazor.DAL.Entities.Message", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<long>("ChatId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsPartner")
                        .HasColumnType("bit");

                    b.Property<bool>("IsRead")
                        .HasColumnType("bit");

                    b.Property<long?>("MessageGroupId")
                        .HasColumnType("bigint");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ChatId");

                    b.ToTable("Message");
                });

            modelBuilder.Entity("TelegramChatBlazor.DAL.Entities.Answer", b =>
                {
                    b.HasOne("TelegramChatBlazor.DAL.Entities.Category", "Category")
                        .WithMany("Answers")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("TelegramChatBlazor.DAL.Entities.Attachment", b =>
                {
                    b.HasOne("TelegramChatBlazor.DAL.Entities.Message", "Message")
                        .WithMany("Attachments")
                        .HasForeignKey("MessageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Message");
                });

            modelBuilder.Entity("TelegramChatBlazor.DAL.Entities.Chat", b =>
                {
                    b.HasOne("TelegramChatBlazor.DAL.Entities.Bot", "Bot")
                        .WithMany("Chats")
                        .HasForeignKey("BotId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bot");
                });

            modelBuilder.Entity("TelegramChatBlazor.DAL.Entities.Message", b =>
                {
                    b.HasOne("TelegramChatBlazor.DAL.Entities.Chat", "Chat")
                        .WithMany("Messages")
                        .HasForeignKey("ChatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Chat");
                });

            modelBuilder.Entity("TelegramChatBlazor.DAL.Entities.Bot", b =>
                {
                    b.Navigation("Chats");
                });

            modelBuilder.Entity("TelegramChatBlazor.DAL.Entities.Category", b =>
                {
                    b.Navigation("Answers");
                });

            modelBuilder.Entity("TelegramChatBlazor.DAL.Entities.Chat", b =>
                {
                    b.Navigation("Messages");
                });

            modelBuilder.Entity("TelegramChatBlazor.DAL.Entities.Message", b =>
                {
                    b.Navigation("Attachments");
                });
#pragma warning restore 612, 618
        }
    }
}
