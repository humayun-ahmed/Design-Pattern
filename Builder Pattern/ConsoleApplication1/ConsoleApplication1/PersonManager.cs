namespace ConsoleApplication1
{
    public class PersonManager
    {
        private readonly SwissPersonBuilder _swissPersonBuilder = new SwissPersonBuilder();
        private readonly NonSwissPersonBuilder _nonSwissPersonBuilder = new NonSwissPersonBuilder();

        public void AddPerson(AddPersonParams addPersonParams)
        {
            var repository=new Repository();
            if (addPersonParams.Nationality == Nationality.Swiss)
            {
                var person = CreateSwissPerson(addPersonParams);

                repository.AddPerson(person);
            }
            else
            {
                var person = CreateNonSwissPerson(addPersonParams);

                repository.AddPerson(person);
            }
        }

        private IPerson CreateNonSwissPerson(AddPersonParams addPersonParams)
        {
            

            Director director = new Director(_nonSwissPersonBuilder);
            director.Construct(addPersonParams);
            IPerson person = _nonSwissPersonBuilder.GetResult();



            return person;
        }

        private IPerson CreateSwissPerson(AddPersonParams addPersonParams)
        {
            Director director = new Director(_swissPersonBuilder);
            director.Construct(addPersonParams);
            IPerson person = _swissPersonBuilder.GetResult();
            return person;
        }
    }

    public class Director
    {
        private PersonBuilderBase _personBuilderBase;

        public Director(PersonBuilderBase personBuilderBase)
        {
            _personBuilderBase = personBuilderBase;
        }

        public void Construct(AddPersonParams addPersonParams)
        {
            _personBuilderBase.BuildName(addPersonParams);
            _personBuilderBase.BuildBirthCountry(addPersonParams);
            _personBuilderBase.BuildAddress(addPersonParams);
            _personBuilderBase.BuildParents(addPersonParams);
        }
    }
}