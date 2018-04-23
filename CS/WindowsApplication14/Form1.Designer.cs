namespace WindowsApplication14 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraGauges.Core.Model.IndicatorState indicatorState1 = new DevExpress.XtraGauges.Core.Model.IndicatorState();
            DevExpress.XtraGauges.Core.Model.IndicatorState indicatorState2 = new DevExpress.XtraGauges.Core.Model.IndicatorState();
            this.gaugeControl1 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.stateIndicatorGauge1 = new DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorGauge();
            this.redIndicator = new DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorComponent();
            this.fadeLevel = new System.Windows.Forms.TrackBar();
            this.gaugeControl2 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.stateIndicatorGauge2 = new DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorGauge();
            this.greenIndicator = new DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorComponent();
            this.greenLevel = new System.Windows.Forms.TrackBar();
            this.redLevel = new System.Windows.Forms.TrackBar();
            this.blueLevel = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.stateIndicatorGauge1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redIndicator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fadeLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateIndicatorGauge2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenIndicator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // gaugeControl1
            // 
            this.gaugeControl1.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.stateIndicatorGauge1});
            this.gaugeControl1.Location = new System.Drawing.Point(20, 12);
            this.gaugeControl1.Name = "gaugeControl1";
            this.gaugeControl1.Size = new System.Drawing.Size(260, 260);
            this.gaugeControl1.TabIndex = 0;
            // 
            // stateIndicatorGauge1
            // 
            this.stateIndicatorGauge1.Bounds = new System.Drawing.Rectangle(6, 6, 248, 248);
            this.stateIndicatorGauge1.Indicators.AddRange(new DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorComponent[] {
            this.redIndicator});
            this.stateIndicatorGauge1.Name = "stateIndicatorGauge1";
            // 
            // redIndicator
            // 
            this.redIndicator.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(124F, 124F);
            this.redIndicator.Name = "stateIndicatorComponent1";
            this.redIndicator.Shader = new DevExpress.XtraGauges.Core.Drawing.OpacityShader("");
            this.redIndicator.StateIndex = 0;
            indicatorState1.Name = "State";
            indicatorState1.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem1;
            this.redIndicator.States.AddRange(new DevExpress.XtraGauges.Core.Model.IIndicatorState[] {
            indicatorState1});
            // 
            // fadeLevel
            // 
            this.fadeLevel.Location = new System.Drawing.Point(20, 278);
            this.fadeLevel.Name = "fadeLevel";
            this.fadeLevel.Size = new System.Drawing.Size(260, 42);
            this.fadeLevel.TabIndex = 1;
            this.fadeLevel.Value = 10;
            this.fadeLevel.Scroll += new System.EventHandler(this.OnOpacityChanged);
            // 
            // gaugeControl2
            // 
            this.gaugeControl2.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.stateIndicatorGauge2});
            this.gaugeControl2.Location = new System.Drawing.Point(286, 12);
            this.gaugeControl2.Name = "gaugeControl2";
            this.gaugeControl2.Size = new System.Drawing.Size(260, 260);
            this.gaugeControl2.TabIndex = 1;
            // 
            // stateIndicatorGauge2
            // 
            this.stateIndicatorGauge2.Bounds = new System.Drawing.Rectangle(6, 6, 248, 248);
            this.stateIndicatorGauge2.Indicators.AddRange(new DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorComponent[] {
            this.greenIndicator});
            this.stateIndicatorGauge2.Name = "stateIndicatorGauge1";
            // 
            // greenIndicator
            // 
            this.greenIndicator.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(124F, 124F);
            this.greenIndicator.Name = "stateIndicatorComponent1";
            this.greenIndicator.Shader = new DevExpress.XtraGauges.Core.Drawing.ComplexShader("Opacity[1] Colors[Style1:;Style2:]");
            this.greenIndicator.StateIndex = 0;
            indicatorState2.Name = "State";
            indicatorState2.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem3;
            this.greenIndicator.States.AddRange(new DevExpress.XtraGauges.Core.Model.IIndicatorState[] {
            indicatorState2});
            // 
            // greenLevel
            // 
            this.greenLevel.Location = new System.Drawing.Point(287, 279);
            this.greenLevel.Maximum = 255;
            this.greenLevel.Name = "greenLevel";
            this.greenLevel.Size = new System.Drawing.Size(259, 42);
            this.greenLevel.TabIndex = 2;
            this.greenLevel.TickFrequency = 16;
            this.greenLevel.Value = 255;
            this.greenLevel.Scroll += new System.EventHandler(this.OnGreenChanged);
            // 
            // redLevel
            // 
            this.redLevel.Location = new System.Drawing.Point(286, 315);
            this.redLevel.Maximum = 255;
            this.redLevel.Name = "redLevel";
            this.redLevel.Size = new System.Drawing.Size(259, 42);
            this.redLevel.TabIndex = 3;
            this.redLevel.TickFrequency = 16;
            this.redLevel.Scroll += new System.EventHandler(this.OnRedChanged);
            // 
            // blueLevel
            // 
            this.blueLevel.Location = new System.Drawing.Point(286, 350);
            this.blueLevel.Maximum = 255;
            this.blueLevel.Name = "blueLevel";
            this.blueLevel.Size = new System.Drawing.Size(259, 42);
            this.blueLevel.TabIndex = 4;
            this.blueLevel.TickFrequency = 16;
            this.blueLevel.Scroll += new System.EventHandler(this.OnBlueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 404);
            this.Controls.Add(this.blueLevel);
            this.Controls.Add(this.redLevel);
            this.Controls.Add(this.greenLevel);
            this.Controls.Add(this.gaugeControl2);
            this.Controls.Add(this.fadeLevel);
            this.Controls.Add(this.gaugeControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.stateIndicatorGauge1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redIndicator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fadeLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateIndicatorGauge2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenIndicator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl1;
        private DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorGauge stateIndicatorGauge1;
        private DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorComponent redIndicator;
        private System.Windows.Forms.TrackBar fadeLevel;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl2;
        private DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorGauge stateIndicatorGauge2;
        private DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorComponent greenIndicator;
        private System.Windows.Forms.TrackBar greenLevel;
        private System.Windows.Forms.TrackBar redLevel;
        private System.Windows.Forms.TrackBar blueLevel;
    }
}

