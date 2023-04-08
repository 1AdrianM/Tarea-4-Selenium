using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace TestQA
{
    class Program
    {
        static void Main(string[] args)
        {
            // Iniciar una nueva instancia del navegador Chrome
            IWebDriver driver = new ChromeDriver(@"C:\ruta\al\controlador"); //Ruta donde se encuentra el ejecutable del controlador

            // Abrir la página de inicio de Facebook
            driver.Navigate().GoToUrl("https://www.facebook.com");

            // Iniciar sesión en Facebook con un usuario y contraseña
            IWebElement emailField = driver.FindElement(By.Name("email"));
            emailField.SendKeys("adrian944uchiha@gmail.com");
            IWebElement passwordField = driver.FindElement(By.Name("pass"));
            passwordField.SendKeys("Tylerjace25");
            IWebElement loginButton = driver.FindElement(By.Name("login"));
            loginButton.Click();
            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();

            // Guardar la captura de pantalla en un archivo
            screenshot.SaveAsFile("screenshot.png", ScreenshotImageFormat.Png);

            // Esperar a que la página de inicio se cargue completamente
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
 
            // Ir al muro del usuario
            driver.Navigate().GoToUrl("https://www.facebook.com/profile.php");

         

            // Cerrar el navegador
            driver.Quit();

            Console.WriteLine("Prueba automatizada completada");
            Console.ReadLine();
        }
    }
}

