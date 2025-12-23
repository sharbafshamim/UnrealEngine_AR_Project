# AR Prototyping Demo

This repository contains a small augmented reality (AR) prototype built for a course assignment to demonstrate rapid AR prototyping using off‑the‑shelf hardware and software resources.

## Purpose and Objectives

- **Purpose**  
  Demonstrate the ability to prototype AR experiences using consumer‑grade hardware (smartphone, tablet, or AR headset) and widely available software tools.

- **Objective**  
  Develop a simple AR application that allows a user to interact with virtual objects overlaid on real‑world surfaces (for example, placing 3D shapes on a detected floor or table).

## Features

- **Minimum features**
  - Detect a real‑world surface (e.g., floor or table).
  - Allow the user to place simple virtual objects (sphere, cylinder, cone, cube/block, etc.) on the detected surface.

- **Nice‑to‑have features**
  - Allow the user to select a placed virtual object.
  - Allow the user to change the **color** of the selected virtual object.

- **Target platforms and SDKs**
  - Runs on a smartphone, tablet, or AR headset (e.g., MS HoloLens, Meta/Oculus Quest passthrough).
  - Built using Unity or Unreal Engine.
  - Uses one of:
    - Google ARCore (Android)
    - Apple ARKit (iOS)
    - MRTK (Microsoft HoloLens)

## Project Structure

A typical structure for this project (actual paths may vary slightly depending on engine and setup):

- `Assets/` or `Content/`  
  Engine assets, materials, prefabs/blueprints, and scenes/levels.

- `Scripts/` or `Source/`  
  Application logic, including:
  - Plane detection and raycasting.
  - Object placement on detected surfaces.
  - Object selection and color changing (if implemented).

- `Scenes/` or `Maps/`  
  The main AR scene/level used for the demo.

- `Docs/`  
  Additional documentation, notes, or design sketches.

- `Build/` (optional, often excluded from Git)  
  Platform‑specific build artifacts, if included.

## How to Run

### Prerequisites

Depending on the engine and platform:

- **Unity**
  - A supported Unity version (matching this project).
  - AR Foundation plus platform‑specific packages (e.g., ARCore XR Plugin, ARKit XR Plugin, or MRTK).

- **Unreal Engine**
  - A compatible version of Unreal Engine (e.g., 5.x).
  - Platform AR plugins enabled (ARCore, ARKit, or MRTK as needed).

Device requirements (one of the following):

- Android device with ARCore support.
- iOS device with ARKit support.
- Microsoft HoloLens or Meta/Oculus Quest with passthrough for headset‑based AR.

1. **Clone the repository**

2. **Open the project**

- Unreal: open the `.uproject` file with the matching Unreal Engine version.

3. **Configure platform settings**
- Android: enable ARCore/AR plugin and set minimum SDK version as required.
- iOS: enable ARKit/AR plugin and configure bundle identifier and signing (requires an Apple developer account for device deployment).
- HoloLens: configure MRTK and UWP build settings.

4. **Build and deploy**
- Follow the standard engine workflow to build and deploy to the target device.
- Use USB or Wi‑Fi deployment depending on platform and tooling.



## iOS / macOS Notes (Developer Account and Descriptor File Issue)

During development on macOS with an iPhone, deployment of the Unreal‑based iOS build encountered issues related to using a **free** Apple account:

- Errors occurred about failing to open the project descriptor file when trying to run the `.uproject` over a local network or as part of the iOS build pipeline.
- Similar issues have been reported by other users in the Unreal community when opening or deploying `.uproject` files over a network or with certain remote setups, for example:  
https://forums.unrealengine.com/t/failed-to-open-descriptor-file-error-when-opening-uproject-file-on-local-network-solution/788090

From community experience and tooling limitations:

- A paid Apple Developer Program account (around 100 USD per year) is typically required for reliable Unreal iOS deployment and code signing for on‑device testing and distribution.
- For this course project, that cost is considered too high just to get a short prototype running on an iPhone, so iOS deployment was not completed with a paid account.





