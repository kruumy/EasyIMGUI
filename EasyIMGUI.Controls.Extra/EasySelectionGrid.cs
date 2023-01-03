using EasyIMGUI.Controls.Extra.Base;
using EasyIMGUI.Controls.Interfaces;
using UnityEngine;

namespace EasyIMGUI.Controls.Extra
{
    public class EasySelectionGrid : Selector, IStyle, ILayoutOptions
    {
        public GUIStyle Style { get; set; } = null;

        public LayoutOptions LayoutOptions { get; set; } = new LayoutOptions();
        public int Width { get; set; } = 2;

        public override void Draw()
        {
            if (Style != null) Value = GUILayout.SelectionGrid(Value, Items.Contents, Width, Style, LayoutOptions);
            else Value = GUILayout.SelectionGrid(Value, Items.Contents, Width, LayoutOptions);
            base.Draw();
        }
    }
}
