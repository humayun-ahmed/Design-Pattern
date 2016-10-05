// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Person.cs" company="">
//   
// </copyright>
// <summary>
//   The person.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ConsoleApplication2
{
    using System.Collections.Generic;

    using ConsoleApplication2.Dto;

    /// <summary>
    /// The person.
    /// </summary>
    public class Person
    {
        /// <summary>
        /// The _addresses.
        /// </summary>
        private List<AddressDTO> _addresses;

        /// <summary>
        /// The _parents.
        /// </summary>
        private List<Parent> _parents;

        /// <summary>
        /// The _parents swiss.
        /// </summary>
        private Parent _parentsSwiss;

        /// <summary>
        /// The _permanent address.
        /// </summary>
        private AddressDTO _permanentAddress;

        /// <summary>
        /// The _place of origin.
        /// </summary>
        private AddressDTO _placeOfOrigin;

        /// <summary>
        /// Gets or sets the addresses.
        /// </summary>
        public List<AddressDTO> Addresses
        {
            get
            {
                return _addresses;
            }

            set
            {
                _addresses = value;
            }
        }

        /// <summary>
        /// Gets or sets the birth country.
        /// </summary>
        public string BirthCountry { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the gurdians.
        /// </summary>
        public List<Person> Gurdians { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the middle name.
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// Gets or sets the official name.
        /// </summary>
        public string OfficialName { get; set; }

        /// <summary>
        /// Gets or sets the parents.
        /// </summary>
        public List<Parent> Parents
        {
            get
            {
                return _parents;
            }

            set
            {
                _parents = value;
            }
        }

        /// <summary>
        /// Gets or sets the parents swiss.
        /// </summary>
        public Parent ParentsSwiss
        {
            get
            {
                return _parentsSwiss;
            }

            set
            {
                _parentsSwiss = value;
            }
        }

        /// <summary>
        /// Gets or sets the permanent address.
        /// </summary>
        public AddressDTO PermanentAddress
        {
            get
            {
                return _permanentAddress;
            }

            set
            {
                _permanentAddress = value;
            }
        }

        /// <summary>
        /// Gets or sets the place of origin.
        /// </summary>
        public List<AddressDTO> PlaceOfOrigin { get; set; }
    }
}