using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Kiwi.ComponentFactory.Toolkit
{
    internal class KiwiCheckButtonCollectionEditor : UITypeEditor
    {
        /// <summary>
        /// Gets the editor style used by the EditValue method.
        /// </summary>
        /// <param name="context">An ITypeDescriptorContext that can be used to gain additional context information.</param>
        /// <returns>A UITypeEditorEditStyle enumeration value that indicates the style of editor.</returns>
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            if ((context != null) && (context.Instance != null))
                return UITypeEditorEditStyle.Modal;
            else
                return base.GetEditStyle(context);
        }

        /// <summary>
        /// Edits the specified object's value using the editor style indicated by GetEditStyle.
        /// </summary>
        /// <param name="context">An ITypeDescriptorContext that can be used to gain additional context information.</param>
        /// <param name="provider">An IServiceProvider that this editor can use to obtain services.</param>
        /// <param name="value">The object to edit.</param>
        /// <returns></returns>
        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            if ((context != null) && (context.Instance != null) && (provider != null))
            {
                // Must use the editor service for showing dialogs
                IWindowsFormsEditorService editorService = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));

                if (editorService != null)
                {
                    // Cast the value to the correct type
                    KiwiCheckSet checkSet = (KiwiCheckSet)context.Instance;

                    // Create the dialog used to edit the set of KiwiCheckButtons
                    KiwiCheckButtonCollectionForm dialog = new KiwiCheckButtonCollectionForm(checkSet);

                    if (editorService.ShowDialog(dialog) == DialogResult.OK)
                    {
                        // Notify container that value has been changed
                        context.OnComponentChanged();
                    }
                }
            }

            // Return the original value
            return value;
        }
    }
}
