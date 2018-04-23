Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication14
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim indicatorState1 As New DevExpress.XtraGauges.Core.Model.IndicatorState()
			Dim indicatorState2 As New DevExpress.XtraGauges.Core.Model.IndicatorState()
			Me.gaugeControl1 = New DevExpress.XtraGauges.Win.GaugeControl()
			Me.stateIndicatorGauge1 = New DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorGauge()
			Me.redIndicator = New DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorComponent()
			Me.fadeLevel = New System.Windows.Forms.TrackBar()
			Me.gaugeControl2 = New DevExpress.XtraGauges.Win.GaugeControl()
			Me.stateIndicatorGauge2 = New DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorGauge()
			Me.greenIndicator = New DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorComponent()
			Me.greenLevel = New System.Windows.Forms.TrackBar()
			Me.redLevel = New System.Windows.Forms.TrackBar()
			Me.blueLevel = New System.Windows.Forms.TrackBar()
			CType(Me.stateIndicatorGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.redIndicator, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.fadeLevel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.stateIndicatorGauge2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.greenIndicator, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.greenLevel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.redLevel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.blueLevel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gaugeControl1
			' 
			Me.gaugeControl1.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() { Me.stateIndicatorGauge1})
			Me.gaugeControl1.Location = New System.Drawing.Point(20, 12)
			Me.gaugeControl1.Name = "gaugeControl1"
			Me.gaugeControl1.Size = New System.Drawing.Size(260, 260)
			Me.gaugeControl1.TabIndex = 0
			' 
			' stateIndicatorGauge1
			' 
			Me.stateIndicatorGauge1.Bounds = New System.Drawing.Rectangle(6, 6, 248, 248)
			Me.stateIndicatorGauge1.Indicators.AddRange(New DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorComponent() { Me.redIndicator})
			Me.stateIndicatorGauge1.Name = "stateIndicatorGauge1"
			' 
			' redIndicator
			' 
			Me.redIndicator.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(124F, 124F)
			Me.redIndicator.Name = "stateIndicatorComponent1"
			Me.redIndicator.Shader = New DevExpress.XtraGauges.Core.Drawing.OpacityShader("")
			Me.redIndicator.StateIndex = 0
			indicatorState1.Name = "State"
			indicatorState1.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem1
			Me.redIndicator.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() { indicatorState1})
			' 
			' fadeLevel
			' 
			Me.fadeLevel.Location = New System.Drawing.Point(20, 278)
			Me.fadeLevel.Name = "fadeLevel"
			Me.fadeLevel.Size = New System.Drawing.Size(260, 42)
			Me.fadeLevel.TabIndex = 1
			Me.fadeLevel.Value = 10
'			Me.fadeLevel.Scroll += New System.EventHandler(Me.OnOpacityChanged);
			' 
			' gaugeControl2
			' 
			Me.gaugeControl2.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() { Me.stateIndicatorGauge2})
			Me.gaugeControl2.Location = New System.Drawing.Point(286, 12)
			Me.gaugeControl2.Name = "gaugeControl2"
			Me.gaugeControl2.Size = New System.Drawing.Size(260, 260)
			Me.gaugeControl2.TabIndex = 1
			' 
			' stateIndicatorGauge2
			' 
			Me.stateIndicatorGauge2.Bounds = New System.Drawing.Rectangle(6, 6, 248, 248)
			Me.stateIndicatorGauge2.Indicators.AddRange(New DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorComponent() { Me.greenIndicator})
			Me.stateIndicatorGauge2.Name = "stateIndicatorGauge1"
			' 
			' greenIndicator
			' 
			Me.greenIndicator.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(124F, 124F)
			Me.greenIndicator.Name = "stateIndicatorComponent1"
			Me.greenIndicator.Shader = New DevExpress.XtraGauges.Core.Drawing.ComplexShader("Opacity[1] Colors[Style1:;Style2:]")
			Me.greenIndicator.StateIndex = 0
			indicatorState2.Name = "State"
			indicatorState2.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ProgressItem3
			Me.greenIndicator.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() { indicatorState2})
			' 
			' greenLevel
			' 
			Me.greenLevel.Location = New System.Drawing.Point(287, 279)
			Me.greenLevel.Maximum = 255
			Me.greenLevel.Name = "greenLevel"
			Me.greenLevel.Size = New System.Drawing.Size(259, 42)
			Me.greenLevel.TabIndex = 2
			Me.greenLevel.TickFrequency = 16
			Me.greenLevel.Value = 255
'			Me.greenLevel.Scroll += New System.EventHandler(Me.OnGreenChanged);
			' 
			' redLevel
			' 
			Me.redLevel.Location = New System.Drawing.Point(286, 315)
			Me.redLevel.Maximum = 255
			Me.redLevel.Name = "redLevel"
			Me.redLevel.Size = New System.Drawing.Size(259, 42)
			Me.redLevel.TabIndex = 3
			Me.redLevel.TickFrequency = 16
'			Me.redLevel.Scroll += New System.EventHandler(Me.OnRedChanged);
			' 
			' blueLevel
			' 
			Me.blueLevel.Location = New System.Drawing.Point(286, 350)
			Me.blueLevel.Maximum = 255
			Me.blueLevel.Name = "blueLevel"
			Me.blueLevel.Size = New System.Drawing.Size(259, 42)
			Me.blueLevel.TabIndex = 4
			Me.blueLevel.TickFrequency = 16
'			Me.blueLevel.Scroll += New System.EventHandler(Me.OnBlueChanged);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(574, 404)
			Me.Controls.Add(Me.blueLevel)
			Me.Controls.Add(Me.redLevel)
			Me.Controls.Add(Me.greenLevel)
			Me.Controls.Add(Me.gaugeControl2)
			Me.Controls.Add(Me.fadeLevel)
			Me.Controls.Add(Me.gaugeControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.stateIndicatorGauge1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.redIndicator, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.fadeLevel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.stateIndicatorGauge2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.greenIndicator, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.greenLevel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.redLevel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.blueLevel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private gaugeControl1 As DevExpress.XtraGauges.Win.GaugeControl
		Private stateIndicatorGauge1 As DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorGauge
		Private redIndicator As DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorComponent
		Private WithEvents fadeLevel As System.Windows.Forms.TrackBar
		Private gaugeControl2 As DevExpress.XtraGauges.Win.GaugeControl
		Private stateIndicatorGauge2 As DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorGauge
		Private greenIndicator As DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorComponent
		Private WithEvents greenLevel As System.Windows.Forms.TrackBar
		Private WithEvents redLevel As System.Windows.Forms.TrackBar
		Private WithEvents blueLevel As System.Windows.Forms.TrackBar
	End Class
End Namespace

