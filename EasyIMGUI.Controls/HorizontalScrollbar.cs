using EasyIMGUI.Controls.Base;
using EasyIMGUI.Controls.Interfaces;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    public class HorizontalScrollbar : Scrollbar, ILayoutOptions, IStyle
    {
        public LayoutOptions LayoutOptions { get; set; } = new LayoutOptions();

        public GUIStyle Style { get; set; } // TODO

        public override void Draw()
        {
            Value = GUILayout.HorizontalScrollbar(Value, Size, Minimum, Maximum, LayoutOptions);
        }
    }
}
