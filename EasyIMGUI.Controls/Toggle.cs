using EasyIMGUI.Controls.Base;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    public class Toggle : ValueAndContentControl<bool>
    {
        public override void Draw()
        {
            Value = GUILayout.Toggle(Value, Content);
        }
    }
}
