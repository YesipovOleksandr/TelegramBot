﻿using Microsoft.EntityFrameworkCore;
using TelegramChatBlazor.DAL.Entities;

namespace TelegramChatBlazor.DAL.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Bot> Bots { get; set; }
        public DbSet<Chat> Chat { get; set; }
        public DbSet<Message> Message { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Attachment> Attachments { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Chat>().HasIndex(u => u.Id).IsUnique();

            builder.Entity<Category>().HasMany(x => x.Answers)
           .WithOne(x => x.Category).HasForeignKey(x => x.CategoryId)
           .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Chat>()
           .HasMany<Message>(g => g.Messages)
           .WithOne(s => s.Chat).HasForeignKey(s => s.ChatId);

            builder.Entity<Bot>()
           .HasMany<Chat>(g => g.Chats)
           .WithOne(s => s.Bot).HasForeignKey(s => s.BotId);

            builder.Entity<Message>()
           .HasMany<Attachment>(g => g.Attachments)
           .WithOne(s => s.Message).HasForeignKey(s => s.MessageId);

            builder.Entity<Bot>().HasData(new Bot { Id = 1, Token = "5536982597:AAHGE_tYhVLViVvUzlnFpelX7aSv0H4kbp8", Name = "Jironimo", UserName = "JironimoBot", CreateAt = DateTime.Now, Chats = new List<Chat> { } });
            builder.Entity<Bot>().HasData(new Bot { Id = 2, Token = "5493821109:AAGpCZCpURP2dn1yM_wEdAQCdA21avI5ggM", Name = "TelegramBotBlazor", UserName = "TelegramBotBlazorBot", CreateAt = DateTime.Now, Chats = new List<Chat> { } });

            builder.Entity<Color>().HasData(new Color { Id = 1, ColorHex = "#FFFFFF" });
            builder.Entity<Color>().HasData(new Color { Id = 2, ColorHex = "#3C95FF" });
            builder.Entity<Color>().HasData(new Color { Id = 3, ColorHex = "#FFCE31" });
            builder.Entity<Color>().HasData(new Color { Id = 4, ColorHex = "#25CC62" });
            builder.Entity<Color>().HasData(new Color { Id = 5, ColorHex = "#ED4C5C" });
            builder.Entity<Color>().HasData(new Color { Id = 6, ColorHex = "#9C4CED" });
            builder.Entity<Color>().HasData(new Color { Id = 7, ColorHex = "#4CEDED" });
            builder.Entity<Color>().HasData(new Color { Id = 8, ColorHex = "#ED4CB6" });

            builder.Entity<Manager>().HasData(new Manager { Id = 1, Name = "Alex Yesipov", Email = "testEmail@gmail.com", ImgPath = "https://ps.w.org/user-avatar-reloaded/assets/icon-256x256.png?rev=2540745", CreateAt = DateTime.Now, LastOnline = DateTime.Now });
            builder.Entity<Manager>().HasData(new Manager { Id = 2, Name = "Alex Ivanov", Email = "testEmail2@gmail.com", ImgPath = "https://w7.pngwing.com/pngs/340/946/png-transparent-avatar-user-computer-icons-software-developer-avatar-child-face-heroes.png", CreateAt = DateTime.Now, LastOnline = DateTime.Now });
            builder.Entity<Manager>().HasData(new Manager { Id = 3, Name = "Kate Yesipova", Email = "testEmail3@gmail.com", ImgPath = "https://www.kindpng.com/picc/m/163-1636340_user-avatar-icon-avatar-transparent-user-icon-png.png", CreateAt = DateTime.Now, LastOnline = DateTime.Now });
            builder.Entity<Manager>().HasData(new Manager { Id = 4, Name = "Alex Pupkin", Email = "testEmail4@gmail.com", ImgPath = "https://image.pngaaa.com/345/1582345-middle.png", CreateAt = DateTime.Now, LastOnline = DateTime.Now });
            builder.Entity<Manager>().HasData(new Manager { Id = 1, Name = "Alex Yesipov", Email = "testEmail@gmail.com", ImgPath = "https://ps.w.org/user-avatar-reloaded/assets/icon-256x256.png?rev=2540745", CreateAt = DateTime.Now, LastOnline = DateTime.Now });
            builder.Entity<Manager>().HasData(new Manager { Id = 2, Name = "Alex Ivanov", Email = "testEmail2@gmail.com", ImgPath = "https://w7.pngwing.com/pngs/340/946/png-transparent-avatar-user-computer-icons-software-developer-avatar-child-face-heroes.png", CreateAt = DateTime.Now, LastOnline = DateTime.Now });
            builder.Entity<Manager>().HasData(new Manager { Id = 3, Name = "Kate Yesipova", Email = "testEmail3@gmail.com", ImgPath = "https://www.kindpng.com/picc/m/163-1636340_user-avatar-icon-avatar-transparent-user-icon-png.png", CreateAt = DateTime.Now, LastOnline = DateTime.Now });
            builder.Entity<Manager>().HasData(new Manager { Id = 4, Name = "Alex Pupkin", Email = "testEmail4@gmail.com", ImgPath = "https://image.pngaaa.com/345/1582345-middle.png", CreateAt = DateTime.Now, LastOnline = DateTime.Now });

            builder.Entity<Category>().HasData(new Category { Id = 1, Name = "Hello-bye",CreatedAt=DateTime.Now });
            builder.Entity<Category>().HasData(new Category { Id = 2, Name = "Продажа", CreatedAt = DateTime.Now });
            builder.Entity<Category>().HasData(new Category { Id = 3, Name = "Брокеры", CreatedAt = DateTime.Now });
            builder.Entity<Category>().HasData(new Category { Id = 1, Name = "Hello-bye", CreatedAt = DateTime.Now });
            builder.Entity<Category>().HasData(new Category { Id = 2, Name = "Продажа", CreatedAt = DateTime.Now });
            builder.Entity<Category>().HasData(new Category { Id = 3, Name = "Брокеры", CreatedAt = DateTime.Now });
            builder.Entity<Category>().HasData(new Category { Id = 1, Name = "Hello-bye", CreatedAt = DateTime.Now });
            builder.Entity<Category>().HasData(new Category { Id = 2, Name = "Продажа", CreatedAt = DateTime.Now });
            builder.Entity<Category>().HasData(new Category { Id = 3, Name = "Брокеры", CreatedAt = DateTime.Now });

            builder.Entity<Answer>().HasData(new Answer { Id = 1, ShortName = "Hi",FullAnswer= "Hello-bye",CategoryId=1, CreatedAt = DateTime.Now });
            builder.Entity<Answer>().HasData(new Answer { Id = 2, ShortName = "Hi how", FullAnswer = "Hello how are you?", CategoryId = 1, CreatedAt = DateTime.Now });
            builder.Entity<Answer>().HasData(new Answer { Id = 3, ShortName = "Чем могу помочь ?", FullAnswer = "Hey!How do you do? I'm ready to talk to you and answer your questions. ", CategoryId = 1, CreatedAt = DateTime.Now });
            builder.Entity<Answer>().HasData(new Answer { Id = 4, ShortName = "Подпишись на канал с результатами", FullAnswer = "How do I get a demo version?https://globalforexforum.com/threads/elon-musk-ea-demo.340/", CategoryId = 1, CreatedAt = DateTime.Now });
            builder.Entity<Answer>().HasData(new Answer { Id = 5, ShortName = "Спасибо за ваш запрос", FullAnswer = "Okay, thanks for the request ! If you have any new questions about ELM_EA, please let me know. I am online and ready to help you 24/5", CategoryId = 1, CreatedAt = DateTime.Now });

            base.OnModelCreating(builder);
        }
    }
}

