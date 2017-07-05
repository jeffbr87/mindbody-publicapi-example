using System;

namespace PublicApiApp.Exceptions
{
    /// <summary>
    /// An formatted exception representing an error response in API interactions
    /// </summary>
    public class ApiException : Exception
    {
        // ReSharper disable RedundantNameQualifier

        public ApiException(ClientService.MBResult result) : base(FormatExceptionMessage(result.Message))
        {
        }

        public ApiException(ClassService.MBResult result) : base(FormatExceptionMessage(result.Message))
        {
        }

        public ApiException(SaleService.MBResult result) : base(FormatExceptionMessage(result.Message))
        {
        }

        // ReSharper enable RedundantNameQualifier

        private static string FormatExceptionMessage(string message) => $"Error - {message}";
    }
}
