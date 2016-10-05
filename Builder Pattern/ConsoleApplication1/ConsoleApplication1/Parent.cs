namespace ConsoleApplication1
{
    public class Parent
    {
        private IPerson _father;
        private IPerson _mother;

        public IPerson Father
        {
            get { return _father; }
            set { _father = value; }
        }

        public IPerson Mother
        {
            get { return _mother; }
            set { _mother = value; }
        }
    }
}