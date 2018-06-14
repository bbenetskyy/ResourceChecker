using ResourceChecker.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ToolsPortable;

namespace ResourceChecker.Logic
{
    public class SearchLogic 
    {
        protected readonly SettingsModel settingsModel;

        public SearchLogic(SettingsModel settingsModel)
        {
            this.settingsModel = settingsModel;
        }
        public List<string> MakeSearch()
        {
            if (settingsModel == null)
                throw new ArgumentNullException(nameof(settingsModel));
            if (!CheckFolder(settingsModel.SearchAt.Folder))
                throw new ArgumentException($"Incorrect folder - {settingsModel.SearchAt}");
            if (settingsModel.SearchAt.FilesRegex.IsBlank())
                throw new ArgumentException($"Files Regex is blank!");
            var files = Directory.GetFiles(settingsModel.SearchAt.Folder, settingsModel.SearchAt.FilesRegex);
            var matches = files.Select(GetMatches);
            return matches
                .SelectMany(
                    element =>
                        element.OfType<string>()
                         .Select(s => s))
                .ToList();
        }

        protected MatchCollection GetMatches(string filePath)
        {
            var lines = File.ReadAllLines(filePath);
            var matches = lines
                .Select(
                    line =>
                        Regex.Matches(line, settingsModel.SearchFor.TextRegex));

            return matches.First();

        }

        protected bool CheckFolder(string folder)
        {
            return Directory.Exists(folder);
        }
    }
}
