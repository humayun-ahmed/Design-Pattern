namespace ConsoleApplication2.Dto
{
    using ConsoleApplication2;

    public class Parent
    {
        private Person _father;
        private Person _mother;

        public Person Father
        {
            get { return this._father; }
            set { this._father = value; }
        }

        public Person Mother
        {
            get { return this._mother; }
            set { this._mother = value; }
        }
    }
}