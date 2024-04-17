﻿namespace Wallet.Pages.GooglePay
{
    using OpenQA.Selenium;

    public class DecryptionApiSwaggerPage : PageBase
    {
        public static readonly string Title = "Swagger UI";
        public static readonly string Url = "https://wallet.lyndychivs.com/swagger/index.html";

        public DecryptionApiSwaggerPage(IWebDriver webDriver)
            : base(webDriver, Title)
        {
        }
    }
}