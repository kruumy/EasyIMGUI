namespace EasyIMGUI.Controls.Base
{
    public abstract class SliderControl : Control, ISlider
    {
        public float Value { get; set; } = 5;
        public float Minimum { get; set; } = 0;
        public float Maximim { get; set; } = 10;
    }
}
