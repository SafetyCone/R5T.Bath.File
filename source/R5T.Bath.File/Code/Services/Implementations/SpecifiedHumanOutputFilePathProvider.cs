using System;

using R5T.T0064;


namespace R5T.Bath.File
{
    [ServiceImplementationMarker]
    public class SpecifiedHumanOutputFilePathProvider : IHumanOutputFilePathProvider, IServiceImplementation
    {
        private string HumanOutputFilePath { get; }


        public SpecifiedHumanOutputFilePathProvider(
            [NotServiceComponent] string humanOutputFilePath)
        {
            this.HumanOutputFilePath = humanOutputFilePath;
        }

        public string GetHumanOutputFilePath()
        {
            return this.HumanOutputFilePath;
        }
    }
}
