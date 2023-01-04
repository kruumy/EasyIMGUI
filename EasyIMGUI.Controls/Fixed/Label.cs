using EasyIMGUI.Controls.Shared;
using UnityEngine;

namespace EasyIMGUI.Controls.Fixed
{
    public class Label : Shared.Label, IDimensions
    {
        public Rect Dimensions { get; set; } = new Rect(0, 0, 0, 0);
        public override void Draw()
        {
            GUI.Label(Dimensions, Content);
        }
    }
}
