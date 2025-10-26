namespace IntermediateOOPs
{
    internal class Car : Vehicle
    {
        public static int NumberOfWheels = 4;
        public decimal _price;
        public decimal Price 
        {
            get {  return _price; }
            set 
            {
                if(value > 0)
                    _price = value;
            }
        }
    }
}
