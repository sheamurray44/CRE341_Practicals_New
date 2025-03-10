# GDAD-CRE341-Practicals

Main Menu Scene = Assets/_CRE341/Scenes/MainMenu
Gameplay Scene = Assets/_CRE341/Scenes/Level_1

Initial work with the Proc Gen map:
-Struggled to change materials and make it look better, found out it was lighting issues.
-Added new textures to look more cave like.
-Added black fog to simulate darkness.
-Adjusted random fill percent to an amount suitable for NPC Pathfinding, having it at 50 led to the NPC getting stuck.

Work with AI State Machines:
-Initially using a "Chase Player State" that simply used a navmesh to follow the player.
-Tried to use an abstract state class, implementing the class into a statemanager that would handle swapping states, each state having its own unique logic. Decided not to go forward with it.
-Implemented the Animator FSM went through in class which yielded much better results.
