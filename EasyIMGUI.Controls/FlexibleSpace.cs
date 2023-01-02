using EasyIMGUI.Controls.Base;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    public class FlexibleSpace : Control
    {
        public override void Draw()
        {
            GUILayout.FlexibleSpace();
        }
    }
}
