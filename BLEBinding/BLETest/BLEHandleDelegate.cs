using System;
using BLE;
using MonoTouch.UIKit;

namespace BLETest
{

	// Strong delegate class
	public class BLEHandleDelegate:BLEDelegate
	{
		private UIViewController _parent;
		public BLEHandleDelegate (UIViewController parent)
		{
			parent = _parent;
		}

		public override void BleDidConnect ()
		{
			// NOTE: Don't call the base implementation on a Model class
			// see http://docs.xamarin.com/ios/tutorials/Events%2c_Protocols_and_Delegates 
			Console.WriteLine ("Conectado..."); 
//			throw new NotImplementedException ();
		}

		public override void BleDidUpdateRSSI (MonoTouch.Foundation.NSNumber rssi)
		{
			// NOTE: Don't call the base implementation on a Model class
			// see http://docs.xamarin.com/ios/tutorials/Events%2c_Protocols_and_Delegates 
			Console.WriteLine ("RSSO acutalizado... " + rssi.ToString() );
//			throw new NotImplementedException ();
		}

		public override void BleDidDisconnect ()
		{
			// NOTE: Don't call the base implementation on a Model class
			// see http://docs.xamarin.com/ios/tutorials/Events%2c_Protocols_and_Delegates 
			Console.WriteLine ("Desconectado...");
//			throw new NotImplementedException ();
		}
	}
}

