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
        SplitContainer1 = New SplitContainer()
        cblinpacitados = New CheckedListBox()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Label1 = New Label()
        txtpersonas = New TextBox()
        PrintDocument1 = New Printing.PrintDocument()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        SuspendLayout()
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.Location = New Point(0, 0)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(cblinpacitados)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(Button3)
        SplitContainer1.Panel2.Controls.Add(Button2)
        SplitContainer1.Panel2.Controls.Add(Button1)
        SplitContainer1.Panel2.Controls.Add(Label1)
        SplitContainer1.Panel2.Controls.Add(txtpersonas)
        SplitContainer1.Size = New Size(800, 450)
        SplitContainer1.SplitterDistance = 266
        SplitContainer1.TabIndex = 0
        ' 
        ' cblinpacitados
        ' 
        cblinpacitados.FormattingEnabled = True
        cblinpacitados.Location = New Point(3, 6)
        cblinpacitados.Name = "cblinpacitados"
        cblinpacitados.Size = New Size(263, 444)
        cblinpacitados.TabIndex = 0
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(42, 350)
        Button3.Name = "Button3"
        Button3.Size = New Size(166, 88)
        Button3.TabIndex = 4
        Button3.Text = "Imprimir"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(243, 155)
        Button2.Name = "Button2"
        Button2.Size = New Size(166, 88)
        Button2.TabIndex = 3
        Button2.Text = "Eliminar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(42, 155)
        Button1.Name = "Button1"
        Button1.Size = New Size(166, 88)
        Button1.TabIndex = 2
        Button1.Text = "Agregar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(31, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(417, 46)
        Label1.TabIndex = 1
        Label1.Text = "Control de Incapacitados"
        ' 
        ' txtpersonas
        ' 
        txtpersonas.Location = New Point(42, 90)
        txtpersonas.Name = "txtpersonas"
        txtpersonas.Size = New Size(367, 27)
        txtpersonas.TabIndex = 0
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(SplitContainer1)
        Name = "Form1"
        Text = "Form1"
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        SplitContainer1.Panel2.PerformLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents cblinpacitados As CheckedListBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtpersonas As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument

End Class
