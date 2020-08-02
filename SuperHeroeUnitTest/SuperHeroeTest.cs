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
        
        public SuperHeroeTest()
        {
            _search = new SearchRepository();
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
            var response = _search.HeroesDetails(44);
            Assert.NotNull(response.Result);
            
            Assert.Pass();
            
        }

        [Test]
        public void ShowNoFoundDetailHeroe()
        {
            var Heroe = new Heroe() { Id="33333333"};
           
            var response = _search.HeroesDetails(Convert.ToInt32(Heroe.Id));
            Assert.IsNotNull(response.Result);
            
            Assert.Pass();

        }

    
    }
}
