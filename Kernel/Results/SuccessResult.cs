namespace Kernel.Results;

public class SuccessResult : Result
{
    #region Constructors
    public SuccessResult() 
    {
        Success = true;
    }
    #endregion
}

public class SuccessResult<T> : Result<T>
{
    #region Constructors
    public SuccessResult(T data) : base(data)
    {
        Success = true;
    }
    #endregion
}
