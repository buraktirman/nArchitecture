namespace Core.Security.Enums;

public enum AuthenticatorType
{
    None = 0, //Direkt email ve şifre ile giriş
    Email = 1, //Email platformu veya 2 factor authentication üzerinden giriş
    Otp = 2 //One time password ile giriş (sms, google authenticator, vs.)
}