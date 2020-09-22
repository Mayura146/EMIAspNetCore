using CandyOnlineShopping.Models.Entity;
using CandyOnlineShopping.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyOnlineShopping.Models.Repositories
{
    public class CandyRepository : ICandyRepsoitory
    {
        private readonly ICategoryRepository _categoryRepository;
        public CandyRepository(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public IEnumerable<Candy> GetAll()
        {
            List<Candy> candies = new List<Candy>()
                {
                    new Candy{Id=1,Name="Assorted Hard Candy",Price=45.4M,Description="Assorted Hardy Candy",Category=_categoryRepository.GetAll().ToList()[0],
                        ImageUrl="\\Images\\hardCandy.jpg",IsInStock=true,IsOnSale=false,ImageThumbnailUrl="\\Images\\thumbnail\\hardCandy-small.jpg"
                },

                    new Candy { Id=2,Name="Assorted Chocalate Candy",Price=5.95M,Description="Assorted Chocalte Candy",Category=_categoryRepository.GetAll().ToList()[1],ImageUrl="\\Images\\chocolateCandy.jpg",IsInStock=true,IsOnSale=false,ImageThumbnailUrl= "\\Images\\thumbnail\\chocolateCandy-small.jpg" },

                     new Candy { Id=2,Name="Assorted Fruit Candy",Price=3.95M,Description="Assorted Fruit Candy",Category=_categoryRepository.GetAll().ToList()[2],ImageUrl="\\Images\\FruitCandy.jpg",IsInStock=true,IsOnSale=false,ImageThumbnailUrl= "\\Images\\thumbnail\\FruitCandy-small.jpg" }
            };
            return candies;
        }

        public Candy GetById(int candyId)
        {
            return GetAll().FirstOrDefault(c => c.Id == candyId);
            
        }

        public IEnumerable<Candy> GetOnSale()
        {
            throw new NotImplementedException();
        }
    }
}
