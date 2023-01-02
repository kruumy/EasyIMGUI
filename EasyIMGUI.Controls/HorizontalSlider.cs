using EasyIMGUI.Controls.Base;
using EasyIMGUI.Controls.Interfaces;
using System.Collections.Generic;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    public class HorizontalSlider : Slider, IStyleSlider, ILayoutOptions
    {
        public GUIStyle SliderStyle { get; set; } // TODO

        public GUIStyle ThumbStyle { get; set; } // TODO

        public List<GUILayoutOption> LayoutOptions { get; set; } = new List<GUILayoutOption>();

        public override void Draw()
        {
            Value = GUILayout.HorizontalSlider(Value, Minimum, Maximum, LayoutOptions.ToArray());
        }
    }
}
