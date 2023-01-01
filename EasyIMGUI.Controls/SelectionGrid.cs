using EasyIMGUI.Controls.Base;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    public class SelectionGrid : SelectionControl
    {
        public int Width { get; set; } = 2;

        public override void Draw()
        {
            Value = GUILayout.SelectionGrid(Value, Contents, Width);
        }
    }
}
