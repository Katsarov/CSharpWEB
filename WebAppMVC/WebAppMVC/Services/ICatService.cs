

using System.Collections.Generic;

namespace WebAppMVC.Services
{
    public interface ICatService
    {
        public IEnumerable<string> GetCatNames();

        public string SomeValue { get; set; }
    }
}
