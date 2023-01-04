using EasyIMGUI.Controls.Shared;
using System;

namespace EasyIMGUI.Controls.Extra
{
    /// <summary>
    /// A <see cref="Control"/> containing properties <see cref="Prefix"/> and <see cref="Postfix"/> that allow you to run your own <see cref="Action"/> before or after controls are drawn.
    /// </summary>
    public class Code : NestedControl
    {
        public Action Prefix { get; set; } = null;
        public Action Postfix { get; set; } = null;
        public override void Draw()
        {
            Prefix?.Invoke();
            base.Draw();
            Postfix?.Invoke();
        }
    }
}
