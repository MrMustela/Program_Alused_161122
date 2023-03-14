using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7märts
{
    public class GenderList
    {
        public static readonly List<Gender> genderList = new List<Gender>
        {
            new Gender()
            {
                Id = Guid.Parse("4d894ab3-815b-42e6-805d-6145d671d0a3"),
                Sex = "male"
            },
            new Gender()
            {
                Id = Guid.Parse("4db6ecb3-6f3e-4087-ada4-91bebe48a132"),
                Sex = "female"
            },

        };
    }
}
