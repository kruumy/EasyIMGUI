using EasyIMGUI.Controls.Base;
using EasyIMGUI.Controls.Interfaces;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    public class Area : NestedControl, IDimensions, IContent, IStyle
    {
        public Rect Dimensions { get; set; } = new Rect(Screen.width / 2, Screen.height / 2, 300, 300);

        public GUIContent Content { get; set; } = new GUIContent("");

        public GUIStyle Style { get; set; } // TODO

        public override void Draw()
        {
            GUILayout.BeginArea(Dimensions, Content);
            base.Draw();
            GUILayout.EndArea();
        }
    }
}
