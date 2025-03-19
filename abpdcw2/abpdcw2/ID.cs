namespace abpdcw2
{
    public class Id
    {
        private int _id;

        
        public Id(int initialId = 0)
        {
            _id = initialId;
        }

        public int IdValue
        {
            get { return _id; }
            set { _id = value; }
        }

     
        public void Increment()
        {
            _id += 1;
        }
    }
}