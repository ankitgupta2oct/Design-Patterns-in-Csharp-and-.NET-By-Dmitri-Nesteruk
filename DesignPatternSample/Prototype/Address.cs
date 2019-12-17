namespace DesignPatternSample.Prototype
{
    public class Address
    {
        public string City;
        public int HouseNumber;

        public Address(string city, int houseNumber)
        {
            City = city;
            HouseNumber = houseNumber;
        }

        public override string ToString()
        {
            return $"HouseNumber: {HouseNumber}, City: {City}";
        }
    }
}