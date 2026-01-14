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
    public class TranslationAPIException : Exception
    {
        public int StatusCode { get; set; }
        public string APIResponse { get; set; }
        
        public TranslationAPIException(string message, int statusCode, string response)
            : base(message)
        {
            StatusCode = statusCode;
            APIResponse = response;
        }
        
        public TranslationAPIException(string message) : base(message) {}
    }
}