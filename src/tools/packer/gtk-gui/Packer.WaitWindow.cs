
// This file has been generated by the GUI designer. Do not modify.
namespace Packer
{
	public partial class WaitWindow
	{
		private global::Gtk.VBox vbox1;
		private global::Gtk.Image imgAnimation;
		private global::Gtk.Label lFile;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Packer.WaitWindow
			this.WidthRequest = 200;
			this.HeightRequest = 200;
			this.Name = "Packer.WaitWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("Packer");
			this.TypeHint = ((global::Gdk.WindowTypeHint)(4));
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Modal = true;
			this.Resizable = false;
			// Container child Packer.WaitWindow.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			this.vbox1.BorderWidth = ((uint)(6));
			// Container child vbox1.Gtk.Box+BoxChild
			this.imgAnimation = new global::Gtk.Image ();
			this.imgAnimation.Name = "imgAnimation";
			this.vbox1.Add (this.imgAnimation);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.imgAnimation]));
			w1.Position = 0;
			// Container child vbox1.Gtk.Box+BoxChild
			this.lFile = new global::Gtk.Label ();
			this.lFile.Name = "lFile";
			this.lFile.LabelProp = global::Mono.Unix.Catalog.GetString ("File");
			this.lFile.Ellipsize = ((global::Pango.EllipsizeMode)(2));
			this.vbox1.Add (this.lFile);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.lFile]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 200;
			this.DefaultHeight = 200;
			this.Hide ();
		}
	}
}
