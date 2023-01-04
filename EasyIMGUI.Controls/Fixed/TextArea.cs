using EasyIMGUI.Controls.Shared;
using UnityEngine;

namespace EasyIMGUI.Controls.Fixed
{
    public class TextArea : Shared.TextControl, IDimensions
    {
        public Rect Dimensions { get; set; } = new Rect(0, 0, 0, 0);

        public override void Draw()
        {
            Value = GUI.TextArea(Dimensions, Value, MaxLength);
        }
    }
}
