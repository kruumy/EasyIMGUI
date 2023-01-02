using EasyIMGUI.Controls.Base;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    /// <summary>
    /// A <see cref="Control"/> containing the implementation of <see cref="GUILayout.Space(float)"/>.
    /// </summary>
    public class Space : ValueControl<float>
    {
        public override void Draw()
        {
            GUILayout.Space(Value);
        }
    }
}
