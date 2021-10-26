Public Class Form1
    Dim cambio As Integer = 0
    Dim intento As Integer = 5
    Dim sum As Integer = 0
    Dim letter As Integer = 0
    Dim nombres() As String = {"pizza", "zapato", "BMW", "USA"}

    Private Sub cargarpalabra()
        'contador para cambiar de palabras
        cambio = cambio + 2
        lblcambio.Text = cambio

        'dependiendo del contador se visualizan los recuadros dependiendo de la palabra
        If lblcambio.Text = 2 Then
            'pizza
            txt1.Visible = True
            txt2.Visible = True
            txt3.Visible = True
            txt4.Visible = True
            txt5.Visible = True
        End If
        If lblcambio.Text = 4 Then
            'zapato
            txt1.Visible = True
            txt2.Visible = True
            txt3.Visible = True
            txt4.Visible = True
            txt5.Visible = True
            txt6.Visible = True
        End If
        If lblcambio.Text = 6 Then
            'BMW
            txt1.Visible = True
            txt2.Visible = True
            txt3.Visible = True
            txt4.Visible = False
            txt5.Visible = False
            txt6.Visible = False
        End If
        If lblcambio.Text = 8 Then
            'USA
            txt1.Visible = True
            txt2.Visible = True
            txt3.Visible = True
            txt4.Visible = False
            txt5.Visible = False
            txt6.Visible = False


        End If


    End Sub

    Private Sub ahorcado()
        If lblcambio.Text = 2 Then
            sum = 0
            'pizza
            If btnA.Enabled = False Then
                txt5.Text = "A"
                sum = sum + 2

            End If
            If btnZ.Enabled = False Then
                txt3.Text = "Z"
                txt4.Text = "Z"
                sum = sum + 2

            End If
            If btnP.Enabled = False Then
                txt1.Text = "P"
                sum = sum + 2

            End If
            If btnI.Enabled = False Then
                txt2.Text = "I"
                sum = sum + 2

            End If
            If sum = 8 Then
                MsgBox("Felicidades Campeon  ", vbInformation, "A_H_O_R_C_A_D_O_")
                deshabilitar()
                btnew.Visible = True
            End If

        End If
        If lblcambio.Text = 4 Then
            sum = 0
            'zapato
            If btnA.Enabled = False Then
                txt2.Text = "A"
                txt4.Text = "A"
                sum = sum + 2
            End If
            If btnZ.Enabled = False Then
                txt1.Text = "Z"
                sum = sum + 2
            End If
            If btnP.Enabled = False Then
                txt3.Text = "P"
                sum = sum + 2
            End If
            If btnT.Enabled = False Then
                txt5.Text = "T"
                sum = sum + 2
            End If
            If btnO.Enabled = False Then
                txt6.Text = "O"
                sum = sum + 2
            End If
            If sum = 10 Then
                MsgBox("Felicidades Campeon  ", vbInformation, "A_H_O_R_C_A_D_O_")
                deshabilitar()
                btnew.Visible = True
            End If
        End If
        If lblcambio.Text = 6 Then
            sum = 0
            'BMW
            If btnB.Enabled = False Then
                txt1.Text = "B"
                sum = sum + 2
            End If
            If btnM.Enabled = False Then
                txt2.Text = "M"
                sum = sum + 2
            End If
            If btnW.Enabled = False Then
                txt3.Text = "W"
                sum = sum + 2
            End If
            If sum = 6 Then
                MsgBox("Felicidades Campeon  ", vbInformation, "A_H_O_R_C_A_D_O_")
                deshabilitar()
                btnew.Visible = True
            End If
        End If

        Dim salir As String

        If lblcambio.Text = 8 Then
            sum = 0
            'USA
            If btnU.Enabled = False Then
                txt1.Text = "U"
                sum = sum + 2
            End If
            If btnS.Enabled = False Then
                txt2.Text = "S"
                sum = sum + 2
            End If
            If btnA.Enabled = False Then
                txt3.Text = "A"
                sum = sum + 2
            End If
            If sum = 6 Then
                MsgBox("Felicidades Campeon  ", vbInformation, "A_H_O_R_C_A_D_O_")
                deshabilitar()

                salir = MsgBox("Terminaste el juego del ahorcado " + vbNewLine + "¿Desea jugar otra vez?  ", vbQuestion + vbYesNo, "A_H_O_R_C_A_D_O_")
                If salir = vbYes Then
                    cambio = 0
                    btnew.Visible = True
                Else
                    Me.Close()
                End If
            End If
        End If
    End Sub

    Private Sub gameover()
        If intento = 4 Then
            pb0.Visible = False
            pb1.Visible = True
            pb2.Visible = False
            pb3.Visible = False
            pb4.Visible = False
            pb5.Visible = False
        End If
        If intento = 3 Then
            pb0.Visible = False
            pb1.Visible = False
            pb2.Visible = True
            pb3.Visible = False
            pb4.Visible = False
            pb5.Visible = False
        End If
        If intento = 2 Then
            pb0.Visible = False
            pb1.Visible = False
            pb2.Visible = False
            pb3.Visible = True
            pb4.Visible = False
            pb5.Visible = False
        End If
        If intento = 1 Then
            pb0.Visible = False
            pb1.Visible = False
            pb2.Visible = False
            pb3.Visible = False
            pb4.Visible = True
            pb5.Visible = False
        End If
        If intento = 0 Then
            pb0.Visible = False
            pb1.Visible = False
            pb2.Visible = False
            pb3.Visible = False
            pb4.Visible = False
            pb5.Visible = True
            MsgBox("GAME OVER  ", vbCritical, "A_H_O_R_C_A_D_O_")
            Me.Close()
        End If

    End Sub
    Private Sub intento1()
        If cambio = 2 Then
            intento = intento - 1
            lblint.Text = intento
        End If

        gameover()
    End Sub
    Private Sub intento2()
        If cambio = 4 Then
            intento = intento - 1
            lblint.Text = intento
        End If
        gameover()
    End Sub
    Private Sub intento3()
        If cambio = 6 Then
            intento = intento - 1
            lblint.Text = intento
        End If
        gameover()
    End Sub
    Private Sub intento4()
        If cambio = 8 Then
            intento = intento - 1
            lblint.Text = intento
        End If

        gameover()
    End Sub

    Private Sub reinicioltr()
        txt1.Text = "___"
        txt2.Text = "___"
        txt3.Text = "___"
        txt4.Text = "___"
        txt5.Text = "___"
        txt6.Text = "___"
    End Sub

    Private Sub habilitarbtn()
        btnA.Enabled = True
        btnB.Enabled = True
        btnC.Enabled = True
        btnD.Enabled = True
        btnE.Enabled = True
        btnF.Enabled = True
        btnG.Enabled = True
        btnH.Enabled = True
        btnI.Enabled = True
        btnJ.Enabled = True
        btnK.Enabled = True
        btnL.Enabled = True
        btnM.Enabled = True
        btnN.Enabled = True
        btnO.Enabled = True
        btnP.Enabled = True
        btnQ.Enabled = True
        btnR.Enabled = True
        btnS.Enabled = True
        btnT.Enabled = True
        btnU.Enabled = True
        btnV.Enabled = True
        btnW.Enabled = True
        btnX.Enabled = True
        btnY.Enabled = True
        btnZ.Enabled = True

    End Sub
    Private Sub deshabilitar()
        btnA.Enabled = False
        btnB.Enabled = False
        btnC.Enabled = False
        btnD.Enabled = False
        btnE.Enabled = False
        btnF.Enabled = False
        btnG.Enabled = False
        btnH.Enabled = False
        btnI.Enabled = False
        btnJ.Enabled = False
        btnK.Enabled = False
        btnL.Enabled = False
        btnM.Enabled = False
        btnN.Enabled = False
        btnO.Enabled = False
        btnP.Enabled = False
        btnQ.Enabled = False
        btnR.Enabled = False
        btnS.Enabled = False
        btnT.Enabled = False
        btnU.Enabled = False
        btnV.Enabled = False
        btnW.Enabled = False
        btnX.Enabled = False
        btnY.Enabled = False
        btnZ.Enabled = False

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnpista.Visible = False
        lblcambio.Text = cambio
        lblint.Text = intento
        Label2.Text = nombres(0).Length


        txt1.Visible = False
        txt2.Visible = False
        txt3.Visible = False
        txt4.Visible = False
        txt5.Visible = False
        txt6.Visible = False



    End Sub

    Private Sub btnew_Click(sender As Object, e As EventArgs) Handles btnew.Click

        btnew.Visible = False

        btnpista2.Visible = True
        btnpista2.Enabled = True
        intento = 5
        lblint.Text = 5

        pb0.Visible = True
        pb1.Visible = False
        pb2.Visible = False
        pb3.Visible = False
        pb4.Visible = False
        pb5.Visible = False

        habilitarbtn()
        cargarpalabra()
        reinicioltr()


    End Sub

    Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
        btnA.Enabled = False
        ahorcado()
        intento3()
    End Sub

    Private Sub btnB_Click(sender As Object, e As EventArgs) Handles btnB.Click
        btnB.Enabled = False
        ahorcado()
        intento1()
        intento2()
        intento4()
        intento4()
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        btnC.Enabled = False
        intento1()
        intento2()
        intento3()
        intento4()
    End Sub

    Private Sub btnD_Click(sender As Object, e As EventArgs) Handles btnD.Click
        btnD.Enabled = False
        intento1()
        intento2()
        intento3()
        intento4()
    End Sub

    Private Sub btnE_Click(sender As Object, e As EventArgs) Handles btnE.Click
        btnE.Enabled = False
        intento1()
        intento2()
        intento3()
        intento4()
    End Sub

    Private Sub btnF_Click(sender As Object, e As EventArgs) Handles btnF.Click
        btnF.Enabled = False
        intento1()
        intento2()
        intento3()
        intento4()
    End Sub

    Private Sub btnG_Click(sender As Object, e As EventArgs) Handles btnG.Click
        btnG.Enabled = False
        intento1()
        intento2()
        intento3()
        intento4()
    End Sub

    Private Sub btnH_Click(sender As Object, e As EventArgs) Handles btnH.Click
        btnH.Enabled = False
        intento1()
        intento2()
        intento3()
        intento4()
    End Sub

    Private Sub btnI_Click(sender As Object, e As EventArgs) Handles btnI.Click
        btnI.Enabled = False
        ahorcado()
        intento2()
        intento3()
        intento4()
    End Sub

    Private Sub btnJ_Click(sender As Object, e As EventArgs) Handles btnJ.Click
        btnJ.Enabled = False
        intento1()
        intento2()
        intento3()
        intento4()
    End Sub

    Private Sub btnK_Click(sender As Object, e As EventArgs) Handles btnK.Click
        btnK.Enabled = False
        intento1()
        gameover()
        intento2()
        intento3()
        intento4()
    End Sub

    Private Sub btnL_Click(sender As Object, e As EventArgs) Handles btnL.Click
        btnL.Enabled = False
        intento1()
        intento2()
        intento3()
        intento4()
    End Sub

    Private Sub btnM_Click(sender As Object, e As EventArgs) Handles btnM.Click
        btnM.Enabled = False
        ahorcado()
        intento1()
        intento2()
        intento4()
    End Sub

    Private Sub btnN_Click(sender As Object, e As EventArgs) Handles btnN.Click
        btnN.Enabled = False
        intento1()
        intento2()
        intento3()
        intento4()
    End Sub

    Private Sub btnO_Click(sender As Object, e As EventArgs) Handles btnO.Click
        btnO.Enabled = False
        ahorcado()
        intento1()
        intento3()
        intento4()
    End Sub

    Private Sub btnP_Click(sender As Object, e As EventArgs) Handles btnP.Click
        btnP.Enabled = False
        ahorcado()
        intento3()
        intento4()
    End Sub

    Private Sub btnQ_Click(sender As Object, e As EventArgs) Handles btnQ.Click
        btnQ.Enabled = False
        intento1()
        intento2()
        intento3()
        intento4()
    End Sub

    Private Sub btnR_Click(sender As Object, e As EventArgs) Handles btnR.Click
        btnR.Enabled = False
        intento1()
        intento2()
        intento3()
        intento4()
    End Sub

    Private Sub btnS_Click(sender As Object, e As EventArgs) Handles btnS.Click
        btnS.Enabled = False
        ahorcado()
        intento1()
        intento2()
        intento3()

    End Sub

    Private Sub btnT_Click(sender As Object, e As EventArgs) Handles btnT.Click
        btnT.Enabled = False
        ahorcado()
        intento1()
        intento3()
        intento4()
    End Sub

    Private Sub btnU_Click(sender As Object, e As EventArgs) Handles btnU.Click
        btnU.Enabled = False
        ahorcado()
        intento1()
        intento2()
        intento3()
    End Sub

    Private Sub btnV_Click(sender As Object, e As EventArgs) Handles btnV.Click
        btnV.Enabled = False
        intento1()
        intento2()
        intento3()
        intento4()
    End Sub

    Private Sub btnW_Click(sender As Object, e As EventArgs) Handles btnW.Click
        btnW.Enabled = False
        ahorcado()
        intento1()
        intento2()
        intento4()
    End Sub

    Private Sub btnX_Click(sender As Object, e As EventArgs) Handles btnX.Click
        btnX.Enabled = False
        intento1()
        intento2()
        intento3()
        intento4()
    End Sub

    Private Sub btnY_Click(sender As Object, e As EventArgs) Handles btnY.Click
        btnY.Enabled = False
        intento1()
        intento2()
        intento3()
        intento4()
    End Sub

    Private Sub btnZ_Click(sender As Object, e As EventArgs) Handles btnZ.Click
        btnZ.Enabled = False
        ahorcado()
        intento3()
        intento4()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnpista.Click

        btnpista.Visible = False
        btnpista.Enabled = False

        intento = intento - 1
        lblint.Text = intento

        If lblcambio.Text = 2 Then
            letter = nombres(0).Length
            MsgBox("Comida rapida", vbInformation, "A_H_O_R_C_A_D_O_")
        End If
        If lblcambio.Text = 4 Then
            letter = nombres(1).Length
            MsgBox("Prenda de vestir", vbInformation, "A_H_O_R_C_A_D_O_")
        End If
        If lblcambio.Text = 6 Then
            letter = nombres(2).Length
            MsgBox("Marca de coche ", vbInformation, "A_H_O_R_C_A_D_O_")
        End If
        If lblcambio.Text = 8 Then
            letter = nombres(3).Length
            MsgBox("Pais primer mundista ", vbInformation, "A_H_O_R_C_A_D_O_")
        End If
    End Sub

    Private Sub btnpista2_Click(sender As Object, e As EventArgs) Handles btnpista2.Click
        btnpista2.Visible = False
        btnpista2.Enabled = False

        btnpista.Visible = True
        btnpista.Enabled = True

        intento = intento - 1
        lblint.Text = intento

        If lblcambio.Text = 2 Then
            letter = nombres(0).Length
            MsgBox("Tiene " & letter & " letras", vbInformation, "A_H_O_R_C_A_D_O_")
        End If
        If lblcambio.Text = 4 Then
            letter = nombres(1).Length
            MsgBox("Tiene " & letter & " letras", vbInformation, "A_H_O_R_C_A_D_O_")
        End If
        If lblcambio.Text = 6 Then
            letter = nombres(2).Length
            MsgBox("Tiene " & letter & " letras", vbInformation, "A_H_O_R_C_A_D_O_")
        End If
        If lblcambio.Text = 8 Then
            letter = nombres(3).Length
            MsgBox("Tiene " & letter & " letras", vbInformation, "A_H_O_R_C_A_D_O_")
        End If
    End Sub
End Class
