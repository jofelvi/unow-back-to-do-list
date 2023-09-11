namespace api_todo_list_new.shared
{
    public class ValidationException : Exception
    {
        public ValidationException(string message) : base(message) { }
    }
}
