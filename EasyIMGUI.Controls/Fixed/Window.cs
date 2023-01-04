using UnityEngine;

namespace EasyIMGUI.Controls.Fixed
{
    public class Window : Shared.Window
    {
        /// <inheritdoc/>
        public override void Draw()
        {
            Dimensions = GUI.Window(ID, Dimensions, WindowFunction, Content);
        }
    }
}
