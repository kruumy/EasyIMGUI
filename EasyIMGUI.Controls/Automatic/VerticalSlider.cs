using EasyIMGUI.Controls.Shared;
using UnityEngine;

namespace EasyIMGUI.Controls.Automatic
{
    /// <summary>
    /// A <see cref="Control"/> containing the implementation of <see cref="GUILayout.VerticalSlider(float, float, float, GUIStyle, GUIStyle, GUILayoutOption[])"/>.
    /// </summary>
    public class VerticalSlider : Shared.Slider, ILayoutOptions
    {

        public LayoutOptions LayoutOptions { get; set; } = new LayoutOptions();

        public override void Draw()
        {
            Value = GUILayout.VerticalSlider(Value, Maximum, Minimum, LayoutOptions);
        }
    }
}
