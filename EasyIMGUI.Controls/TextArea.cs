using EasyIMGUI.Controls.Base;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    public class TextArea : TextControl
    {
        public override void Draw()
        {
            Value = GUILayout.TextArea(Value);
        }
    }
}
