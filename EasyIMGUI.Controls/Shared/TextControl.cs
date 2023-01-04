namespace EasyIMGUI.Controls.Shared
{
    /// <summary>
    /// Represents the base of a text element.
    /// </summary>
    public abstract class TextControl : ValueControl<string>
    {
        /// <summary>
        /// The max length for the <see cref="TextControl"/>.
        /// </summary>
        public int MaxLength { get; set; } = int.MaxValue;
    }
}
