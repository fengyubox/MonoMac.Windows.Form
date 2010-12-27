using System;
using MonoMac.AppKit;
namespace System.Windows.Forms
{
	public partial class Label : TextBox
	{
		public Label ()
		{
			m_helper.Selectable = false;
			m_helper.Editable = false;
			//this.Font = NSFont.FromFontName ("Arial", 10);
			m_helper.Bordered = false;
		}
		public bool AutoSize { get; set; }

		public override string Text {
			get { return base.Text; }
			set {
				base.Text = value;
				resize ();
			}
		}
		/*
		public override bool AcceptsFirstResponder ()
		{
			return false;
		}
		*/
		private void resize ()
		{
			if (!AutoSize)
				return;
			m_helper.SizeToFit ();
		}
	}
}
