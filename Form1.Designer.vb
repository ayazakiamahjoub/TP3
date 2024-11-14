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
        lstTaille = New ComboBox()
        rdProp1 = New RadioButton()
        rdProp2 = New RadioButton()
        rdProp3 = New RadioButton()
        Label1 = New Label()
        ChkProp1 = New CheckBox()
        ChkProp2 = New CheckBox()
        ChkProp3 = New CheckBox()
        ChkProp4 = New CheckBox()
        Button1 = New Button()
        Label2 = New Label()
        Label3 = New Label()
        label4 = New Label()
        SuspendLayout()
        ' 
        ' lstTaille
        ' 
        lstTaille.Font = New Font("Segoe UI Emoji", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lstTaille.FormattingEnabled = True
        lstTaille.Items.AddRange(New Object() {"petite", "moyenne", "grande"})
        lstTaille.Location = New Point(72, 55)
        lstTaille.Name = "lstTaille"
        lstTaille.Size = New Size(299, 39)
        lstTaille.TabIndex = 0
        lstTaille.Text = "La taille de pizza "
        ' 
        ' rdProp1
        ' 
        rdProp1.AutoSize = True
        rdProp1.Font = New Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rdProp1.Location = New Point(72, 184)
        rdProp1.Name = "rdProp1"
        rdProp1.Size = New Size(117, 24)
        rdProp1.TabIndex = 1
        rdProp1.TabStop = True
        rdProp1.Text = "Croute fine"
        rdProp1.UseVisualStyleBackColor = True
        ' 
        ' rdProp2
        ' 
        rdProp2.AutoSize = True
        rdProp2.Font = New Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rdProp2.Location = New Point(72, 233)
        rdProp2.Name = "rdProp2"
        rdProp2.Size = New Size(159, 24)
        rdProp2.TabIndex = 2
        rdProp2.TabStop = True
        rdProp2.Text = "Croute classique"
        rdProp2.UseVisualStyleBackColor = True
        ' 
        ' rdProp3
        ' 
        rdProp3.AutoSize = True
        rdProp3.Font = New Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rdProp3.Location = New Point(72, 279)
        rdProp3.Name = "rdProp3"
        rdProp3.Size = New Size(145, 24)
        rdProp3.TabIndex = 3
        rdProp3.TabStop = True
        rdProp3.Text = "Croute épaisse"
        rdProp3.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(72, 129)
        Label1.Name = "Label1"
        Label1.Size = New Size(171, 31)
        Label1.TabIndex = 4
        Label1.Text = "Type de croute"
        ' 
        ' ChkProp1
        ' 
        ChkProp1.AutoSize = True
        ChkProp1.Font = New Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ChkProp1.Location = New Point(463, 184)
        ChkProp1.Name = "ChkProp1"
        ChkProp1.Size = New Size(137, 24)
        ChkProp1.TabIndex = 5
        ChkProp1.Text = "Champignons"
        ChkProp1.UseVisualStyleBackColor = True
        ' 
        ' ChkProp2
        ' 
        ChkProp2.AutoSize = True
        ChkProp2.Font = New Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ChkProp2.Location = New Point(463, 224)
        ChkProp2.Name = "ChkProp2"
        ChkProp2.Size = New Size(79, 24)
        ChkProp2.TabIndex = 6
        ChkProp2.Text = "Olives"
        ChkProp2.UseVisualStyleBackColor = True
        ' 
        ' ChkProp3
        ' 
        ChkProp3.AutoSize = True
        ChkProp3.Font = New Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ChkProp3.Location = New Point(463, 268)
        ChkProp3.Name = "ChkProp3"
        ChkProp3.Size = New Size(101, 24)
        ChkProp3.TabIndex = 7
        ChkProp3.Text = "Poivrons"
        ChkProp3.UseVisualStyleBackColor = True
        ' 
        ' ChkProp4
        ' 
        ChkProp4.AutoSize = True
        ChkProp4.Font = New Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ChkProp4.Location = New Point(463, 315)
        ChkProp4.Name = "ChkProp4"
        ChkProp4.Size = New Size(227, 24)
        ChkProp4.TabIndex = 8
        ChkProp4.Text = "Fromage supplémentaire"
        ChkProp4.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.SteelBlue
        Button1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(262, 333)
        Button1.Name = "Button1"
        Button1.Size = New Size(133, 43)
        Button1.TabIndex = 9
        Button1.Text = "afficher"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(447, 129)
        Label2.Name = "Label2"
        Label2.Size = New Size(176, 31)
        Label2.TabIndex = 10
        Label2.Text = "Les ingrédients"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(275, 434)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 20)
        Label3.TabIndex = 11
        ' 
        ' label4
        ' 
        label4.BackColor = Color.LightBlue
        label4.Location = New Point(110, 394)
        label4.Name = "label4"
        label4.Size = New Size(472, 149)
        label4.TabIndex = 12
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(800, 552)
        Controls.Add(label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(ChkProp4)
        Controls.Add(ChkProp3)
        Controls.Add(ChkProp2)
        Controls.Add(ChkProp1)
        Controls.Add(Label1)
        Controls.Add(rdProp3)
        Controls.Add(rdProp2)
        Controls.Add(rdProp1)
        Controls.Add(lstTaille)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lstTaille As ComboBox
    Friend WithEvents rdProp1 As RadioButton
    Friend WithEvents rdProp2 As RadioButton
    Friend WithEvents rdProp3 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents ChkProp1 As CheckBox
    Friend WithEvents ChkProp2 As CheckBox
    Friend WithEvents ChkProp3 As CheckBox
    Friend WithEvents ChkProp4 As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents label4 As Label

End Class
