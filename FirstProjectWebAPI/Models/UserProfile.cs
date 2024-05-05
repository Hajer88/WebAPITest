using System;
using AutoMapper;
using FirstProjectWebAPI.Models.DTO;

namespace FirstProjectWebAPI.Models
{
	public class UserProfile : Profile
	{
		public UserProfile()
		{
			CreateMap<Categorie, CategorieDTO>();
			CreateMap<CategorieDTO, Categorie>();
		}
	}
}

