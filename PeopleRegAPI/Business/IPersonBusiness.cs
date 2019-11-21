using System.Collections.Generic;
using PeopleRegAPI.Model;

namespace PeopleRegAPI.Business
{
    public interface IPersonBusiness
    {
        Person Create (Person person);
        Person FindById (long id);
        List<Person> FindAll ();
        Person Update(Person person);
        void Delete(long id);
    }
}