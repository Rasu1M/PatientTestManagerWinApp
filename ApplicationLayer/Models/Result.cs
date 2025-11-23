namespace PatientTestManagerWinApp.ApplicationLayer.Models
{
    public class Result<TResponse>
    {
        public bool Success { get; set; }
        public string? Message { get; set; }
        public TResponse? Data { get; set; }

        public static Result<TResponse> Ok(TResponse data, string message = "")
        {
            return new Result<TResponse> { Success = true, Data = data, Message = message };
        }

        public static Result<TResponse> Fail(string message)
        {
            return new Result<TResponse> { Success = false, Message = message, Data = default };
        }
    }
}
