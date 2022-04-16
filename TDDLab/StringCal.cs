namespace TDDLab
{
    public class StringCal
    {
        private string numString;
        private char dlimtr = ',';


        public StringCal()
        {
            numString = "";

        }

        public StringCal(string _NumsString)
        {
            numString = _NumsString;


        }

        public char Delim
        {
            get { return dlimtr; }
            set { dlimtr = value; }
        }


        public void Add()
        {



        }

    }
}