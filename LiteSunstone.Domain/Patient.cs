namespace LiteSunstone.Domain
{
    public class Patient
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public Patient(string id, string name, int age) {
            Id = id;
            Name = name;
            Age = age;
        }

    }
}