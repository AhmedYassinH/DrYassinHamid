Imports System.Data.OleDb

Public Class Form1
    Dim con As New OleDbConnection
    

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtinf.TextChanged

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtphone.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       



        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\DrYassinHamid.accdb"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        con.Open()
        Try
            Dim cmdupdate As New OleDbCommand
            cmdupdate.Connection = con
            cmdupdate.CommandText = "Update DrYassinHamid set m_Name = '" + txtName.Text + "' , m_Date = '" + dtp.Value + "' , m_phone = '" + txtphone.Text + " ' , m_inf = '" + txtinf.Text + " ',m_m='" + txtm.Text + "' Where m_ID = '" + txtID.Text + "'"
            cmdupdate.ExecuteNonQuery()
            MsgBox("تم تعديل بيانات المريض")
            txtID.Clear()
            txtName.Clear()
            txtinf.Clear()
            txtphone.Clear()
            txtm.Clear()
            dtp.Value = Now
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        con.Open()
        Try
            Dim cmddelet As New OleDbCommand
            cmddelet.Connection = con
            cmddelet.CommandText = "Delete From DrYassinHamid where m_ID = '" + txtID.Text + "'"
            cmddelet.ExecuteNonQuery()
            MsgBox("تم حذف المريض")
            txtID.Clear()
            txtName.Clear()
            txtinf.Clear()
            txtphone.Clear()
            txtm.Clear()
            dtp.Value = Now
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        con.Close()
    End Sub


    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtID.Clear()
        txtName.Clear()
        txtinf.Clear()
        txtphone.Clear()
        txtm.Clear()
        dtp.Value = Now

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(txtm.Text, New Font("Tahoma", 20), Brushes.Black, 10, 20)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub Label9_Click_1(sender As Object, e As EventArgs) Handles lbl_Date.Click
        lbl_Date.Text = Now
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged

    End Sub

    Private Sub lbl_Date_TextChanged(sender As Object, e As EventArgs) Handles lbl_Date.TextChanged

    End Sub


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        





        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            PrintDocument1.Print()

        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click


      


        con.Open()
        Try
            Dim cmdinsert As New OleDbCommand
            cmdinsert.Connection = con
            cmdinsert.CommandText = "insert into DrYassinHamid values ('" + txtID.Text + "','" + txtName.Text + "','" + dtp.Value + "','" + txtphone.Text + "','" + txtinf.Text + "','" + txtm.Text + "')"
            cmdinsert.ExecuteNonQuery()
            MsgBox("تم حفظ المريض")
            txtID.Clear()
            txtName.Clear()
            txtinf.Clear()
            txtphone.Clear()
            txtm.Clear()
            dtp.Value = Now


        Catch ex As Exception
            MsgBox("عفوا هذا المريض مسجل مسبقا".ToString)
        End Try
        con.Close()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click







        con.Open()
        Try
            Dim cmdselect As New OleDbCommand
            cmdselect.Connection = con
            cmdselect.CommandText = " select * from DrYassinHamid Where m_ID = '" + txtID.Text + "' or m_phone = '" + txtphone.Text + "' or m_inf = '" + txtinf.Text + "'"
            Dim re As OleDbDataReader
            re = cmdselect.ExecuteReader
            If re.Read Then
                txtID.Text = re(0).ToString
                txtName.Text = re(1).ToString
                dtp.Value = re(2).ToString
                txtphone.Text = re(3).ToString
                txtinf.Text = re(4).ToString
                txtm.Text = re(5).ToString

            Else
                MsgBox("عفوا هذا المريض غير مسجل")
            End If

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

       




        con.Open()
        Try
            Dim cmddelet As New OleDbCommand
            cmddelet.Connection = con
            cmddelet.CommandText = "Delete From DrYassinHamid where m_ID = '" + txtID.Text + "'"
            cmddelet.ExecuteNonQuery()
            MsgBox("تم حذف المريض")
            txtID.Clear()
            txtName.Clear()
            txtinf.Clear()
            txtphone.Clear()
            txtm.Clear()
            dtp.Value = Now
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        con.Close()

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
       





        End



        




    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click

     

        txtID.Clear()
        txtName.Clear()
        txtinf.Clear()
        txtphone.Clear()
        txtm.Clear()
        dtp.Value = Now
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click


      





        con.Open()
        Try
            Dim cmdupdate As New OleDbCommand
            cmdupdate.Connection = con
            cmdupdate.CommandText = "Update DrYassinHamid set m_Name = '" + txtName.Text + "' , m_Date = '" + dtp.Value + "' , m_phone = '" + txtphone.Text + " ' , m_inf = '" + txtinf.Text + " ',m_m='" + txtm.Text + "' Where m_ID = '" + txtID.Text + "'"
            cmdupdate.ExecuteNonQuery()
            MsgBox("تم تعديل بيانات المريض")
            txtID.Clear()
            txtName.Clear()
            txtinf.Clear()
            txtphone.Clear()
            txtm.Clear()
            dtp.Value = Now
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub PictureBox3_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox3.MouseMove

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub txtm_TextChanged(sender As Object, e As EventArgs) Handles txtm.TextChanged

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs)

    End Sub
End Class
