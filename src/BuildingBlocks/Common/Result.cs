using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Result;

public class Result
{
    public bool IsSuccess { get; }
    public string Error { get; }

    public Result(bool isSuccess, string error)
    {
        IsSuccess = isSuccess;
        Error = error;
    }

    //public static Result Success() => new(true, string.Empty);
    //public static Result Failure(string error) => new(false, error);
}
