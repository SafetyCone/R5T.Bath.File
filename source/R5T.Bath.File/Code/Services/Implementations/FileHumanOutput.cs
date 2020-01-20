using System;
using System.IO;

using R5T.Bath.Default;


namespace R5T.Bath.File
{
    public class FileHumanOutput : TextWriterHumanOutput, IHumanOutput, IDisposable
    {
        #region IDisposable

        private bool zDisposed = false;


        public void Dispose()
        {
            this.Dispose(true);
        }

        // Remove the virtual call if the class is sealed (or has no plans for subclassing, in which case this should be communicated by sealing the class).
        protected virtual void Dispose(bool disposing)
        {
            if (!this.zDisposed)
            {
                if (disposing)
                {
                    this.TextWriter.Dispose();
                }
            }

            this.zDisposed = true;
        }

        #endregion


        public FileHumanOutput(string humanOutputFilePath)
        {
            this.Setup(humanOutputFilePath);
        }

        public FileHumanOutput(IHumanOutputFilePathProvider humanOutputFilePathProvider)
        {
            var humanOutputFilePath = humanOutputFilePathProvider.GetHumanOutputFilePath();

            this.Setup(humanOutputFilePath);
        }

        private void Setup(string humanOutputFilePath)
        {
            this.TextWriter = new StreamWriter(humanOutputFilePath);
        }
    }
}
