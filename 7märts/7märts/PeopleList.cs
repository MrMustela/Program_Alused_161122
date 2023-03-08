using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _7märts
{
    public class PeopleList
    {
        public static readonly List<People> peoples = new List<People>
        {
            new People()
            {
                Id = 1,
                Name = "Moona",
                Age = 11,
                GenderId = Guid.Parse("4db6ecb3-6f3e-4087-ada4-91bebe48a132")
            },
            new People()
            {
                Id = 2,
                Name = "Poona",
                Age = 21,
                GenderId = Guid.Parse("4db6ecb3-6f3e-4087-ada4-91bebe48a132")
            },
            new People()
            {
                Id = 3,
                Name = "Tooma",
                Age = 24,
                GenderId = Guid.Parse("4d894ab3-815b-42e6-805d-6145d671d0a3")
            },
            new People()
            {
                Id = 4,
                Name = "Soona",
                Age = 42,
                GenderId = Guid.Parse("4db6ecb3-6f3e-4087-ada4-91bebe48a132")
            },
            new People()
            {
                Id = 5,
                Name = "Mari",
                Age = 17,
                GenderId = Guid.Parse("4db6ecb3-6f3e-4087-ada4-91bebe48a132")
            },
            new People()
            {
                Id = 6,
                Name = "Mari",
                Age = 21,
                GenderId = Guid.Parse("4db6ecb3-6f3e-4087-ada4-91bebe48a132")
            },
            new People()
            {
                Id = 7,
                Name = "Bill",
                Age = 21,
                GenderId = Guid.Parse("4d894ab3-815b-42e6-805d-6145d671d0a3")
            },
        };
    }
}
