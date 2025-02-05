using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace POS_System
{

    public class WaterMarkTextBox : TextBox
    {

        private Font oldFont = null;
        private bool waterMarkTextEnabled = false;

        #region Attributes
        private Color _waterMarkColor = Color.LightGray;

        public Color WaterMarkColor
        {
            get
            {
                return _waterMarkColor;
            }
            set
            {
                _waterMarkColor = value;
                Invalidate();
            }
        }

        private string _waterMarkText = "Water Mark";

        public string WaterMarkText
        {
            get
            {
                return _waterMarkText;
            }
            set
            {
                _waterMarkText = value;
                Invalidate();
            }
        }
        #endregion

        // Default constructor
        public WaterMarkTextBox()
        {
            JoinEvents(true);
        }

        private void JoinEvents(bool @join)
        {
            if (join)
            {
                TextChanged += WaterMark_Toggle;
                LostFocus += WaterMark_Toggle;
                FontChanged += WaterMark_FontChanged;
                // No one of the above events will start immeddiatlly 
                // TextBox control still in constructing, so,
                // Font object (for example) couldn't be catched from within WaterMark_Toggle
                // So, call WaterMark_Toggel through OnCreateControl after TextBox is totally created
                // No doupt, it will be only one time call

                // Old solution uses Timer.Tick event to check Create property
            }
        }

        private void WaterMark_Toggle(object sender, EventArgs args)
        {
            if (Text.Length <= 0)
            {
                EnableWaterMark();
            }
            else
            {
                DisableWaterMark();
            }
        }

        private void WaterMark_FontChanged(object sender, EventArgs args)
        {
            if (waterMarkTextEnabled)
            {
                oldFont = new Font(Font.FontFamily, Font.Size, Font.Style, Font.Unit);
                Refresh();
            }
        }

        private void EnableWaterMark()
        {
            // Save current font until returning the UserPaint style to false (NOTE: It is a try and error advice)
            oldFont = new Font(Font.FontFamily, Font.Size, Font.Style, Font.Unit);

            // Enable OnPaint Event Handler
            SetStyle(ControlStyles.UserPaint, true);
            waterMarkTextEnabled = true;

            // Trigger OnPaint immediatly
            Refresh();

        }

        private void DisableWaterMark()
        {
            // Disbale OnPaint event handler
            waterMarkTextEnabled = false;
            SetStyle(ControlStyles.UserPaint, false);

            // Return oldFont if existed
            if (oldFont is not null)
            {
                Font = new Font(Font.FontFamily, Font.Size, Font.Style, Font.Unit);
            }
        }

        // Override OnCreateControl 
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            WaterMark_Toggle(null, null);
        }

        // Override OnPaint
        protected override void OnPaint(PaintEventArgs e)
        {
            // Use the same font that was defined in base class
            var drawFont = new Font(Font.FontFamily, Font.Size, Font.Style, Font.Unit);
            // Create new brush with gray color or 
            var drawBrush = new SolidBrush(WaterMarkColor); // use WaterMarkColor
                                                            // Draw Test or WaterMark
            e.Graphics.DrawString(Interaction.IIf(waterMarkTextEnabled, WaterMarkText, Text).ToString(), drawFont, drawBrush, new Point(0, 0));
            base.OnPaint(e);
        }

    }
}