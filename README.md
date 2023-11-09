This Branch Having 3D project based on the below requirements
1. >Write a C# code snippet to create a Unity function that moves a GameObject forward when
   a specific button (e.g., the "W" key) is pressed.
2. >Develop a Unity script that changes the color of a GameObject when it's within a certain
   proximity to another GameObject. Provide both the C# script and the Unity scene setup.

---

<h4>About this project: </h4>

Since it's a POC, I have used the resources which is already available in Internet.
I have used [Third Person Starter Pack](https://assetstore.unity.com/packages/essentials/starter-assets-third-person-character-controller-urp-196526) asset from Unity Asset Store which gives good environments and basic codes for player movements. 
I have modified the Input Actions asset to remove the jump feature from the asset which is not needed for the POC.
The reason for using this asset is because we can build and test this POC on **both PC and Mobile**.

<h4>Scripts Used : </h4>

1. **PlayerInput.cs :** This script is responsible for reading the button inputs from the user and invoking the particular function based on the input.
2. **StarterAssetsInputs.cs :** Responsible for listening the inputs from PlayerInput.cs and UI Controls.
3. **ThirdPersonController.cs :** Responsible for Player movements based on StarterAssetsInput class values
4. **ChangeColorBasedOnDistance.cs :** This Script is responsible for changing the color of the attached gameobject when the player gets near to proximity. It using [CheckSphere()](https://docs.unity3d.com/ScriptReference/Physics.CheckSphere.html) method, distanceCheckRadius and LayerMask variables to find whether the player is inside the proximity or not. The code is optimised such a way that it won't change the same color everytime even the player is in the proximity. The Serialized variables helps the same scripts can be used on different objects without modifying the code.

**Scene Name :** Custom Playground