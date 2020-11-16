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
			Dim vault As IEdmVault5 = New EdmVault5
			If Not vault.IsLoggedIn Then
				vault.LoginAuto(VaultsComboBox.Text, Me.Handle.ToInt32())
			End If

			Dim Cards As New ArrayList
			Cards.Clear()

			Dim Folder As IEdmFolder5
			Folder = vault.RootFolder

			Dim VarMgr As IEdmVariableMgr5
			VarMgr = vault

			Dim VarPos As IEdmPos5
			VarPos = VarMgr.GetFirstVariablePosition

			While Not VarPos.IsNull
				Dim Var As IEdmVariable5
				Var = VarMgr.GetNextVariable(VarPos)

				If Not Var.Name = "Description" Then
					Continue While
				End If
				Dim AttPos As IEdmPos5
				AttPos = Var.GetFirstAttributePosition("")
				While Not AttPos.IsNull
					Dim Att As IEdmAttribute5
					Att = Var.GetNextAttribute(AttPos)
					Dim Extensions() As String
					Extensions = Att.Extensions.Split(",")
					Dim Extension As String
					For Each Extension In Extensions
						Try
							Dim Card As IEdmCard5
							Card = Folder.GetCard(Extension)
							If Card.cardtype = EdmCardType.EdmCard_File Then
								If Not Cards.Contains(Card.Name) Then
									Cards.Add(Card.Name)
								End If
							End If

						Catch ex As Runtime.InteropServices.COMException
							If Not ex.ErrorCode = &H8004021D Then
								Throw New Runtime.InteropServices.COMException(ex.Message, ex.ErrorCode)
							End If
						End Try
					Next Extension
				End While
			End While

			Dim CardName As String
			For Each CardName In Cards
				MessageBox.Show(CardName + " has the variable ""Description"" mapped to it")
			Next CardName

		Catch ex As Runtime.InteropServices.COMException
			MessageBox.Show("HRESULT = 0x" +
				ex.ErrorCode.ToString("X") + vbCrLf +
				ex.Message)
		Catch ex As Exception
			MessageBox.Show(ex.Message)
		End Try
	End Sub

End Class
