# Yin-Yang

Yin-Yang - rest in virtual world 🎬 youtube demo link: (tb updated)

- **Group**: 3
- **Members**:
  - 🧙‍♂️ Xiaolan Wu <wu.xiaol@northeastern.edu> 
  - 🧙🏻‍♀️ Yufei Mei <charlottemay234@gmail.com>
  - 🧙🏻‍♀️ <a href="https://www.linkedin.com/in/xun-zhu/" target="_blank">Xun Zhu</a> <rayzzzx13@gmail.com>

## Geting Start
To use this project, you'll need to have Unity version 2021.3.16f1 or later installed. You can download Unity from the official website: https://unity.com/.
Once you have Unity installed, you can download or clone this repository to your local machine.


## Structure of the App
### 1. Welcome page
Allow user to select different rooms.
 

### 2. Yin Room
In the yin room, user can enjoy the beautiful scene along with breathing guidance and soft background sound.
![image](https://user-images.githubusercontent.com/120827194/225977987-14961323-de68-49e2-be9a-0f983d735128.png)


### 3. Yang Room
In the yang room, user can gain some exercises by moving their body, there are bunch of screens will pop
to the player, and the player just need to copy the action in the screen, try to act as the same as the screen.

## Update & Progress
### Xiaolan Wu
#### 2023/3/10
1. initialize welcome scene.
2. design welcome UI for user

#### 2023/3/11
1. Scene Loading: uses script to load appropriate sub-scene when click button
2. UI design: change active color when user hovers over
3. audio: contains background sound plays continuesly while the user interacts with the UI. 

#### 2023/3/14
1. Asset create: create hole in the wall asset with probuilder

#### 2023/3/23 &24
1. Yang Scene: Adjust wall postion & spped to increase the experience of user
2. Yin Scene: create basic object for hapitc function
3. Yang Scene: Adjust the way wall spwan. Walls will be spawn only after user click ok.

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

#### 20233/30
1. Successfully change the speed with one object, when change to six objects, 
fail to change the speed. Also can’t change the direction of the object yet.

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

### 
#### 
