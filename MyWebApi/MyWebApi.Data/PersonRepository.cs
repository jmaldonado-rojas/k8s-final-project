using Dapper;
using MyWebApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApi.Data
{
    public class PersonRepository : IPersonRepository
    {
        MySqlDbConnection _dbConnection;

        public PersonRepository(MySqlDbConnection mySqlDbConnection)
        {
            _dbConnection = mySqlDbConnection;
        }

        public async Task<bool> AddPerson(Person person)
        {
            var addPersonQuery = "INSERT INTO Person(Name, LastName, Role) VALUES (@Name, @LastName, @Role)";
            var result = await _dbConnection.GetMySqlConnection().ExecuteAsync(addPersonQuery, person);
            return result > 0;
        }

        public async Task<IEnumerable<Person>> GetAllPersons()
        {
            var getAllPersonsQuery = "SELECT Id, Name, LastName, Role FROM Person";
            return await _dbConnection.GetMySqlConnection().QueryAsync<Person>(getAllPersonsQuery);
        }

        public async Task<Person> GetPerson(int id)
        {
            var getPersonQuery = "SELECT Id, Name, LastName, Role FROM Person WHERE Id = @Id";
            return await _dbConnection.GetMySqlConnection().QueryFirstOrDefaultAsync<Person>(getPersonQuery, new {Id = id});
        }
    }
}
