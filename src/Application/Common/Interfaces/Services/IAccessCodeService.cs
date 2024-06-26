﻿namespace Defender.Portal.Application.Common.Interfaces;

public interface IAccessCodeService
{
    Task SendEmailVerificationAccessCodeAsync(Guid? userId);
    Task SendUserUpdateAccessCodeAsync(Guid? userId);
    Task<bool> VerifyAccessCodeAsync(int code);
    Task<bool> VerifyEmailAsync(int hash, int code);
}
