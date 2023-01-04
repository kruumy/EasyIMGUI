
using UnityEngine;

namespace EasyIMGUI.Controls.Extra
{
    public class ToggleButton : Toggle
    {
        public override void Draw()
        {
            Value = GUILayout.Toggle(Value, Content, "button", LayoutOptions);
        }
    }
}
