using AuthServiceIN6BV.Application.Interfaces;

namespace AuthServiceIN6BV.Application.Validators;

public static class FileValidator
{
    private static readonly string[] AllowImageExtensions = { ".jpg", ".jpeg", ".png", ".webp" };

    public const int MaxFileSizeInBytes = 5 * 1024 * 1024; // 5 MB

    public static (bool isValid, string errorMessage) ValidateImage(IFileData file)
    {
        if(file == null || file.Size == 0)
        {
            return (false, "File is required.");
        }

        if (file.Size > MaxFileSizeInBytes)
        {
            return (false, $"File size cannot exceed {MaxFileSizeInBytes / (1024 * 1024)} MB.");
        }

        var extension = Path.GetExtension(file.FileName).ToLowerInvariant();

        if(!AllowImageExtensions.Contains(extension))
        {
            return (false, $"Only the following file types are allowed: {string.Join(", ", AllowImageExtensions)}");
        }

        var allowedContentTypes = new[] { "image/jpeg", "image/png", "image/webp" };
        if (!allowedContentTypes.Contains(file.ContentType.ToLowerInvariant()))
        {
            return (false, "Invalid file content type.");
        }
        return (true, null);
    }


    public static string GenerateSecureFileName(string originalFileName)
    {
        var extension = Path.GetExtension(originalFileName).ToLowerInvariant();
        var uniqueId = Guid.NewGuid().ToString("N")[..12];
        return $"profile-{uniqueId}{extension}";
    }
}