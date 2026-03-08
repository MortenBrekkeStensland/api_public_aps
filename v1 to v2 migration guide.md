## v1 to v2 migration

> **Note:** API v1 support has been removed from current APS versions. Only API v2 (length-prefixed JSON messages) is supported.

## Protocol overview

APS uses length-prefixed JSON messages for both sending and receiving data. Each message is prefixed with a 4-byte big-endian integer indicating the length of the JSON payload.

Clients can optionally send an API version message to indicate their supported version:

```JSON
{
    "command": "api_version",
    "api_version": 2
}
```

If the `api_version` message is omitted, APS still expects API v2 communication. The version message is used for compatibility reporting between APS and the connected client.

When a client connects, APS sends a message indicating its supported API version:

```JSON
{
   "action": "api_version",
   "api_version": 2
}
```

To send a message:
1. Serialize the JSON to UTF-8 bytes.
2. Calculate the byte length.
3. Send a 4-byte big-endian integer with the length.
4. Send the JSON bytes.

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
