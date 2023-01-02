using EasyIMGUI.Controls.Base;
using EasyIMGUI.Controls.Interfaces;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    public class ScrollView : NestedControl, IStyle, ILayoutOptions
    {
        public Vector2 Position { get; set; } = Vector2.zero;

        public GUIStyle Style { get; set; } // TODO

        public LayoutOptions LayoutOptions { get; set; } = new LayoutOptions();

        public override void Draw()
        {
            GUILayout.BeginScrollView(Position, LayoutOptions);
            base.Draw();
            GUILayout.EndScrollView();
        }
    }
}
