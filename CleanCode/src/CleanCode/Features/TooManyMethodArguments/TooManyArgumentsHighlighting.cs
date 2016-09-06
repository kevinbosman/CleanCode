using CleanCode;
using CleanCode.Features.TooManyMethodArguments;
using JetBrains.DocumentModel;
using JetBrains.ReSharper.Feature.Services.Daemon;
using JetBrains.ReSharper.Psi.CSharp;

[assembly: RegisterConfigurableSeverity(TooManyArgumentsHighlighting.SeverityID, null, 
    CleanCodeHighlightingGroupIds.CleanCode, "Too many arguments", "Too many arguments passed to a method.",
    Severity.WARNING, false)]

namespace CleanCode.Features.TooManyMethodArguments
{
    [ConfigurableSeverityHighlighting(SeverityID, CSharpLanguage.Name)]
    public class TooManyArgumentsHighlighting : IHighlighting
    {
        internal const string SeverityID = "TooManyArguments";
        private readonly string tooltip;
        private readonly DocumentRange documentRange;

        public TooManyArgumentsHighlighting(string toolTip, DocumentRange documentRange)
        {
            tooltip = toolTip;
            this.documentRange = documentRange;
        }

        public DocumentRange CalculateRange()
        {
            return documentRange;
        }

        public string ToolTip
        {
            get { return tooltip; }
        }

        public string ErrorStripeToolTip
        {
            get { return tooltip; }
        }

        public bool IsValid()
        {
            return true;
        }
    }
}