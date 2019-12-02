namespace DesignPatternSample.Builder.FacetedBuilder
{
    public class PersonBuilder
    {
        protected Person person = new Person();

        public PersonAddressBuilder Lives => new PersonAddressBuilder(person);
        public PersonJobBuilder Works => new PersonJobBuilder(person);

        public override string ToString()
        {
            return person.ToString();
        }
    }
}