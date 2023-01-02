namespace EasyIMGUI.Controls.Base
{
    /// <summary>
    /// Represents the base of a text element.
    /// </summary>
    public abstract class TextElement : ValueControl<string>
    {
        /// <summary>
        /// The max length for the <see cref="TextElement"/>.
        /// </summary>
        public int MaxLength { get; set; } = int.MaxValue;
    }
}
