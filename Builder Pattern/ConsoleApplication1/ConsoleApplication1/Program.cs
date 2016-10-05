using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager pm=new PersonManager();
            var nameList = new Dictionary<string, Name>();
            var parentList = new Dictionary<string, Parent>();
            var addressList = new Dictionary<string, Address>();
            pm.AddPerson(new AddPersonParams(nameList, parentList, addressList));
        }
    }
}
