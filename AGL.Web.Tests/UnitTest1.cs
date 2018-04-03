using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AGl.Service;
using System.Linq;
using System.Collections.Generic;
using AGL.Data;

namespace AGL.Web.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //AGLRepository repo = new AGLRepository("http://agl-developer-test.azurewebsites.net/people.json");

            //var data = repo.GetData();
            //var data = repo.GetPeronsWithCats();

            //var grpd = data.GroupBy(x => x.gender);
            //var res = grpd.Select(x => new { gender = x.Key, cats = x.SelectMany(item => item.pets).Distinct().OrderBy(y => y.name).ToList() }).ToList();

        }
    }
}
