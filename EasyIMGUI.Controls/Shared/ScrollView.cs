using UnityEngine;

namespace EasyIMGUI.Controls.Shared
{
    public abstract class ScrollView : NestedControl
    {
        public Vector2 Position { get; set; } = new Vector2(0, 0);
        public bool AlwaysShowHorizontal = false;
        public bool AlwaysShowVertical = false;
    }
}
