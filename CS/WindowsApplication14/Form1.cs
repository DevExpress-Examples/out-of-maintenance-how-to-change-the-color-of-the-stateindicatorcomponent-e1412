using System.Windows.Forms;
using System;
using DevExpress.XtraGauges.Core.Drawing;
using System.Drawing;

namespace WindowsApplication14 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        void OnOpacityChanged(object sender, EventArgs e) {
            ((OpacityShader)this.redIndicator.Shader).Opacity = 
                ((float)fadeLevel.Value / (float)fadeLevel.Maximum);
        }
        void OnGreenChanged(object sender, EventArgs e) {
            UpdateShader();
        }
        void OnRedChanged(object sender, EventArgs e) {
            UpdateShader();
        }
        void OnBlueChanged(object sender, EventArgs e) {
            UpdateShader();
        }
        void UpdateShader() {
            ((StyleShader)greenIndicator.Shader).StyleColor2 =
                Color.FromArgb(redLevel.Value, greenLevel.Value, blueLevel.Value);
        }
    }
}