using EasyIMGUI.Controls.Base;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    public class TextField : ValueControl<string>
    {
        public override void Draw()
        {
            Value = GUILayout.TextField(Value);
        }
    }
}
