

Public Class Form1
    'Name: Jess Clarence I. Arreza'
    'Subject and Code: CPE223L (6730)'
    'Laboratory 6'

    Dim totalOutput As Decimal = 0
    Public Sub Empty()
        DescComboBox.Text = ""
        salesTextBox.Text = ""
        qtyTextBox.Text = ""
        totalTextBox.Text = "0"
    End Sub

    Public Sub ValidData()
        Try
            If DescComboBox.Text = String.Empty Then
                MessageBox.Show("Must have Selected Descrition")
                Empty()

            End If

            If salesTextBox.Text = String.Empty Or CInt(salesTextBox.Text) <= 0 Then
                MessageBox.Show("Must have a sales")
                Empty()
            End If

            If qtyTextBox.Text = String.Empty Or CInt(qtyTextBox.Text) <= 0 Then
                MessageBox.Show("Must have a quantity")
                Empty()
            End If
        Catch ex As Exception
            MessageBox.Show("Error! something is not right")
        End Try

    End Sub

    Private Sub CountPartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CountPartToolStripMenuItem.Click
        MessageBox.Show("The Count: " & ListBox.Items.Count.ToString(), "Numbers of Being Listed")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        If MessageBox.Show(" Are you sure you want to exit the application ? ", "Exit  ?", MessageBoxButtons.YesNo) = DialogResult.Yes Then

            Me.Close()

        Else
            Me.Show()
        End If
    End Sub

    Private Sub AddPartToListBoxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddPartToListBoxToolStripMenuItem.Click
        ValidData()
        Try
            Dim salesPrice As Decimal = Decimal.Parse(salesTextBox.Text) * Decimal.Parse(qtyTextBox.Text)
            Dim strSalesPrice As String = Convert.ToString(salesPrice)


            ListBox.Items.Add(DescComboBox.Text & "- Price: $" & salesTextBox.Text & "- Qty: " & qtyTextBox.Text & "- Line Total: $" & strSalesPrice)
            Empty()

            totalOutput += salesPrice
            totalTextBox.Text = Convert.ToString(totalOutput)


        Catch ex As Exception

        End Try

    End Sub

    Private Sub ClearPartInListBoxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearPartInListBoxToolStripMenuItem.Click

        If MessageBox.Show("Are you sure you want to delete the list?", "Clear?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            ListBox.Items.Clear()
            Empty()
        End If

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Name: Jess Clarence I. Arreza" & Environment.NewLine & "Date: Wednesday, 4 May 2022")
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        ClearPartInListBoxToolStripMenuItem.PerformClick()

    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        AddPartToComboBoxToolStripMenuItem.PerformClick()
    End Sub

    Private Sub AddPartToComboBoxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddPartToComboBoxToolStripMenuItem.Click

        If DescComboBox.Text = String.Empty Then
            MessageBox.Show("Empty Text", "Needs to fill up the Text Box")
        Else
            DescComboBox.Items.Add(DescComboBox.Text)
        End If

    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If DescComboBox.Text = String.Empty Then
            MessageBox.Show("Empty Text", "Needs to fill up the Text Box")
        Else
            DescComboBox.Items.RemoveAt(DescComboBox.SelectedIndex)
        End If
    End Sub
End Class

