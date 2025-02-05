using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace POS_System
{

    class DotNetBarTabcontrol : TabControl
    {

        public DotNetBarTabcontrol()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            DoubleBuffered = true;
            SizeMode = TabSizeMode.Fixed;
            ItemSize = new Size(44, 136);
        }
        protected override void CreateHandle()
        {
            base.CreateHandle();
            Alignment = TabAlignment.Left;
        }

        public Pen ToPen(Color color)
        {
            return new Pen(color);
        }

        public Brush ToBrush(Color color)
        {
            return new SolidBrush(color);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var B = new Bitmap(Width, Height);
            var G = Graphics.FromImage(B);
            try
            {
                SelectedTab.BackColor = Color.White;
            }
            catch
            {
            }
            G.Clear(Color.White);
            G.FillRectangle(new SolidBrush(Color.FromArgb(246, 248, 252)), new Rectangle(0, 0, ItemSize.Height + 4, Height));
            // G.DrawLine(New Pen(Color.FromArgb(170, 187, 204)), New Point(Width - 1, 0), New Point(Width - 1, Height - 1))    'comment out to get rid of the borders
            // G.DrawLine(New Pen(Color.FromArgb(170, 187, 204)), New Point(ItemSize.Height + 1, 0), New Point(Width - 1, 0))                   'comment out to get rid of the borders
            // G.DrawLine(New Pen(Color.FromArgb(170, 187, 204)), New Point(ItemSize.Height + 3, Height - 1), New Point(Width - 1, Height - 1)) 'comment out to get rid of the borders
            G.DrawLine(new Pen(Color.FromArgb(170, 187, 204)), new Point(ItemSize.Height + 3, 0), new Point(ItemSize.Height + 3, 999));
            for (int i = 0, loopTo = TabCount - 1; i <= loopTo; i++)
            {
                if (i == SelectedIndex)
                {
                    var x2 = new Rectangle(new Point(GetTabRect(i).Location.X - 2, GetTabRect(i).Location.Y - 2), new Size(GetTabRect(i).Width + 3, GetTabRect(i).Height - 1));
                    var myBlend = new ColorBlend();
                    myBlend.Colors = new Color[] { Color.FromArgb(232, 232, 240), Color.FromArgb(232, 232, 240), Color.FromArgb(232, 232, 240) };
                    myBlend.Positions = new float[] { 0.0f, 0.5f, 1.0f };
                    var lgBrush = new LinearGradientBrush(x2, Color.Black, Color.Black, 90.0f);
                    lgBrush.InterpolationColors = myBlend;
                    G.FillRectangle(lgBrush, x2);
                    G.DrawRectangle(new Pen(Color.FromArgb(170, 187, 204)), x2);


                    G.SmoothingMode = SmoothingMode.HighQuality;
                    Point[] p = new Point[] { new Point(ItemSize.Height - 3, GetTabRect(i).Location.Y + 20), new Point(ItemSize.Height + 4, GetTabRect(i).Location.Y + 14), new Point(ItemSize.Height + 4, GetTabRect(i).Location.Y + 27) };
                    G.FillPolygon(Brushes.White, p);
                    G.DrawPolygon(new Pen(Color.FromArgb(170, 187, 204)), p);

                    if (ImageList is not null)
                    {
                        try
                        {
                            if (ImageList.Images[TabPages[i].ImageIndex] is not null)
                            {

                                G.DrawImage(ImageList.Images[TabPages[i].ImageIndex], new Point(x2.Location.X + 8, x2.Location.Y + 6));
                                G.DrawString("      " + TabPages[i].Text, Font, Brushes.DimGray, x2, new StringFormat() { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center });
                            }
                            else
                            {
                                G.DrawString(TabPages[i].Text, new Font(Font.FontFamily, Font.Size, FontStyle.Bold), Brushes.DimGray, x2, new StringFormat() { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center });
                            }
                        }
                        catch (Exception ex)
                        {
                            G.DrawString(TabPages[i].Text, new Font(Font.FontFamily, Font.Size, FontStyle.Bold), Brushes.DimGray, x2, new StringFormat() { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center });
                        }
                    }
                    else
                    {
                        G.DrawString(TabPages[i].Text, new Font(Font.FontFamily, Font.Size, FontStyle.Bold), Brushes.DimGray, x2, new StringFormat() { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center });
                    }

                    G.DrawLine(new Pen(Color.FromArgb(200, 200, 250)), new Point(x2.Location.X - 1, x2.Location.Y - 1), new Point(x2.Location.X, x2.Location.Y));
                    G.DrawLine(new Pen(Color.FromArgb(200, 200, 250)), new Point(x2.Location.X - 1, x2.Bottom - 1), new Point(x2.Location.X, x2.Bottom));
                }
                else
                {
                    var x2 = new Rectangle(new Point(GetTabRect(i).Location.X - 2, GetTabRect(i).Location.Y - 2), new Size(GetTabRect(i).Width + 3, GetTabRect(i).Height + 1));
                    G.FillRectangle(new SolidBrush(Color.FromArgb(246, 248, 252)), x2);
                    G.DrawLine(new Pen(Color.FromArgb(170, 187, 204)), new Point(x2.Right, x2.Top), new Point(x2.Right, x2.Bottom));
                    if (ImageList is not null)
                    {
                        try
                        {
                            if (ImageList.Images[TabPages[i].ImageIndex] is not null)
                            {
                                G.DrawImage(ImageList.Images[TabPages[i].ImageIndex], new Point(x2.Location.X + 8, x2.Location.Y + 6));
                                G.DrawString("      " + TabPages[i].Text, Font, Brushes.DimGray, x2, new StringFormat() { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center });
                            }
                            else
                            {
                                G.DrawString(TabPages[i].Text, Font, Brushes.DimGray, x2, new StringFormat() { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center });
                            }
                        }
                        catch (Exception ex)
                        {
                            G.DrawString(TabPages[i].Text, Font, Brushes.DimGray, x2, new StringFormat() { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center });
                        }
                    }
                    else
                    {
                        G.DrawString(TabPages[i].Text, Font, Brushes.DimGray, x2, new StringFormat() { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center });
                    }
                }
            }

            e.Graphics.DrawImage(B , 0, 0);
            G.Dispose();
            B.Dispose();
        }
    }
}