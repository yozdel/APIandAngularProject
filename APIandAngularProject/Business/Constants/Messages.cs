using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi.";
        public static string ProductNameInvalid = "Ürün İsmi Geçersiz.";
        public static string MaintenanceTime = "Sistem Bakımda.";
        public static string ProductsListed = "Ürünler Listelendi.";
        public static string ProductCountOfCategoryError ="Bir Kategoride En Fazla 10 Ürün Olanilir.";
        public static string ProductNameAlreadyExists="Bu İsimde Bir Ürün Var";
        public static string CategoryLimitExceded="Kategori Limiti Aşıldı.";
        public static string AuthorizationDenied="Yetkisiz Erişim.";
        public static string UserRegistered="Kayıt Oldu.";
        public static string UserNotFound="Kullanıcı Bulunamadı.";
        public static string PasswordError="Parola Hatası.";
        public static string SuccessfulLogin="Başarılı Giriş.";
        public static string UserAlreadyExists="Kullanıcı Mevcut.";
        public static string AccessTokenCreated="Token Oluşturuldu.";
    }
}
