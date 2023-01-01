using EasyIMGUI.Controls.Base;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    public class Vertical : NestedControl
    {
        public override void Draw()
        {
            GUILayout.BeginVertical();
            base.Draw();
            GUILayout.EndVertical();
        }
    }
}
