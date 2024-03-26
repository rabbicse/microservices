using Mehedi.Application.SharedKernel.Enums;
using Mehedi.Application.SharedKernel.Exceptions;

namespace Mehedi.Application.SharedKernel.Interfaces;

public interface IResult
{
    ResultStatus Status { get; }
    IEnumerable<string> Errors { get; }
    IEnumerable<ValidationError> ValidationErrors { get; }
    Type ValueType { get; }
    object GetValue();
}
