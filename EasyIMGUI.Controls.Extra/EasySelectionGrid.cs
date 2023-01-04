using EasyIMGUI.Controls.Extra.Base;
using EasyIMGUI.Controls.Interfaces;
using UnityEngine;

namespace EasyIMGUI.Controls.Extra
{
    public class EasySelectionGrid : Selector, ILayoutOptions
    {
        public LayoutOptions LayoutOptions { get; set; } = new LayoutOptions();
        public int Width { get; set; } = 2;

        public override void Draw()
        {
            GUILayout.SelectionGrid(Value, Items.Contents, Width, LayoutOptions);
            base.Draw();
        }
    }
}
