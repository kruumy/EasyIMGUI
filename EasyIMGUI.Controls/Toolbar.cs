using EasyIMGUI.Controls.Base;
using EasyIMGUI.Controls.Interfaces;
using System.Collections.Generic;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    /// <summary>
    /// A <see cref="Control"/> containing the implementation of <see cref="GUILayout.Toolbar(int, GUIContent[], GUIStyle, GUI.ToolbarButtonSize, GUILayoutOption[])"/>.
    /// </summary>
    public class Toolbar : ValueControl<int>, IContents, IStyle, ILayoutOptions
    {
        public List<GUIContent> Contents { get; set; } = new List<GUIContent>();

        public GUIStyle Style { get; set; } = null;

        public LayoutOptions LayoutOptions { get; set; } = new LayoutOptions();

        public override void Draw()
        {
            if (Style != null) Value = GUILayout.Toolbar(Value, Contents.ToArray(), Style, LayoutOptions);
            else Value = GUILayout.Toolbar(Value, Contents.ToArray(), LayoutOptions);
        }
    }
}
