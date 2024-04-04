# Audio-Video Processing

This application allows the user to load video or audio files and apply different operations to them, like gamma correction, etc. On the video part the operations can be applied to a ROI (Region of Interest). All the features will be listed down.

<a href="https://weather.petrut.dev/"> Demo of the working application. </a>

<p align="center">
  <img src="https://i.imgur.com/LBesLB3.png" alt="Photo of the presentation of the project"/>
  <img src="https://i.imgur.com/ScGql1p.png" alt="Photo of the presentation of the project"/>
</p>

## Features

- Button to load/play video
- Select Region of Interest (ROI) in the first frame of the video
- Convert ROI to grayscale
- Extract specific color component (R, G, or B) from ROI
- Carousel mode for video ROI: alternating grayscale and color components
- Apply brightness correction/gamma correction to ROI
- Background subtraction on ROI with replacement by a specified picture
- Adjust color space/map on ROI
- Resize/Rotate ROI
- Button to select and unite two videos with cross-dissolve transition
- Video combining: play one video with another overlaid in a smaller window (video in video)
- Button to select three audio files and one video
- Mix the first two audio files into one with specified input levels
- Concatenate output with the third selected audio, implementing cross-fading between audio tracks
- Change the pitch level of the generated audio by one octave up or down
- Add the generated audio file as sound to the video

## Technologies

- C#
- EmguCV (C# wrapper for OpenCV)
- .NET Framework
- WinForms or WPF for the GUI
- DirectX or OpenGL for video rendering
- Audio libraries like NAudio for audio processing
- File I/O for handling video and audio files
- Utilization of events for handling user interactions and asynchronous processing
