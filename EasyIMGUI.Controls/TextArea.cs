using EasyIMGUI.Controls.Base;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    public class TextArea : ValueControl<string>
    {
        public override void Draw()
        {
            Value = GUILayout.TextArea(Value);
        }
    }
}
