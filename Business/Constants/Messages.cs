using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
   public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed="Ürünler listelendi";

        public static string ProductCountOfCategoryError = "Kategorideki limit sayısını aştınız";

        public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var";
        public static string AuthorizationDenied="Yetkiniz yok.";
    }
}
