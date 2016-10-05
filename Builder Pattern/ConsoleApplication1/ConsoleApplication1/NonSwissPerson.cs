using System.Collections.Generic;

namespace ConsoleApplication1
{
    public class NonSwissPerson : IPerson
    {
        private List<AddressDTO> _addresses;
        private List<Parent> _parents;
        private string p;
        private string p_2;
        private string p_3;

        public NonSwissPerson(string p, string p_2, string p_3)
        {
            // TODO: Complete member initialization
            this.p = p;
            this.p_2 = p_2;
            this.p_3 = p_3;
        }

        public NonSwissPerson()
        {
            // TODO: Complete member initialization
        }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string OfficialName { get; set; }
        public string BirthCountry { get; set; }

        public List<AddressDTO> Addresses
        {
            get { return _addresses; }
            set { _addresses = value; }
        }

        public List<Parent> Parents
        {
            get { return _parents; }
            set { _parents = value; }
        }


        Parent IPerson.Parents
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
                throw new System.NotImplementedException();
            }
        }
    }
}