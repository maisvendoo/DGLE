
// This file has been generated by the GUI designer. Do not modify.
namespace Packer
{
	public partial class SupportedFormatsWindow
	{
		private global::Gtk.VBox vbox1;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.NodeView formatsView;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Packer.SupportedFormatsWindow
			this.WidthRequest = 400;
			this.HeightRequest = 300;
			this.Name = "Packer.SupportedFormatsWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("Supported Formats");
			this.TypeHint = ((global::Gdk.WindowTypeHint)(1));
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Modal = true;
			this.Decorated = false;
			// Container child Packer.SupportedFormatsWindow.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.formatsView = new global::Gtk.NodeView ();
			this.formatsView.CanFocus = true;
			this.formatsView.Name = "formatsView";
			this.GtkScrolledWindow.Add (this.formatsView);
			this.vbox1.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.GtkScrolledWindow]));
			w2.Position = 0;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 300;
			this.Hide ();
		}
	}
}
