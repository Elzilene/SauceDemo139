using System;
using TechTalk.SpecFlow;

namespace MyNamespace
{
    [Binding]
    public class StepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;

        private IWebdriver driver; // objeto do selenium

        public StepDefinitions(ScenarioContext scenarioContext)

        {
            _scenarioContext = scenarioContext;
        }
        [BeforeScenario]
        public void SetUp()
        {
            // Instanciando o ChromeDriver através do WebDriverManager
            new DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver(); // instanciou o Selenium como Chrome
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(10000);
            driver.Manage().Window.Maximize();
        }

        [AfterScenario]
        public void TearDown()
        {
            driver.Quit(); // encerrou o Selenium
        }
        }
        [Given(@"que acesso a página inicial do site")]
        public void DadoQueAcessoAPaginaInicialDoSite()
        {
          
        }

        [When(@"preencho o usuário como ""(.*)""")]
        public void QuandoPreenchoOUsuarioComo(string p0)
        {
           driver.FidElement(By.Id("user-name").SendKeys(username));
        }

        [When(@"a senha ""(.*)"" e clico no botao Login")]
        public void QuandoASenhaEClicoNoBotaoLogin(string p0)
        {
            driver.FidElement(By.Id("password").SendKeys(String password));
            driver.FindElement(By.Id("login-button")).Click();
        }

        [When(@"adiciono o produto ""(.*)"" ao carrinho")]
        public void QuandoAdicionoOProdutoAoCarrinho(string p0)
        {
            Assert.That(driver.FidElement(By.cssSelector("span-tittle").Text, Is.EqualTo(title)));
        }

        [When(@"clico no icone do carrinho de compras")]
        public void QuandoClicoNoIconeDoCarrinhoDeCompras()
        {
            String productSelector = "add-to-cart-"
            // id da mochila
            // id da lanterna

        }

        [Then(@"exibe ""(.*)"" no titulo da secao")]
        public void EntaoExibeNoTituloDaSecao(string products0)
        {
           
        }

        [Then(@"exibe a pagina do carrinho com a quantidade ""(.*)""")]  
        public void EntaoExibeAPaginaDoCarrinhoComAQuantidade(string p0) 
        {
            _scenarioContext.Pending();
        }

        [Then(@"nome do produto ""(.*)""")]
        public void EntaoNomeDoProduto(string p0)
        {
           
        }

        [Then(@"o preco como ""(.*)""")]
        public void EntaoOPrecoComo(string p0)
        {
            
    }
}