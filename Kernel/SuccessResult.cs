namespace Shared.Kernel;

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
    public SuccessResult(T data) : base(data)
    {
        Success = true;
    }
}
