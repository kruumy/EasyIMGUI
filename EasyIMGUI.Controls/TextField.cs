using EasyIMGUI.Controls.Base;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    public class TextField : TextControl
    {
        public override void Draw()
        {
            Value = GUILayout.TextField(Value);
        }
    }
}
