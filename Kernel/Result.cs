namespace Shared.Kernel;

public abstract class Result
{
    #region Properties
    public bool Success { get; protected set; }
    public bool Failure => !Success;
    #endregion
}

public abstract class Result<T> : Result 
{
    #region Private Properties
    private T _data;
    #endregion
    
    #region Public Properties
    public T Data 
    {
        get => Success ? _data : throw new Exception($"Data is only accessible when {nameof(Success)} is true"); 
        set => _data = value;
    }
    #endregion
    
    #region Constructors
    protected Result(T data) 
    {
        _data = data;
    }
    #endregion

}
