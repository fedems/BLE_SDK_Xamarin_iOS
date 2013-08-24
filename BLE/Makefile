XBUILD=/Applications/Xcode.app/Contents/Developer/usr/bin/xcodebuild
#BTOUCH=/Developer/MonoTouch/usr/bin/btouch
PROJECT_ROOT=.
PROJECT=$(PROJECT_ROOT)/BLE.xcodeproj
TARGET=BLE

all: libBLESDK.a

libBLE-i386.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphonesimulator -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphonesimulator/lib$(TARGET).a $@

libBLE-armv7.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch armv7 -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphoneos/lib$(TARGET).a $@

libBLESDK.a: libBLE-i386.a libBLE-armv7.a
	lipo -create -output $@ $^

clean:
	-rm -f *.a *.dll
