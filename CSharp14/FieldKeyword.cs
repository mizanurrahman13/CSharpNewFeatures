namespace CSharp14;

public class FieldKeyword
{
    private string _message;
    public string MessageOld
    {
        get => _message;
        set => _message = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string MessageNew
    {
        get;
        set => field = value ?? throw new ArgumentNullException(nameof(value));
    }
}
