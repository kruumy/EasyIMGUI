using EasyIMGUI.Controls.Base;
using EasyIMGUI.Controls.Interfaces;
using System.Collections.Generic;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    public class HorizontalScrollbar : Scrollbar, ILayoutOptions, IStyle
    {
        public List<GUILayoutOption> LayoutOptions { get; set; } = new List<GUILayoutOption>();

        public GUIStyle Style { get; set; } = new GUIStyle(GUI.skin.horizontalScrollbar);

        public override void Draw()
        {
            Value = GUILayout.HorizontalScrollbar(Value, Size, Minimum, Maximum, Style, LayoutOptions.ToArray());
        }
    }
}
