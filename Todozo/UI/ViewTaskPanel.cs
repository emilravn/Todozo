using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Todozo.UI
{
    class ViewTaskPanel : TableLayoutPanel
    {
        public ViewTaskPanel()
        {
            this.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
|           System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.Location = new System.Drawing.Point(357, 100);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            //this.Name = "flowLayoutPanelTask";
            this.Padding = new System.Windows.Forms.Padding(50, 25, 0, 0);
            this.Size = new System.Drawing.Size(1144, 649);
            this.TabIndex = 3;
            
        }
    }
}
