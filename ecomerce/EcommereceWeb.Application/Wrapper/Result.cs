
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcommereceWeb.Application.Interfaces.Common;

namespace EcommereceWeb.Application.Wrapper
{
    public class Result : IResult
    {
        public Result()
        {

        }

        public Message Status { get; set; }
        public bool Succeeded { get; set; }
        public static IResult Fail() => new Result { Succeeded = false };
        public static IResult Fail(string message, int code)
        {
            return new Result { Succeeded = false, Status = new Message { message = message, code = code } };
        }
        public static Task<IResult> FailAsync(string message, int code = 500)
        {
            return Task.FromResult(Fail(message, code));
        }
        public static IResult Sucess()
        {
            return new Result { Succeeded = true };
        }
        public static IResult Sucess(string message, int code)
        {
            return new Result { Succeeded = true, Status = new Message { message = message, code = code } };
        }
        public static Task<IResult> SucessAsync() => Task.FromResult(Sucess());
        public static Task<IResult> SucessAsync(string message, int code = 200)
        {
            return Task.FromResult(Sucess(message, code));
        }



    }
    public class Result<T> : IResult<T>
    {
        public Message Status { get; set; }
        public bool Succeeded { get; set; }

        public Result()
        {

        }
        public T Data { get; set; }
        

        public static Result<T> Fail() => new Result<T> { Succeeded = false };
        public static Result<T> Fail(string message, int code)
        {
            return new Result<T> { Succeeded = false, Status = new Message { message = message, code = code } };
        }
        public static Task<Result<T>> FailAsync(string message, int code = 500)
        {
            return Task.FromResult(Fail(message, code));
        }
        public static Result<T> Sucess()
        {
            return new Result<T> { Succeeded = true };
        }
        public static Result<T> Sucess(string message, int code)
        {
            return new Result<T> { Succeeded = true, Status = new Message { message = message, code = code } };
        }
        public static Result<T> Sucess(T data)
        {
            return new Result<T> { Succeeded = true, Data = data };
        }
    
        public static Result<T> Sucess(T data, string message, int code)
        {
            return new Result<T> { Succeeded = true, Data = data, Status = new Message { message = message, code = code } };

        }
      
        public static Task<Result<T>> SucessAsync() => Task.FromResult(Sucess());

        public static Task<Result<T>> SucessAsync(string message, int code = 200)
        {
            return Task.FromResult(Sucess(message, code));
        }


        public static Task<Result<T>> SucessAsync(T data, string message, int code = 200)
        {
            return Task.FromResult(Sucess(data, message, code));
        }



        public static Task<Result<T>> SucessAsync(T data)
        {
            return Task.FromResult(Sucess(data));
        }




    }
}
