using System;
using System.Collections.Generic;
using System.Threading;
using PeopleRegAPI.Model;

namespace PeopleRegAPI.Services.Implementations
{
    public class PersonService : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            
        }

        public List<Person> FindAll()
        {
            List<Person> people = new List<Person>();
            for(int i = 0; i < 8; i++){
                Person person = MockPerson(i);
                people.Add(person);
            }
            return people;
        }

        private Person MockPerson(int i)
        {
            return new Person{
                Id = IncrementAndGet(),
                FirstName = "Name" + i,
                LastName = "LastName" + i,
                Address = "Address" + i,
                Gender = "Gender" + i
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }

        public Person FindById(long id)
        {
            return new Person{
                Id = IncrementAndGet(),
                FirstName = "Thiago",
                LastName = "Justo",
                Address = "Rua Leonor Porto, 34",
                Gender = "Male"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }
    }
}