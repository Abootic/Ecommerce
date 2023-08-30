

namespace Target.Application.Interfaces.Common
{
    public class Message
    {
        public string message { get; set; }
        public int code { get; set; }   
    }
    public interface IResult
    {
        Message Status { get; set; }
        bool Succeeded { get; set; }
    }
    public interface IResult<out T> :IResult
    {

        T Data { get; }
      
    }
}
