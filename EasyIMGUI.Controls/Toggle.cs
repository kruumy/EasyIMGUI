using EasyIMGUI.Controls.Base;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    public class Toggle : ValueControl<bool>, IContent
    {
        public GUIContent Content { get; set; } = GUIContent.none;
        public override void Draw()
        {
            Value = GUILayout.Toggle(Value, Content);
        }
    }
}
