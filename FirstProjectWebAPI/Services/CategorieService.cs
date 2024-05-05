using System;
using AutoMapper;
using FirstProjectWebAPI.Models;
using FirstProjectWebAPI.Models.DTO;
using Microsoft.EntityFrameworkCore;

namespace FirstProjectWebAPI.Services
{
	public class CategorieService : ICategoryService
	{
        private readonly Appdbcontext _db;
        private readonly IMapper _mapper;
		public CategorieService(Appdbcontext _db, IMapper _mapper)
		{
            this._db = _db;
            this._mapper = _mapper;
		}

        public async Task<IEnumerable<CategorieDTO>> GetAll()
        {
            var c = await _db.categories.ToListAsync();
            var cDTO = _mapper.Map<List<CategorieDTO>>(c);
            

            return cDTO;
        }

        /*public  IEnumerable<Categorie> GetAllTest()
        {
            var test = staticAllCategories()
                .ToList();
            return test;
        }

        private  List<Categorie> staticAllCategories()
        {
            List<Categorie> MockData = new List<Categorie>()
                {
                new Categorie()
                { Id = 1, name = "Cat1" }

                 };
            return MockData;
          
        }*/

    }
}

