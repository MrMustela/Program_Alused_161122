
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
            Console.WriteLine("----------------------------------");
            CountLINQ();
            Console.WriteLine("----------------------------------");
            //MaxLINQ();
            SumLINQ();
            Console.WriteLine("----------------------------------");
            FirstOrDefaultLINQ();
            Console.WriteLine("----------------------------------");
            LastOfDefault();
            Console.WriteLine("----------------------------------");
            SingleOrDefault();
            Console.WriteLine("----------------------------------");
            SequenceEqual();
            Console.WriteLine("----------------------------------");
            ConcatLINQ();
            Console.WriteLine("----------------------------------");
            DefaultIfEmpty();
            Console.WriteLine("----------------------------------");
            EmptyRangeRepeat();
            Console.WriteLine("----------------------------------");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("----------------------------------");




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

        public static void CountLINQ()
        {
            Console.WriteLine("LINQ Count");

            var count = PeopleList.peoples.Count();

            Console.WriteLine("Number of people: " + count);
        }

        //public static void MaxLINQ()
        //{
            //Console.WriteLine("Max LINQ");

            //var max = PeopleList.peoples.Max();

            //Console.WriteLine("People Id: {0}, Student name: {1}",
                //max.Id, max);
        //}

        public static void SumLINQ()
        {
            Console.WriteLine("Sum LINQ");

            var total = NumberList.numberList.Sum();

            Console.WriteLine("Sum of even elements: " + total);
        }

        public static void FirstOrDefaultLINQ()
        {
            Console.WriteLine("FirstOrDefaultLINQ");

            //var firstOrDefault = PeopleList.peoples.FirstOrDefault();

            //Console.WriteLine(firstOrDefault);
            //var result2 = NumberList.numberList.FirstOrDefault();
              //var result2 = PeopleList.peoples.Name.FirstOrDefault();
            //Console.WriteLine("First or default result: " + result2);
        }
        public static void LastOfDefault()
        {
            Console.WriteLine("LastOrDefaultLINQ");

            var lastOrDefault = PeopleList.peoples.LastOrDefault();

            Console.WriteLine(lastOrDefault);

        }
        public static void SingleOrDefault()
        {
            IList<int> oneElement = new List<int>() { 7 };

            Console.WriteLine("Single or Default");

            var singleOrDefault = oneElement.SingleOrDefault();

            Console.WriteLine(singleOrDefault);
        }
        public static void SequenceEqual()
        {
            Console.WriteLine("SequenceEqual LINQ");

            IList<string> stringsList = new List<string>()
            { "One", "Two", "Three", "Four", "Five" };

            IList<string> stringsList2 = new List<string>()
            { "One", "Two", "Three", "Four" };

            //see kontrollib, kas seal on väärtuseid või ei ole
            //kas seal on üks ühele olemas väärtused
            bool isEqual = stringsList.SequenceEqual(stringsList2);

            Console.WriteLine(isEqual);
            
        }
        public static void ConcatLINQ()
        {
            Console.WriteLine("Concat LINQ");
            
            IList<int> collection1 = new List<int>() { 1, 2, 3 };
            IList<int> collection2 = new List<int>() { 4, 5, 6 };

            var collection3 = collection1.Concat(collection2);

            foreach (var item in collection3)
            {
                Console.WriteLine(item);
            }
        }
        public static void DefaultIfEmpty()
        {
            IList<int> emptyList = new List<int>();

            Console.WriteLine("DefaultIfEmpty LINQ");

            var newList1 = emptyList.DefaultIfEmpty();
            var newList2 = emptyList.DefaultIfEmpty(100);

            Console.WriteLine("Count: " + newList1.Count());
            Console.WriteLine("Count: " + newList1.ElementAt(0));

            Console.WriteLine("Count: " + newList2.Count());
            Console.WriteLine("Count: " + newList2.ElementAt(0));
        }
        public static void EmptyRangeRepeat()
        {
            Console.WriteLine("EmptyRangeRepeat LINQ");

            var emptyCollection1 = Enumerable.Empty<string>();
            var emptyCollection2 = Enumerable.Empty<People>();

            Console.WriteLine("Type {0}" + emptyCollection1.GetType().Name);
            Console.WriteLine("Count: {0} " + emptyCollection1.Count());

            Console.WriteLine("Type {0}" + emptyCollection2.GetType().Name);
            Console.WriteLine("Count: {0} " + emptyCollection2.Count());

            var intCollection = Enumerable.Range(3, 9);
            Console.WriteLine("Total count: {0} ", intCollection.Count());

            for (int i = 0; i < intCollection.Count(); i++)
            {
                Console.WriteLine("Value at index {0} : {1}", i, intCollection.ElementAt(i));
            }

            var repeatCollection = Enumerable.Range(3, 9);
            Console.WriteLine("Total count: {0} ", intCollection.Count());

            for (int i = 0; i < repeatCollection.Count(); i++)
            {
                Console.WriteLine("Value at index {0} : {1}", i, repeatCollection.ElementAt(i));
            }
        }

    }
}