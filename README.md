Since my previous Chat Agregator is no longer working, it's time to make a new version.

Intended features:
* Chat (mostly previous Chat Agregator features)
  * Read Live chat from platforms:
    * YouTube Streams
    * Twitch Streams
    * Kick Streams
  * Connect to local DB
    * Remember user's chat activity
    * Currency tracking
      * Allow for commands
  * Agregate Chat streams into one output
  * Messages are PUSHED to subscribers not PULLED
    * Pub-Sub architecture
  * Settings 
  * Custom chat styles
* Re-stream capability
  * RTMP Server
    * Smart decision: If output format = input format just forward, otherwise re-encode
  * FFMPEG / alt for re-encoding
  * per-platform format settings
* 