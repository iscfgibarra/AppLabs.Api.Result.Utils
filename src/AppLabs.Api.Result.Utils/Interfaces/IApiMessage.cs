namespace AppLabs.Api.Result.Utils.Interfaces
{
    public interface IApiMessage
    {
        public string Code { get; set; }

        public string Message { get; set; }
    }
}