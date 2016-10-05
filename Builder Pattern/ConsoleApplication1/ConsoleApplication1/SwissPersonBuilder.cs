namespace ConsoleApplication1
{
    public class SwissPersonBuilder : PersonBuilderBase
    {
        public SwissPersonBuilder()
        {
            _person = new SwissPerson();   
        }
        public  void BuildGuardian(AddPersonParams addPersonParams)
        {
            ((SwissPerson)_person).Gurdians.Add(new SwissPerson(addPersonParams.NameList["GurdianFName"].Text,
                                                                    addPersonParams.NameList["GurdianMName"].Text,
                                                                    addPersonParams.NameList["GurdianLFName"].Text));
        }

        public override void BuildParents(AddPersonParams addPersonParams)
        {
            _person.Parents.Father = new SwissPerson(addPersonParams.NameList["FathersFName"].Text,
                                                                        addPersonParams.NameList["FathersMName"].Text,
                                                                        addPersonParams.NameList["FatherLFName"].Text);
            _person.Parents.Mother = new SwissPerson(addPersonParams.NameList["MothersFName"].Text,
                                                                        addPersonParams.NameList["MothersMName"].Text,
                                                                        addPersonParams.NameList["MothersLFName"].Text);

            _person.Parents.Father.Parents.Father = new SwissPerson(addPersonParams.NameList["GFathersFName"].Text,
                                                                                       addPersonParams.NameList["GFathersMName"].Text,
                                                                                       addPersonParams.NameList["GFatherLFName"].Text);

            _person.Parents.Father.Parents.Mother = new SwissPerson(addPersonParams.NameList["GMothersFName"].Text,
            
                                                                                       addPersonParams.NameList["GMothersMName"].Text,
                                                                                       addPersonParams.NameList["GMothersLFName"].Text);

            BuildGuardian(addPersonParams);
        }

        public override void BuildAddress(AddPersonParams addPersonParams)
        {
            ((SwissPerson)_person).PermanentAddress = new AddressDTO(addPersonParams.AddressList["BPlace"].HouseNo,
                                                                         addPersonParams.AddressList["BPlace"].RoadNo,
                                                                         addPersonParams.AddressList["BPlace"].BuildingNo,
                                                                         addPersonParams.AddressList["BPlace"].City,
                                                                         addPersonParams.AddressList["BPlace"].Country);

            ((SwissPerson)_person).PlaceOfOrigin[0] = new AddressDTO(addPersonParams.AddressList["MarriageOrigin"].HouseNo,
                                                                         addPersonParams.AddressList["MarriageOrigin"].RoadNo,
                                                                         addPersonParams.AddressList["MarriageOrigin"].BuildingNo,
                                                                         addPersonParams.AddressList["MarriageOrigin"].City,
                                                                         addPersonParams.AddressList["MarriageOrigin"].Country,
                                                                         addPersonParams.AddressList["MarriageOrigin"].ValidFrom,
                                                                         addPersonParams.AddressList["MarriageOrigin"].ValidTo);

            ((SwissPerson)_person).PlaceOfOrigin[1] = new AddressDTO(addPersonParams.AddressList["AcquiredOrigin"].HouseNo,
                                                                         addPersonParams.AddressList["AcquiredOrigin"].RoadNo,
                                                                         addPersonParams.AddressList["AcquiredOrigin"].BuildingNo,
                                                                         addPersonParams.AddressList["AcquiredOrigin"].City,
                                                                         addPersonParams.AddressList["AcquiredOrigin"].Country,
                                                                         addPersonParams.AddressList["AcquiredOrigin"].ValidFrom,
                                                                         addPersonParams.AddressList["AcquiredOrigin"].ValidTo);
        }
    }
}