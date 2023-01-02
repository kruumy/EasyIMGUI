using EasyIMGUI.Controls.Base;
using EasyIMGUI.Controls.Interfaces;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    public class HorizontalSlider : Slider, IStyleSlider, ILayoutOptions
    {
        public GUIStyle SliderStyle { get; set; } // TODO

        public GUIStyle ThumbStyle { get; set; } // TODO

        public LayoutOptions LayoutOptions { get; set; } = new LayoutOptions();

        public override void Draw()
        {
            Value = GUILayout.HorizontalSlider(Value, Minimum, Maximum, LayoutOptions);
        }
    }
}
