using EasyIMGUI.Controls.Base;
using EasyIMGUI.Controls.Interfaces;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    public class Vertical : NestedControl, ILayoutOptions, IStyle, IContent
    {
        public LayoutOptions LayoutOptions { get; set; } = new LayoutOptions();

        public GUIStyle Style { get; set; } = new GUIStyle(GUIStyle.none);

        public GUIContent Content { get; set; } = new GUIContent("");

        public override void Draw()
        {
            GUILayout.BeginVertical(Content, Style, LayoutOptions);
            base.Draw();
            GUILayout.EndVertical();
        }
    }
}
