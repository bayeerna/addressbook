﻿// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;

namespace WebAddressbookTests //все тесты будем помещать в это пространство имён
{
    [TestFixture]
    public class GroupCreationTests : AuthTestBase
    {
       
        [Test]
        public void GroupCreationTest()
        {
            //сначала инициализируем тестовые данные, потом создаем группу

            GroupData group = new GroupData("aaa");//параметр - имя(аaа)
            group.Header = "ddd";
            group.Footer = "fff";
            
            app.Groups.Create(group);
        }

        [Test]
        public void EmptyGroupCreationTest()
        {
            GroupData group = new GroupData("");//параметр - имя()
            group.Header = "";
            group.Footer = "";
            
            app.Groups.Create(group);
        }








    }
}
