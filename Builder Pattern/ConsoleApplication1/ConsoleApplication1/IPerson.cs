namespace ConsoleApplication1
{
    public interface IPerson
    {
        string FirstName { get; set; }
        string MiddleName { get; set; }
        string LastName { get; set; }
        string OfficialName { get; set; }
        string BirthCountry { get; set; }
        Parent Parents { get; set; }
    }
}