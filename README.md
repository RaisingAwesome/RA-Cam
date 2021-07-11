# RACam

This is the beginning of the repository for the Raising Awesome Smart Cam project.  It will apply various Visual AI techniques.

# Build a Pi:

   1. Get a Raspberry Pi Zero and blank 16 Gig SD Card
   2. Build with the Raspberry Pi Imager Software
   3. Remove the sD card from the PC and reinsert to activate the readable SD drive.
   4. Make the Pi SSH ready and on your wifi upon first use (aka headless):
      Create an empty file titled ssh and put on the PC's SD card drive.
      Create a file named wpa_supplicant.conf with the following in it:

```
country=US
ctrl_interface=DIR=/var/run/wpa_supplicant GROUP=netdev
update_config=1
network={
ssid="WIFI_SSID"
scan_ssid=1
psk="WIFI_PASSWORD"
key_mgmt=WPA-PSK
}
```

   **_NOTE:_** Only 2.4Ghz WiFi connections are compatible with RPi's!  A 5Ghz will not work.

# RTPSERVER
## Install the RTP Server:
   <https://sylvaindurand.org/surveillance-camera-with-raspberry-pi/>
```
sudo apt-get update
sudo apt-get install #catch up everything
sudo apt-get install git #if you haven't already got it
sudo apt-get install cmake liblog4cpp5-dev libv4l-dev
git clone https://github.com/mpromonet/v4l2rtspserver.git
cd v4l2rtspserver/
cmake .
make
sudo make install
```

  ./v4l2rtspserver -H 972 -W 1296 -F 15 -P 8555 /dev/video0

## To rotate 180, use the default driver parameters:
```
v4l2-ctl --set-ctrl vertical_flip=1
v4l2-ctl --set-ctrl horizontal_flip=1
```

# C# APPROACH
After getting dotnet installed, do the following in the RA-Cam directory:
```
dotnet add package OpenCV.Net --version 3.3.1
```
