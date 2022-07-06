﻿using AutoMapper;
using TelegramChatBlazor.DAL.Entities;

namespace TelegramChatBlazor.DAL.MappingProfile
{
    public class DataAccessMapingProfile : Profile
    {
        public DataAccessMapingProfile()
        {
            CreateMap<Message, Domain.Models.Messages.Message>().ReverseMap();
            CreateMap<Chat, Domain.Models.Chat>().ReverseMap();
            CreateMap<Bot, Domain.Models.Bot>().ReverseMap();
            CreateMap<Color, Domain.Models.Color>().ReverseMap();
            CreateMap<Manager, Domain.Models.Managers.Manager>().ReverseMap();
            CreateMap<Answer, Domain.Models.HelpWord.Answer>().ReverseMap();
            CreateMap<Category, Domain.Models.HelpWord.Category>().ReverseMap();

        }
    }
}
