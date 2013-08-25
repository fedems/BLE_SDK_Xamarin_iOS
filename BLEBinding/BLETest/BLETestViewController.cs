using System;
using System.Drawing;
using System.Runtime.InteropServices;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using BLE;

namespace BLETest
{
	public partial class BLETestViewController : UIViewController
	{
		private BLE.BLE _ble = new BLE.BLE();  
		private BLEHandleDelegate _delegado;
		private MonoTouch.CoreBluetooth.CBPeripheral _disp;
		private NSData dat2;
		private byte[] buf2;

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
			_ble.ControlSetup (1);
			//_delegado = new BLEHandleDelegate (this); 				- with Strong delegate
			//_ble.Delegate = _delegado;								- with Strong delegate
			_ble.WeakDelegate = this;									  //- with Weak delegate

			btnConectar.TouchDown += delegate {
				_ble.FindBLEPeripherals(2);
				NSTimer timer = NSTimer.CreateScheduledTimer((float) 2.0,() => AfterTimer());
			};

			lblBoton2.TouchDown += delegate {
				sendAnalogIn();
			};
		
			Console.WriteLine ("Termina ViewDidLoad");
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
			Console.WriteLine ("Termina timer");
		}

		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations
			return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
		}

		// Send and retrieve data methods

		/* Send command to Arduino to enable analog reading */
		void sendAnalogIn()
		{
			buf2 = new byte[] {0xA0, 0x00, 0x00};
		
			buf2[1] = 0x01; // Analog Input Pin - On (Pin A5)
			dat2 = NSData.FromArray(buf2);
			_ble.Write(dat2);
		}

		/* Send command to Arduino to enable digital writing */
		void sendDigitalIn()
		{
			byte[] buf= {0x01, 0x00, 0x00};

			buf[1] = 0x00; // Digital Output Pin - Ox01 (Pin 4) or Digital Input Pin - 0x00 (Pin 5)
			NSData data = NSData.FromArray(buf);
			_ble.Write(data);
		}

		// PWM slide will call this to send its value to Arduino
		void sendPWM()
		{
			byte[] buf= {0x02, 0x00, 0x00};

			NSData data = NSData.FromArray(buf);
			_ble.Write(data);
		}

		// Servo slider will call this to send its value to Arduino
		void sendServo()
		{
			byte[] buf= {0x03, 0x00, 0x00};

			NSData data = NSData.FromArray(buf);
			_ble.Write(data);
		}

		// Weak delegate - methods

		[Export("bleDidConnect")]
		public void BleDidConnect ()
		{
			btnConectar.SetTitle("Desconectar",UIControlState.Normal);
			lblStatus.Text = "Conectado a: \n\t\t\t\t\t" + _disp.Name + " :ID: " + _disp.UUID.ToString();
			Console.WriteLine("Framework Version: " + _ble.ReadFrameworkVersion.ToString());
			Console.WriteLine("Lib Version: " + _ble.ReadLibVer.ToString());
			Console.WriteLine("Vendor name: " + _ble.ReadVendorName.ToString());
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
		public void BleDidReceiveData(IntPtr data, int length)
		{
			byte[] datos = new byte[3];
			Marshal.Copy(data, datos, 0, 3);

			// parse data, all commands are in 3-byte
			for (int i=0; i<length; i+=3) 
			{
				if (datos [i] == 0x0A) 
				{
					if (datos [i + 1] == 0x01)
						swStatus.SelectedSegment = 0;
					else
						swStatus.SelectedSegment = 1;
				} 
				else if (datos [i] == 0x0B) 
				{
					int Value;

					Value = datos [i + 2] | datos [i + 1] << 8;
					lblAnalogIn.Text = "Analog Input:  \t" + Value.ToString();
				}
			}
		}

	}
}
