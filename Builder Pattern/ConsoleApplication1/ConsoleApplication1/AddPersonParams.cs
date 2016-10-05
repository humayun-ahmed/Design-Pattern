using System.Collections.Generic;

namespace ConsoleApplication1
{
    public class AddPersonParams
    {
        private Dictionary<string, Name> _nameList;
        private Dictionary<string, Parent> _parentList;
        private Dictionary<string, Address> _addressList;
        private Nationality _nationality; 

        public AddPersonParams(Dictionary<string, Name> nameList, Dictionary<string, Parent> parentList, Dictionary<string, Address> addressList)
        {
            NameList = nameList;
            ParentList = parentList;
            AddressList = addressList;
        }

        public Dictionary<string, Name> NameList
        {
            get { return _nameList; }
            set { _nameList = value; }
        }

        public Dictionary<string, Parent> ParentList
        {
            get { return _parentList; }
            set { _parentList = value; }
        }

        public Dictionary<string, Address> AddressList
        {
            get { return _addressList; }
            set { _addressList = value; }
        }

        public Nationality Nationality
        {
            get { return _nationality; }
            set { _nationality = value; }
        }
    }

        
        
    
}