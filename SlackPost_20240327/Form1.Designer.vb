<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TxtPost = New TextBox()
        ButPost = New Button()
        SuspendLayout()
        ' 
        ' TxtPost
        ' 
        TxtPost.Location = New Point(11, 12)
        TxtPost.Multiline = True
        TxtPost.Name = "TxtPost"
        TxtPost.Size = New Size(259, 185)
        TxtPost.TabIndex = 0
        ' 
        ' ButPost
        ' 
        ButPost.Location = New Point(172, 203)
        ButPost.Name = "ButPost"
        ButPost.Size = New Size(98, 38)
        ButPost.TabIndex = 1
        ButPost.Text = "投稿"
        ButPost.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(282, 253)
        Controls.Add(ButPost)
        Controls.Add(TxtPost)
        Name = "Form1"
        Text = "Slack投稿"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TxtPost As TextBox
    Friend WithEvents ButPost As Button

End Class
