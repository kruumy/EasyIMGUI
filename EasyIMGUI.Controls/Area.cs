using EasyIMGUI.Controls.Base;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    public class Area : NestedControl, IDimensions
    {
        public Rect Dimensions { get; set; } = new Rect(Screen.width / 2, Screen.height / 2, 300, 300);
        public override void Draw()
        {
            GUILayout.BeginArea(Dimensions);
            base.Draw();
            GUILayout.EndArea();
        }
    }
}
