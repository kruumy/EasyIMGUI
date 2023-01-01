using System.Collections.Generic;

namespace EasyIMGUI.Controls.Base
{
    public abstract class NestedControl : Control
    {
        public List<Control> Controls { get; } = new List<Control>();

        public override void Draw()
        {
            Controls.ForEach(c => c.Draw());
        }
    }
}
