Imports Microsoft.VisualBasic
Imports System.Windows.Forms
Imports System
Imports DevExpress.XtraGauges.Core.Drawing
Imports System.Drawing

Namespace WindowsApplication14
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub OnOpacityChanged(ByVal sender As Object, ByVal e As EventArgs) Handles fadeLevel.Scroll
			CType(Me.redIndicator.Shader, OpacityShader).Opacity = (CSng(fadeLevel.Value) / CSng(fadeLevel.Maximum))
		End Sub
		Private Sub OnGreenChanged(ByVal sender As Object, ByVal e As EventArgs) Handles greenLevel.Scroll
			UpdateShader()
		End Sub
		Private Sub OnRedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles redLevel.Scroll
			UpdateShader()
		End Sub
		Private Sub OnBlueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles blueLevel.Scroll
			UpdateShader()
		End Sub
		Private Sub UpdateShader()
			CType(greenIndicator.Shader, StyleShader).StyleColor2 = Color.FromArgb(redLevel.Value, greenLevel.Value, blueLevel.Value)
		End Sub
	End Class
End Namespace