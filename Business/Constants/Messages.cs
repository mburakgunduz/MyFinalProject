using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor";
        public static string ProductAdded = "Ürün Eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductsListed = "Ürünler Listelendi";
        public static string ProductCountCategoryError = "Kategori sayısı 10dan az olsun";
        public static string ProductNameAlreadyExists = "Bu ürün isminde zaten bir ürün var";
    }
}
