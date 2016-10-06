namespace ConsoleApplication2.Dto
{
    public class Address
    {
        private string _country;
        private string _houseNo;
        private string _roadNo;
        private string _buildingNo;
        private string _validFrom;

        public string Country
        {
            get { return this._country; }
            set { this._country = value; }
        }

        public string HouseNo
        {
            get { return this._houseNo; }
            set { this._houseNo = value; }
        }

        public string RoadNo
        {
            get { return this._roadNo; }
            set { this._roadNo = value; }
        }

        public string BuildingNo
        {
            get { return this._buildingNo; }
            set { this._buildingNo = value; }
        }

        public string City
        {
            get { throw new System.NotImplementedException(); }
            set { throw new System.NotImplementedException(); }
        }

        public string ValidFrom
        {
            get { return this._validFrom; }
            set { this._validFrom = value; }
        }

        public string ValidTo
        {
            get { throw new System.NotImplementedException(); }
            set { throw new System.NotImplementedException(); }
        }
    }
}