

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If lstTaille.SelectedItem Is Nothing Then
            MessageBox.Show("Veuillez sélectionner une taille de pizza.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Dim taille = lstTaille.SelectedItem.ToString
        Dim ingredient = ""
        If rdProp1.Checked Then
            ingredient = " Croute fine"
        ElseIf rdProp2.Checked Then
            ingredient = " Croute Classique"
        ElseIf rdProp3.Checked Then
            ingredient = " Croute épaisse"
        Else
            MessageBox.Show("Veuillez sélectionner un type de croûte.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Dim IngrSupp = ""

        If ChkProp1.Checked Then
            If IngrSupp <> "" Then IngrSupp &= ", "
            IngrSupp &= "Champignons"

        End If

        If ChkProp2.Checked Then
            If IngrSupp <> "" Then IngrSupp &= ", "
            IngrSupp &= "Olives"
        End If
        If ChkProp3.Checked Then
            If IngrSupp <> "" Then IngrSupp &= ", "
            IngrSupp &= "Poivrons"

        End If
        If ChkProp4.Checked Then
            If IngrSupp <> "" Then IngrSupp &= ", "
            IngrSupp &= "Fromage supplémentaire"

        End If
        If IngrSupp = "" Then
            IngrSupp = "Aucun ingrédient supplémentaire sélectionné"

        End If
        Dim recapitulatif = "Récapitulatif de la commande:" & Environment.NewLine
        recapitulatif &= "Taille de la pizza : " & taille & Environment.NewLine
        recapitulatif &= "Type de croûte : " & ingredient & Environment.NewLine
        recapitulatif &= "Ingrédients supplémentaires : " & IngrSupp
        label4.Text = recapitulatif



    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTaille.SelectedIndexChanged
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rdProp1.Checked = False
        rdProp2.Checked = False
        rdProp3.Checked = False
        ChkProp1.Checked = False
        ChkProp2.Checked = False
        ChkProp3.Checked = False
        ChkProp4.Checked = False
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles label4.Click

    End Sub

End Class
