# UnityAnchorGrid

Who needs it?

Unity GridLayout require you to input the size of the cells which leads you to problems when you are working on anchor based UI.
AnchorGrid.cs automatically set anchors on child game objects to work like GridLayout. 

Usage:
1. simply import this cs into your project and add AnchorGrid to the parent container game object of objects you want to grid.
2. set the column count to the number of column you need in the grid.
3. make the parent object to validate on the editor. 
4. Give proper spacing by entering top/left/right/bottom values on child objects with the new anchor values.

Limitation:
1. only support horizontal orientation (placing child objects from top-left to top-right into bottom-left side)
anyone can contribute to the repository to suppor the feature.


