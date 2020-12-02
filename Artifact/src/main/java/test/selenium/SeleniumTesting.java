package test.selenium;
import org.junit.Test;
import org.junit.Before;
import org.junit.After;
import static org.junit.Assert.*;
import static org.hamcrest.CoreMatchers.is;
import static org.hamcrest.core.IsNot.not;
import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.firefox.FirefoxDriver;
import org.openqa.selenium.chrome.ChromeDriver;
import org.openqa.selenium.remote.RemoteWebDriver;
import org.openqa.selenium.remote.DesiredCapabilities;
import org.openqa.selenium.Dimension;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.interactions.Actions;
import org.openqa.selenium.support.ui.ExpectedConditions;
import org.openqa.selenium.support.ui.WebDriverWait;
import org.openqa.selenium.JavascriptExecutor;
import org.openqa.selenium.Alert;
import org.openqa.selenium.Keys;
import java.util.*;
import java.net.MalformedURLException;
import java.net.URL;
public class SeleniumTesting {
  private WebDriver driver;
  private Map<String, Object> vars;
  JavascriptExecutor js;
  @Before
  public void setUp() {
	System.setProperty("webdriver.chrome.driver", "C:\\Users\\Mihai\\Desktop\\chromedriver.exe");
    driver = new ChromeDriver();
    js = (JavascriptExecutor) driver;
    vars = new HashMap<String, Object>();
  }
  @After
  public void tearDown() {
    driver.quit();
  }
  public String waitForWindow(int timeout) {
    try {
      Thread.sleep(timeout);
    } catch (InterruptedException e) {
      e.printStackTrace();
    }
    Set<String> whNow = driver.getWindowHandles();
    Set<String> whThen = (Set<String>) vars.get("window_handles");
    if (whNow.size() > whThen.size()) {
      whNow.removeAll(whThen);
    }
    return whNow.iterator().next();
  }
  @Test
  public void untitled() {
    driver.get("https://www.javatpoint.com/");
    driver.manage().window().setSize(new Dimension(1920, 1031));
    driver.findElement(By.id("gsc-i-id1")).click();
    driver.findElement(By.id("gsc-i-id1")).sendKeys("selenium");
    driver.findElement(By.id("gsc-i-id1")).sendKeys(Keys.ENTER);
    driver.switchTo().frame(0);
    driver.findElement(By.linkText("Selenium Testing - Caută Selenium Testing")).click();
    driver.close();
    driver.findElement(By.cssSelector("#\\___gcse_0 > .gsc-control-cse")).click();
    driver.findElement(By.id("gsc-i-id1")).click();
    driver.findElement(By.id("gsc-i-id1")).sendKeys("selenium");
    driver.findElement(By.cssSelector("#\\___gcse_0 .gsc-search-button > .gsc-search-button")).click();
    driver.findElement(By.cssSelector("#\\___gcse_0 .gsc-search-button > .gsc-search-button")).click();
    {
      WebElement element = driver.findElement(By.cssSelector("#\\___gcse_0 .gsc-search-button > .gsc-search-button"));
      Actions builder = new Actions(driver);
      builder.moveToElement(element).perform();
    }
    {
      WebElement element = driver.findElement(By.tagName("body"));
      Actions builder = new Actions(driver);
      builder.moveToElement(element, 0, 0).perform();
    }
    driver.findElement(By.id("gsc-i-id1")).sendKeys(Keys.ENTER);
    driver.findElement(By.id("gsc-i-id1")).sendKeys("selenium");
    vars.put("window_handles", driver.getWindowHandles());
    driver.findElement(By.linkText("Selenium Tutorial - javatpoint")).click();
    vars.put("win5737", waitForWindow(2000));
    driver.switchTo().window(vars.get("win5737").toString());
    {
      WebElement element = driver.findElement(By.linkText("Running Test on Chrome"));
      Actions builder = new Actions(driver);
      builder.moveToElement(element).perform();
    }
    driver.findElement(By.linkText("Running Test on Chrome")).click();
    js.executeScript("window.scrollTo(0,1500)");
    js.executeScript("window.scrollTo(0,2300)");
    driver.findElement(By.cssSelector("#bottomnext > .next:nth-child(2)")).click();
  }
}
