using Emmetienne.CustomApiPluginTypeIdSanitizer.EventBus;
using System.ComponentModel;
using System.Windows.Forms;

namespace Emmetienne.CustomApiPluginTypeIdSanitizer.Components
{
    internal class SourceEnvironmentLabelView
    {
        private readonly ToolStripButton sourceEnvironmentButton;

        private readonly string noSourceConnectionText = "Connect to source environment";

        public SourceEnvironmentLabelView(Component targetEnvirontmentButton)
        {
            this.sourceEnvironmentButton = (ToolStripButton)targetEnvirontmentButton;
            EventBusSingleton.Instance.setSourceEnvironmentName += SetButtonLabel;
            EventBusSingleton.Instance.clearSourcetEnvironmentName += ClearButtonLabel;
        }

        private void SetButtonLabel(string label)
        {
            this.sourceEnvironmentButton.Text = $"Source envinronment: {label}";
        }

        private void ClearButtonLabel()
        {
            this.sourceEnvironmentButton.Text = noSourceConnectionText;
        }
    }
}
