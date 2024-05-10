namespace Kernel.Results;

public class Error
{
    #region Constructors
    public Error(string message)
    {
        Message = message;
    }
    #endregion

    #region Public Properties
    public string Message { get; }
    #endregion
}
