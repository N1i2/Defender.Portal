﻿namespace WebUI.ErrorMapping;

public enum UIErrorCodes
{
    Error_UnhandledError,

    Error_EmptyLogin,
    Error_EmptyEmail,
    Error_EmptyNickname,
    Error_EmptyPassword,

    Error_InvalidEmail,
    Error_InvalidPhoneNumber,
    Error_InvalidLoginOrPassword,

    Error_PasswordIsTooShort,
    Error_PasswordIsTooLong,

    Error_EmailAddressInUse,
    Error_PhoneNumberInUse,
    Error_NicknameInUse,

    Error_NicknameIsTooShort,
    Error_NicknameIsTooLong,

    Error_AccessCodeWasExpired,
    Error_AccessCodeWasAlreadyUsed,
    Error_InvalidAccessCode,

    Error_UserBlocked,
}
