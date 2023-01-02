using EasyIMGUI.Controls.Base;
using EasyIMGUI.Controls.Interfaces;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    public class TextField : TextBlock, IStyle, ILayoutOptions
    {
        public GUIStyle Style { get; set; } // TODO

        public LayoutOptions LayoutOptions { get; set; } = new LayoutOptions();

        public override void Draw()
        {
            Value = GUILayout.TextField(Value, MaxLength, LayoutOptions);
        }
    }
}
