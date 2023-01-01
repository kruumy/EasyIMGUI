using EasyIMGUI.Controls.Base;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    public class Toggle : Control, IContent, IValue<bool>
    {
        public bool Value { get; set; } = default;
        public GUIContent Content { get; set; } = GUIContent.none;
        public override void Draw()
        {
            Value = GUILayout.Toggle(Value, Content);
        }
    }
}
