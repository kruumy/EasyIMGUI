namespace EasyIMGUI.Controls.Base
{
    public abstract class SliderControl : ValueControl<float>
    {
        public float Minimum { get; set; } = 0;
        public float Maximim { get; set; } = 10;
    }
}
