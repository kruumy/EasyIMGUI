namespace EasyIMGUI.Controls.Base
{
    public interface ISlider : IValue<float>
    {
        float Minimum { get; set; }
        float Maximum { get; set; }
    }
}
