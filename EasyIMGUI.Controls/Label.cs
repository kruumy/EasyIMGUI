using EasyIMGUI.Controls.Base;
using EasyIMGUI.Controls.Interfaces;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    /// <summary>
    /// A <see cref="Control"/> containing the implementation of <see cref="GUILayout.Label(GUIContent, GUIStyle, GUILayoutOption[])"/>.
    /// </summary>
    public class Label : Control, IContent, ILayoutOptions
    {
        public GUIContent Content { get; set; } = new GUIContent("");

        public LayoutOptions LayoutOptions { get; set; } = new LayoutOptions();

        public override void Draw()
        {
            GUILayout.Label(Content, LayoutOptions);
        }
    }
}
