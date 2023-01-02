using EasyIMGUI.Controls.Base;
using EasyIMGUI.Controls.Interfaces;
using System.Collections.Generic;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    public class Toggle : ValueControl<bool>, IContent, IStyle, ILayoutOptions
    {
        public GUIContent Content { get; set; } = new GUIContent("");

        public GUIStyle Style { get; set; } = new GUIStyle(GUI.skin.toggle);

        public List<GUILayoutOption> LayoutOptions { get; set; } = new List<GUILayoutOption>();

        public override void Draw()
        {
            Value = GUILayout.Toggle(Value, Content, Style, LayoutOptions.ToArray());
        }
    }
}
