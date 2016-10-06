namespace ConsoleApplication2
{
    using ConsoleApplication2.Dto;

    internal class SwissPersonBuilder
    {
        private static void BuildSwissPerson(Person person, AddPersonParams addPersonParams)
        {
            person.Gurdians.Add(
                new Person(
                    addPersonParams.NameList["GurdianFName"].Text,
                    addPersonParams.NameList["GurdianMName"].Text,
                    addPersonParams.NameList["GurdianLFName"].Text));

            person.ParentsSwiss.Father = new Person(
                addPersonParams.NameList["FathersFName"].Text,
                addPersonParams.NameList["FathersMName"].Text,
                addPersonParams.NameList["FatherLFName"].Text);
            person.ParentsSwiss.Mother = new Person(
                addPersonParams.NameList["MothersFName"].Text,
                addPersonParams.NameList["MothersMName"].Text,
                addPersonParams.NameList["MothersLFName"].Text);

            person.ParentsSwiss.Father.ParentsSwiss.Father = new Person(
                addPersonParams.NameList["GFathersFName"].Text,
                addPersonParams.NameList["GFathersMName"].Text,
                addPersonParams.NameList["GFatherLFName"].Text);

            person.ParentsSwiss.Father.ParentsSwiss.Mother = new Person(
                addPersonParams.NameList["GMothersFName"].Text,
                addPersonParams.NameList["GMothersMName"].Text,
                addPersonParams.NameList["GMothersLFName"].Text);

            person.PermanentAddress = new AddressDTO(
                addPersonParams.AddressList["BPlace"].HouseNo,
                addPersonParams.AddressList["BPlace"].RoadNo,
                addPersonParams.AddressList["BPlace"].BuildingNo,
                addPersonParams.AddressList["BPlace"].City,
                addPersonParams.AddressList["BPlace"].Country);

            person.PlaceOfOrigin[0] = new AddressDTO(
                addPersonParams.AddressList["MarriageOrigin"].HouseNo,
                addPersonParams.AddressList["MarriageOrigin"].RoadNo,
                addPersonParams.AddressList["MarriageOrigin"].BuildingNo,
                addPersonParams.AddressList["MarriageOrigin"].City,
                addPersonParams.AddressList["MarriageOrigin"].Country,
                addPersonParams.AddressList["MarriageOrigin"].ValidFrom,
                addPersonParams.AddressList["MarriageOrigin"].ValidTo);

            person.PlaceOfOrigin[1] = new AddressDTO(
                addPersonParams.AddressList["AcquiredOrigin"].HouseNo,
                addPersonParams.AddressList["AcquiredOrigin"].RoadNo,
                addPersonParams.AddressList["AcquiredOrigin"].BuildingNo,
                addPersonParams.AddressList["AcquiredOrigin"].City,
                addPersonParams.AddressList["AcquiredOrigin"].Country,
                addPersonParams.AddressList["AcquiredOrigin"].ValidFrom,
                addPersonParams.AddressList["AcquiredOrigin"].ValidTo);
        }
    }
}