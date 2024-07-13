## APS API

### Protocol:
APS has a TCP server that waits for a client connection on a default port (31600) and can be configured from the app settings. Once a connection is instantiated between the client and APS it will continuously listen to the incoming messages from that client.
The commands should be sent as an ASCII string with `$` as a termination char at
the end of it (e.g. Navigation_NextFS$).



### Commands:

#### Presentations file commands
1. `Navigation_NextFS`: Open the next presentation using the focused app in fullscreen
2. `Navigation_PrevFS`: Open prev presentation using the focused app in fullscreen
3. `Navigation_NextNoFS`: Open the next presentation using the focused app
4. `Navigation_CurrentFS`: Set current presentation in fullscreen
5. `OpenStart_Presentation`: supported params 3
6. `OpenStart_Presentation_Slot`: supported params 3
7. `Navigation_CloseOthers`
##### Presentations commands parameters: 
Some commands can have up to 3 params separated by `^` like `OpenStart_Presentation`
##### Parameters order:
1. Slide Number
2. Fullscreen Flag: can be 0 or 1
3. FilePath or Slot Number
##### Examples
- `OpenStart_Presentation^2^1^C:\1.pptx`: Will start presentation `C:\1.pptx` on slide 2 in fullscreen
- `OpenStart_Presentation_Slot^1^0^1`: Will start the presentation in slot 1 on slide 1 in a normal window
- `Powerpoint_Go^2` will open slide 2 of the currently opened PP presentation

---
#### Presentations slide commands
1. `Key_Left`Invokes keyboard-stroke Key Left 
2. `Key_Right` 
3. `Key_Esc`
4. `Key_B`
5. `Generic`: Go to a specified slide (Generic)
6. `Powerpoint_Go`: Go to a specified slide (PowerPoint)
7. `Powerpoint_Previous`
8. `Powerpoint_Next`
9. `Acrobat_Go`: Go to a specified slide (Adobe Acrobat DC Pro)
10. `Acrobat_Previous`
11. `Acrobat_Next`
12. `Keynote_GO` Go to a specified slide (Keynote)
13. `Keynote_Previous`
14. `Keynote_Next`

---


#### Images commands
1. `Freeze`
2. `DisplayTest`
3. `Blackout`
4. `ExitImages` 
5. `Capture`: Take a screenshot and save it to a bank, e.g. `Capture1`
6. `Display`: Display an image, e.g. `Display1`
7. `states`

---

#### Media Player commands
1. `Play_MediaPlayer`
2. `Pause_MediaPlayer`
3. `Restart_MediaPlayer`
4. `Stop_MediaPlayer`
5. `Loop_MediaPlayer`
6. `Fade_MediaPlayer`
7. `Load_MediaPlayer`: This can accept additional param as follows:\
  a. `Load_MediaPlayer#Previous`\
  b. `Load_MediaPlayer#Next`\
  c. `Load_MediaPlayer#1` where 1 is the media slot number
1. `MediaPlayer_Position`: in seconds `MediaPlayer_Position#30`
2. `MediaPlayer_Forward`: in seconds `MediaPlayer_Forward#30`
3.  `MediaPlayer_Rewind`: in seconds `MediaPlayer_Rewind#30`

##### Media Player commands parameters
Media Player commands use different separator `#`

---

### Feedback:
Once the client is connected to APS it will continuously receive info. This will be a JSON string that has a `$` as a termination char at the very end.
> Some of the feedback will be sent only with some commands like `states`, `capture`, `display`


#### Presentations Slots Feedback
```JSON
{
   "action": "slots",
   "data":{
      "filenames": [ "01.pptx", "02.pptx", "03.pptx", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-"],
      "exists": [true, true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false],
      "opened": [true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false]
   }
}$
```

- `filenames`: An array of configured files in the `Presentations` tab
- `exists`:  An array to indicate if the file exists on the system or not
- `opened`:  An array to indicate if the file is currently opened or not

#### Files Feedback
```JSON
{
   "action": "files",
   "data":{
      "curr": "02.pptx",
      "prev": "01.pptx",
      "next":"-",
      "slide_number": "1",
      "slides_count": "10",
      "builds_count": "2"
   }
}$
```
> All of the above params should be sent, if one is not available, just send "-" as value.

#### Images States Feedback
```JSON
{
   "action": "states",
   "data":{
      "displayTest": false,
      "displayBlack": false,
      "displayFreeze": false,
      "displayIndex": -1,
      "isLoaded": [ true, true, true, false, false, false, true, false, false, false]
   }
}$
```

- `displayTest`: Will be true if the color-bars screen is displayed
- `displayBlack`: Will be true if the black screen is displayed 
- `displayFreeze`: Will be true if the screen is freeze
- `displayIndex`: Zero indexed to show the index of the image from `Still Images` tab that is currently displayed, will be `-1` if none of them is displayed
- `isLoaded`: An array to indicate if an image is added to each slot or not


#### Media Player Feedback
```JSON
{
   "action":"MediaPlayer",
   "data":{
      "filenames":["video1.mp4","video2.mp4","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-"],
      "Media_playing":"1",
      "Media_loaded":"2",
      "Media_playing_filename":"video1.mp4",
      "Media_loaded_filename":"video2.mp4",
      "Media_playback_state":"playing",
      "Media_time_elapsed":"00:00:35",
      "Media_time_left":"00:19:15",
      "Media_duration":"00:19:50",
      "Media_player_loop_status":"off",
      "Media_player_fade_status":"on"
      }
}$
```
- `filenames`: An array of configured files in the `Media Player` tab
- `Media_playing`: The slot number of the currently playing media
- `Media_loaded`: The slot number of the currently loaded media
- `Media_playback_state`: it can be `playing`, `paused`, or `None`
