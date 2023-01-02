using EasyIMGUI.Controls.Base;
using EasyIMGUI.Controls.Interfaces;
using System.Collections.Generic;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    public class Horizontal : NestedControl, ILayoutOptions, IStyle, IContent
    {
        public List<GUILayoutOption> LayoutOptions { get; set; } = new List<GUILayoutOption>();

        public GUIStyle Style { get; set; } = new GUIStyle(GUIStyle.none);

        public GUIContent Content { get; set; } = new GUIContent("");

        public override void Draw()
        {
            GUILayout.BeginHorizontal(Style, LayoutOptions.ToArray());
            base.Draw();
            GUILayout.EndHorizontal();
        }
    }
}
