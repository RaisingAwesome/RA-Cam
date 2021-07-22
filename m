cd /home/pi/RA-Cam
sudo systemctl stop kestrel-ra-cam
dotnet publish -o /var/www/ra-cam
sudo systemctl start kestrel-ra-cam

