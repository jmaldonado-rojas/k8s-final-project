using MyWebApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApi.Data
{
    public interface IPersonRepository
    {
        Task<IEnumerable<Person>> GetAllPersons();

        Task<Person> GetPerson(int id);

        Task<bool> AddPerson(Person person);
    }
}
