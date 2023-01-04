using EasyIMGUI.Controls.Shared.Interfaces;
using UnityEngine;

namespace EasyIMGUI.Controls.Fixed
{
    public class SelectionGrid : Shared.SelectionGrid, IDimensions
    {
        public Rect Dimensions { get; set; } = new Rect(0, 0, 0, 0);
        public override void Draw()
        {
            Value = GUI.SelectionGrid(Dimensions, Value, Contents.ToArray(), Width);
        }
    }
}
