﻿namespace Kernel.Results;

public abstract class Result
{
    #region Properties
    public bool Success { get; protected set; }
    public bool Failure => !Success;
    public string? Message { get; protected set; }
    #endregion
}

public abstract class Result<T> : Result
{
    #region Constructors
    protected Result(T data)
    {
        _data = data;
    }
    #endregion

    #region Public Properties
    public T Data
    {
        get => Success ? _data : throw new Exception($"Data is only accessible when {nameof(Success)} is true");
        set => _data = value;
    }
    #endregion

    #region Private Properties
    private T _data;
    #endregion

}
