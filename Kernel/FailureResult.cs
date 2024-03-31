namespace Shared.Kernel;

internal interface IFailureResult 
{
    string Message { get; }
    IReadOnlyCollection<Error> Errors { get; }
}
public class FailureResult : Result
{
    #region Properties
    public string Message { get; }
    public IReadOnlyCollection<Error> Errors { get; }
    #endregion

    #region Constructors
    public FailureResult(string message, IReadOnlyCollection<Error> errors) 
    {
        Success = false;
        Message = message;
        Errors = errors ?? [];
    }
    #endregion 
}

public class FailureResult<T> : Result<T>
{
    #region Properties
    public string Message { get; }
    public IReadOnlyCollection<Error> Errors { get; }
    #endregion

    #region Constructors
    public FailureResult(string message, IReadOnlyCollection<Error> errors) : base(default!)
    {
        Message = message;
        Errors = errors;
    }
    #endregion

}
