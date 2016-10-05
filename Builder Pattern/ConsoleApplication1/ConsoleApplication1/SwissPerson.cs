using System.Collections.Generic;

namespace ConsoleApplication1
{
    public class SwissPerson : IPerson
    {
        private AddressDTO _permanentAddress;
        private AddressDTO _placeOfOrigin;
        private Parent _parents;
        private string p;
        private string p_2;
        private string p_3;

        public SwissPerson(string p, string p_2, string p_3)
        {
            // TODO: Complete member initialization
            this.p = p;
            this.p_2 = p_2;
            this.p_3 = p_3;
        }

        public SwissPerson()
        {
            // TODO: Complete member initialization
        }

        public string FirstName
        {
            get { throw new System.NotImplementedException(); }
            set { throw new System.NotImplementedException(); }
        }

        public string MiddleName
        {
            get { throw new System.NotImplementedException(); }
            set { throw new System.NotImplementedException(); }
        }

        public string LastName
        {
            get { throw new System.NotImplementedException(); }
            set { throw new System.NotImplementedException(); }
        }

        public string OfficialName
        {
            get { throw new System.NotImplementedException(); }
            set { throw new System.NotImplementedException(); }
        }

        public string BirthCountry
        {
            get { throw new System.NotImplementedException(); }
            set { throw new System.NotImplementedException(); }
        }

        public AddressDTO PermanentAddress
        {
            get { return _permanentAddress; }
            set { _permanentAddress = value; }
        }

        public List<AddressDTO> PlaceOfOrigin
        {
            get { throw new System.NotImplementedException(); }
            set { throw new System.NotImplementedException(); }
        }

        public Parent Parents
        {
            get { return _parents; }
            set { _parents = value; }
        }

        public List<IPerson> Gurdians
        {
            get { throw new System.NotImplementedException(); }
            set { throw new System.NotImplementedException(); }
        }
    }
}