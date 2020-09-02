using System;

namespace blazor.Client.Helpers
{
    public class CustomGreeting2
    {
        public static string customgreeting(string value)
        {
            return value.ToUpper() + " hoje é " + DateTime.Today;
        }
    }
}