


using System.Collections.Generic;

namespace WebAppMVC.Services
{

    public class CatService : ICatService
    {
        

        public IEnumerable<string> GetCatNames()
        {
            return new List<string>
            {
                "Ivan", "Gosho", "Pesho"
            };
        }

        public string SomeValue { get; set; }
    }
}
