namespace ConsoleApplication2.Dto
{
    public class AddressDTO
    {
        private string p;
        private string p_2;
        private string p_3;
        private string p_4;
        private string p_5;
        private string p_6;
        private string p_7;

        public AddressDTO(string houseNo, string roadNo, string buildingNo, string city, string country)
        {
            throw new System.NotImplementedException();
        }

        public AddressDTO(string p, string p_2, string p_3, string p_4, string p_5, string p_6, string p_7)
        {
            // TODO: Complete member initialization
            this.p = p;
            this.p_2 = p_2;
            this.p_3 = p_3;
            this.p_4 = p_4;
            this.p_5 = p_5;
            this.p_6 = p_6;
            this.p_7 = p_7;
        }
    }
}