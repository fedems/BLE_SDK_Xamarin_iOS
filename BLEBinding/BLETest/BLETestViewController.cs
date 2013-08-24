using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using BLE;

namespace BLETest
{
	public partial class BLETestViewController : UIViewController
	{
		private BLE.BLE _ble;  
		private BLEHandleDelegate _delegado;
		private MonoTouch.CoreBluetooth.CBPeripheral _disp;

		public BLETestViewController () : base ("BLETestViewController", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// UI elements initialization
			lblStatus.Text = "Desconectado";
			lblRSSI.Text = "RSSI: 0";
			swStatus.SelectedSegment = 1;
			swStatus.Enabled = false;

			// BLE inititialization
			_ble = new BLE.BLE();
			_ble.ControlSetup (1);
			//_delegado = new BLEHandleDelegate (this); 				- with Strong delegate
			//_ble.Delegate = _delegado;								- with Strong delegate
			_ble.WeakDelegate = this;									  //- with Weak delegate

			btnConectar.TouchDown += delegate {
				_ble.FindBLEPeripherals(2);
				NSTimer timer = NSTimer.CreateScheduledTimer((float) 2.0,() => AfterTimer());
			};

			// Perform any additional setup after loading the view, typically from a nib.
		}

		public void AfterTimer()
		{
			if (_ble.IsConnected) 
			{
				_ble.CM.CancelPeripheralConnection(_disp);
			}
			else
			{
				// If any device was found -> Connecto to 1st one on the list ID0
				if (_ble.Peripherals.Count > 0) 
				{
					// No. devices found
					Console.WriteLine ("Disp encontrados:" + _ble.Peripherals.Count);

					_disp = new MonoTouch.CoreBluetooth.CBPeripheral (_ble.Peripherals.ValueAt (0));

					// Device debug information
					Console.WriteLine (_disp.Description);
					Console.WriteLine (_disp.Name);
					//Console.WriteLine (_disp.UUID);

					// Connect to device
					_ble.ConnectPeripheral(_disp);
				}
			}
		}

		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations
			return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
		}

		// Weak delegate - methods

		[Export("bleDidConnect")]
		public void BleDidConnect ()
		{
			btnConectar.SetTitle("Desconectar",UIControlState.Normal);
			lblStatus.Text = "Conectado a: \n\t\t\t\t\t" + _disp.Name + " :ID: " + _disp.UUID.ToString();
		}

		[Export("bleDidDisconnect")]
		public void BleDidDisconnect ()
		{
			btnConectar.SetTitle("Conectar",UIControlState.Normal);
			lblStatus.Text = "Desconectado";
			lblRSSI.Text = "RSSI : 0";
		}

		[Export("bleDidUpdateRSSI:")]
		public void BleDidUpdateRSSI (MonoTouch.Foundation.NSNumber rssi)
		{
			lblRSSI.Text = "RSSI : " + rssi.ToString();
		}

		[Export("bleDidReceiveData:length:")]
		public void BleDidReceiveData(string data, int length)
		{
			Console.WriteLine ("Length :  %d", length);

			// parse data, all commands are in 3-byte
			for (int i=0; i<length; i+=3) {
				Console.WriteLine ("0x%02X, 0x%02X, 0x%02X", data [i], data [i + 1], data [i + 2]);

				if (data [i] == 0x0A) 
				{
					if (data [i + 1] == 0x01)
						swStatus.SelectedSegment = 0;
					else
						swStatus.SelectedSegment = 1;
				} 
				else if (data [i] == 0x0B) 
				{
					int Value;

					Value = data [i + 2] | data [i + 1] << 8;
					lblAnalogIn.Text = "Analog Input:  \t" + Value.ToString();
				}
			}
		}

	}
}
