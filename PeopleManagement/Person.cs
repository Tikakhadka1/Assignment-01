public class Person
{
    public int Index;
    public string UserId;
    public string FirstName;
    public string LastName;
    public string Sex;
    public string Email;
    public string Phone;
    public string DateOfBirth;
    public string JobTitle;

    public Person(int index, string userId, string firstName, string lastName, string sex, string email, string phone, string dateOfBirth, string jobTitle)
    {
        Index = index;
        UserId = userId;
        FirstName = firstName;
        LastName = lastName;
        Sex = sex;
        Email = email;
        Phone  = phone;
        DateOfBirth = dateOfBirth;
        JobTitle = jobTitle;
    }
}