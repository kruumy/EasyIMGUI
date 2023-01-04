using EasyIMGUI.Controls.Shared;
using UnityEngine;

namespace EasyIMGUI.Controls.Automatic
{
    /// <summary>
    /// A <see cref="Control"/> containing the implementation of <see cref="GUILayout.Toolbar(int, GUIContent[], GUIStyle, GUI.ToolbarButtonSize, GUILayoutOption[])"/>.
    /// </summary>
    public class Toolbar : Shared.Toolbar, ILayoutOptions
    {

        public LayoutOptions LayoutOptions { get; set; } = new LayoutOptions();

        public override void Draw()
        {
            Value = GUILayout.Toolbar(Value, Contents.ToArray(), LayoutOptions);
        }
    }
}
