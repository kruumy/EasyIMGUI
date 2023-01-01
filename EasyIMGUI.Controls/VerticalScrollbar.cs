using EasyIMGUI.Controls.Base;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    public class VerticalScrollbar : ScrollbarControl
    {
        public override void Draw()
        {
            Value = GUILayout.VerticalScrollbar(Value, Size, Minimum, Maximim);
        }
    }
}
