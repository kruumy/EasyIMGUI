using EasyIMGUI.Controls.Base;
using EasyIMGUI.Controls.Interfaces;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    /// <summary>
    /// A <see cref="Control"/> containing the implementation of <see cref="GUILayout.BeginArea(Rect, GUIContent, GUIStyle)"/> and <see cref="GUILayout.EndArea"/>.
    /// </summary>
    public class Area : NestedControl, IDimensions, IContent, IStyle
    {
        public Rect Dimensions { get; set; } = new Rect(Screen.width / 2, Screen.height / 2, 300, 300);

        public GUIContent Content { get; set; } = new GUIContent("");

        public GUIStyle Style { get; set; } = null;

        public override void Draw()
        {
            if (Style != null) GUILayout.BeginArea(Dimensions, Content, Style);
            else GUILayout.BeginArea(Dimensions, Content);
            base.Draw();
            GUILayout.EndArea();
        }
    }
}
