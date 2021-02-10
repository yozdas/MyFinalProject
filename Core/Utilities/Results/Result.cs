using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {


        public Result(bool success, string message) : this(success)
        {
            //Get ler readonly dir, sadece ctor da set edilebilir.
            Message = message;
        }
        public Result(bool success)
        {
            //Get ler readonly dir, sadece ctor da set edilebilir.
            Success = success;

        }

        public bool Success { get; }
        public string Message { get; }
    }
}
