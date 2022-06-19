﻿using AutoMapper;
using TelegramChatBlazor.DAL.Entities;

namespace TelegramChatBlazor.DAL.MappingProfile
{
    public class DataAccessMapingProfile : Profile
    {
        public DataAccessMapingProfile()
        {
            CreateMap<Message, Domain.Models.Message>().ReverseMap();
            CreateMap<Chat, Domain.Models.Chat>().ReverseMap();           
        }
    }
}
