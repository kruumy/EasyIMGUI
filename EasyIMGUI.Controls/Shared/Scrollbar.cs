namespace EasyIMGUI.Controls.Shared
{
    /// <summary>
    /// Represents the base of a Scrollbar.
    /// </summary>
    public abstract class Scrollbar : Slider
    {
        /// <summary>
        /// The size of the <see cref="Scrollbar"/>.
        /// </summary>
        public float Size { get; set; } = 25;
    }
}
