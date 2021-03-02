using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
   public class Messages
    {
        public static string CarAddedWrong = "Girilen bilgiler doğru değildir.";
        public static string CarAddedSuccess = "Araba eklenmiştir";
        public static string CarDeletedSuccess = "Araba silinmiştir.";
        public static string CarListed = "Arabalar listelenmiştir";
        public static string CarUpdated = "Araba güncellenmiştir.";
        public static string BrandUpdated = "Model güncellenmiştir.";

      

        public static string BrandAdded = "Model Eklenmiştir.";
        public static string BrandDeleted = "Model Silinmiştir.";

        public static string ColorUpdated = "Renk güncellenmiştir.";
        public static string ColorAdded = "Renk Eklenmiştir.";
        public static string ColorDeleted = "Renk Silinmiştir.";
        public static string UsersAdded = "Kullanıcı eklendi";

        public static string UsersDeleted = "Kullanıcı silindi ";
        public static string UsersListed = "Kullanıcı listelendi ";
        public static string UserUpdated = "Kullanıcı güncellendi ";
        

        public static string CustomerAdded = "Müşteri eklendi ";
        public static string CustomerDeleted = "Müşteri silindi ";
        public static string CustomerUpdated = "Müşteri güncellendi ";
        public static string RentalAdded = "Kiralama eklendi ";
        public static string RentalNotAdded = "Araç kirada ";
        public static string RentalDeleted = "Kiralama silindi ";
        public static string RentalListed = "Kiralama listelendi ";
        public static string RentalUpdated = "Kiralama güncellendi ";
        internal static string TheNumberOfImagesUploadedHasExceeded;
        internal static string ErrorDeleted;
        internal static string SuccessDeleted;
        internal static string SuccessListed;
        internal static string SuccessAdded;
        public static string FailAddedImageLimit="Fotograf limit aşıldı";
        internal static string ImageUpdated;
        internal static string ImageLimit;
        internal static string DesiredListed;
        internal static string CarImageListed;
        internal static string CarImageGetAll;
        public static string UserNotFound="Kullanıcı bulunamadı";
        public static string PasswordError="Şifre hatalı";
        public static string SuccessfulLogin="Giriş başarılı";
        public static string UserAlreadyExists="Bu kullanıcı zaten mevcut";
        public static string UserRegistered="Kullanıcı başarıyla kaydedildi.";
        public static string AccessTokenCreated ="Access token başarıyla oluşturuldu";
        public static string AuthorizationDenied="Yetkiniz yok";
    }
}
