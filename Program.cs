using System;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.IO;
using DevUtil.Utils;

namespace DevUtil
{
    class Program
    {
        static int Main(string[] args)
        {
            var rootCommand = new RootCommand("Collection of Dev Utility Functions");

            // Generate password
            var generatePassword = new Command("generatePassword", "Generate new password");
            generatePassword.AddOption(
                new Option<int>(
                    aliases: new string[] { "--length", "-l" },
                    getDefaultValue: () => 8,
                    "Password length"
                )
            );
            generatePassword.AddOption(
                new Option<bool>(
                    aliases: new string[] { "--no-numbers", "-nn" },
                    getDefaultValue: () => false,
                    "Omit numbers"
                )
            );
            generatePassword.AddOption(
                new Option<bool>(
                    aliases: new string[] { "--no-symbols", "-ns" },
                    getDefaultValue: () => false,
                    "Omit symbols"
                )
            );
            generatePassword.Handler = CommandHandler.Create<int, bool, bool>((length, noNumbers, noSymbols) =>
            {
                var password = PasswordGenerator.Generate(length, !noNumbers, !noSymbols);
                Console.WriteLine($"Password: {password}");
            });
            rootCommand.AddCommand(generatePassword);

            // Generate GUID
            var generateGuid = new Command("generateGuid", "Generate a new GUID");
            generateGuid.AddOption(
                new Option<bool>(
                    aliases: new string[] { "--lowercase", "-l" },
                    getDefaultValue: () => false,
                    "Return as lowercase"
                )
            );
            generateGuid.Handler = CommandHandler.Create<bool>((lowercase) =>
            {
                var guid = Guid.NewGuid();
                if (lowercase == false)
                    Console.WriteLine($"GUID: {guid.ToString().ToUpper()}");
                else
                    Console.WriteLine($"GUID: {guid}");
            });
            rootCommand.AddCommand(generateGuid);

            return rootCommand.InvokeAsync(args).Result;
        }
    }
}
