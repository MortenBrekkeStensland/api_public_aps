## APS API

### Protocol:
APS has a TCP server that waits for a client connection on a default port (4778) and can be configured from the app settings. Once a connection is instantiated between the client and APS it will continuously listen to the incoming messages from that client.
The commands should be sent as an ASCII string with `$` as a termination char at
the end of it (e.g. FireNext$).


### Commands:

 1. `Navigation_NextFS`: Open next presentation using the focused app in fullscreen
 2. `Navigation_PrevFS`: Open prev presentation using the focused app in fullscreen
 3. `Navigation_NextNoFS`: Open next presentation using the focused app
 4. `Navigation_CurrentFS`: Set current presentation in fullscreen
 5. `Navigation_CloseOthers`
 6. `Key_Left`
 7. `Key_Right` 
 8. `Key_Esc`
 9. `Key_B`
 10. `Freeze`
 11. `DisplayTest`
 12. `Blackout`
 13. `ExitImages` 
 14. `states`
 15. `Capture` 
 16. `Display` 
 17. `OpenStart_Presentation`
 18. `OpenStart_Presentation_Slot`
 19. `Generic`
 20. `Powerpoint_Go`
 21. `Powerpoint_Previous`
 22. `Powerpoint_Next`
 23. `Acrobat_Go`
 24. `Acrobat_Previous`
 25. `Acrobat_Next`


### Feedback:
Once the client is connected to APS it will continuously receive info. This will be JSON string that has a `$` as a termination char at the very end.
> Some of the feedbacks will be sent only with some commands like `states`, `capture`, `display`


#### Presentations Slots Feedback
```JSON
{
   "action":"slots",
   "data":{
      "filenames":[ "01.pptx", "02.pptx", "03.pptx", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-"],
      "exists":[true, true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false],
      "opened":[true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false]
   }
}$
```

- `filenames`: An array of configured files in `Presentations` tab
- `exists`:  An array to indicate if the file is exist on the system or not
- `opened`:  An array to indicate if the file is currently opened or not

#### Files Feedback
```JSON
{
   "action":"files",
   "data":{
      "curr":"02.pptx",
      "prev":"01.pptx",
      "next":"-"
   }
}$
```

#### Images States Feedback
```JSON
{
   "action":"states",
   "data":{
      "displayTest":false,
      "displayBlack":false,
      "displayFreeze":false,
      "displayIndex":-1,
      "isLoaded":[ true, true, true, false, false, false, true, false, false, false]
   }
}$
```

- `displayTest`: Will be true if the color-bars screen is displayed
- `displayBlack`: Will be true if the black screen is displayed 
- `displayFreeze`: Will be true if the screen is freezed
- `displayIndex`: Zero indexed to show the index of the image from `Still Images` tab that is currently displayed, will be `-1` if none of them is displayed
- `isLoaded`: An array to indicate if an image is added to each slot or not