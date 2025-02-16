Public Class DataGridViewDisableButtonCell
   Inherits DataGridViewButtonCell

   Private mEnabledValue As Boolean
   Public Property Enabled() As Boolean
      Get
         Return mEnabledValue
      End Get
      Set(ByVal value As Boolean)
         mEnabledValue = value
      End Set
   End Property

   Private mShowDisabledText As Boolean
   Public Property ShowDisabledText() As Boolean
      Get
         Return mShowDisabledText
      End Get
      Set(ByVal value As Boolean)
         mShowDisabledText = value
      End Set
   End Property

   ' Override the Clone method so that the Enabled property is copied.
   Public Overrides Function Clone() As Object
      Dim Cell As DataGridViewDisableButtonCell = CType(MyBase.Clone(), DataGridViewDisableButtonCell)
      Cell.Enabled = Me.Enabled
      Return Cell
   End Function

   ' By default, enable the button cell.
   Public Sub New()
      Me.mEnabledValue = True
      Me.mShowDisabledText = False
   End Sub

   Protected Overrides Sub Paint(ByVal graphics As Graphics, ByVal clipBounds As Rectangle, ByVal cellBounds As Rectangle, ByVal rowIndex As Integer, ByVal elementState As DataGridViewElementStates, ByVal value As Object, ByVal formattedValue As Object, ByVal errorText As String, ByVal cellStyle As DataGridViewCellStyle, ByVal advancedBorderStyle As DataGridViewAdvancedBorderStyle, ByVal paintParts As DataGridViewPaintParts)
      ' The button cell is disabled, so paint the border, background, and disabled button for the cell.
      If Not Me.mEnabledValue Then
         ' Draw the background of the cell, if specified.
         If (paintParts And DataGridViewPaintParts.Background) = DataGridViewPaintParts.Background Then
            Dim cellBackground As New SolidBrush(cellStyle.BackColor)
            graphics.FillRectangle(cellBackground, cellBounds)
            cellBackground.Dispose()
         End If

         ' Draw the cell borders, if specified.
         If (paintParts And DataGridViewPaintParts.Border) = DataGridViewPaintParts.Border Then
            PaintBorder(graphics, clipBounds, cellBounds, cellStyle, advancedBorderStyle)
         End If

         ' Calculate the area in which to draw the button.
         Dim buttonArea As Rectangle = cellBounds
         Dim buttonAdjustment As Rectangle = Me.BorderWidths(advancedBorderStyle)
         buttonArea.X += buttonAdjustment.X
         buttonArea.Y += buttonAdjustment.Y
         buttonArea.Height -= buttonAdjustment.Height
         buttonArea.Width -= buttonAdjustment.Width

         If ShowDisabledText Then
            ' Draw the disabled button.                
            ButtonRenderer.DrawButton(graphics, buttonArea, VisualStyles.PushButtonState.Disabled)

            ' Draw the disabled button text. 
            If TypeOf Me.FormattedValue Is String Then
               TextRenderer.DrawText(graphics, CStr(Me.FormattedValue), Me.DataGridView.Font, buttonArea, SystemColors.GrayText)
            End If
         End If

      Else
         ' The button cell is enabled, so let the base class 
         ' handle the painting.
         MyBase.Paint(graphics, clipBounds, cellBounds, rowIndex, elementState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts)

      End If
   End Sub
End Class