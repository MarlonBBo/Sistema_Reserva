namespace Sistema_Reserva.Model
{
    public class ResponseModel<T>
    {
        public T? Data { get; set; } 
        public string Message { get; set; } = string.Empty; 
        public List<string>? Participants { get; set; } 
    }
}
