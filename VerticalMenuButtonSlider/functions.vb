Module functions
#Region "Button-SLider"
    Friend SliderSender As Control
    Friend Sub PanelSlider(ByVal slider As Control, ByVal sliderTimer As Timer)
        Dim Ypos = SliderSender.Location.Y
        Dim JumpSize = 10
        Dim HorizontalPosition = 0
        If slider.Location.Y < Ypos Then
            Dim btwn = Ypos - slider.Location.Y
            If btwn < JumpSize Then
                slider.Location = New Point(HorizontalPosition, Ypos)
            Else
                slider.Location = New Point(HorizontalPosition, slider.Location.Y + JumpSize)
            End If
        End If
        If slider.Location.Y > Ypos Then
            Dim btwn = slider.Location.Y - Ypos
            If btwn < JumpSize Then
                slider.Location = New Point(HorizontalPosition, Ypos)
            Else
                slider.Location = New Point(HorizontalPosition, slider.Location.Y - JumpSize)
            End If
        End If
        If slider.Location.Y = Ypos Then
            sliderTimer.Stop()
        End If
    End Sub

    Friend Sub PanelSlider2(ByVal slider As Control, ByVal sliderTimer As Timer)
        Dim Xpos = SliderSender.Location.X
        Dim JumpSize = 10
        Dim VerticalPosition = 39
        If slider.Location.X < Xpos Then
            Dim btwn = Xpos - slider.Location.X
            If btwn < JumpSize Then
                slider.Location = New Point(Xpos, VerticalPosition)
            Else
                slider.Location = New Point(slider.Location.X + JumpSize, VerticalPosition)
            End If
        End If
        If slider.Location.X > Xpos Then
            Dim btwn = slider.Location.X - Xpos
            If btwn < JumpSize Then
                slider.Location = New Point(Xpos, VerticalPosition)
            Else
                slider.Location = New Point(slider.Location.X - JumpSize, VerticalPosition)
            End If
        End If
        If slider.Location.Y = Xpos Then
            sliderTimer.Stop()
        End If
    End Sub

#End Region
    Friend Sub StartTimer(ByVal tm As Timer)
        tm.Enabled = True
        tm.Start()
    End Sub
End Module
