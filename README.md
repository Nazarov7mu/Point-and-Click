# Point and Click simple game
The Task for Tritan

# My Guidelines for Mobile Unity Projects

## Scene structure
-----SETUP-----  
-------UI--------  
-----WORLD-----  

**Example:**  
<img width="435" alt="" src="https://user-images.githubusercontent.com/43933209/170028369-3762c6f7-01b9-42f9-b2b7-6af0f8a54c04.png">

## Utils scripts
### CameraFitter
Attach "CameraFitter" script to Camera in the scene.  

**Example:**  
1) **9:16** aspect ratio (Default)
2) **18.5:9** aspect ratio with script
3) **18.5:9** aspect ratio without script (camera is cropped which is wrong)    

1. <img height="400" alt="" src="https://user-images.githubusercontent.com/43933209/170029422-7b73e078-74df-4a99-9bbc-7f6ca1b836d1.png"> 2. <img height="400" alt="" src="https://user-images.githubusercontent.com/43933209/170030639-37219e34-4be4-49f8-bcad-ed3d42f5eef7.png"> 3. <img height="400" alt="" src="https://user-images.githubusercontent.com/43933209/170030049-dcb89981-252c-4056-b1c4-33aad76b6751.png">

### CanvasMatch
Attach to ScriptsUI gameobject in SETUP section. Drag and drop Canvases that need to adapt to scripts array list.  

**Example:**  
Look to "CameraFitter" screenshots, UI elements like Pause button and Score number changed their sizes depending on resolution.  

### SafeAreaPanel
Create empty gameobject in Canvas, and stretch anchor. Attach script to this gameobject. Helps with notches, hole punches, chins.  
<img width="490" alt="" src="https://user-images.githubusercontent.com/43933209/170033635-545fb61a-65f8-43cd-9fe1-dad9d56220ea.png">

**Example:**  
<img width="260" alt="" src="https://user-images.githubusercontent.com/43933209/170033974-b5a4e4ff-9d52-49a6-b1ee-120f2a4fb125.png">

