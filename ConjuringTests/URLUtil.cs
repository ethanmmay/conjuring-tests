namespace ConjuringTests.URLUtil {
    public class URLUtil {
        private const string baseURL = "https://ethanmmay.github.io/conjuring-site";

        public String GetHomePageURL() {
            return baseURL;
        }

        public String GetBedroomGURL() {
            return baseURL + "/bedroom-g.html";
        }

        public String GetBedroomBURL() {
            return baseURL + "/bedroom-b.html";
        }

        public String GetOutsideGURL() {
            return baseURL + "/outside-g.html";
        }

        public String GetOutsideBURL() {
            return baseURL + "/outside-b.html";
        }

        public String GetBasementGURL() {
            return baseURL + "/basement-g.html";
        }

        public String GetBasementBURL() {
            return baseURL + "/basement-b.html";
        }
    }
}