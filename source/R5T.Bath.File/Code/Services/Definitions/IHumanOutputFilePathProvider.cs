using System;

using R5T.T0064;


namespace R5T.Bath.File
{
    [ServiceDefinitionMarker]
    public interface IHumanOutputFilePathProvider : IServiceDefinition
    {
        string GetHumanOutputFilePath();
    }
}
