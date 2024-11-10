## v1 to v2 migration

Starting from API v2, APS should use length-prefixed JSON messages for both sending and receiving data, instead of using $ as a termination character. This is the main protocol change, though a few command and feedback modifications were also made.

### Commands

#### Changed
- Capture1, Capture2, ...\
    Renamed to Capture_Image accepts bank_number parameter
- Display1, Display2, ...\
    Renamed to Display_Image with bank_number parameter
- Load_MediaPlayer#Next, Load_MediaPlayer#Previous, Load_MediaPlayer#1, ...\
    Changed to just Load_MediaPlayer that accepts bank_number which can be "Next", "Previous", or integer

#### Added
- SetSelected_PresentationFolder:\
accepts bank_number parameter which can be "Next", "Previous", or integer
- SetSelected_MediaFolder:\
accepts bank_number parameter which can be "Next", "Previous", or integer
- CapturePresentationSlot: accepts bank_number
- CaptureFolder: accepts bank_number
- SetPresentationSlotPath: accepts 2 parameters slot and file_path
- SetMediaSlotPath: accepts 2 parameters bank_number and file_path
- SetImageSlotPath: accepts 2 parameters bank_number and file_path
- Clear: accepts 2 parameters
    - clear_type_key: can be one of these values [StillImages, Media, SlotPresentations, PresentationFolders, MediaFolders]
    - bank_number: can be "All" or integer

### Feedbacks

#### Changed
- states: Renamed to imagesstates

### Added
- slot_capture
- folder_capture
- any_presentation_displayed
- presentation_folders
- watched_presentation_folder
- opened_folder_presentation
- media_folders
- watched_media_folder
