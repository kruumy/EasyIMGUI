using EasyIMGUI.Controls.Shared;
using UnityEngine;

namespace EasyIMGUI.Controls.Fixed
{
    public class VerticalSlider : Shared.Slider, IDimensions
    {
        public Rect Dimensions { get; set; } = new Rect(0, 0, 0, 0);

        public override void Draw()
        {
            Value = GUI.VerticalSlider(Dimensions, Value, Maximum, Minimum);
        }
    }
}
