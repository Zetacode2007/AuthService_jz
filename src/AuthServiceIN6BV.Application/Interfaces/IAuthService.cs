using AuthServiceIN6BV.Application.DTOs;
using AuthServiceIN6BV.Application.DTOs.Email;

namespace AuthServiceIN6BV.Application.Interfaces;

public interface IAuthService
{
    Task<RegisterResponseDto> RegisterAsync(RegisterDto registerDto);
    Task<AuthResponseDto> LoginAsync(LoginDto loginDto);
    Task<EmailReponseDto> VerifyEmailAsync(VerifyEmailDto verifyEmailDto);
    Task<EmailReponseDto> ResendVerificationEmailAsync(ResendVerificationDto resendVerificationDto);
    Task<EmailReponseDto> ForgotPasswordAsync(ForgotPasswordDto forgotPasswordDto);
    Task<EmailReponseDto> ResetPasswordAsync(ResetPasswordDto resetPasswordDto);
    Task<UserResponseDto> GetUserByIdAsync(string userId);
}