using EasyIMGUI.Controls.Base;
using EasyIMGUI.Controls.Interfaces;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    /// <summary>
    /// A <see cref="Control"/> containing the implementation of <see cref="GUILayout.HorizontalSlider(float, float, float, GUIStyle, GUIStyle, GUILayoutOption[])"/>.
    /// </summary>
    public class HorizontalSlider : Slider, IStyleSlider, ILayoutOptions
    {
        public GUIStyle SliderStyle { get; set; } = null;

        public GUIStyle ThumbStyle { get; set; } = null;

        public LayoutOptions LayoutOptions { get; set; } = new LayoutOptions();

        public override void Draw()
        {
            if (SliderStyle != null && ThumbStyle != null) Value = GUILayout.HorizontalSlider(Value, Minimum, Maximum, SliderStyle, ThumbStyle, LayoutOptions);
            else Value = GUILayout.HorizontalSlider(Value, Minimum, Maximum, LayoutOptions);
        }
    }
}
