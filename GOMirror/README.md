# GO Mirror
Home Smart-Mirror Project using some IoT [TIBCO Flogo.io](http://www.flogo.io/) for real time Status updates.

![GO Mirror image](../images/goMirror.png?raw=true "GO Mirror")<br>
> basically this was my Christmas gift, for some between the years development.

## Implemenation
Build using Unity3D, TIBCO Flogo for IoT Device Status updates running on RaspberryPi 3+<br>
Full Unity source in Assets Folder.<br>

![GO Mirror Animation](../images/goMirror.gif?raw=true "GO Mirror animation")<br>
> Unity Animation in case someone is nearby the Mirror.

## Unity Webserver
Central Area in the Implemenation is the Webserver and the Objects it can modify:

![GO Mirror API](../images/api-script.png?raw=true "GO Mirror API")<br>

Unity runs in this Implementation a Webserver, that allows Screen updates, such as ...
- http://localhost:8079/api?switch=1
- http://localhost:8079/api?anim=true
- http://localhost:8079/api?text=A%20wunderfull%20day.
- http://localhost:8079/api?status=Temperature:13°C

## Features
With this simple Technology in place, you can e.g.
- switch screen view using Alexa Echo, by voice commands (executed via Flogo as well)
- do some Unity3D animation, in case there is someone nearby the screen/mirror
- execute Screen updates on Temperature Status or Welcome Messages
- Flogo on RaspberryPi is also resonsable for switching off the Screen over night

<br><br>

> One benefit of having the Mirror running a Unity3D Application is the multiplatform Support, so you can run the mirror with Winodows, Linux, android, etc. Next you can create easlily and quick very great 3D Animations to attract people in front of the mirror.
