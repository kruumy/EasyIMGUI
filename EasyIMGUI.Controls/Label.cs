using EasyIMGUI.Controls.Base;
using EasyIMGUI.Controls.Interfaces;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    /// <summary>
    /// A <see cref="Control"/> containing the implementation of <see cref="GUILayout.Label(GUIContent, GUIStyle, GUILayoutOption[])"/>.
    /// </summary>
    public class Label : Control, IContent, IStyle, ILayoutOptions
    {
        public GUIContent Content { get; set; } = new GUIContent("");

        public GUIStyle Style { get; set; } = null;

        public LayoutOptions LayoutOptions { get; set; } = new LayoutOptions();

        public override void Draw()
        {
            if (Style != null) GUILayout.Label(Content, Style, LayoutOptions);
            else GUILayout.Label(Content, LayoutOptions);
        }
    }
}
