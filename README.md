# Yin-Yang

Yin-Yang - rest in virtual world 🎬 youtube demo link: [(Youtube link)](https://youtu.be/MhZpYduk3Ao)

- **Group**: 3
- **Members**:
  - 🧙‍♂️ Xiaolan Wu <wu.xiaol@northeastern.edu> 
  - 🧙🏻‍♀️ Yufei Mei <charlottemay234@gmail.com>
  - 🧙🏻‍♀️ <a href="https://www.linkedin.com/in/xun-zhu/" target="_blank">Xun Zhu</a> <rayzzzx13@gmail.com>

## Geting Start
To experience Yin Yang VR, ensure you have Unity 2021.3f installed and an Oculus Quest 2 device ready for use. 
Download or clone the project from the GitHub repository and open it in Unity. 
Build and deploy the project to your Oculus Quest 2 device to begin exploring the Yin Yang VR experience.

## Structure of the App
### 1. Welcome page
The Main Scene serves as the entry point for users, allowing them to choose between the Yin Room or the Yang Room, each offering a unique experience.
![image](https://user-images.githubusercontent.com/43577080/232867245-e5f6de39-dec8-4f9e-a6ed-7c96c335d192.png)


### 2. Yin Room
In the yin room, user can enjoy the beautiful scene along with breathing guidance and soft background sound.
![image](https://user-images.githubusercontent.com/120827194/225977987-14961323-de68-49e2-be9a-0f983d735128.png)

This scene includes the following functions:

### A. Interactive Objects 
Users can interact with objects like clouds and fireworks to enhance their relaxation experience.
![image](https://user-images.githubusercontent.com/43577080/232867579-4ceed0b8-81a8-43db-8553-e8d29070a874.png)


### B. Breathing Mode
Breathing Mode is a feature in the Yin Yang VR game designed to help users relax, unwind, and practice mindfulness.
![image](https://user-images.githubusercontent.com/43577080/232867750-cf242cff-58ff-4932-be83-d318e1f812fd.png)

#### Features
  - **Breathing Guidance**: Upon confirmation, the sphere will scale up and down for a 3-minute session, visually guiding the user through the breathing exercise.
  - **In-Game Instructions**: As the sphere scales up, a UI text element reading "Breathe In" appears, and the Oculus Quest 2 controller vibrates. When the sphere scales down, the UI text changes to "Breathe Out."
  - **Haptic Feedback**: The Oculus Quest 2 controllers provide haptic feedback during the "Breathe In" phase, enhancing the user's immersion and mindfulness.

#### Benefits
The Breathing Mode in the Yin Yang VR game offers a relaxing, immersive experience that promotes mindfulness and helps users reduce stress. By following the guided breathing exercise, users can calm their minds, improve focus, and enhance their overall well-being.

#### C. Meditation Mode
Follow the Guided meditation to relax.
![image](https://user-images.githubusercontent.com/43577080/232867949-8c7c14b7-5db7-4c46-8931-63dd85f4e46d.png)

### 3. Yang Room
In the yang room, user can gain some exercises by moving their body, there are bunch of screens will pop to the player.
Users follow the poses displayed on the dancing wall, providing an entertaining and interactive way to stay active in the virtual world.
![image](https://user-images.githubusercontent.com/43577080/233514839-fefd4aa1-6dd6-431b-a5b6-5cab3ee57cb9.png)
![image](https://user-images.githubusercontent.com/43577080/233514971-76f04817-3abf-4d1b-b8d7-6dfae9eb1f1e.png)
![image](https://user-images.githubusercontent.com/43577080/233514903-295441c4-e3c6-4442-bb2f-26281252bbd1.png)


## Update & Progress
### Xiaolan Wu
#### 2023/3/10
1. Initialized the Welcome Scene.
2. Designed an intuitive and user-friendly Welcome UI.

#### 2023/3/11
1. Implemented Scene Loading: Scripts now load the appropriate sub-scene when buttons are clicked.
2. Enhanced UI design: Active color changes when users hover over buttons.
3. Integrated background audio that plays continuously while users interact with the UI.

#### 2023/3/14
1. Asset Create: Created a custom "hole in the wall" asset using ProBuilder.

#### 2023/3/23 &24
1. Yang Scene: Optimized wall position and speed for an improved user experience.
2. Yin Scene: Created a basic object for haptic feedback functionality.
3. Yang Scene: Modified the wall spawning mechanism, walls now spawn only after users click "OK".

#### 2023/3/28
1. Yin Scene: Developed the Breathing Cue Scale Up function, allowing the object to scale up and down in a loop.
2. Yin Scene: Created a UI guide for the breathing object.
3. Yin Scene: Updated the object's texture for enhanced visuals.

#### 2023/4/4
1. Yin Scene: Fixed bugs related to the breathing object.
2. Main Scene: Updated the skybox to match the visual style of other rooms.

#### 2023/4/10
1. Implemented a menu page in both Yin and Yang Scenes, enabling users to change settings using the secondary button.

#### 2023/4/15
1. Improved the UI design for the menu page.
2. Searched for suitable meditation guide audio resources.

#### 2023/4/17
1. Implemented "stop" and "restart" functions for the Breath Mode.
2. Added interactive hints with visual cues, including labels, raycast color changes, and controller vibrations.
3. Implemented the SetTrigger function for the avatar, allowing users to start animations.

### Xun Zhu
#### 2023/3/10
1. Quick initialize the yang scene, try to implement the screen model.

#### 2023/3/11
1. Run the world but fail, may be the version problem.

#### 2023/3/12
1. Use Xiaolan's main branch to re-create yang scene, this time works.
2. Re-create the model in the yangSample scene, and build simple UI in the page.
3. Add the audio in the yangSample scene.

#### 2023/3/14
1. Import the danceWall created by Xiaolan to yangSample, and start create more wall.

#### 2023/3/15
1. Create 6 DanceWalls in total and with different colors.
2. Import a scene from internet, change the background scene for yangSample.

#### 2023/3/18
1. Project crash on my end due to the iCloud issue, delete the old one and put 
everything in a new folder with suffix “.nosync”. The project automatically 
created existing files with suffix “ 2”, and this cause the project fail to 
load and run, thus remove everything and recreated a new one.
2. Create a canvas showing some information with button OK to make it disappear, 
and a “Main Page” button to go back to main page.
3. Change the danceWall object to prefabs, add functionality to them, right now 
they can pop to user automatically. Create few scripts that handle these functions.

#### 2023/3/25
1. Add buttons stop and resume.

#### 2023/3/27
1. Some research on assets.

#### 2023/3/29
1. Try add slider or input field to control the DanceWall's speed.

#### 2023/3/30
1. Successfully change the speed with one object, when change to six objects, 
fail to change the speed. Also can’t change the direction of the object yet.

#### 2023/4/1
1. Can change the speed for the six objects, need to fix some buttons.

#### 2023/04/03
1. Finish the slider so users can change the danceWall's speed now.

#### 2023/04/06
1. Try add Oculus Integration, prefab has detection scripts. In the branch xunzhu-04/06, hasn’t push yet, doesn’t work and come with a lot errors.
2. New branch xunzhu-04/06v2, successfully create score system, now can display the score in the console.
3. Create UI score text to display score in the screen.

#### 2023/04/17
1. Add solar system object
2. Change audio
3. Add haptic functionality

### Yufei Mei
#### 2023/03/10
1. Designed the yin room scene
2. Initialized yin room scene

#### 2023/03/12
1. Added loop background music to yin room scene
2. Adjust the objects location that the VR headset can see
2. Added the instruction welcome board

#### 2023/03/15
1. Tried to add haptic effect by default but failed

#### Until 2023/04/04
1. Changed Yin room floor to water surface

2. Removed the previous Yang room skybox which is rotating and selected a style that's similar to Yin room.

3. Updated Yin room welcome canvas: the background music only plays when start button is clicked

4. Updated the breathing canvas and breath-assist object location and use flow

5. Added an island to Yin room
<img width="491" alt="Screenshot 2023-04-04 at 9 51 08 PM" src="https://user-images.githubusercontent.com/120827194/229985347-3dacb440-059c-41cb-aef1-71f93b00cf8f.png">

6. Added fire pit object and added correspoding toggle on canvas to turn on the fire along with firing crack sound
<img width="286" alt="Screenshot 2023-04-04 at 10 02 54 PM" src="https://user-images.githubusercontent.com/120827194/229985780-30fec631-40d1-43ff-8535-9de4ec37defb.png">

7. removed fire toggle and added controlFire script to turn on and off fire pit when raycast clicks on it (FINALLY IT WORKS!!

#### Until 2023/04/12
1. Built a meditation buddy model through NOMAD
![IMG_1167](https://user-images.githubusercontent.com/120827194/232248576-6c370239-9e5c-463c-8264-676d63e49102.PNG)

2. Added animation and audio source to Mediation Buddy

3. Added particle system for rain simuation

4. Added cloud as a trigger for rain particle system

5. Optimized script for particle system triggering 

### 
#### 
