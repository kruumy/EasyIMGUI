using EasyIMGUI.Controls.Shared.Interfaces;
using UnityEngine;

namespace EasyIMGUI.Controls.Fixed
{
    public class HorixontalSlider : Shared.Slider, IDimensions
    {
        public Rect Dimensions { get; set; } = new Rect(0, 0, 0, 0);
        public override void Draw()
        {
            Value = GUI.HorizontalSlider(Dimensions, Value, Minimum, Maximum);
        }
    }
}
