This Branch Having 3D project based on the below requirements

>Create a Unity scene with a basic VR environment (e.g., a room) and implement a feature that allows
the user to pick up and move objects within the scene using VR controllers.

<h5>About this project:</h5>

I have used XR Interaction Toolkit built on the top of **OpenXR**. This project contains simple interactable objects.

**Why OpenXR?** Well, most of the XR devices available in the market where using OpenXR standards which helping the developers where they don't need to recreate the same app with different SDK/Plugins given by respective OEMs. In other words, the app which built on the top of OpenXR plugin will run on most of the available devices. But the developer needs to map the controllers and some platform specific features won't work.  

---
<h5>Scripts Used :</h5>

I have utilized the scripts which is created by Unity's XRTK. some main objects and scripts for interaction are,
1. XR Origin/XR Rig Prefab : Responsible for performing the 6DoF operations in the XR environment and contains controller mapping logics to communicate with Real and virtual controllers.
2. XRDirectInteractor: Interactor used for directly interacting with Interactables that are touching. This is handled via trigger volumes that update the current set of valid targets for this interactor. This component must have a collision volume that is set to be a trigger to work.
3. XRGrabInteractable: Interactable component that allows for basic grab functionality. To make this interactable work,it should have rigidbody and the attached object or it's children should have atleast one collider.

**Scene Name :** VR Scene