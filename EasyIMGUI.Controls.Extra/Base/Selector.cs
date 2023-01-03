using EasyIMGUI.Controls.Base;

namespace EasyIMGUI.Controls.Extra.Base
{
    public abstract class Selector : ValueControl<int>
    {
        public SelectorItems Items { get; set; } = new SelectorItems();
        public SelectorItem SelectedItem => Items[Value];

        public override void Draw()
        {
            SelectedItem.Control.Draw();
        }
    }
}
