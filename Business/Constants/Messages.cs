using Core.Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAddedMessage = "Ürün başarıyla eklendi.";
        public static string ProductUpdatedMessage = "Ürün başarıyla güncellendi.";
        public static string ProductDeletedMessage = "Ürün başarıyla silindi.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Şifre Hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";

        public static string UserAlreadyExists = "Bu e-posta adresi kullanılmış!";

        public static string UserRegistered = "Kullanıcı başarıyla oluşturuldu.";

        public static string AccessTokenCreated = "Access Token başarıyla oluşturuldu.";
    }
}