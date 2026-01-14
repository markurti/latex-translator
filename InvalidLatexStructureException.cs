using System;
using System.Collections.Generic;
using System.Data;
using UiPath.Activities.System.Jobs.Coded;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Excel;
using UiPath.Excel.Activities;
using UiPath.Excel.Activities.API;
using UiPath.Excel.Activities.API.Models;
using UiPath.Orchestrator.Client.Models;

namespace TranslatorEvaluator
{
    public class InvalidLatexStructureException : Exception
    {
        public string LatexSection { get; set; }
        public int LineNumber { get; set; }
        
        public InvalidLatexStructureException(string message, string section, int line)
            : base(message)
        {
            LatexSection = section;
            LineNumber = line;
        }
        
        public InvalidLatexStructureException(string message) : base(message) {}
    }
}