namespace Shared.Kernel;

public class Error
{
    #region Properties
    public string Code { get; }
    public string Details { get; }
    #endregion

    #region Constructors
    public Error(string code, string details)
    {
        Code = code;
        Details = details;
    }
    #endregion

}
