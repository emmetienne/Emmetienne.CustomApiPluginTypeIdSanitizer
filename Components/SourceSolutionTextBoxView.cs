using Emmetienne.CustomApiPluginTypeIdSanitizer.EventBus;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Emmetienne.CustomApiPluginTypeIdSanitizer.Components
{
    internal class SourceSolutionTextBoxView
    {
        private readonly TextBox component;
        public SourceSolutionTextBoxView(Component component)
        {
            this.component = (TextBox)component;

            EventBusSingleton.Instance.disableUiElements += DisableComponent;
            EventBusSingleton.Instance.setSolutionZipToSanitizeFilePath += SetSolutionZipToSanitizeFilePath;
        }

        private void SetSolutionZipToSanitizeFilePath(string solutionToSanitizePath)
        {
            this.component.Text = solutionToSanitizePath;
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