namespace ConjuringTests.Utils {
    public static class URLUtil
    {
        private static readonly string _baseUrl = "https://ethanmmay.github.io/conjuring-site";
  
        public static string CreatePath(string subpath) {
            return $"{_baseUrl}/{subpath}";
        }
    }
}