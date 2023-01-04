using EasyIMGUI.Controls.Shared.Base;
using UnityEngine;

namespace EasyIMGUI.Controls.Automatic
{
    /// <summary>
    /// A <see cref="Control"/> containing the implementation of <see cref="GUILayout.FlexibleSpace"/>.
    /// </summary>
    public class FlexibleSpace : Control
    {
        public override void Draw()
        {
            GUILayout.FlexibleSpace();
        }
    }
}
