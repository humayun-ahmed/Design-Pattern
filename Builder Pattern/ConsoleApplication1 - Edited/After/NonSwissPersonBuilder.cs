namespace ConsoleApplication2
{
    using ConsoleApplication2.Dto;

    internal class NonSwissPersonBuilder
    {
        private static void BuildNonSwissPerson(Person person, AddPersonParams addPersonParams)
        {
            var parent = new Parent();
            person.Parents.Add(parent);
            parent.Father = new Person(
                addPersonParams.NameList["FathersFName"].Text,
                addPersonParams.NameList["FathersMName"].Text,
                addPersonParams.NameList["FatherLFName"].Text);
            parent.Mother = new Person(
                addPersonParams.NameList["MothersFName"].Text,
                addPersonParams.NameList["MothersMName"].Text,
                addPersonParams.NameList["MothersLFName"].Text);

            person.Addresses.Add(
                new AddressDTO(
                    addPersonParams.AddressList["BPlace"].HouseNo,
                    addPersonParams.AddressList["BPlace"].RoadNo,
                    addPersonParams.AddressList["BPlace"].BuildingNo,
                    addPersonParams.AddressList["BPlace"].City,
                    addPersonParams.AddressList["BPlace"].Country));

            person.Addresses.Add(
                new AddressDTO(
                    addPersonParams.AddressList["MarriageOrigin"].HouseNo,
                    addPersonParams.AddressList["MarriageOrigin"].RoadNo,
                    addPersonParams.AddressList["MarriageOrigin"].BuildingNo,
                    addPersonParams.AddressList["MarriageOrigin"].City,
                    addPersonParams.AddressList["MarriageOrigin"].Country,
                    addPersonParams.AddressList["MarriageOrigin"].ValidFrom,
                    addPersonParams.AddressList["MarriageOrigin"].ValidTo));

            person.Addresses.Add(
                new AddressDTO(
                    addPersonParams.AddressList["AcquiredOrigin"].HouseNo,
                    addPersonParams.AddressList["AcquiredOrigin"].RoadNo,
                    addPersonParams.AddressList["AcquiredOrigin"].BuildingNo,
                    addPersonParams.AddressList["AcquiredOrigin"].City,
                    addPersonParams.AddressList["AcquiredOrigin"].Country,
                    addPersonParams.AddressList["AcquiredOrigin"].ValidFrom,
                    addPersonParams.AddressList["AcquiredOrigin"].ValidTo));
        }
    }
}