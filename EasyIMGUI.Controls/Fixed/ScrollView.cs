using EasyIMGUI.Controls.Shared.Interfaces;
using UnityEngine;

namespace EasyIMGUI.Controls.Fixed
{
    public class ScrollView : Shared.ScrollView, IDimensions
    {
        public Rect Dimensions { get; set; } = new Rect(0, 0, 0, 0);
        public override void Draw()
        {
            // TODO: check this
            Position = GUI.BeginScrollView(Dimensions, Position, Dimensions, AlwaysShowHorizontal, AlwaysShowVertical);
            base.Draw();
            GUI.EndScrollView();
        }
    }
}
