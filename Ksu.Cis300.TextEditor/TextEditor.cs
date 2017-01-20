/* TextEditor.cs
 * Author: Laurel Knust 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ksu.Cis300.TextEditor
{
    public partial class TextEditor : Form
    {
        public TextEditor()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Called whenever the user clicks "Open"
        /// </summary>
        private void uxOpen_Click(object sender, EventArgs e)
        {
            if (uxOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fn = uxOpenFileDialog.FileName; // Processes the file
                MessageBox.Show("Cannot open" + fn + ".");
            }
        }

        /// <summary>
        /// Called whenever the user clicks "Save As"
        /// </summary>
        private void uxSaveAs_Click(object sender, EventArgs e)
        {
            if (uxSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fn = uxSaveFileDialog.FileName; // Processes the file
                MessageBox.Show("Cannot write to" + fn + ".");
            }
        }
    }
}
