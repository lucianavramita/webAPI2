namespace webAPI2.Models
{
    public class Adult
    {
     public int Id { get; set; } = 0;
     public string FirstName { get; set; } = "";
     public string LastName { get; set; } = "";
     public string HairColor { get; set; } = "";
     public string EyeColor { get; set; } = "";
     public int Age { get; set; } = 0;
     public float Weight { get; set; } = 0;
    public char Sex { get; set; } = 'N';
    public Job JobTitle { get; set; }
    }
}