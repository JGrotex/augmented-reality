# GO Mirror
Home Smart-Mirror Project using some IoT Flogo for Status updates 

![GO Mirror image](../images/goMirror.png?raw=true "GO Mirror")<br>
^ basically this was my christmas gift, for some between the years development.
<br>
Build using Unity3D, TIBCO Flogo for IoT Device Status updates running on RaspberryPi 3+<br>
Full source in Assets Folder.<br>
<br>
Unity runs in this Implementation a Webserver, that allows Screen updates, such as ...
- http://localhost:8079/api?switch=1
- http://localhost:8079/api?anim=true
- http://localhost:8079/api?text=A%20wunderfull%20day.
- http://localhost:8079/api?status=Temperature:13°C

With this simple Technology in place, I can e.g.
- switch screen view using Alexa Echo, by voice commands
- do some Unity3D animation, in case there is someone nearby the screen
- execute Screen updates on Temperature Status or Welcome Message.

more Details on Medium, soon ...
