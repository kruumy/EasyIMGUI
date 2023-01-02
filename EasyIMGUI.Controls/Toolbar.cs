using EasyIMGUI.Controls.Base;
using EasyIMGUI.Controls.Interfaces;
using System.Collections.Generic;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    public class Toolbar : ValueControl<int>, IContents, IStyle, ILayoutOptions
    {
        public List<GUIContent> Contents { get; set; } = new List<GUIContent>();

        public GUIStyle Style { get; set; } = new GUIStyle(GUI.skin.button);

        public List<GUILayoutOption> LayoutOptions { get; set; } = new List<GUILayoutOption>();
        public override void Draw()
        {
            Value = GUILayout.Toolbar(Value, Contents.ToArray(), Style, LayoutOptions.ToArray());
        }
    }
}
