namespace ConjuringTests.Utils {
    public static class URLUtil
    {
        private static string _baseUrl = "https://ethanmmay.github.io/conjuring-site";
  
        public static string CreatePath(string subpath) {
            return $"{_baseUrl}/{subpath}";
        }
    }

    class HeaderNavigation {
        public void NavigateTo(string searchKeyword) {

        }
    }
}