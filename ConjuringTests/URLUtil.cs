namespace ConjuringTests.URLUtil {
    public class URLUtil {
        private string _baseUrl = "https://ethanmmay.github.io/conjuring-site";
  
        public String CreatePath(this string subpath) {
            return $"{_baseUrl}/{subpath}";
        }
    }

    class HeaderNavigation {
        public HeaderNavigation() {}

        public void NavigateToSearch() {
            _driver.Navigate().To(Urls.Search.CreatePath());
        }
    }
}