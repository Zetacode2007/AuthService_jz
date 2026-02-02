using System;
using Microsoft.Extensions.Logging;

namespace AuthServiceIN6BV.Application.Extensions;

public static partial class LoggerExtensions
{
    [LoggerMessage(
        EventId = 1001,
        Level = LogLevel.Information,
        Message = "User {Username} registered succesfully.")]
    public static partial void LogUserRegister(this ILogger loger, string username);

    [LoggerMessage(
        EventId = 1002,
        Level = LogLevel.Information,
        Message = "User login succesfully.")]
    public static partial void LogUserLoggedIn(this ILogger loger);

    [LoggerMessage(
        EventId = 1003,
        Level = LogLevel.Warning,
        Message = "Failed login attempt.")]
    public static partial void LogFailedLoginAttempt(this ILogger loger);

    [LoggerMessage(
        EventId = 1004,
        Level = LogLevel.Warning,
        Message = "Registration rejected: Email already exists.")]
    public static partial void LogRegistrationWithExistingEmail(this ILogger loger);

    [LoggerMessage(
        EventId = 1005,
        Level = LogLevel.Warning,
        Message = "Registration rejected: Username already exists.")]
    public static partial void LogRegistrationWithExistingUsername(this ILogger loger);

    [LoggerMessage(
        EventId = 1006,
        Level = LogLevel.Error,
        Message = "Error uploading profile image.")]
    public static partial void LogImageUploadError(this ILogger loger);
}