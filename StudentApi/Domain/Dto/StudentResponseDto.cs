namespace Domain.Dto;

public class StudentResponseDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public double Grade { get; set; }
    public char FirstNonRepeatedLetter { get; set; }
}