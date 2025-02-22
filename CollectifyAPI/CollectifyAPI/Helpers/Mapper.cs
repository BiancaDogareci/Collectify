﻿using AutoMapper;
using CollectifyAPI.Models;
using CollectifyAPI.Dtos;

namespace CollectifyAPI.Helpers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<AppUser, UserProfile>().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            CreateMap<UserProfile, AppUser>().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
        
            CreateMap<Note, SimpleNote>().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            CreateMap<SimpleNote, Note>().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<Group, SimpleGroup>().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            CreateMap<SimpleGroup, Group>().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
        }
    }
}
