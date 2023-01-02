namespace EasyIMGUI.Controls.Base
{
    public abstract class TextBlock : ValueControl<string>
    {
        public int MaxLength { get; set; } = int.MaxValue;
    }
}
