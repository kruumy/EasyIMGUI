using EasyIMGUI.Controls.Base;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    public class ScrollView : NestedControl
    {
        public Vector2 Position { get; set; } = Vector2.zero;

        public override void Draw()
        {
            GUILayout.BeginScrollView(Position);
            base.Draw();
            GUILayout.EndScrollView();
        }
    }
}
