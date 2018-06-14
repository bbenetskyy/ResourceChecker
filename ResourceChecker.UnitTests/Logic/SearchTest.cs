using Microsoft.VisualStudio.TestTools.UnitTesting;
using ResourceChecker.Logic;
using ResourceChecker.Models;
using ResourceChecker.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ResourceChecker.UnitTests.Logic
{
    [TestClass]
    class SearchTest
    {
        public SettingsModel SettingsModel { get; set; }
        public SearchHub SearchHub { get; set; }

        [TestInitialize]
        public void Init()
        {
            SettingsModel = new SettingsModel
            {
                CheckAt = new CheckAtModel
                {
                    FilesRegex = "*.cs",
                    Folder = "/"
                },
                SearchAt = new CheckAtModel
                {
                    FilesRegex = "*.txt",
                    Folder = "/"
                },
                SearchFor = new CheckForModel
                {
                    TextRegex = "{{*}}"
                },
                Skip = new SkipModel
                {
                    Condition = Condition.StartWith,
                    Text = "{{bwf"
                }
            };
            SearchHub = new SearchHub(SettingsModel);
        }

        [TestMethod]
        public void GetMatchesTest()
        {
            Assert.Fail();
        }
    }

    public class SearchHub: SearchLogic
    {
        public  SettingsModel SettingsModel { get; set; }

        public SearchHub(SettingsModel settingsModel)
            :base(settingsModel)
        {
            SettingsModel = settingsModel;
        }

        public MatchCollection GetMatchesHub(string filePath)
        {
            return GetMatches(filePath);
        }
    }
}
