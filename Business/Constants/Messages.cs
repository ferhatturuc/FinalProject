using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryErrpor = "Bir kategoride en fazla 10 ürün olur";
        public static string ProductNameAlreadyExist = "Bu isimde bir ürün zaten var";
        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor";
        public static string AuthorizationDenied = "Yetkiniz Yok";

        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string ProductDeleted = "Ürün Silindi";

        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";

        public static string CategoryAdded = "Kategori eklendi";
        public static string CategoryDeleted = "Kategori silindi";
        public static string ProductUpdated = "Ürün Güncellendi";
    }
}
