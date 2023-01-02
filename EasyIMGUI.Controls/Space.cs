using EasyIMGUI.Controls.Base;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    public class Space : ValueControl<float>
    {
        public override void Draw()
        {
            GUILayout.Space(Value);
        }
    }
}
