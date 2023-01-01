namespace EasyIMGUI.Controls.Base
{
    public abstract class TextControl : Control, IValue<string>
    {
        public string Value { get; set; } = string.Empty;
    }
}
