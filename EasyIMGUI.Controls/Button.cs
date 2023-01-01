using EasyIMGUI.Controls.Base;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    public class Button : ButtonControl
    {
        public override void Draw()
        {
            if (GUILayout.Button(Content))
            {
                Invoke_OnButtonPressed();
            }
        }
    }
}
