using EasyIMGUI.Controls.Base;
using EasyIMGUI.Controls.Interfaces;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    /// <summary>
    /// A <see cref="Control"/> containing the implementation of <see cref="GUILayout.BeginScrollView(Vector2, GUIStyle, GUILayoutOption[])"/> and <see cref="GUILayout.EndScrollView"/>.
    /// </summary>
    public class ScrollView : NestedControl, ILayoutOptions
    {
        public Vector2 Position { get; set; } = Vector2.zero;

        public LayoutOptions LayoutOptions { get; set; } = new LayoutOptions();

        public override void Draw()
        {
            GUILayout.BeginScrollView(Position, LayoutOptions);
            base.Draw();
            GUILayout.EndScrollView();
        }
    }
}
