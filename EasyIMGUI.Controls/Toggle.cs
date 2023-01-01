using UnityEngine;

namespace EasyIMGUI.Controls
{
    public class Toggle : ContentAndValueControl<bool>
    {
        public override void Draw()
        {
            Value = GUILayout.Toggle(Value, Content, LayoutOptions);
        }
    }
}
