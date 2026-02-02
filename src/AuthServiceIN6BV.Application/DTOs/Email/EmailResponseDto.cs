namespace AuthServiceIN6BV.Application.DTOs.Email;

public class EmailReponseDto
{
    public bool Success {get; set;}
    public string Message {get; set;} = string.Empty;
    public object? Data {get; set;}
}