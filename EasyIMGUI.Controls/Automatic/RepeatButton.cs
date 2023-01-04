using EasyIMGUI.Controls.Interfaces;
using EasyIMGUI.Controls.Shared.Base;
using UnityEngine;

namespace EasyIMGUI.Controls.Automatic
{
    /// <summary>
    /// A <see cref="Control"/> containing the implementation of <see cref="GUILayout.RepeatButton(GUIContent, GUIStyle, GUILayoutOption[])"/>.
    /// </summary>
    public class RepeatButton : Shared.Button, ILayoutOptions
    {

        public LayoutOptions LayoutOptions { get; set; } = new LayoutOptions();

        public override void Draw()
        {
            if (GUILayout.RepeatButton(Content, LayoutOptions))
            {
                Invoke_OnButtonPressed();
            }
        }
    }
}
