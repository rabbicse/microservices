using System.Text.Json.Serialization;

namespace Mehedi.Application.SharedKernel.Responses;

public class PagedResult<T> : Result<T>
{
    public PagedResult(PagedInfo pagedInfo, T value) : base(value)
    {
        PagedInfo = pagedInfo;
    }

    [JsonInclude]
    public PagedInfo PagedInfo { get; init; }
}
