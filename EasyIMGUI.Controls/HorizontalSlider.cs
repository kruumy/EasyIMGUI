using EasyIMGUI.Controls.Base;
using EasyIMGUI.Controls.Interfaces;
using System.Collections.Generic;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    public class HorizontalSlider : Slider, IStyleSlider, ILayoutOptions
    {
        public GUIStyle SliderStyle { get; set; } = new GUIStyle(GUI.skin.horizontalSlider);

        public GUIStyle ThumbStyle { get; set; } = new GUIStyle(GUI.skin.horizontalSliderThumb);

        public List<GUILayoutOption> LayoutOptions { get; set; } = new List<GUILayoutOption>();

        public override void Draw()
        {
            Value = GUILayout.HorizontalSlider(Value, Minimum, Maximum, SliderStyle, ThumbStyle, LayoutOptions.ToArray());
        }
    }
}
