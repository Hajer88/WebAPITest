using System;
using FirstProjectWebAPI.Models;
using FirstProjectWebAPI.Models.DTO;

namespace FirstProjectWebAPI.Services
{
	public interface ICategoryService
	{
		Task<IEnumerable<CategorieDTO>> GetAll();
		//IEnumerable<Categorie> GetAllTest();
	}
}

