namespace Mehedi.Read.Infrastructure.SharedKernel.Interfaces;

/// <summary>
/// Represents the interface for application options.
/// </summary>
public interface IAppOptions
{
    /// <summary>
    /// The configuration section path.
    /// </summary>
    static abstract string ConfigSectionPath { get; }
}
