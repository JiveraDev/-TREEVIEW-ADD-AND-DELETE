Public Class Form1
    Dim input
    Private Sub ADDNODE_Click(sender As Object, e As EventArgs) Handles ADDNODE.Click
        Dim newnode = InputBox(input)

        If frsttreeview.SelectedNode IsNot Nothing Then
            frsttreeview.SelectedNode.Nodes.Add(newnode)
        Else
            frsttreeview.Nodes.Add(newnode)
        End If
    End Sub

    Private Sub delnode_Click(sender As Object, e As EventArgs) Handles delnode.Click


        If frsttreeview.SelectedNode IsNot Nothing Then
            Dim result As DialogResult = MessageBox.Show("are you sure to delete:" & vbCrLf & frsttreeview.SelectedNode.Text, "Caution", MessageBoxButtons.OKCancel)
            If result = DialogResult.OK Then
                frsttreeview.SelectedNode.Nodes.Remove(frsttreeview.SelectedNode)
            End If

        End If
    End Sub
End Class
