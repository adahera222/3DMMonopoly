Component Copier
an editor extension tool for Unity
written by Stephen Borden for IS3D
http://is3d-online.com/unitytools/

How do I use this thing?
------------------------

First you select a GameObject in your Hierarchy, Scene, or Project window. You can now select "Copy Components" from either the Component menu in Unity, or from the right click menu of the top of the Transform component in the Inspector.

A window will now pop up giving you check boxes for each of the components on your selected GameObject. You can select them to copy a default component of that type, or you can click the arrow under the check box to select individual fields and properties to copy into the component. If a component of this type does not exist it will be created. If it does exist and you selected properties and/or fields to copy they will be replace with the copied value when you paste.

Pasting is done relatively the same way you copied. However this time you can select any number of GameObjects to copy onto. Select them in the Hierarchy, Scene, or Project window and select "Paste Components" from the Component menu or right click menu of the Transform displayed in the Inspector.

Your components and their values should now be copied! Remember, if you decided you don't like your new copied components and values after all you can always Undo.

Revision History
-----------------

1.00 Initial release.
1.01 Copied components should now reflect the enabled or disabled state of the copied component. Previously the copied component would be enabled even if the original was disabled.
1.02 Added the ability to select/deselect all of a component's fields and properties.
1.03 You can now copy more than one of the same type of component.
1.04 The Component Copier should now show more of the variables you might want to copy, without the need to modify the script.
1.05 Fixed a bug in the previous version that caused problems when copying multiple Components to multiple GameObjects. Sorry about that.

Questions? Comments?
--------------------

contact us at unitytools@is3d-online.com