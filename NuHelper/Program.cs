namespace NuHelper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using NuHelper.Commands;

    internal class Program
    {
        private static readonly Dictionary<string, ICommand> Commands = new Dictionary<string, ICommand>();

        private static void Main(string[] args)
        {
            Commands.Add("shortFrameworkName", new ShortFrameworkNameCommand());

            if (args.Length > 0)
            {
                ICommand command;

                if (Commands.TryGetValue(args[0], out command))
                {
                    try
                    {
                        command.Execute(args.Skip(1).ToArray());
                    }
                    catch (Exception e)
                    {
                        Console.Error.WriteLine("error running '{0}': {1}", args[0], e.Message);
                    }
                }
                else
                {
                    Console.Error.WriteLine("unknown command '{0}'", args[0]);
                }
            }
            else
            {
                Console.Error.WriteLine("Must specify a command");
            }
        }
    }
}
