using EasyIMGUI.Controls.Base;
using EasyIMGUI.Controls.Interfaces;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    /// <summary>
    /// A <see cref="Control"/> containing the implementation of <see cref="GUILayout.HorizontalScrollbar(float, float, float, float, GUIStyle, GUILayoutOption[])"/>.
    /// </summary>
    public class HorizontalScrollbar : Scrollbar, ILayoutOptions, IStyle
    {
        public LayoutOptions LayoutOptions { get; set; } = new LayoutOptions();

        public GUIStyle Style { get; set; } = null;

        public override void Draw()
        {
            if (Style != null) Value = GUILayout.HorizontalScrollbar(Value, Size, Minimum, Maximum, Style, LayoutOptions);
            else Value = GUILayout.HorizontalScrollbar(Value, Size, Minimum, Maximum, LayoutOptions);
        }
    }
}
