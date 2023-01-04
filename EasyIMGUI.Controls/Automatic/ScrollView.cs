using EasyIMGUI.Controls.Interfaces;
using EasyIMGUI.Controls.Shared.Base;
using UnityEngine;

namespace EasyIMGUI.Controls.Automatic
{
    /// <summary>
    /// A <see cref="Control"/> containing the implementation of <see cref="GUILayout.BeginScrollView(Vector2, GUIStyle, GUILayoutOption[])"/> and <see cref="GUILayout.EndScrollView"/>.
    /// </summary>
    public class ScrollView : Shared.ScrollView, ILayoutOptions
    {
        public LayoutOptions LayoutOptions { get; set; } = new LayoutOptions();

        public override void Draw()
        {
            Position = GUILayout.BeginScrollView(Position, AlwaysShowHorizontal, AlwaysShowVertical, LayoutOptions);
            base.Draw();
            GUILayout.EndScrollView();
        }
    }
}
