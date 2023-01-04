using EasyIMGUI.Controls.Automatic;
using UnityEngine;

namespace EasyIMGUI.Controls.Extra
{
    public class EasyToolbar : Selector, ILayoutOptions
    {
        public GUIStyle Style { get; set; } = null;

        public LayoutOptions LayoutOptions { get; set; } = new LayoutOptions();

        public override void Draw()
        {
            Value = GUILayout.Toolbar(Value, Items.Contents, LayoutOptions);
            base.Draw();
        }
    }

}
