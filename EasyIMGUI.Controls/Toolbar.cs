using EasyIMGUI.Controls.Base;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    public class Toolbar : SelectionControl, Control, IValue<int>, IContents
    {
        public override void Draw()
        {
            Value = GUILayout.Toolbar(Value, Contents);
        }
    }
}
