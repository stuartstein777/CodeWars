namespace Solution
{
    using System.Text.RegularExpressions;
    using System;
    class Kata
    {
        public static bool is_valid_IP(string ipAddress)
        {
            Console.WriteLine(ipAddress);
            var pattern = new Regex(@"^((25[0-5]|(2[0-4]|1\d|[1-9]|)\d)(\.(?!$)|$)){4}$");
            return pattern.IsMatch(ipAddress);
        }
    }
}