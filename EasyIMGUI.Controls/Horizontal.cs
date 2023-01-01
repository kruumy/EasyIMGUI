using EasyIMGUI.Controls.Base;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    public class Horizontal : NestedControl
    {
        public override void Draw()
        {
            GUILayout.BeginHorizontal();
            base.Draw();
            GUILayout.EndHorizontal();
        }
    }
}
