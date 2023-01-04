using EasyIMGUI.Controls.Base;
using EasyIMGUI.Controls.Interfaces;
using System.Collections.Generic;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    /// <summary>
    /// A <see cref="Control"/> containing the implementation of <see cref="GUILayout.Toolbar(int, GUIContent[], GUIStyle, GUI.ToolbarButtonSize, GUILayoutOption[])"/>.
    /// </summary>
    public class Toolbar : ValueControl<int>, IContents, ILayoutOptions
    {
        public List<GUIContent> Contents { get; set; } = new List<GUIContent>();

        public LayoutOptions LayoutOptions { get; set; } = new LayoutOptions();

        public override void Draw()
        {
            Value = GUILayout.Toolbar(Value, Contents.ToArray(), LayoutOptions);
        }
    }
}
