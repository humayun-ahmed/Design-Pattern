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
    using System.Diagnostics;

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
            Person person = new Person("FirstName", "MiddleName", "LastName");
            if (addPersonParams.Nationality == Nationality.Swiss)
            {
                SwissPersonBuilder builder=new SwissPersonBuilder();
                builder.BuildSwissPerson(person, addPersonParams);
            }
            else
            {
                NonSwissPersonBuilder builder = new NonSwissPersonBuilder();
                builder.BuildNonSwissPerson(person, addPersonParams);
            }

            Debug.Print(person.FirstName);

        }
    }
}