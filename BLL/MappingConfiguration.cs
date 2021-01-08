using AutoMapper;
using BLL.DTOs;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public static class MappingConfiguration
    {
        public static MapperConfiguration ConfigureMapper()
        {
            MapperConfiguration config = new MapperConfiguration(c => {

                c.CreateMap<Mark, MarkDTO>();

                c.CreateMap<Genre, GenreDTO>();

                c.CreateMap<BooksList, BooksListDTO>();

                c.CreateMap<Book, BookDTO>();

                c.CreateMap<Author, AuthorDTO>().ReverseMap();

                c.CreateMap<User, UserDTO>();

            });

            return config;
        }
    }
}
