namespace Kernel.Results;

internal interface IFailureResult
{
    #region Properties
    IReadOnlyCollection<Error> Errors { get; }
    #endregion
}

public class FailureResult : Result
{
    #region Constructors
    public FailureResult(string message, IReadOnlyCollection<Error> errors)
    {
        Success = false;
        Message = message;
        Errors = errors ?? [];
    }
    #endregion
    
    #region Properties
    public IReadOnlyCollection<Error> Errors { get; }
    #endregion
}

public class FailureResult<T> : Result<T>
{
    #region Constructors
    public FailureResult(string message, IReadOnlyCollection<Error> errors) : base(default!)
    {
        Message = message;
        Errors = errors;
    }
    #endregion
    
    #region Properties
    public IReadOnlyCollection<Error> Errors { get; }
    #endregion


}
