using UnityEngine;

namespace EasyIMGUI.Controls.Automatic
{
    /// <summary>
    /// A <see cref="Control"/> containing the implementation of <see cref="GUILayout.HorizontalScrollbar(float, float, float, float, GUIStyle, GUILayoutOption[])"/>.
    /// </summary>
    public class HorizontalScrollbar : Shared.Scrollbar, ILayoutOptions
    {
        public LayoutOptions LayoutOptions { get; set; } = new LayoutOptions();

        public override void Draw()
        {
            Value = GUILayout.HorizontalScrollbar(Value, Size, Minimum, Maximum, LayoutOptions);
        }
    }
}
