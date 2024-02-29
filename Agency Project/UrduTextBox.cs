/*
 * Author: Muhammad Mobeen Movania
 * Last modified: 9 June 2007
 * 
 * This product is provided as is without any implied warranty
 * Use it at your own risk.
 * You may use this in a product provided that you keep this notice
 * and the Author tag above and also provide the author name in your
 * application somewhere ideally in the about box. 
 * If you feel you have improved it, please let me know at mobeen211@yahoo.com
 * so that others may benefit from it. 
 * */
using System;
using System.Text;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace UrduTextBoxDemo
{
	/// <summary>
	/// A simple UrduTextBox Control for C# by Muhammad Mobeen Movania
	/// </summary>
	
	public class UrduTextBox : System.Windows.Forms.TextBox
	{
		//used to keep track of keystrokes handled by us
		private bool handled = false;
		
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public UrduTextBox()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			this.RightToLeft = RightToLeft.Yes;			
		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
		}
		#endregion

		#region Urdutextbox custom code
		protected override void OnKeyPress(KeyPressEventArgs e)
		{		
			//Move the caret to the end of text				
			this.SelectionStart = this.Text.Length;

			e.Handled=handled;
			
			//We handle only the required keys checked in the key down event
			//the rest are passed to the parent
			if(!handled)
				base.OnKeyPress (e);						
		}		

		protected override void OnKeyDown(KeyEventArgs e)
		{	
			//Set the handled flag only if we are handlign a keystroke
			handled = (e.KeyCode== Keys.Space || e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.Decimal || e.KeyCode == Keys.OemQuestion || e.KeyCode == Keys.OemPipe || e.KeyCode == Keys.OemBackslash ||e.KeyCode == Keys.OemSemicolon ||e.KeyCode ==Keys.OemQuotes 	|| e.KeyCode ==	Keys.OemOpenBrackets || e.KeyCode == Keys.OemCloseBrackets ) ||
				(e.KeyCode >= Keys.D0 && e.KeyCode<=Keys.D9) || (e.KeyCode>= Keys.A && e.KeyCode<= Keys.Z);
			
			//Get the text from our textbox and store it in a string builder
			StringBuilder sb = new StringBuilder(this.Text);				

			//Append appropriate letter to our textbox based on the key pressed
			switch(e.KeyCode)
			{
				case Keys.D0:
					sb.Append("\u0660");
					break;

				case Keys.D1:
					sb.Append("\u0661");
					break;

				case Keys.D2:
					sb.Append("\u0662");
					break;

				case Keys.D3:
					sb.Append("\u0663");
					break;

				case Keys.D4:
					sb.Append("\u0664");
					break;

				case Keys.D5:
					sb.Append("\u0665");
					break;

				case Keys.D6:
					sb.Append("\u0666");
					break;

				case Keys.D7:
					sb.Append("\u0667");
					break;

				case Keys.D8:
					sb.Append("\u0668");
					break;

				case Keys.D9:
					sb.Append("\u0669");
					break;		
				
				case Keys.Space:
					sb.Append(" \u200c");							
					break;

				case Keys.A:
					sb.Append(((e.Shift)?"\u0622":"\u0627"));					
					break;

				case Keys.B:
					sb.Append(((e.Shift)?"\u0613":"\u0628"));
					break;

				case Keys.C:
					sb.Append(((e.Shift)?"\u062b":"\u0686"));					
					break;

				case Keys.D:
					sb.Append(((e.Shift)?"\u0688":"\u062f"));					
					break;

				case Keys.E:
					sb.Append(((e.Shift)?"\u0610":"\u0639"));					
					break;

				case Keys.F:
					sb.Append("\u0641");
					break;

				case Keys.G:
					sb.Append(((e.Shift)?"\u063a":"\u06af"));
					break;

				case Keys.H:
					sb.Append(((e.Shift)?"\u062d":"\u06be"));//0647 also
					break;

				case Keys.I:
					sb.Append("\u06cc");//0649 also
					break;

				case Keys.J:
					sb.Append(((e.Shift)?"\u0636":"\u062c"));					
					break;

				case Keys.K:
					sb.Append(((e.Shift)?"\u062e":"\u0643"));
					break;
				
				case Keys.L:
					sb.Append(((e.Shift)?"\u0612":"\u0644"));					
					break;

				case Keys.M:
					sb.Append("\u0645");					
					break;

				case Keys.N:
					sb.Append(((e.Shift)?"\u06ba":"\u0646"));					
					break;

				case Keys.O:					
					sb.Append(((e.Shift)?"\u0629":"\u06c1"));
					break;

				case Keys.P:
					sb.Append(((e.Shift)?"\u0645":"\u067e"));//paish
					break;
					
				case Keys.Q:
					sb.Append("\u0642");
					break;

				case Keys.R:
					sb.Append(((e.Shift)?"\u0691":"\u0631"));					
					break;
					
				case Keys.S:
					sb.Append(((e.Shift)?"\u0635":"\u0633"));					
					break;
				
				case Keys.T:
					sb.Append(((e.Shift)?"\u0679":"\u062a"));
					break;

				case Keys.U:
					sb.Append("\u0621");
					break;

				case Keys.V:
					sb.Append(((e.Shift)?"\u0638":"\u0637"));					
					break;

				case Keys.W:
					sb.Append(((e.Shift)?"\u0635\u0644\u0649\u0020\u0627\u0644\u0644\u0647\u0020\u0639\u0644\u064a\u0647\u0020\u0648\u0633\u0644\u0645":"\u0648"));
					break;

				case Keys.X:
					sb.Append(((e.Shift)?"\u0698":"\u0634"));					
					break;

				case Keys.Y:
					sb.Append("\u06d2");
					break;
				
				case Keys.Z:
					sb.Append(((e.Shift)?"\u0630":"\u0632"));
					break;
			
				case Keys.Decimal:
					sb.Append("\u06d4");	
					break;

				case Keys.Oemcomma:
					sb.Append("\u060c");
					break;
								 
				case Keys.OemQuestion:
					sb.Append("\u061f");					
					break;

				case Keys.OemPipe:
					sb.Append("\u06d4");					
					break;

				case Keys.OemBackslash:
					sb.Append("\u0602");					
					break;
							
				case Keys.OemSemicolon:
					sb.Append("\u061b");					
					break;

				case Keys.OemQuotes:
					sb.Append("\u0022");
					break;

				case Keys.OemOpenBrackets:					
					sb.Append("\u007b");
					break;

				case Keys.OemCloseBrackets:					
					sb.Append("\u007d");
					break;
			}		
			
			//Set the text to our textbox from the string builder
			this.Text = sb.ToString();
		}
		#endregion
	}
}
