namespace CarWebAPI.Modules
{
    public class BaseResponse<T>
    {
        public bool Success { get; set; }
        public T Value { get; set; }
        public int TotalPages { get; set; }
        public string ErrorMessage { get; set; }
    }
}
