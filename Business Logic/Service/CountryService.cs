using Business_Logic;
using Business_Logic.Interface;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic.Service
{
    public class CountryService : ICountryService
    {

        private SoccerContext context;

        public CountryService(SoccerContext context)
        {
            this.context = context;
        }

        public List<Country> getAll()
        {
            return context.Countries.ToList();
        }
    }
}
