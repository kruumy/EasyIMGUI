using EasyIMGUI.Controls.Extra.Base;
using EasyIMGUI.Controls.Interfaces;
using UnityEngine;

namespace EasyIMGUI.Controls.Extra
{
    public class EasyToolbar : Selector, IStyle, ILayoutOptions
    {
        public GUIStyle Style { get; set; } // TODO

        public LayoutOptions LayoutOptions { get; set; } = new LayoutOptions();

        public override void Draw()
        {
            Value = GUILayout.Toolbar(Value, Items.Contents, LayoutOptions);
            base.Draw();
        }
    }

}
