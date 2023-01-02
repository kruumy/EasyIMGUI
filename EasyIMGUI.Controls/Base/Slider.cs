namespace EasyIMGUI.Controls.Base
{
    public abstract class Slider : ValueControl<float>
    {
        public float Minimum { get; set; } = 0;
        public float Maximum { get; set; } = 10;
    }
}
