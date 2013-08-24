using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libBLESDK.a", LinkTarget.Simulator | LinkTarget.ArmV7, ForceLoad = true)]
