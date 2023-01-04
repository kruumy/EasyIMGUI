using EasyIMGUI.Controls.Shared;
using UnityEngine;

namespace EasyIMGUI.Controls.Fixed
{
    public class Group : NestedControl, IContent, IDimensions
    {
        public Rect Dimensions { get; set; } = new Rect(10, 10, 300, 300);

        public GUIContent Content { get; set; } = new GUIContent("");
        public override void Draw()
        {
            GUI.BeginGroup(Dimensions, Content);
            base.Draw();
            GUI.EndGroup();
        }
    }
}
