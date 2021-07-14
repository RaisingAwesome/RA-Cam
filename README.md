# RACam

The RA-Cam, or Raising Awesome Camera, is a Raspberry Pi Zero W based smart camera application/framework for the home.  It applies various Visual AI techniques to auto snapshot images and send alerts.  It also auto detects other Ra-Cam's automatically on your network.

For full build info, visit our blog at Element14:  https://www.element14.com/community/community/project14/photography/blog/2021/07/11/just-a-test-troubleshooting-posting-issues

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

# OPENCV
## Install it for cpp:
```
# Install minimal prerequisites (Ubuntu 18.04 as reference)
sudo apt update && sudo apt install -y cmake g++ wget unzip
# Download and unpack sources
wget -O opencv.zip https://github.com/opencv/opencv/archive/master.zip
unzip opencv.zip
# Create build directory
mkdir -p build && cd build
# Configure
cmake  ../opencv-master
# Build
cmake --build .
```
## .Net 5:
After getting dotnet installed, do the following in the RA-Cam directory:
```
dotnet add package OpenCV.Net --version 3.3.1
```

# Video General Stuff
## To rotate 180, use the default driver parameters:
```
v4l2-ctl --set-ctrl vertical_flip=1
v4l2-ctl --set-ctrl horizontal_flip=1
```
