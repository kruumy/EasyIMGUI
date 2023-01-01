using EasyIMGUI.Controls.Base;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    public class VerticalSlider : SliderControl
    {
        public override void Draw()
        {
            Value = GUILayout.VerticalSlider(Value, Minimum, Maximim);
        }
    }
}
