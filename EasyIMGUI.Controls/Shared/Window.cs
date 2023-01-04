using UnityEngine;

namespace EasyIMGUI.Controls.Shared
{
    public abstract class Window : NestedControl, IDimensions, IContent
    {
        public GUIContent Content { get; set; } = new GUIContent("");
        public bool IsDragable { get; set; } = true;
        public Rect Dimensions { get; set; } = new Rect(0, 0, 300, 300);
        public int ID { get; set; } = new System.Random().Next();

        protected void WindowFunction(int windowID)
        {
            base.Draw();
            if (IsDragable)
            {
                GUI.DragWindow(new Rect(0, 0, Dimensions.width, 20));
            }
        }
    }
}
