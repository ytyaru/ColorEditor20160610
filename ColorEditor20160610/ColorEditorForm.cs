/**
 * ColorEditor20160610
 *
 * These codes are licensed under CC0.
 * http://creativecommons.org/publicdomain/zero/1.0/deed.ja
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ColorEditor20160610
{
    public partial class ColorEditorForm : Form
    {
        private Color nowColor;

        private System.EventHandler numericUpDown1ValueChangedEventHandler;
        private System.EventHandler numericUpDown2ValueChangedEventHandler;
        private System.EventHandler numericUpDown3ValueChangedEventHandler;
        private System.EventHandler hScrollBar1ValueChangedEventHandler;
        private System.EventHandler hScrollBar2ValueChangedEventHandler;
        private System.EventHandler hScrollBar3ValueChangedEventHandler;

        public ColorEditorForm()
        {
            InitializeComponent();
            this.nowColor = Color.FromArgb(0, 0, 0);

            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();

            this.numericUpDown1ValueChangedEventHandler = new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.numericUpDown2ValueChangedEventHandler = new System.EventHandler(this.numericUpDown2_ValueChanged);
            this.numericUpDown3ValueChangedEventHandler = new System.EventHandler(this.numericUpDown3_ValueChanged);

            this.hScrollBar1ValueChangedEventHandler += new System.EventHandler(this.hScrollBar1_ValueChanged);
            this.hScrollBar2ValueChangedEventHandler += new System.EventHandler(this.hScrollBar2_ValueChanged);
            this.hScrollBar3ValueChangedEventHandler += new System.EventHandler(this.hScrollBar3_ValueChanged);

            this.numericUpDown1.ValueChanged += this.numericUpDown1ValueChangedEventHandler;
            this.numericUpDown2.ValueChanged += this.numericUpDown2ValueChangedEventHandler;
            this.numericUpDown3.ValueChanged += this.numericUpDown3ValueChangedEventHandler;

            this.hScrollBar1.ValueChanged += this.hScrollBar1ValueChangedEventHandler;
            this.hScrollBar2.ValueChanged += this.hScrollBar2ValueChangedEventHandler;
            this.hScrollBar3.ValueChanged += this.hScrollBar3ValueChangedEventHandler;

            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.nowColor = Color.FromArgb(
                (int)this.numericUpDown1.Value,
                (int)this.numericUpDown2.Value,
                (int)this.numericUpDown3.Value);
            pictureBox1.BackColor = this.nowColor;

            // http://bbs.wankuma.com/index.cgi?mode=al2&namber=7027&KLOG=17
            this.hScrollBar1.ValueChanged -= this.hScrollBar1ValueChangedEventHandler;
            this.hScrollBar1.Value = (int)this.numericUpDown1.Value;
            this.hScrollBar1.ValueChanged += this.hScrollBar1ValueChangedEventHandler;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            this.nowColor = Color.FromArgb(
                (int)this.numericUpDown1.Value,
                (int)this.numericUpDown2.Value,
                (int)this.numericUpDown3.Value);
            pictureBox1.BackColor = this.nowColor;

            this.hScrollBar2.ValueChanged -= this.hScrollBar2ValueChangedEventHandler;
            this.hScrollBar2.Value = (int)this.numericUpDown2.Value;
            this.hScrollBar2.ValueChanged += this.hScrollBar2ValueChangedEventHandler;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            this.nowColor = Color.FromArgb(
                (int)this.numericUpDown1.Value,
                (int)this.numericUpDown2.Value,
                (int)this.numericUpDown3.Value);
            pictureBox1.BackColor = this.nowColor;

            this.hScrollBar3.ValueChanged -= this.hScrollBar3ValueChangedEventHandler;
            this.hScrollBar3.Value = (int)this.numericUpDown3.Value;
            this.hScrollBar3.ValueChanged += this.hScrollBar3ValueChangedEventHandler;
        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            this.nowColor = Color.FromArgb(
                (int)this.hScrollBar1.Value,
                (int)this.hScrollBar2.Value,
                (int)this.hScrollBar3.Value);
            pictureBox1.BackColor = this.nowColor;

            this.numericUpDown1.ValueChanged -= this.numericUpDown1ValueChangedEventHandler;
            this.numericUpDown1.Value = this.hScrollBar1.Value;
            this.numericUpDown1.ValueChanged += this.numericUpDown1ValueChangedEventHandler;
        }

        private void hScrollBar2_ValueChanged(object sender, EventArgs e)
        {
            this.nowColor = Color.FromArgb(
                (int)this.hScrollBar1.Value,
                (int)this.hScrollBar2.Value,
                (int)this.hScrollBar3.Value);
            pictureBox1.BackColor = this.nowColor;

            this.numericUpDown2.ValueChanged -= this.numericUpDown2ValueChangedEventHandler;
            this.numericUpDown2.Value = this.hScrollBar2.Value;
            this.numericUpDown2.ValueChanged += this.numericUpDown2ValueChangedEventHandler;
        }

        private void hScrollBar3_ValueChanged(object sender, EventArgs e)
        {
            this.nowColor = Color.FromArgb(
                (int)this.hScrollBar1.Value,
                (int)this.hScrollBar2.Value,
                (int)this.hScrollBar3.Value);
            pictureBox1.BackColor = this.nowColor;

            this.numericUpDown3.ValueChanged -= this.numericUpDown3ValueChangedEventHandler;
            this.numericUpDown3.Value = this.hScrollBar3.Value;
            this.numericUpDown3.ValueChanged += this.numericUpDown3ValueChangedEventHandler;
        }
    }
}
