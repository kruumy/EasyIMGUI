using EasyIMGUI.Controls.Shared;
using UnityEngine;

namespace EasyIMGUI.Controls.Automatic
{
    /// <summary>
    /// A <see cref="Control"/> containing the implementation of <see cref="GUILayout.Window(int, Rect, GUI.WindowFunction, GUIContent, GUIStyle, GUILayoutOption[])"/>.
    /// </summary>
    public class Window : Shared.Window, ILayoutOptions
    {
        public LayoutOptions LayoutOptions { get; set; } = new LayoutOptions();

        public override void Draw()
        {
            Dimensions = GUILayout.Window(ID, Dimensions, WindowFunction, Content, LayoutOptions);
        }
    }
}
