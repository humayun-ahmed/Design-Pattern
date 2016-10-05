namespace ConsoleApplication1
{
    public class NonSwissPersonBuilder:PersonBuilderBase
    {
        private NonSwissPerson _nonSwissPerson;

        public NonSwissPersonBuilder()
        {
            _nonSwissPerson=new NonSwissPerson();
        }
        public override void BuildParents(AddPersonParams addPersonParams)
        {
            var parent = new Parent();
            _nonSwissPerson.Parents.Add(parent);
            parent.Father = new SwissPerson(addPersonParams.NameList["FathersFName"].Text,
                                            addPersonParams.NameList["FathersMName"].Text,
                                            addPersonParams.NameList["FatherLFName"].Text);
            parent.Mother = new SwissPerson(addPersonParams.NameList["MothersFName"].Text,
                                            addPersonParams.NameList["MothersMName"].Text,
                                            addPersonParams.NameList["MothersLFName"].Text);
        }

        public override void BuildAddress(AddPersonParams addPersonParams)
        {
            _nonSwissPerson.Addresses.Add(new AddressDTO(addPersonParams.AddressList["BPlace"].HouseNo,
                                                                        addPersonParams.AddressList["BPlace"].RoadNo,
                                                                        addPersonParams.AddressList["BPlace"].BuildingNo,
                                                                        addPersonParams.AddressList["BPlace"].City,
                                                                        addPersonParams.AddressList["BPlace"].Country));

            _nonSwissPerson.Addresses.Add(new AddressDTO(addPersonParams.AddressList["MarriageOrigin"].HouseNo,
                                                                        addPersonParams.AddressList["MarriageOrigin"].RoadNo,
                                                                        addPersonParams.AddressList["MarriageOrigin"].BuildingNo,
                                                                        addPersonParams.AddressList["MarriageOrigin"].City,
                                                                        addPersonParams.AddressList["MarriageOrigin"].Country,
                                                                        addPersonParams.AddressList["MarriageOrigin"].ValidFrom,
                                                                        addPersonParams.AddressList["MarriageOrigin"].ValidTo));

            _nonSwissPerson.Addresses.Add(new AddressDTO(addPersonParams.AddressList["AcquiredOrigin"].HouseNo,
                                                                        addPersonParams.AddressList["AcquiredOrigin"].RoadNo,
                                                                        addPersonParams.AddressList["AcquiredOrigin"].BuildingNo,
                                                                        addPersonParams.AddressList["AcquiredOrigin"].City,
                                                                        addPersonParams.AddressList["AcquiredOrigin"].Country,
                                                                        addPersonParams.AddressList["AcquiredOrigin"].ValidFrom,
                                                                        addPersonParams.AddressList["AcquiredOrigin"].ValidTo));
        }

      
    }
}