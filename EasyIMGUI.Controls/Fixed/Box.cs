using EasyIMGUI.Controls.Shared;
using UnityEngine;

namespace EasyIMGUI.Controls.Fixed
{
    public class Box : Shared.Box, IDimensions
    {
        public Rect Dimensions { get; set; } = new Rect(0, 0, 0, 0);

        public override void Draw()
        {
            GUI.Box(Dimensions, Content);
        }
    }
}
