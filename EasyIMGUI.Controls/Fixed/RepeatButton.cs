using EasyIMGUI.Controls.Shared.Interfaces;
using UnityEngine;

namespace EasyIMGUI.Controls.Fixed
{
    public class RepeatButton : Shared.Button, IDimensions
    {
        public Rect Dimensions { get; set; } = new Rect(0, 0, 0, 0);
        public override void Draw()
        {
            if (GUI.RepeatButton(Dimensions, Content))
            {
                Invoke_OnButtonPressed();
            }
        }
    }
}
