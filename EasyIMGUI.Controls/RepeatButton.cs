using EasyIMGUI.Controls.Base;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    public class RepeatButton : ButtonControl
    {
        public override void Draw()
        {
            if (GUILayout.RepeatButton(Content))
            {
                Invoke_OnButtonPressed();
            }
        }
    }
}
