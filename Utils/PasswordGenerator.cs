using System;

namespace DevUtil.Utils
{
    public static class PasswordGenerator
    {
        private static string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static readonly string numberArr = "0123456789";
        private static readonly string symbolArr = "!@#$%^&*_-+=";

        public static string Generate(int length = 8, bool numbers = true, bool symbols = true)
        {
            var password = string.Empty;
            var rand = new Random();
            if (numbers == true)
                chars += numberArr;
            if (symbols == true)
                chars += symbolArr;

            for (var i = 0; i < length; i++)
            {
                password += chars[rand.Next(chars.Length - 1)];
            }

            return password;
        }
    }
}