using EasyIMGUI.Controls.Base;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    public class Toolbar : SelectionControl
    {
        public override void Draw()
        {
            Value = GUILayout.Toolbar(Value, Contents);
        }
    }
}
