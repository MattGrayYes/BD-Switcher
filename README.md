# BD Switcher

This is a Windows app that allows you to route NDI video sources BirdDog BD-Play NDI Recievers.

It uses mDNS (Zeroconf/Bonjour) to discover NDI video sources and BirdDog players on your network, and the BirdDog REST API to tell the player to connect to a source.

## How It Works
It searches for NDI video sources and BirdDog players on your network using mDNS (Zeroconf).

BD Switcher constructs an HTTP POST request to the BirdDog Player in order to route the selected source to it. The API command has the following format:

```http
POST http://[Selected Destination IP]:8080/connectTo
Content-Type: application/json
{ "sourceName": "[Selected Source Name]" }
```
* `[Selected Destination IP]`: The IP address of the selected BirdDog player.
* `[Selected Source Name]`: The name of the selected NDI video source.

Upon confirmation, BD Switcher sends the constructed API command to the BirdDog player.
