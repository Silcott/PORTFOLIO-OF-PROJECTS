using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore_UI.Static
{
    public static class Endpoints
    {
        public static string BaseUrl = "http://localhost:60013/";
        public static string AuthorsEndpoint = $"{BaseUrl}api/authors";
        public static string BooksEndpoint = $"{BaseUrl}api/books/";
    }
}
