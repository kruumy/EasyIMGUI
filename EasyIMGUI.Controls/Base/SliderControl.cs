using System;

namespace EasyIMGUI.Controls.Base
{
    public abstract class SliderControl : Control
    {
        private float _Value = 5;
        public float Value
        {
            get
            {
                return _Value;
            }
            set
            {
                if (_Value != value)
                {
                    _Value = value;
                    OnValueChanged?.Invoke(this, value);
                }
            }
        }
        public float Minimum { get; set; } = 0;
        public float Maximim { get; set; } = 10;
        public event EventHandler<float> OnValueChanged;
    }
}
