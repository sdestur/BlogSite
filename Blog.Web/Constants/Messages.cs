namespace Blog.Web.Constants
{
    public static class Messages
    {
        public static class ArticleMessage
        {
            public static string Add(string articleTitle)
            {
                return $"{articleTitle} makalesi başarıyla eklenmiştir.";
            }

            public static string Update(string articleTitle)
            {
                return $"{articleTitle} makalesi başarıyla güncellenmiştir.";
            }

            public static string Delete(string articleTitle)
            {
                return $"{articleTitle} makalesi başarıyla silinmiştir.";
            }

            public static string UndoDelete(string articleTitle)
            {
                return $"{articleTitle} makalesi başarıyla geri alınmıştır.";
            }
        }

        public static class CategoryMessage
        {
            public static string Add(string categoryName)
            {
                return $"{categoryName} kategorisi başarıyla eklenmiştir.";
            }

            public static string Update(string categoryName)
            {
                return $"{categoryName} kategorisi başarıyla güncellenmiştir.";
            }

            public static string Delete(string categoryName)
            {
                return $"{categoryName} kategorisi başarıyla silinmiştir.";
            }

            public static string UndoDelete(string categoryName)
            {
                return $"{categoryName} kategorisi başarıyla geri alınmıştır.";
            }
        }

        public static class UserMessage
        {
            public static string Add(string userName)
            {
                return $"{userName} email adresli kullanıcı başarıyla eklenmiştir.";
            }

            public static string Update(string userName)
            {
                return $"{userName} email adresli kullanıcı başarıyla güncellenmiştir.";
            }

            public static string Delete(string userName)
            {
                return $"{userName} email adresli kullanıcı başarıyla silinmiştir.";
            }
        }
    }
}
