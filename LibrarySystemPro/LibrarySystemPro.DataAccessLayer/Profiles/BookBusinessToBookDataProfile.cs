﻿using AutoMapper;
using LibrarySystemPro.BusinessObjects;
using LibrarySystemPro.DatabaseEntity;
using System;

namespace LibrarySystemPro.DataAccessLayer.Profiles
{
    public class BookBusinessToBookDataProfile : Profile
    {
        public BookBusinessToBookDataProfile()
        {
            this.CreateMap<BookBusiness, Book>();
        }
    }
}
