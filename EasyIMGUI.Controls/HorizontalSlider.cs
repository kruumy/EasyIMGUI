using EasyIMGUI.Controls.Base;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    public class HorizontalSlider : SliderControl
    {
        public override void Draw()
        {
            Value = GUILayout.HorizontalSlider(Value, Minimum, Maximim);
        }
    }
}
