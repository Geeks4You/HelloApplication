﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnClickMe = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnClickMe
        '
        Me.btnClickMe.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnClickMe.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClickMe.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnClickMe.Location = New System.Drawing.Point(60, 80)
        Me.btnClickMe.Name = "btnClickMe"
        Me.btnClickMe.Size = New System.Drawing.Size(154, 80)
        Me.btnClickMe.TabIndex = 0
        Me.btnClickMe.Text = "Click ME!"
        Me.btnClickMe.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnClickMe)
        Me.Name = "Form1"
        Me.Text = "Hello Application"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnClickMe As Button
End Class
