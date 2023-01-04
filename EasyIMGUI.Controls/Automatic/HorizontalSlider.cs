using EasyIMGUI.Controls.Shared;
using UnityEngine;

namespace EasyIMGUI.Controls.Automatic
{
    /// <summary>
    /// A <see cref="Control"/> containing the implementation of <see cref="GUILayout.HorizontalSlider(float, float, float, GUIStyle, GUIStyle, GUILayoutOption[])"/>.
    /// </summary>
    public class HorizontalSlider : Shared.Slider, ILayoutOptions
    {
        /// <inheritdoc/>
        public LayoutOptions LayoutOptions { get; set; } = new LayoutOptions();

        /// <inheritdoc/>

        public override void Draw()
        {
            Value = GUILayout.HorizontalSlider(Value, Minimum, Maximum, LayoutOptions);
        }
    }
}
