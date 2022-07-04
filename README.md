# HoloPreferenceDemo
HoloLens shopping demo highlighting products for a set preference

This project was created using Unity version <b>2018.4.!</b> It will not work on versions 2019 or higher, since the standard was changed from UWP to IL2CPP and we need the .net scripting backend for development on HoloLens.<br>
If you don't have Unity installed already, use the <a href="https://unity3d.com/get-unity/download">Unity hub</a> for installation, that makes it easiest and installs dependencies for you.<br>
Additionally, you need UWP .Net build support. You might need Android build support for smartphone Apps, Vuforia Augmented Reality if you want to use image recognition.

You will probably also need the <a href="https://developer.microsoft.com/de-de/windows/downloads/windows-10-sdk/">Windows 10 SDK</a>
There, select the .net framework development kit as well as IP over USB

# Project Settings

Go to Edit:
Project Settings
<ul>
<li> check the Windows Store icon Player settings (in Other section)<br>
<li> change Scripting Backend to .Net (in Publishing section)<br>
<li> check the following Capabilities: InternetClient, InternetClientServer, PrivateNetworkClientServer, SpatialPerception (if you want to include object
recognition and/ or anchors for AR) in XR Settings, Microphone (if you want to use speech input)<br>
<li> check: Virtual Reality Supported (ensure Windows Mixed Reality is set)
Vuforia Augmented Reality Supported (again for object recognition - not used in this project version) <br>
<li> Quality settings: set the quality for your used system to low
</ul>

Project setup for Mixed Reality and VR:<br>
    <ul>
<li> Select Main Camera in the Hierarchy panel <br>
<li> In the Inspector panel, find the Transform component and change the Position from (X: 0, Y: 1, Z: -10) to (X: 0, Y: 0, Z: 0)<br>
Additionally, for <b>HoloLens</b>: <br>
<li> With the Main Camera still selected in the Hierarchy panel, find the Camera component in the Inspector panel and change the Clear Flags dropdown from Skybox to Solid Color. <br>
<li> Select the Background color picker and change the RGBA values to (0, 0, 0, 0) <br>
<li> With the Main Camera still selected in the Hierarchy panel, find the Camera component in the Inspector panel and change the Near Clip Plane field from the default 0.3 to the HoloLens recommended 0.85. <br>
    </ul>
For VR keep the Skybox setting etc

for <b>HoloLens, VR</b>: In file - build settings change to Universal Windows Platform, add open scene and check Unity C# Projects, click on switch platform

for <b>Smartphone</b>: In file - build settings change to Android mobile, add open scene, click on switch platform

to build the project, click build, create a new folder named App for your
finished project

To load/run the project (HoloLens), go to the created folder and click on the created solution (solutionname.sln)  to open the project in Visual Studio. In Visual Studio, change the Config to Release, Platform to x86 and build to device

Required configuration for toggle to work:
<ul>

<li> If you don't have any UI objects yet, create one (GameObject -> UI -> Button/Toggle/Slider/etc.)<br>
<li> Select the EventSystem object (this GameObject is automatically created for you when you create an UI objects, but unlike other UI objects, does not have Canvas as a parent/ancestor)<br>
<li> Add the "HoloLens Input Module" component to EventSystem (leave StandaloneInputModule attached for the UI to still work in the editor with mouse and keyboard)<br>
<li> Select the Canvas object (this containing GameObject is automatically created for you, and is a parent/ancestor to your UI objects)<br>
<li> Change "Render Mode" to "World Space"<br>
<li> Drag the Main Camera object onto the "Event Camera" field<br>
<li> Remember to put your camera's position at the origin<br>
</ul>
