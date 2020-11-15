' ==============================================================
'
' Copyright 2009 - 2015 Dassault Systèmes SolidWorks Corporation
'
' ==============================================================

Imports EPDM.Interop.epdm

Public Class Exercise4

	Private Sub Exercise4_Load( _
		ByVal sender As System.Object, _
		ByVal e As System.EventArgs) _
		Handles MyBase.Load

		Try
			Dim vault As IEdmVault8 = New EdmVault5
			Dim Views() As EdmViewInfo = Nothing

			vault.GetVaultViews(Views, False)
			VaultsComboBox.Items.Clear()
			For Each View As EdmViewInfo In Views
				VaultsComboBox.Items.Add(View.mbsVaultName)
			Next
			If VaultsComboBox.Items.Count > 0 Then
				VaultsComboBox.Text = VaultsComboBox.Items(0)
			End If

		Catch ex As Runtime.InteropServices.COMException
			MessageBox.Show("HRESULT = 0x" + _
				ex.ErrorCode.ToString("X") + vbCrLf + _
				ex.Message)
		Catch ex As Exception
			MessageBox.Show(ex.Message)
		End Try
	End Sub

	Private Sub FindCardsButton_Click( _
		ByVal sender As System.Object, _
		ByVal e As System.EventArgs) _
		Handles FindCardsButton.Click

		Try


		Catch ex As Runtime.InteropServices.COMException
			MessageBox.Show("HRESULT = 0x" + _
				ex.ErrorCode.ToString("X") + vbCrLf + _
				ex.Message)
		Catch ex As Exception
			MessageBox.Show(ex.Message)
		End Try
	End Sub

End Class
