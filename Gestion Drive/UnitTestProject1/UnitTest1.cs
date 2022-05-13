using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;/*
using BC = BCrypt.Net;*/
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestHash()
        {
            {
                string pwd = "password";

                if (BC.BCrypt.Verify(pwd) == "password")
                {
                    Console.WriteLine("Le mot de passe n'a pas été hashé");
                }
                else
                {
                    Console.WriteLine("Le mot de passe est hashé");
                }

            }
        }
    }
}
