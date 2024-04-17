class CSVParser
{
    private List<Person> people;

    public CSVParser()
    {
        people = new List<Person>();
    }

public void Parse(string filePath)
    {
        using (var reader = new StreamReader(filePath))
        {
            string line;
            #pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            while ((line = reader.ReadLine()) != null)
            {
                var data = line.Split(',');
                var index = int.Parse(data[0]);
                   var userId = data[1];
                   var firstName = data[2];
                   var lastName = data[3];
                   var sex = data[4];
                   var email = data[5];
                   var phone = data[6];
                   var dateOfBirth = data[7];
                   var jobTitle = data[8];
                       
                   var person = new Person(index, userId, firstName, lastName, sex, email, phone, dateOfBirth, jobTitle);
                   people.Add(person);
                }
            }
    }
    public void PrintNames()
    {
        foreach (var person in people)
        {
            Console.WriteLine($"{person.FirstName} {person.LastName}");
        }
    }
}