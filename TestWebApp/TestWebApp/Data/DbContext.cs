

using System.Collections;
using System.Collections.Generic;

namespace TestWebApp.Data
{
    public class DbContext
    {

        public IEnumerable<Cat> AllCats()
            => new List<Cat>
            {
                new Cat{Id = 1, Name = "Sharo", Age = 6, Owner = new Owner{Id = 1, Name = "Kenov"}},
                new Cat{Id = 2, Name = "Lady", Age = 13, Owner = new Owner{Id = 1, Name = "Kenov"}},
                new Cat{Id = 3, Name = "Tomohiro", Age = 2, Owner = new Owner{Id = 2, Name = "Richard"}}
            };

    }
}
