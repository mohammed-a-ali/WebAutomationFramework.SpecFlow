﻿using BLL.Browser;
using BLL.Utilities;
using OpenQA.Selenium;

namespace BLL.Pages
{
    public class HomePageElements
    {
        public IWebElement HomePageImage { get { return Driver.WebDriver.FindElement(By.XPath("//img[@alt='nopCommerce demo store']")); } }

    }
}
