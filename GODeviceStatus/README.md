# Augmented Reality
AR Fragments build with TIBCO Cloud Products, Unity 3D, and Google ARCore. 

## Device Status with Augmented Image detection
This augmented reality Demo shows the detection of a Device or Machine area.  The virtual Object next to it displays Status Informations like a detected Temperature in real-time. The little flashing virtual LED indicates a working connection to the ESP 8622. All implemented using TIBCO Cloud Integration, Unity 3D and Google AR Core.

![TIBCO AR image](../images/AR-TIBCO-Flogo.png?raw=true "Device Status in Augmented Reality")

Short Intro Video on YouTube here: https://www.youtube.com/watch?v=MMWO99B3XV0

_Consider as well the detected of other Images e.g. a transformer on a bigger facility, or pump next to engine._
_At least something need to make the Image unique, by in AR so called Images Features._ 

### Overview
This Prove of Concepts uses TIBCO Cloud Integrations Services and the TIBCO Mashery API Gateway to secure the communication between der Device and Unity showing the Augmented Reality Device Status Details.
First Version was using just a Public TIBCO Cloud Integration Flogo Service, and showed the following properties in Unity 3D:

![TIBCO Unity Props](../images/TIBCO-TCI-Unity-Properties.png?raw=true "TCI Unity Properties")

### used Technologies
following techniques used to implement this Scenario:
- TIBCO Cloud Integration
- Unity 3D
- Google AR Core
- Android SDK

### Sample Code Fragments
working Unity 3D C# [Sourcecode Fragments added here](https://github.com/JGrotex/augmented-reality/tree/master/Source%20Fragments).
1. The first Sample shows how to connect from Unity to a public TIBCO Cloud Integration Flogo Service.
2. The second Sample connects to a secure TIBCO Mashery API using a Developer specific API Key.

_This Area is still work in progress to make these things easily reusable._

### Unity Prefabs
used AR Flogo Device Status Object [Prefab](https://github.com/JGrotex/augmented-reality/tree/master/prefabs)

![Flogo Prefab](../images/Flogo-Device-Status.png?raw=true "Flogo Device Status Object Prefab")

### TIBCO Benefits
Sure something like this can be created using other techniques, but TIBCO brings the following main benefits into the whole Solution:
- globally available Cloud Platform for Operation (TIBCO Cloud)
- graphical Service Design and Implemenation (TIBCO Flogo)
- secure, scalable and robust API Gateway (TIBCO Mashery)
and this is to mention only some.

<hr>

< back to [Main AR page](https://jgrotex.github.io/augmented-reality/)
