public class OptionItem
{
    public string Text { get; set; }
    public int Value { get; set; }

    public OptionItem(string text, int value)
    {
        Text = text;
        Value = value;
    }

    public override string ToString()
    {
        return Text;
    }
}
