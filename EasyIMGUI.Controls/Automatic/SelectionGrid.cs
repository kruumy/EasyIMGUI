using EasyIMGUI.Controls.Shared;
using UnityEngine;

namespace EasyIMGUI.Controls.Automatic
{
    /// <summary>
    /// A <see cref="Control"/> containing the implementation of <see cref="GUILayout.SelectionGrid(int, GUIContent[], int, GUIStyle, GUILayoutOption[])"/>.
    /// </summary>
    public class SelectionGrid : Shared.SelectionGrid, ILayoutOptions
    {
        public LayoutOptions LayoutOptions { get; set; } = new LayoutOptions();
        public override void Draw()
        {
            Value = GUILayout.SelectionGrid(Value, Contents.ToArray(), Width, LayoutOptions);
        }
    }
}
