using RestWithASPNET5Udemy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RestWithASPNET5Udemy.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person
        }

        public void Delete(long id)
        {
    
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for(int i =0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person)
            }
            return persons

        }

      
       
        public Person FindByID(long id)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                Address = "Rua qualquer ",
                FirstName = "Guilherme",
                Gender = "Male",
                LastName = "Brito"
            };
        }

        public Person update(Person person)
        {
            return person;
        }
        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                Address = "Person Address " +i,
                FirstName = "Person First Name" + i,
                Gender = i%2 ==0 ? "Male" : "Female" ,
                LastName = "Person Last Name" + i
            };
        }


    }
}
