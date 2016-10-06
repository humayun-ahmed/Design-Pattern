// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="">
//   
// </copyright>
// <summary>
//   The program.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ConsoleApplication2
{
    using System.Collections.Generic;

    using ConsoleApplication2.Dto;

    /// <summary>
    /// The program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        private static void Main(string[] args)
        {
            var nameList = new Dictionary<string, Name>();
            var parentList = new Dictionary<string, Parent>();
            var addressList = new Dictionary<string, Address>();
            var addPersonParams = new AddPersonParams(nameList, parentList, addressList);
            Person person = new Person();

            person.BirthCountry = addPersonParams.AddressList["BPlace"].Country;

            person.FirstName = addPersonParams.NameList["FName"].Text;
            person.MiddleName = addPersonParams.NameList["MName"].Text;
            person.LastName = addPersonParams.NameList["LName"].Text;
            person.OfficialName = string.Format("{0} {1}", person.FirstName, person.LastName);


            if (addPersonParams.Nationality == Nationality.Swiss)
            {
                person.Gurdians.Add(new Person(addPersonParams.NameList["GurdianFName"].Text,
                                                                     addPersonParams.NameList["GurdianMName"].Text,
                                                                     addPersonParams.NameList["GurdianLFName"].Text));

                person.ParentsSwiss.Father = new Person(addPersonParams.NameList["FathersFName"].Text,
                                                                       addPersonParams.NameList["FathersMName"].Text,
                                                                       addPersonParams.NameList["FatherLFName"].Text);
                person.ParentsSwiss.Mother = new Person(addPersonParams.NameList["MothersFName"].Text,
                                                                            addPersonParams.NameList["MothersMName"].Text,
                                                                            addPersonParams.NameList["MothersLFName"].Text);

                person.ParentsSwiss.Father.ParentsSwiss.Father = new Person(addPersonParams.NameList["GFathersFName"].Text,
                                                                                           addPersonParams.NameList["GFathersMName"].Text,
                                                                                           addPersonParams.NameList["GFatherLFName"].Text);

                person.ParentsSwiss.Father.ParentsSwiss.Mother = new Person(addPersonParams.NameList["GMothersFName"].Text,

                                                                                           addPersonParams.NameList["GMothersMName"].Text,
                                                                                           addPersonParams.NameList["GMothersLFName"].Text);


                person.PermanentAddress = new AddressDTO(addPersonParams.AddressList["BPlace"].HouseNo,
                                                                        addPersonParams.AddressList["BPlace"].RoadNo,
                                                                        addPersonParams.AddressList["BPlace"].BuildingNo,
                                                                        addPersonParams.AddressList["BPlace"].City,
                                                                        addPersonParams.AddressList["BPlace"].Country);

                person.PlaceOfOrigin[0] = new AddressDTO(addPersonParams.AddressList["MarriageOrigin"].HouseNo,
                                                                             addPersonParams.AddressList["MarriageOrigin"].RoadNo,
                                                                             addPersonParams.AddressList["MarriageOrigin"].BuildingNo,
                                                                             addPersonParams.AddressList["MarriageOrigin"].City,
                                                                             addPersonParams.AddressList["MarriageOrigin"].Country,
                                                                             addPersonParams.AddressList["MarriageOrigin"].ValidFrom,
                                                                             addPersonParams.AddressList["MarriageOrigin"].ValidTo);

                person.PlaceOfOrigin[1] = new AddressDTO(addPersonParams.AddressList["AcquiredOrigin"].HouseNo,
                                                                             addPersonParams.AddressList["AcquiredOrigin"].RoadNo,
                                                                             addPersonParams.AddressList["AcquiredOrigin"].BuildingNo,
                                                                             addPersonParams.AddressList["AcquiredOrigin"].City,
                                                                             addPersonParams.AddressList["AcquiredOrigin"].Country,
                                                                             addPersonParams.AddressList["AcquiredOrigin"].ValidFrom,
                                                                             addPersonParams.AddressList["AcquiredOrigin"].ValidTo);

            }
            else
            {
                var parent = new Parent();
                person.Parents.Add(parent);
                parent.Father = new Person(addPersonParams.NameList["FathersFName"].Text,
                                                addPersonParams.NameList["FathersMName"].Text,
                                                addPersonParams.NameList["FatherLFName"].Text);
                parent.Mother = new Person(addPersonParams.NameList["MothersFName"].Text,
                                                addPersonParams.NameList["MothersMName"].Text,
                                                addPersonParams.NameList["MothersLFName"].Text);

                person.Addresses.Add(new AddressDTO(addPersonParams.AddressList["BPlace"].HouseNo,
                                                                        addPersonParams.AddressList["BPlace"].RoadNo,
                                                                        addPersonParams.AddressList["BPlace"].BuildingNo,
                                                                        addPersonParams.AddressList["BPlace"].City,
                                                                        addPersonParams.AddressList["BPlace"].Country));

                person.Addresses.Add(new AddressDTO(addPersonParams.AddressList["MarriageOrigin"].HouseNo,
                                                                            addPersonParams.AddressList["MarriageOrigin"].RoadNo,
                                                                            addPersonParams.AddressList["MarriageOrigin"].BuildingNo,
                                                                            addPersonParams.AddressList["MarriageOrigin"].City,
                                                                            addPersonParams.AddressList["MarriageOrigin"].Country,
                                                                            addPersonParams.AddressList["MarriageOrigin"].ValidFrom,
                                                                            addPersonParams.AddressList["MarriageOrigin"].ValidTo));

                person.Addresses.Add(new AddressDTO(addPersonParams.AddressList["AcquiredOrigin"].HouseNo,
                                                                            addPersonParams.AddressList["AcquiredOrigin"].RoadNo,
                                                                            addPersonParams.AddressList["AcquiredOrigin"].BuildingNo,
                                                                            addPersonParams.AddressList["AcquiredOrigin"].City,
                                                                            addPersonParams.AddressList["AcquiredOrigin"].Country,
                                                                            addPersonParams.AddressList["AcquiredOrigin"].ValidFrom,
                                                                            addPersonParams.AddressList["AcquiredOrigin"].ValidTo));
            }

        }
    }
}