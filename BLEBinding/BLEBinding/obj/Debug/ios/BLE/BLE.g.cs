//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using MonoTouch;
using MonoTouch.CoreFoundation;
using MonoTouch.CoreMedia;
using MonoTouch.CoreMotion;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;
using MonoTouch.CoreAnimation;
using MonoTouch.CoreLocation;
using MonoTouch.MapKit;
using MonoTouch.UIKit;
using MonoTouch.CoreGraphics;
using MonoTouch.NewsstandKit;
using MonoTouch.GLKit;
using MonoTouch.CoreVideo;
using OpenTK;

namespace BLE {
	[Register("BLE", true)]
	public unsafe partial class BLE : NSObject {
		[CompilerGenerated]
		const string selDelegate = "delegate";
		static readonly IntPtr selDelegateHandle = Selector.GetHandle ("delegate");
		[CompilerGenerated]
		const string selSetDelegate_ = "setDelegate:";
		static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle ("setDelegate:");
		[CompilerGenerated]
		const string selPeripherals = "peripherals";
		static readonly IntPtr selPeripheralsHandle = Selector.GetHandle ("peripherals");
		[CompilerGenerated]
		const string selSetPeripherals_ = "setPeripherals:";
		static readonly IntPtr selSetPeripherals_Handle = Selector.GetHandle ("setPeripherals:");
		[CompilerGenerated]
		const string selCM = "CM";
		static readonly IntPtr selCMHandle = Selector.GetHandle ("CM");
		[CompilerGenerated]
		const string selSetCM_ = "setCM:";
		static readonly IntPtr selSetCM_Handle = Selector.GetHandle ("setCM:");
		[CompilerGenerated]
		const string selActivePeripheral = "activePeripheral";
		static readonly IntPtr selActivePeripheralHandle = Selector.GetHandle ("activePeripheral");
		[CompilerGenerated]
		const string selSetActivePeripheral_ = "setActivePeripheral:";
		static readonly IntPtr selSetActivePeripheral_Handle = Selector.GetHandle ("setActivePeripheral:");
		[CompilerGenerated]
		const string selReadLibVer = "readLibVer";
		static readonly IntPtr selReadLibVerHandle = Selector.GetHandle ("readLibVer");
		[CompilerGenerated]
		const string selReadFrameworkVersion = "readFrameworkVersion";
		static readonly IntPtr selReadFrameworkVersionHandle = Selector.GetHandle ("readFrameworkVersion");
		[CompilerGenerated]
		const string selReadVendorName = "readVendorName";
		static readonly IntPtr selReadVendorNameHandle = Selector.GetHandle ("readVendorName");
		[CompilerGenerated]
		const string selIsConnected = "isConnected";
		static readonly IntPtr selIsConnectedHandle = Selector.GetHandle ("isConnected");
		[CompilerGenerated]
		const string selReadRSSI = "readRSSI";
		static readonly IntPtr selReadRSSIHandle = Selector.GetHandle ("readRSSI");
		[CompilerGenerated]
		const string selEnableWrite = "enableWrite";
		static readonly IntPtr selEnableWriteHandle = Selector.GetHandle ("enableWrite");
		[CompilerGenerated]
		const string selEnableReadNotification_ = "enableReadNotification:";
		static readonly IntPtr selEnableReadNotification_Handle = Selector.GetHandle ("enableReadNotification:");
		[CompilerGenerated]
		const string selRead = "read";
		static readonly IntPtr selReadHandle = Selector.GetHandle ("read");
		[CompilerGenerated]
		const string selWriteValueCharacteristicUUIDPData_ = "writeValue:characteristicUUID:p:data:";
		static readonly IntPtr selWriteValueCharacteristicUUIDPData_Handle = Selector.GetHandle ("writeValue:characteristicUUID:p:data:");
		[CompilerGenerated]
		const string selWrite_ = "write:";
		static readonly IntPtr selWrite_Handle = Selector.GetHandle ("write:");
		[CompilerGenerated]
		const string selControlSetup_ = "controlSetup:";
		static readonly IntPtr selControlSetup_Handle = Selector.GetHandle ("controlSetup:");
		[CompilerGenerated]
		const string selFindBLEPeripherals_ = "findBLEPeripherals:";
		static readonly IntPtr selFindBLEPeripherals_Handle = Selector.GetHandle ("findBLEPeripherals:");
		[CompilerGenerated]
		const string selConnectPeripheral_ = "connectPeripheral:";
		static readonly IntPtr selConnectPeripheral_Handle = Selector.GetHandle ("connectPeripheral:");
		[CompilerGenerated]
		const string selSwap_ = "swap:";
		static readonly IntPtr selSwap_Handle = Selector.GetHandle ("swap:");
		[CompilerGenerated]
		const string selCentralManagerStateToString_ = "centralManagerStateToString:";
		static readonly IntPtr selCentralManagerStateToString_Handle = Selector.GetHandle ("centralManagerStateToString:");
		[CompilerGenerated]
		const string selScanTimer_ = "scanTimer:";
		static readonly IntPtr selScanTimer_Handle = Selector.GetHandle ("scanTimer:");
		[CompilerGenerated]
		const string selPrintKnownPeripherals = "printKnownPeripherals";
		static readonly IntPtr selPrintKnownPeripheralsHandle = Selector.GetHandle ("printKnownPeripherals");
		[CompilerGenerated]
		const string selPrintPeripheralInfo_ = "printPeripheralInfo:";
		static readonly IntPtr selPrintPeripheralInfo_Handle = Selector.GetHandle ("printPeripheralInfo:");
		[CompilerGenerated]
		const string selGetAllServicesFromPeripheral_ = "getAllServicesFromPeripheral:";
		static readonly IntPtr selGetAllServicesFromPeripheral_Handle = Selector.GetHandle ("getAllServicesFromPeripheral:");
		[CompilerGenerated]
		const string selGetAllCharacteristicsFromPeripheral_ = "getAllCharacteristicsFromPeripheral:";
		static readonly IntPtr selGetAllCharacteristicsFromPeripheral_Handle = Selector.GetHandle ("getAllCharacteristicsFromPeripheral:");
		[CompilerGenerated]
		const string selFindServiceFromUUIDP_ = "findServiceFromUUID:p:";
		static readonly IntPtr selFindServiceFromUUIDP_Handle = Selector.GetHandle ("findServiceFromUUID:p:");
		[CompilerGenerated]
		const string selFindCharacteristicFromUUIDService_ = "findCharacteristicFromUUID:service:";
		static readonly IntPtr selFindCharacteristicFromUUIDService_Handle = Selector.GetHandle ("findCharacteristicFromUUID:service:");
		[CompilerGenerated]
		const string selUUIDToString_ = "UUIDToString:";
		static readonly IntPtr selUUIDToString_Handle = Selector.GetHandle ("UUIDToString:");
		[CompilerGenerated]
		const string selCBUUIDToString_ = "CBUUIDToString:";
		static readonly IntPtr selCBUUIDToString_Handle = Selector.GetHandle ("CBUUIDToString:");
		[CompilerGenerated]
		const string selCompareCBUUIDUUID2_ = "compareCBUUID:UUID2:";
		static readonly IntPtr selCompareCBUUIDUUID2_Handle = Selector.GetHandle ("compareCBUUID:UUID2:");
		[CompilerGenerated]
		const string selCompareCBUUIDToIntUUID2_ = "compareCBUUIDToInt:UUID2:";
		static readonly IntPtr selCompareCBUUIDToIntUUID2_Handle = Selector.GetHandle ("compareCBUUIDToInt:UUID2:");
		[CompilerGenerated]
		const string selCBUUIDToInt_ = "CBUUIDToInt:";
		static readonly IntPtr selCBUUIDToInt_Handle = Selector.GetHandle ("CBUUIDToInt:");
		[CompilerGenerated]
		const string selUUIDSAreEqualU2_ = "UUIDSAreEqual:u2:";
		static readonly IntPtr selUUIDSAreEqualU2_Handle = Selector.GetHandle ("UUIDSAreEqual:u2:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("BLE");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public BLE () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.Init);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.Init);
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public BLE (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.InitWithCoder, coder.Handle);
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public BLE (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public BLE (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("enableWrite")]
		[CompilerGenerated]
		public virtual void EnableWrite ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selEnableWriteHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selEnableWriteHandle);
			}
		}
		
