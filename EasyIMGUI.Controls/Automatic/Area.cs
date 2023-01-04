using EasyIMGUI.Controls.Shared.Base;
using EasyIMGUI.Controls.Shared.Interfaces;
using UnityEngine;

namespace EasyIMGUI.Controls.Automatic
{
    /// <summary>
    /// A <see cref="Control"/> containing the implementation of <see cref="GUILayout.BeginArea(Rect, GUIContent, GUIStyle)"/> and <see cref="GUILayout.EndArea"/>.
    /// </summary>
    public class Area : NestedControl, IDimensions, IContent
    {
        public Rect Dimensions { get; set; } = new Rect(Screen.width / 2, Screen.height / 2, 300, 300);

        public GUIContent Content { get; set; } = new GUIContent("");

        public override void Draw()
        {
            GUILayout.BeginArea(Dimensions, Content);
            base.Draw();
            GUILayout.EndArea();
        }
    }
}
