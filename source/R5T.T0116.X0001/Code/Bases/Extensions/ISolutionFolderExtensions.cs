using System;

using R5T.T0116;
using R5T.T0116.X0001;


namespace System
{
    public static class ISolutionFolderExtensions
    {
        public static string Dependencies(this ISolutionFolder _)
        {
            return SolutionFolders.Dependencies;
        }
    }
}