		[Export ("enableReadNotification:")]
		[CompilerGenerated]
		public virtual void EnableReadNotification (global::MonoTouch.CoreBluetooth.CBPeripheral p)
		{
			if (p == null)
				throw new ArgumentNullException ("p");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selEnableReadNotification_Handle, p.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selEnableReadNotification_Handle, p.Handle);
			}
		}
		
		[Export ("read")]
		[CompilerGenerated]
		public virtual void Read ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selReadHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selReadHandle);
			}
		}
		
		[Export ("writeValue:characteristicUUID:p:data:")]
		[CompilerGenerated]
		public virtual void WriteValue (global::MonoTouch.CoreBluetooth.CBUUID serviceUUID, global::MonoTouch.CoreBluetooth.CBUUID characteristicUUID, global::MonoTouch.CoreBluetooth.CBPeripheral p, NSData data)
		{
			if (serviceUUID == null)
				throw new ArgumentNullException ("serviceUUID");
			if (characteristicUUID == null)
				throw new ArgumentNullException ("characteristicUUID");
			if (p == null)
				throw new ArgumentNullException ("p");
			if (data == null)
				throw new ArgumentNullException ("data");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, selWriteValueCharacteristicUUIDPData_Handle, serviceUUID.Handle, characteristicUUID.Handle, p.Handle, data.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, selWriteValueCharacteristicUUIDPData_Handle, serviceUUID.Handle, characteristicUUID.Handle, p.Handle, data.Handle);
			}
		}
		
		[Export ("write:")]
		[CompilerGenerated]
		public virtual void Write (NSData d)
		{
			if (d == null)
				throw new ArgumentNullException ("d");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selWrite_Handle, d.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selWrite_Handle, d.Handle);
			}
		}
		
		[Export ("controlSetup:")]
		[CompilerGenerated]
		public virtual int ControlSetup (int s)
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend_int (this.Handle, selControlSetup_Handle, s);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper_int (this.SuperHandle, selControlSetup_Handle, s);
			}
		}
		
		[Export ("findBLEPeripherals:")]
		[CompilerGenerated]
		public virtual int FindBLEPeripherals (int timeout)
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend_int (this.Handle, selFindBLEPeripherals_Handle, timeout);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper_int (this.SuperHandle, selFindBLEPeripherals_Handle, timeout);
			}
		}
		
		[Export ("connectPeripheral:")]
		[CompilerGenerated]
		public virtual void ConnectPeripheral (global::MonoTouch.CoreBluetooth.CBPeripheral peripheral)
		{
			if (peripheral == null)
				throw new ArgumentNullException ("peripheral");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selConnectPeripheral_Handle, peripheral.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selConnectPeripheral_Handle, peripheral.Handle);
			}
		}
		
		[Export ("swap:")]
		[CompilerGenerated]
		public virtual global::System.UInt16 Swap (global::System.UInt16 s)
		{
			if (IsDirectBinding) {
				return ApiDefinition.Messaging.UInt16_objc_msgSend_UInt16 (this.Handle, selSwap_Handle, s);
			} else {
				return ApiDefinition.Messaging.UInt16_objc_msgSendSuper_UInt16 (this.SuperHandle, selSwap_Handle, s);
			}
		}
		
		[Export ("centralManagerStateToString:")]
		[CompilerGenerated]
		public virtual string CentralManagerStateToString (int state)
		{
			if (IsDirectBinding) {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_int (this.Handle, selCentralManagerStateToString_Handle, state));
			} else {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_int (this.SuperHandle, selCentralManagerStateToString_Handle, state));
			}
		}
		
		[Export ("scanTimer:")]
		[CompilerGenerated]
		public virtual void ScanTimer (NSTimer timer)
		{
			if (timer == null)
				throw new ArgumentNullException ("timer");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selScanTimer_Handle, timer.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selScanTimer_Handle, timer.Handle);
			}
		}
		
		[Export ("printKnownPeripherals")]
		[CompilerGenerated]
		public virtual void PrintKnownPeripherals ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selPrintKnownPeripheralsHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selPrintKnownPeripheralsHandle);
			}
		}
		
		[Export ("printPeripheralInfo:")]
		[CompilerGenerated]
		public virtual void PrintPeripheralInfo (global::MonoTouch.CoreBluetooth.CBPeripheral peripheral)
		{
			if (peripheral == null)
				throw new ArgumentNullException ("peripheral");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selPrintPeripheralInfo_Handle, peripheral.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selPrintPeripheralInfo_Handle, peripheral.Handle);
			}
		}
		
		[Export ("getAllServicesFromPeripheral:")]
		[CompilerGenerated]
		public virtual void GetAllServicesFromPeripheral (global::MonoTouch.CoreBluetooth.CBPeripheral p)
		{
			if (p == null)
				throw new ArgumentNullException ("p");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selGetAllServicesFromPeripheral_Handle, p.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selGetAllServicesFromPeripheral_Handle, p.Handle);
			}
		}
		
		[Export ("getAllCharacteristicsFromPeripheral:")]
		[CompilerGenerated]
		public virtual void GetAllCharacteristicsFromPeripheral (global::MonoTouch.CoreBluetooth.CBPeripheral p)
		{
			if (p == null)
				throw new ArgumentNullException ("p");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selGetAllCharacteristicsFromPeripheral_Handle, p.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selGetAllCharacteristicsFromPeripheral_Handle, p.Handle);
			}
		}
		
		[Export ("findServiceFromUUID:p:")]
		[CompilerGenerated]
		public virtual global::MonoTouch.CoreBluetooth.CBService FindServiceFromUUID (global::MonoTouch.CoreBluetooth.CBUUID UUID, global::MonoTouch.CoreBluetooth.CBPeripheral p)
		{
			if (UUID == null)
				throw new ArgumentNullException ("UUID");
			if (p == null)
				throw new ArgumentNullException ("p");
			if (IsDirectBinding) {
				return (global::MonoTouch.CoreBluetooth.CBService) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selFindServiceFromUUIDP_Handle, UUID.Handle, p.Handle));
			} else {
				return (global::MonoTouch.CoreBluetooth.CBService) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selFindServiceFromUUIDP_Handle, UUID.Handle, p.Handle));
			}
		}
		
		[Export ("findCharacteristicFromUUID:service:")]
		[CompilerGenerated]
		public virtual global::MonoTouch.CoreBluetooth.CBCharacteristic FindCharacteristicFromUUID (global::MonoTouch.CoreBluetooth.CBUUID UUID, global::MonoTouch.CoreBluetooth.CBService service)
		{
			if (UUID == null)
				throw new ArgumentNullException ("UUID");
			if (service == null)
				throw new ArgumentNullException ("service");
			if (IsDirectBinding) {
				return (global::MonoTouch.CoreBluetooth.CBCharacteristic) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selFindCharacteristicFromUUIDService_Handle, UUID.Handle, service.Handle));
			} else {
				return (global::MonoTouch.CoreBluetooth.CBCharacteristic) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selFindCharacteristicFromUUIDService_Handle, UUID.Handle, service.Handle));
			}
		}
		
		[Export ("UUIDToString:")]
		[CompilerGenerated]
		public virtual string UUIDToString (global::MonoTouch.CoreBluetooth.CBUUID UUID)
		{
			if (UUID == null)
				throw new ArgumentNullException ("UUID");
			if (IsDirectBinding) {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selUUIDToString_Handle, UUID.Handle));
			} else {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selUUIDToString_Handle, UUID.Handle));
			}
		}
		
		[Export ("CBUUIDToString:")]
		[CompilerGenerated]
		public virtual string CBUUIDToString (global::MonoTouch.CoreBluetooth.CBUUID UUID)
		{
			if (UUID == null)
				throw new ArgumentNullException ("UUID");
			if (IsDirectBinding) {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selCBUUIDToString_Handle, UUID.Handle));
			} else {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selCBUUIDToString_Handle, UUID.Handle));
			}
		}
		
		[Export ("compareCBUUID:UUID2:")]
		[CompilerGenerated]
		public virtual int CompareCBUUID (global::MonoTouch.CoreBluetooth.CBUUID UUID1, global::MonoTouch.CoreBluetooth.CBUUID UUID2)
		{
			if (UUID1 == null)
				throw new ArgumentNullException ("UUID1");
			if (UUID2 == null)
				throw new ArgumentNullException ("UUID2");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend_IntPtr_IntPtr (this.Handle, selCompareCBUUIDUUID2_Handle, UUID1.Handle, UUID2.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selCompareCBUUIDUUID2_Handle, UUID1.Handle, UUID2.Handle);
			}
		}
		
		[Export ("compareCBUUIDToInt:UUID2:")]
		[CompilerGenerated]
		public virtual int CompareCBUUIDToInt (global::MonoTouch.CoreBluetooth.CBUUID UUID1, global::System.UInt16 UUID2)
		{
			if (UUID1 == null)
				throw new ArgumentNullException ("UUID1");
			if (IsDirectBinding) {
				return ApiDefinition.Messaging.int_objc_msgSend_IntPtr_UInt16 (this.Handle, selCompareCBUUIDToIntUUID2_Handle, UUID1.Handle, UUID2);
			} else {
				return ApiDefinition.Messaging.int_objc_msgSendSuper_IntPtr_UInt16 (this.SuperHandle, selCompareCBUUIDToIntUUID2_Handle, UUID1.Handle, UUID2);
			}
		}
		
		[Export ("CBUUIDToInt:")]
		[CompilerGenerated]
		public virtual global::System.UInt16 CBUUIDToInt (global::MonoTouch.CoreBluetooth.CBUUID UUID)
		{
			if (UUID == null)
				throw new ArgumentNullException ("UUID");
			if (IsDirectBinding) {
				return ApiDefinition.Messaging.UInt16_objc_msgSend_IntPtr (this.Handle, selCBUUIDToInt_Handle, UUID.Handle);
			} else {
				return ApiDefinition.Messaging.UInt16_objc_msgSendSuper_IntPtr (this.SuperHandle, selCBUUIDToInt_Handle, UUID.Handle);
			}
		}
		
		[Export ("UUIDSAreEqual:u2:")]
		[CompilerGenerated]
		public virtual int UUIDSAreEqual (global::MonoTouch.CoreBluetooth.CBUUID u1, global::MonoTouch.CoreBluetooth.CBUUID u2)
		{
			if (u1 == null)
				throw new ArgumentNullException ("u1");
			if (u2 == null)
				throw new ArgumentNullException ("u2");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend_IntPtr_IntPtr (this.Handle, selUUIDSAreEqualU2_Handle, u1.Handle, u2.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selUUIDSAreEqualU2_Handle, u1.Handle, u2.Handle);
			}
		}
		
		[CompilerGenerated]
		object __mt_Delegate_var;
		[CompilerGenerated]
		public virtual BLEDelegate Delegate {
			[Export ("delegate")]
			get {
				BLEDelegate ret;
				if (IsDirectBinding) {
					ret = (BLEDelegate) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDelegateHandle));
				} else {
					ret = (BLEDelegate) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDelegateHandle));
				}
				MarkDirty ();
				__mt_Delegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDelegate_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDelegate_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_Delegate_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_WeakDelegate_var;
		[CompilerGenerated]
		public virtual NSObject WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Assign)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDelegateHandle));
				} else {
					ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDelegateHandle));
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDelegate_Handle, value == null ? IntPtr.Zero : value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDelegate_Handle, value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_Peripherals_var;
		[CompilerGenerated]
		public virtual NSMutableArray Peripherals {
			[Export ("peripherals")]
			get {
				NSMutableArray ret;
				if (IsDirectBinding) {
					ret = (NSMutableArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPeripheralsHandle));
				} else {
					ret = (NSMutableArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selPeripheralsHandle));
				}
				MarkDirty ();
				__mt_Peripherals_var = ret;
				return ret;
			}
			
			[Export ("setPeripherals:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetPeripherals_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetPeripherals_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_Peripherals_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_CM_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.CoreBluetooth.CBCentralManager CM {
			[Export ("CM")]
			get {
				global::MonoTouch.CoreBluetooth.CBCentralManager ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.CoreBluetooth.CBCentralManager) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCMHandle));
				} else {
					ret = (global::MonoTouch.CoreBluetooth.CBCentralManager) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selCMHandle));
				}
				MarkDirty ();
				__mt_CM_var = ret;
				return ret;
			}
			
			[Export ("setCM:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetCM_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetCM_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_CM_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_ActivePeripheral_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.CoreBluetooth.CBPeripheral ActivePeripheral {
			[Export ("activePeripheral")]
			get {
				global::MonoTouch.CoreBluetooth.CBPeripheral ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.CoreBluetooth.CBPeripheral) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selActivePeripheralHandle));
				} else {
					ret = (global::MonoTouch.CoreBluetooth.CBPeripheral) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selActivePeripheralHandle));
				}
				MarkDirty ();
				__mt_ActivePeripheral_var = ret;
				return ret;
			}
			
			[Export ("setActivePeripheral:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetActivePeripheral_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetActivePeripheral_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_ActivePeripheral_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt16 ReadLibVer {
			[Export ("readLibVer")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt16_objc_msgSend (this.Handle, selReadLibVerHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt16_objc_msgSendSuper (this.SuperHandle, selReadLibVerHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt16 ReadFrameworkVersion {
			[Export ("readFrameworkVersion")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt16_objc_msgSend (this.Handle, selReadFrameworkVersionHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt16_objc_msgSendSuper (this.SuperHandle, selReadFrameworkVersionHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string ReadVendorName {
			[Export ("readVendorName")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selReadVendorNameHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selReadVendorNameHandle));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsConnected {
			[Export ("isConnected")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsConnectedHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsConnectedHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int ReadRSSI {
			[Export ("readRSSI")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selReadRSSIHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selReadRSSIHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Delegate_var = null;
				__mt_WeakDelegate_var = null;
				__mt_Peripherals_var = null;
				__mt_CM_var = null;
				__mt_ActivePeripheral_var = null;
			}
		}
	} /* class BLE */
}
