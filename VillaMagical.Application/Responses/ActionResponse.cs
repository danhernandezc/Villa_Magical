namespace VillaMagical.Application.Responses
{
    public class ActionResponse<T>
    {
        public int StatusCode { get; set; }
        public bool WasSuccess { get; set; }
        public string Message { get; set; }
        public T Result { get; set; }
        public List<T> ListResult { get; set; }
        public object ModelState { get; set; }
    }
}
