using Emmetienne.CustomApiPluginTypeIdSanitizer.EventBus;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Emmetienne.CustomApiPluginTypeIdSanitizer.Components
{
    internal class GenericButtonComponentDisableView
    {
        private readonly Button component;
        public GenericButtonComponentDisableView(Component component)
        {
            this.component = (Button) component;

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
