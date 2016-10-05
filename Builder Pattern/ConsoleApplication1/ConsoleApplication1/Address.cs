namespace ConsoleApplication1
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
            get { return _country; }
            set { _country = value; }
        }

        public string HouseNo
        {
            get { return _houseNo; }
            set { _houseNo = value; }
        }

        public string RoadNo
        {
            get { return _roadNo; }
            set { _roadNo = value; }
        }

        public string BuildingNo
        {
            get { return _buildingNo; }
            set { _buildingNo = value; }
        }

        public string City
        {
            get { throw new System.NotImplementedException(); }
            set { throw new System.NotImplementedException(); }
        }

        public string ValidFrom
        {
            get { return _validFrom; }
            set { _validFrom = value; }
        }

        public string ValidTo
        {
            get { throw new System.NotImplementedException(); }
            set { throw new System.NotImplementedException(); }
        }
    }
}