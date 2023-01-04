using EasyIMGUI.Controls.Base;
using EasyIMGUI.Controls.Interfaces;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    /// <summary>
    /// A <see cref="Control"/> containing the implementation of <see cref="GUILayout.VerticalScrollbar(float, float, float, float, GUIStyle, GUILayoutOption[])"/>.
    /// </summary>
    public class VerticalScrollbar : Scrollbar, ILayoutOptions
    {
        public LayoutOptions LayoutOptions { get; set; } = new LayoutOptions();

        public override void Draw()
        {
            Value = GUILayout.VerticalScrollbar(Value, Size, Minimum, Maximum, LayoutOptions);
        }
    }
}
