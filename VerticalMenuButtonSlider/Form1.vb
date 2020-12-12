Public Class Form1
    Private Sub lbl_closeX_Click(sender As Object, e As EventArgs) Handles lbl_closeX.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SliderSender = sender
        StartTimer(tm_slider)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SliderSender = sender
        StartTimer(tm_slider)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SliderSender = sender
        StartTimer(tm_slider)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SliderSender = sender
        StartTimer(tm_slider)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        SliderSender = sender
        StartTimer(tm_slider)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        SliderSender = sender
        StartTimer(tm_slider)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        SliderSender = sender
        StartTimer(tm_slider)
    End Sub

    Private Sub tm_slider_Tick(sender As Object, e As EventArgs) Handles tm_slider.Tick
        PanelSlider(Panel_SLiderControl, tm_slider)
    End Sub

    ' -------------------
    '  Horizontal Slider
    ' -------------------

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        SliderSender = sender
        StartTimer(tm_slider2)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        SliderSender = sender
        StartTimer(tm_slider2)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        SliderSender = sender
        StartTimer(tm_slider2)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        SliderSender = sender
        StartTimer(tm_slider2)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        SliderSender = sender
        StartTimer(tm_slider2)
    End Sub

    Private Sub tm_slider2_Tick(sender As Object, e As EventArgs) Handles tm_slider2.Tick
        PanelSlider2(Panel_SLiderControl2, tm_slider2)
    End Sub


End Class
