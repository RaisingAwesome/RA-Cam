cd /home/sjmill01/RA-Cam
sudo systemctl stop kestrel-ra-cam
sudo /usr/local/bin/dotnet/dotnet publish -o /var/www/ra-cam
sudo systemctl start kestrel-ra-cam

