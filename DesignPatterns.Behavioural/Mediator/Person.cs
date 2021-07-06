namespace DesignPatterns.Behavioural.Mediator
{
    public class Person
    {
        public string Id { get; private set; }
        public string FirstName { get; private set; }

        public Person(string id, string firstName)
        {
            Id = id;
            FirstName = firstName;
        }
    }
}