using EasyIMGUI.Controls.Base;
using EasyIMGUI.Controls.Interfaces;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    public class Horizontal : NestedControl, ILayoutOptions, IStyle, IContent
    {
        public LayoutOptions LayoutOptions { get; set; } = new LayoutOptions();

        public GUIStyle Style { get; set; } = new GUIStyle();

        public GUIContent Content { get; set; } = new GUIContent("");

        public override void Draw()
        {
            GUILayout.BeginHorizontal(Content, Style, LayoutOptions);
            base.Draw();
            GUILayout.EndHorizontal();
        }
    }
}
