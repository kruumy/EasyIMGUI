using EasyIMGUI.Controls.Shared;
using UnityEngine;

namespace EasyIMGUI.Controls.Fixed
{
    public class HorizontalScrollbar : Shared.Scrollbar, IDimensions
    {
        public Rect Dimensions { get; set; } = new Rect(0, 0, 0, 0);
        public override void Draw()
        {
            Value = GUI.HorizontalScrollbar(Dimensions, Value, Size, Minimum, Maximum);
        }
    }
}
