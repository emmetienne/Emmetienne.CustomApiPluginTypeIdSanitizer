using Emmetienne.CustomApiPluginTypeIdSanitizer.EventBus;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Emmetienne.CustomApiPluginTypeIdSanitizer.Components
{
    internal class SelectSolutionZipButtonView
    {
        private readonly Button component;
        public SelectSolutionZipButtonView(Component component)
        {
            this.component = (Button) component;

            EventBusSingleton.Instance.disableUiElements += DisableComponent;

            this.component.Click += SelectSolutionZip;
        }

        private void SelectSolutionZip(object sender, EventArgs e)
        {
            EventBusSingleton.Instance.initSolutionZipToSanitizeFilePath?.Invoke();
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
