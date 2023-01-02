namespace EasyIMGUI.Controls.Base
{
    /// <summary>
    /// Represents the base of a slider.
    /// </summary>
    public abstract class Slider : ValueControl<float>
    {
        /// <summary>
        /// The minimum value of the <see cref="Slider"/>.
        /// </summary>
        public float Minimum { get; set; } = 0;
        /// <summary>
        /// The maximum value of the <see cref="Slider"/>.
        /// </summary>
        public float Maximum { get; set; } = 10;
    }
}
