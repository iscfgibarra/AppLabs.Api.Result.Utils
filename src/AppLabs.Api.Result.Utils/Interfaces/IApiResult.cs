namespace AppLabs.Api.Result.Utils.Interfaces
{
    public interface IApiResult<out TData, out TMessage>
        where TData: class, new()
        where TMessage: IApiMessage
    {
        bool Success { get; }

        TData Data { get;}

        TMessage Successful { get;}

        TMessage Error { get; }

        string RequestId { get; }
    }
}