using EasyIMGUI.Controls.Base;
using EasyIMGUI.Controls.Interfaces;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    /// <summary>
    /// A <see cref="Control"/> containing the implementation of <see cref="GUILayout.Window(int, Rect, GUI.WindowFunction, GUIContent, GUIStyle, GUILayoutOption[])"/>.
    /// </summary>
    public class Window : NestedControl, IDimensions, IContent, IStyle, ILayoutOptions
    {
        public GUIContent Content { get; set; } = new GUIContent("");
        public LayoutOptions LayoutOptions { get; set; } = new LayoutOptions();

        public GUIStyle Style { get; set; } = null;
        public bool IsDragable { get; set; } = true;
        public Rect Dimensions { get; set; } = new Rect(0, 0, 300, 300);
        public int ID { get; set; } = new System.Random().Next();

        public override void Draw()
        {
            if (Style != null) Dimensions = GUILayout.Window(ID, Dimensions, Work, Content, Style, LayoutOptions);
            else Dimensions = GUILayout.Window(ID, Dimensions, Work, Content, LayoutOptions);
        }
        private void Work(int id)
        {
            base.Draw();
            if (IsDragable)
            {
                GUI.DragWindow(new Rect(0, 0, Dimensions.width, 20));
            }
        }
    }
}
