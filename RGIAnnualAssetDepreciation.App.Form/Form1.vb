Public Class Form
    Private AssetCost As Double
    Private UsefulLife As Double
    Private SalvageValue As Double

    Private Sub btnDisplayDepreciationValues_Click(sender As Object, e As EventArgs) Handles btnDisplayDepreciationValues.Click
        Const enterValuesMessage = "Please enter values to calucalate depreciation schedules."
        Const cboxHeader = "Year" + vbTab + "Depreciation"

        If ValidateInput() Then
            If TryParseInput() Then
                lboxDoubleDecliningBalances.Items.Clear()
                lboxDoubleDecliningBalances.Items.Add(cboxHeader)
                lboxSumOfTheYearsDigits.Items.Clear()
                lboxSumOfTheYearsDigits.Items.Add(cboxHeader)

                For depYear As Integer = 1 To UsefulLife
                    lboxDoubleDecliningBalances.Items.Add(depYear.ToString() + vbTab + Financial.DDB(AssetCost, SalvageValue, UsefulLife, depYear).ToString("F2"))
                    lboxSumOfTheYearsDigits.Items.Add(depYear.ToString() + vbTab + Financial.SYD(AssetCost, SalvageValue, UsefulLife, depYear).ToString("F2"))
                Next
            End If
        Else
            AlertMessage(enterValuesMessage)
        End If

    End Sub

    Private Function ValidateInput() As Boolean
        If String.IsNullOrEmpty(txtAssetCost.Text) Or String.IsNullOrEmpty(txtSalvageValue.Text) Or String.IsNullOrEmpty(txtUsefulLife.Text) Then
            Return False
        End If
        Return True
    End Function

    Private Function TryParseInput() As Boolean
        Const notANumberSuffixMessage As String = "is not a number."

        If Not Double.TryParse(txtAssetCost.Text, AssetCost) Then
            AlertMessage($"{InputNameConstant.AssetCost} {notANumberSuffixMessage}")
            Return False
        ElseIf Not Double.TryParse(txtUsefulLife.Text, UsefulLife) Then
            AlertMessage($"{InputNameConstant.UsefulLife} {notANumberSuffixMessage}")
            Return False
        ElseIf Not Double.TryParse(txtSalvageValue.Text, SalvageValue) Then
            AlertMessage($"{InputNameConstant.SalvageValue} {notANumberSuffixMessage}")
            Return False
        End If
        Return True
    End Function

    Private Shared Sub AlertMessage(message As String)
        MessageBox.Show(message)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class

Public Class InputNameConstant
    Public Const AssetCost As String = "Asset Cost"
    Public Const UsefulLife As String = "Useful Life"
    Public Const SalvageValue As String = "Salvage Value"
End Class
