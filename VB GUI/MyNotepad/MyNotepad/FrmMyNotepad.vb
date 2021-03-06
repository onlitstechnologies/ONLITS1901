﻿Imports System.IO
Public Class FrmMyNotepad
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        If (TxtEditingArea.Text <> "") Then
            If (Me.Text.Substring(0, 1) = "*") Then
                Dim result As Integer = MessageBox.Show("Do you want to save Text!", "MyNotepad", MessageBoxButtons.YesNoCancel)

                If (result = 6) Then
                    SaveFile()
                ElseIf (result = 7) Then
                    TxtEditingArea.Clear()
                End If
            Else
                TxtEditingArea.Clear()
            End If
        End If
    End Sub

    Private Sub SaveFile()
        Dim sfd As New SaveFileDialog() 'Created Object

        If (sfd.ShowDialog() = DialogResult.OK) Then
            Dim sw As New StreamWriter(sfd.FileName)
            sw.WriteLine(TxtEditingArea.Text)
            sw.Close()
        End If


    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If (TxtEditingArea.Text <> "") Then
            Dim result As Integer = MessageBox.Show("Do you want to save Text!", "MyNotepad", MessageBoxButtons.YesNoCancel)
            If (result = 6) Then
                SaveFile()
            ElseIf (result = 7) Then
                TxtEditingArea.Clear()
            End If
        Else
            OpenFile()
        End If
    End Sub

    Private Sub OpenFile()
        Dim ofd As New OpenFileDialog() 'Created Object
        If (ofd.ShowDialog() = DialogResult.OK) Then
            Dim sr As New StreamReader(ofd.FileName)
            TxtEditingArea.Text = sr.ReadLine()
            Me.Text = ofd.FileName
            sr.Close()
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        SaveFile()
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        SaveFile()
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        Dim fd As New FontDialog
        If (fd.ShowDialog() = DialogResult.OK) Then
            TxtEditingArea.Font = fd.Font
            Dim sw As New StreamWriter("MyNotepad.ini")
            sw.WriteLine(fd.Font)
            sw.Close()
        End If
    End Sub

    Private Sub WordWrapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WordWrapToolStripMenuItem.Click
        If (WordWrapToolStripMenuItem.Checked) Then
            TxtEditingArea.WordWrap = True
        Else
            TxtEditingArea.WordWrap = False
        End If
    End Sub

    Private Sub FrmMyNotepad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sr As New StreamReader("MyNotepad.ini")
        Dim myfont As String = sr.ReadLine()
        sr.Close()
        Dim searchchar As Char() = {"=", ","}
        Dim fonts As String() = myfont.Split(searchchar, 5)

        TxtEditingArea.Font = New Font(fonts(1), fonts(3))

    End Sub

    Private Sub TxtEditingArea_TextChanged(sender As Object, e As EventArgs) Handles TxtEditingArea.TextChanged
        'Me.Text = "*" & Me.text
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(TxtEditingArea.Text, TxtEditingArea.Font, Brushes.Black, New Point(10, 10))
    End Sub

    Private Sub PageSetupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PageSetupToolStripMenuItem.Click
        PageSetupDialog1.Document = PrintDocument1
        'PageSetupDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        PageSetupDialog1.ShowDialog()
    End Sub
End Class