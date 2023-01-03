using EasyIMGUI.Controls.Base;
using EasyIMGUI.Controls.Interfaces;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    /// <summary>
    /// A <see cref="Control"/> containing the implementation of <see cref="GUILayout.BeginHorizontal(GUIContent, GUIStyle, GUILayoutOption[])"/> and <see cref="GUILayout.EndHorizontal"/>.
    /// </summary>
    public class Horizontal : NestedControl, ILayoutOptions, IStyle, IContent
    {
        public LayoutOptions LayoutOptions { get; set; } = new LayoutOptions();

        public GUIStyle Style { get; set; } = null;

        public GUIContent Content { get; set; } = new GUIContent("");

        public override void Draw()
        {
            if (Style != null) GUILayout.BeginHorizontal(Content, Style, LayoutOptions);
            else GUILayout.BeginHorizontal(Content, GUIStyle.none, LayoutOptions);
            base.Draw();
            GUILayout.EndHorizontal();
        }
    }
}
