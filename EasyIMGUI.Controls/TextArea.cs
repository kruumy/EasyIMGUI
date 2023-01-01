using EasyIMGUI.Controls.Base;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    public class TextArea : Control, IValue<string>
    {
        public string Value { get; set; } = string.Empty;
        public override void Draw()
        {
            Value = GUILayout.TextArea(Value);
        }
    }
}
