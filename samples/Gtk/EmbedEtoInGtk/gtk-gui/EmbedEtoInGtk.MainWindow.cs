
// This file has been generated by the GUI designer. Do not modify.
namespace EmbedEtoInGtk
{
	public partial class MainWindow
	{
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget EmbedEtoInGtk.MainWindow
			this.Name = "EmbedEtoInGtk.MainWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 423;
			this.DefaultHeight = 312;
			this.Show ();
			this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		}
	}
}
