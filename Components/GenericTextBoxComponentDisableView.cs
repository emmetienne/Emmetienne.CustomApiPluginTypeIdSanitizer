using Emmetienne.CustomApiPluginTypeIdSanitizer.EventBus;
using Emmetienne.CustomApiPluginTypeIdSanitizer.EventBus;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Emmetienne.CustomApiPluginTypeIdSanitizer.Components
{
    internal class GenericTextBoxComponentDisableView
    {
        private readonly TextBox component;
        public GenericTextBoxComponentDisableView(Component component)
        {
            this.component = (TextBox) component;

            EventBusSingleton.Instance.disableUiElements += DisableComponent;
        }
  
        public void DisableComponent(bool isDisabled)
        {
            if (this.component.InvokeRequired)
            {
                Action setDisableComponentSafe = delegate { DisableComponent(isDisabled); };

                this.component.Invoke(setDisableComponentSafe);
            }
            else
            {
                this.component.Enabled = !isDisabled;
            }
        }
    }
}