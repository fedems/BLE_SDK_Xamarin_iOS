// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace BLETest
{
	[Register ("BLETestViewController")]
	partial class BLETestViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIButton btnConectar { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel lblAnalogIn { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton lblBoton2 { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel lblRSSI { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel lblStatus { get; set; }

		[Outlet]
		MonoTouch.UIKit.UISegmentedControl swStatus { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (btnConectar != null) {
				btnConectar.Dispose ();
				btnConectar = null;
			}

			if (lblAnalogIn != null) {
				lblAnalogIn.Dispose ();
				lblAnalogIn = null;
			}

			if (lblBoton2 != null) {
				lblBoton2.Dispose ();
				lblBoton2 = null;
			}

			if (lblRSSI != null) {
				lblRSSI.Dispose ();
				lblRSSI = null;
			}

			if (lblStatus != null) {
				lblStatus.Dispose ();
				lblStatus = null;
			}

			if (swStatus != null) {
				swStatus.Dispose ();
				swStatus = null;
			}
		}
	}
}
