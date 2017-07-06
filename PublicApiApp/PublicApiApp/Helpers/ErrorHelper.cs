using System.Windows.Forms;

namespace PublicApiApp.Helpers
{
    /// <summary>
    /// Helper for creating standardized error messaging
    /// </summary>
    public static class ErrorHelper
    {
        // TODO add some granularity to error responses. IIRC pretty much everything is an error, though

        private enum Severity
        {
            Info,
            Warning,
            Error
        }

        // Even though MBResult

        public static void DisplayError(ClientService.MBResult result) => DisplayError(Severity.Error, result.Message);

        public static void DisplayError(ClassService.MBResult result) => DisplayError(Severity.Error, result.Message);

        public static void DisplayError(SaleService.MBResult result) => DisplayError(Severity.Error, result.Message);

        private static void DisplayError(Severity severity, string message)
        {
            MessageBox.Show(severity.ToString(), message, MessageBoxButtons.OK, severity.GetIcon());
        }

        private static MessageBoxIcon GetIcon(this Severity severity)
        {
            switch (severity)
            {
                case Severity.Info:
                    return MessageBoxIcon.Information;
                case Severity.Warning:
                    return MessageBoxIcon.Warning;
                case Severity.Error:
                    return MessageBoxIcon.Exclamation;
                default:
                    return MessageBoxIcon.None;
            }
        }
    }
}
