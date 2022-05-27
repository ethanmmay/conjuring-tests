import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;

public class HomePage {
    protected WebDriver driver;

    private By messageBy = By.tagName("h1");

    public HomePage(WebDriver driver) { 
        this.driver = driver;
        if (!driver.getTitle().equals("Ethan's Testing Site")) { 
            throw new IllegalStateException("This is not Home Page of logged in user," +
                    " current page is: " + driver.getCurrentUrl());
        }
    }

    public string getMessageText() { 
        return driver.findElement()
    }


}