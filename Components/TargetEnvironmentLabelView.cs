using Emmetienne.CustomApiPluginTypeIdSanitizer.EventBus;
using System.ComponentModel;
using System.Windows.Forms;

namespace Emmetienne.CustomApiPluginTypeIdSanitizer.Components
{
    internal class TargetEnvironmentLabelView
    {
        private readonly ToolStripButton targetEnvironmentButton;

        private readonly string noTargetConnectionText = "Connect to target environment";

        public TargetEnvironmentLabelView(Component targetEnvirontmentButton)
        {
            this.targetEnvironmentButton = (ToolStripButton)targetEnvirontmentButton;
            EventBusSingleton.Instance.setTargetEnvironmentName += SetButtonLabel;
            EventBusSingleton.Instance.clearTargetEnvironmentName += ClearButtonLabel;
        }

        private void SetButtonLabel(string label)
        {
            this.targetEnvironmentButton.Text = $"Target envinronment: {label}";
        }

        private void ClearButtonLabel()
        {
            this.targetEnvironmentButton.Text = noTargetConnectionText;
        }
    }
}
