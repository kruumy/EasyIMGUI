namespace EasyIMGUI.Controls.Base
{
    public abstract class SliderControl : ValueControl<float>, ISlider
    {
        public float Minimum { get; set; } = 0;
        public float Maximum { get; set; } = 10;
    }
}
