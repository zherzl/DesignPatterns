using System;

namespace EventTickets
{
    public class ErrorLog
    {
        public static string GenerateErrorRefMessageAndLog(Exception exception)
        {
            // Here you would log the error and the unique reference ID
            return String.Format
                ("If you wish to contact us please quote reference '{0}'", Guid.NewGuid().ToString());

        }
    }
}