# RACam

This is the beginning of the repository for the Raising Awesome Smart Cam project.  It will apply various Visual AI techniques.

Install the RTP Server:
  sudo apt-get install cmake liblog4cpp5-dev libv4l-dev
  git clone https://github.com/mpromonet/v4l2rtspserver.git
  cd v4l2rtspserver/
  cmake .
  make
  sudo make install


To rotate 180, use the default driver parameters:
v4l2-ctl --set-ctrl vertical_flip=1
v4l2-ctl --set-ctrl horizontal_flip=1
