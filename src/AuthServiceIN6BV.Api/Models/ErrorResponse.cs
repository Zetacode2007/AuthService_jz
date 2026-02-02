using System.Diagnostics;

namespace AuthServiceIN6BV.Api.Models;    

public class ErrorResponse
{
    public int StausCode { get; set; }
    public string? Message { get; set; }
    public string Detail { get; set; } = string.Empty;

    public string? ErrorCode { get; set; }

    public string? TraceId { get; set; } = Activity.Current?.Id ?? string.Empty;

    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    
}