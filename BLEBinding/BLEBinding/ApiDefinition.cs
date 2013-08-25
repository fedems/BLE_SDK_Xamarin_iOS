using System;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.CoreBluetooth;

namespace BLE {

	[BaseType(typeof(NSObject))]
	[Model]
	public partial interface BLEDelegate {

		[Export ("bleDidConnect")]
		void BleDidConnect ();

		[Export ("bleDidDisconnect")]
		void BleDidDisconnect ();

		[Export ("bleDidUpdateRSSI:")]
		void BleDidUpdateRSSI (NSNumber rssi);

		[Export ("bleDidReceiveData:length:")]
		void BleDidReceiveData (IntPtr data, int length);
	}

	[BaseType (typeof (NSObject))]
	//public partial interface BLE : CBCentralManagerDelegate, CBPeripheralDelegate {
	public partial interface BLE {

		[Export ("delegate")]
		BLEDelegate Delegate { get; set; }

		[Export ("delegate", ArgumentSemantic.Assign)]
		[NullAllowed]
		 NSObject WeakDelegate { get; set; }

		[Export ("peripherals")]
		NSMutableArray Peripherals { get; set; }

		[Export ("CM")]
		CBCentralManager CM { get; set; }

		[Export ("activePeripheral")]
		CBPeripheral ActivePeripheral { get; set; }

		[Export ("enableWrite")]
		void EnableWrite ();

		[Export ("enableReadNotification:")]
		void EnableReadNotification (CBPeripheral p);

		[Export ("read")]
		void Read ();

		[Export ("writeValue:characteristicUUID:p:data:")]
		void WriteValue (CBUUID serviceUUID, CBUUID characteristicUUID, CBPeripheral p, NSData data);

		[Export ("readLibVer")]
		UInt16 ReadLibVer { get; }

		[Export ("readFrameworkVersion")]
		UInt16 ReadFrameworkVersion { get; }

		[Export ("readVendorName")]
		string ReadVendorName { get; }

		[Export ("isConnected")]
		bool IsConnected { get; }

		[Export ("readRSSI")]
		int ReadRSSI { get; }

		[Export ("write:")]
		void Write (NSData d);

		[Export ("controlSetup:")]
		int ControlSetup (int s);

		[Export ("findBLEPeripherals:")]
		int FindBLEPeripherals (int timeout);

		[Export ("connectPeripheral:")]
		void ConnectPeripheral (CBPeripheral peripheral);

		[Export ("swap:")]
		UInt16 Swap (UInt16 s);

		[Export ("centralManagerStateToString:")]
		string CentralManagerStateToString (int state);

		[Export ("scanTimer:")]
		void ScanTimer (NSTimer timer);

		[Export ("printKnownPeripherals")]
		void PrintKnownPeripherals ();

		[Export ("printPeripheralInfo:")]
		void PrintPeripheralInfo (CBPeripheral peripheral);

		[Export ("getAllServicesFromPeripheral:")]
		void GetAllServicesFromPeripheral (CBPeripheral p);

		[Export ("getAllCharacteristicsFromPeripheral:")]
		void GetAllCharacteristicsFromPeripheral (CBPeripheral p);

		[Export ("findServiceFromUUID:p:")]
		CBService FindServiceFromUUID (CBUUID UUID, CBPeripheral p);

		[Export ("findCharacteristicFromUUID:service:")]
		CBCharacteristic FindCharacteristicFromUUID (CBUUID UUID, CBService service);

		[Export ("UUIDToString:")]
		string UUIDToString (CBUUID UUID);

		[Export ("CBUUIDToString:")]
		string CBUUIDToString (CBUUID UUID);

		[Export ("compareCBUUID:UUID2:")]
		int CompareCBUUID (CBUUID UUID1, CBUUID UUID2);

		[Export ("compareCBUUIDToInt:UUID2:")]
		int CompareCBUUIDToInt (CBUUID UUID1, UInt16 UUID2);

		[Export ("CBUUIDToInt:")]
		UInt16 CBUUIDToInt (CBUUID UUID);

		[Export ("UUIDSAreEqual:u2:")]
		int UUIDSAreEqual (CBUUID u1, CBUUID u2);
	}
}
