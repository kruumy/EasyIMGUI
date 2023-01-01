using EasyIMGUI.Controls.Base;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    public class Window : NestedControl, IContent, IDimensions
    {
        public GUIContent Content { get; set; } = GUIContent.none;
        public bool IsDragable { get; set; } = true;
        public Rect Dimensions { get; set; } = new Rect(0, 0, 300, 300);
        public int ID { get; } = new System.Random().Next();
        public override void Draw()
        {
            Dimensions = GUILayout.Window(ID, Dimensions, (int id) =>
            {
                base.Draw();
                if (IsDragable)
                {
                    GUI.DragWindow(new Rect(0, 0, Dimensions.width, 20));
                }
            },
            Content);
        }
    }
}
