using System;


namespace R5T.Bath.File
{
    public class SpecifiedHumanOutputFilePathProvider : IHumanOutputFilePathProvider
    {
        private string HumanOutputFilePath { get; }


        public SpecifiedHumanOutputFilePathProvider(string humanOutputFilePath)
        {
            this.HumanOutputFilePath = humanOutputFilePath;
        }

        public string GetHumanOutputFilePath()
        {
            return this.HumanOutputFilePath;
        }
    }
}
