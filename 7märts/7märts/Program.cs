using System.Security.Cryptography.X509Certificates;

namespace _7märts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LINQ");
            WhereLINQ();
            Console.WriteLine("----------------------------------");
            ThenByLINQ();
            Console.WriteLine("----------------------------------");
            ThenByDescendingLINQ();
            Console.WriteLine("----------------------------------");
            ToLookUpLINQ();
            Console.WriteLine("----------------------------------");
            JoinLINQ();
            Console.WriteLine("----------------------------------");
            GroupJoinLINQ();
            Console.WriteLine("----------------------------------");
            //SelectLINQ();
            Console.WriteLine("----------------------------------");
            AllAndAnyLINQ();
            Console.WriteLine("----------------------------------");
            ContainsLINQ();
            Console.WriteLine("----------------------------------");
            AggregateLINQ();
            Console.WriteLine("----------------------------------");
            AvarageLINQ();
        }
        public static void WhereLINQ()
        {
            var peopleAge = PeopleList.peoples.Where(x => x.Age > 20 && x.Age < 23);

            foreach (var item in peopleAge)
            {
                Console.WriteLine(item.Name);

            }
        }

        public static void ThenByLINQ()
        {
            Console.WriteLine("ThenBy järgi reastamine");

            var thenByResult = PeopleList.peoples
                .OrderBy(x => x.Name)
                .ThenBy(x => x.Age);

            foreach (var people in thenByResult)
            {
                Console.WriteLine(people.Name + " " + people.Age);
            }
        }

        public static void ThenByDescendingLINQ()
        {
            Console.WriteLine("ThenByDescending");

            var thenByDescending = PeopleList.peoples
                .OrderBy(x => x.Name)
                .ThenByDescending(x => x.Age);

            foreach (var people in thenByDescending)
            {
                Console.WriteLine(people.Name + " " + people.Age);
            }
        }
        public static void ToLookUpLINQ()
        {
            Console.WriteLine("ToLookUp järgi reastamine");

            var toLookUp = PeopleList.peoples
                .ToLookup(x => x.Age);

            foreach (var people in toLookUp)
            {
                Console.WriteLine("Age group " + people.Key);

                foreach (People p in people)
                {
                    Console.WriteLine("Person name " + p.Name);
                }
            }
        }

        public static void JoinLINQ()
        {
            Console.WriteLine("InnerJoin in LINQ");

            var InnerJoin = PeopleList.peoples
                .Join(GenderList.genderList,
                humans => humans.GenderId,
                gender => gender.Id,
                (humans, gender) => new
                {
                    Name = humans.Name,
                    Sex = gender.Sex
                });

            foreach (var people in InnerJoin)
            {
                Console.WriteLine(people.Name + " " + people.Sex);
            }
        }

        public static void GroupJoinLINQ()
        {
            var groupJoin = GenderList.genderList
                .GroupJoin(PeopleList.peoples,
                p => p.Id,
                g => g.GenderId,
                (p, peopleGroup) => new
                {
                    humans = peopleGroup,
                    GenderFullName = p.Sex
                });

            foreach (var people in groupJoin)
            {
                Console.WriteLine(people.GenderFullName);

                foreach (var name in people.humans)
                {
                    Console.WriteLine(name.Name);
                }
            }
        }

      //  public static void SelectLINQ()
      //  {
      //      Console.WriteLine("Select in LINQ");

      //      var SelectLINQ = PeopleList.peoples
      //          .Select(p => p.Name);

      //      foreach (var peopleName in SelectLINQ)
      //      {
      //          Console.WriteLine(peopleName.name + " " + peopleName.age);
      //      }
      //  }
        
        public static void AllAndAnyLINQ()
        {
            Console.WriteLine("All LINQ");

            bool areALLPeopleTeenagers = PeopleList.peoples
                .All(x => x.Age > 10);

            Console.WriteLine(areALLPeopleTeenagers);

            Console.WriteLine("All LINQ");

            bool isALLPeopleTeenagers = PeopleList.peoples
                .All(x => x.Age > 18);

            Console.WriteLine(isALLPeopleTeenagers);
        }

        public static void ContainsLINQ()
        {
            Console.WriteLine("contains LINQ");

            bool result = NumberList.numberList.Contains(4);

            Console.WriteLine(result);
        }

        public static void AggregateLINQ()
        {
            Console.WriteLine("Aggregate");

            string commaSepratedPersonNames = PeopleList.peoples
                .Aggregate<People, string>(
                "People names: ",
                (str, x) => str += x.Name + ", "
                );

            Console.WriteLine(commaSepratedPersonNames);
        }

        public static void AvarageLINQ()
        {
            var avarageResult = PeopleList.peoples
                .Average(x => x.Age);
            Console.WriteLine(avarageResult);
        }
    }
}