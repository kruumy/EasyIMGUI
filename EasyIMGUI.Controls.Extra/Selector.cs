using EasyIMGUI.Controls.Shared;

namespace EasyIMGUI.Controls.Extra
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
