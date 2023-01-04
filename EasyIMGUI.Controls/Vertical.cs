using EasyIMGUI.Controls.Base;
using EasyIMGUI.Controls.Interfaces;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    /// <summary>
    /// A <see cref="Control"/> containing the implementation of <see cref="GUILayout.BeginVertical(GUIContent, GUIStyle, GUILayoutOption[])"/> and <see cref="GUILayout.EndVertical()"/>
    /// </summary>
    public class Vertical : NestedControl, ILayoutOptions, IContent
    {
        public LayoutOptions LayoutOptions { get; set; } = new LayoutOptions();

        public GUIContent Content { get; set; } = new GUIContent("");

        public override void Draw()
        {
            GUILayout.BeginVertical(Content, GUIStyle.none, LayoutOptions);
            base.Draw();
            GUILayout.EndVertical();
        }
    }
}
