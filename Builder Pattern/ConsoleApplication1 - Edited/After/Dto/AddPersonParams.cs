namespace ConsoleApplication2.Dto
{
    using System.Collections.Generic;

    public class AddPersonParams
    {
        private Dictionary<string, Name> _nameList;
        private Dictionary<string, Parent> _parentList;
        private Dictionary<string, Address> _addressList;
        private Nationality _nationality; 

        public AddPersonParams(Dictionary<string, Name> nameList, Dictionary<string, Parent> parentList, Dictionary<string, Address> addressList)
        {
            this.NameList = nameList;
            this.ParentList = parentList;
            this.AddressList = addressList;
        }

        public Dictionary<string, Name> NameList
        {
            get { return this._nameList; }
            set { this._nameList = value; }
        }

        public Dictionary<string, Parent> ParentList
        {
            get { return this._parentList; }
            set { this._parentList = value; }
        }

        public Dictionary<string, Address> AddressList
        {
            get { return this._addressList; }
            set { this._addressList = value; }
        }

        public Nationality Nationality
        {
            get { return this._nationality; }
            set { this._nationality = value; }
        }
    }

        
        
    
}