namespace NuHelper.Commands
{
    using System;
    using System.Runtime.Versioning;

    internal class ShortFrameworkNameCommand : ICommand
    {
        public void Execute(string[] args)
        {
            if (args.Length < 1)
            {
                throw new ArgumentException("must specify framework name");
            }
            else
            {
                FrameworkName frameworkName = new FrameworkName(args[0]);
                Console.WriteLine(NuGet.VersionUtility.GetShortFrameworkName(frameworkName));
            }
        }
    }
}
