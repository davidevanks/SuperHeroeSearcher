using NUnit.Framework;
using SuperHeroe.Data;
using SuperHeroe.Data.Interfaces;
using SuperHeroe.Data.Models;
using SuperHeroe.Data.Repositories;
using System;
using System.Threading.Tasks;

namespace SuperHeroeUnitTest
{
    
    public class SuperHeroeTest
    {


        SearchRepository _search;
        DetailsHeroeRepository _Details;
        
        public SuperHeroeTest()
        {
            _search = new SearchRepository();
            _Details = new DetailsHeroeRepository();
        }



        [Test]
        public void SearchHeroe()
        {
            var response = _search.Heroes("batman");
            Assert.NotNull(response.Result);
            Assert.Pass();
            
        }

        [Test]
        public void ShowDetailHeroe()
        {
            var response = _Details.HeroesDetails(44);
            Assert.NotNull(response.Result);
            
            Assert.Pass();
            
        }

        [Test]
        public void ShowNoFoundDetailHeroe()
        {
            var Heroe = new Heroe() { Id="33333333"};
           
            var response = _Details.HeroesDetails(Convert.ToInt32(Heroe.Id));
            Assert.IsNotNull(response.Result);
            
            Assert.Pass();

        }

    
    }
}
