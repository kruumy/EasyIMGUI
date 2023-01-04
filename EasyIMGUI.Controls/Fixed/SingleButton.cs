using EasyIMGUI.Controls.Shared;
using UnityEngine;

namespace EasyIMGUI.Controls.Fixed
{
    public class SingleButton : Shared.Button, IDimensions
    {
        /// <inheritdoc/>
        public Rect Dimensions { get; set; } = new Rect(0, 0, 0, 0);

        /// <inheritdoc/>
        public override void Draw()
        {
            if (GUI.Button(Dimensions, Content))
            {
                Invoke_OnButtonPressed();
            }
        }
    }
}
