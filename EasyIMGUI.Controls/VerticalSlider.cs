using EasyIMGUI.Controls.Base;
using EasyIMGUI.Controls.Interfaces;
using System.Collections.Generic;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    public class VerticalSlider : Slider, IStyleSlider, ILayoutOptions
    {
        public GUIStyle SliderStyle { get; set; } = new GUIStyle(GUI.skin.verticalSlider);

        public GUIStyle ThumbStyle { get; set; } = new GUIStyle(GUI.skin.verticalSliderThumb);

        public List<GUILayoutOption> LayoutOptions { get; set; } = new List<GUILayoutOption>();
        public override void Draw()
        {
            Value = GUILayout.VerticalSlider(Value, Minimum, Maximum, SliderStyle, ThumbStyle, LayoutOptions.ToArray());
        }
    }
}
