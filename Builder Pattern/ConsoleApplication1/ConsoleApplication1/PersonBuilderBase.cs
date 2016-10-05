namespace ConsoleApplication1
{
    public abstract class PersonBuilderBase
    {
        protected IPerson _person;

        public  void BuildBirthCountry(AddPersonParams addPersonParams)
        {
            _person.BirthCountry = addPersonParams.AddressList["BPlace"].Country;
        }

        public  void BuildName(AddPersonParams addPersonParams)
        {
         
            _person.FirstName = addPersonParams.NameList["FName"].Text;
            _person.MiddleName = addPersonParams.NameList["MName"].Text;
            _person.LastName = addPersonParams.NameList["LName"].Text;
            _person.OfficialName = string.Format("{0} {1}", _person.FirstName, _person.LastName);
        }

        public abstract void BuildParents(AddPersonParams addPersonParams);
        public abstract void BuildAddress(AddPersonParams addPersonParams);

        public IPerson GetResult()
        {
            return _person;
        }
    }
}