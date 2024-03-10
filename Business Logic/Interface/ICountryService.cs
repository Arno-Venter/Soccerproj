using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic.Interface
{
    public interface ICountryService
    {

        List<Country> getAll();
    }
}
