# Obsidian Runner

Obsidian Runner is a 2D Unity platformer built around forward momentum, precise jumps, and obstacle timing. The project uses a menu-driven flow, prefab-based level loading, persistent progress data, and lightweight UI interactions to create a compact runner experience that is easy to open, study, and extend.

This repository is structured as a Unity project inside the `ObsidianRunner/` directory, making it suitable both as a playable prototype and as a portfolio-style game development project.

## Project Highlights

- Built with Unity `2022.3.62f3`
- 2D side-scrolling runner/platformer gameplay
- Prefab-driven level loading system
- Main menu, level flow, pause, restart, and completion UI
- Persistent player progress and saved volume settings via `PlayerPrefs`
- Camera follow system and score tracking based on player distance
- Includes UI/audio polish elements such as hover scale and hover sound effects
- Uses URP, TextMesh Pro, and LeanTween

## Gameplay Overview

In Obsidian Runner, the player moves through obstacle-based levels, avoids enemies and traps, and reaches the end portal to progress. Score is tracked using horizontal distance traveled, which keeps the feedback immediate and simple. The project focuses on core platformer responsiveness and a clean gameplay loop rather than feature bloat.

## Current Game Flow

1. Launch into the `Menu` scene
2. Start the game or open the level-selection interface
3. Load into the shared `Level` scene
4. Spawn the selected level prefab dynamically
5. Reach the end portal to complete the level or restart after hitting an enemy

## Controls

| Action | Input |
| --- | --- |
| Move right | `D` or `Right Arrow` |
| Move left | `A` or `Left Arrow` |
| Jump | `Space` |
| Pause | `P` |
| Return to menu | `Esc` |

## Tech Stack

- Unity
- C#
- Universal Render Pipeline (URP)
- TextMesh Pro
- LeanTween

## Project Structure

```text
.
├── README.md
└── ObsidianRunner/
    ├── Assets/
    │   ├── Scenes/
    │   ├── Scripts/
    │   ├── Prefabs/
    │   ├── Sprites/
    │   ├── audio/
    │   └── LeanTween/
    ├── Packages/
    └── ProjectSettings/
```

## Key Systems

### Player Movement

The player controller handles left/right movement, jumping, pause access, menu exit, and level completion or restart triggers.

### Level Management

The `LevelManager` dynamically instantiates level prefabs based on the currently selected level, which keeps the playable flow centralized in one gameplay scene.

### Progress Persistence

The project stores level state and settings through `PlayerPrefs`, including:

- current level
- unlocked progress data
- saved audio volume

### UI and Feedback

The project includes:

- menu and settings canvases
- restart and completion overlays
- hover scaling on UI buttons
- hover sound feedback
- score display tied to player position

## Included Content

- `Menu` scene
- `Level` scene
- multiple level prefabs under `Assets/Prefabs/Levels`
- player prefab
- obstacle prefabs including spikes and moving hazards
- audio and sprite assets used by menus and gameplay

## How To Open The Project

1. Install Unity Hub
2. Install Unity Editor `2022.3.62f3`
3. Clone this repository
4. Open the `ObsidianRunner/` folder in Unity Hub
5. Load the `Menu` scene from `Assets/Scenes/Menu.unity`
6. Press Play in the Unity Editor

## Why This Project Stands Out

Obsidian Runner is a good showcase project because it demonstrates more than just a single playable scene. It includes menu flow, reusable level loading, persistent state, UI logic, audio interaction, and scene organization in a form that is easy for recruiters, collaborators, or other developers to review quickly.

## Good Starting Points For Review

If you are exploring the codebase, these are the most useful places to start:

- `Assets/Scripts/playerMovement.cs`
- `Assets/Scripts/score.cs`
- `Assets/Scripts/followPlayer.cs`
- `Assets/Scripts/menuAndQuit.cs`
- `Assets/Scripts/level/LevelManager.cs`
- `Assets/Scripts/level/LevelData.cs`
- `Assets/Scripts/level/LevelButtonPrefab.cs`

## Notes

- The Unity project lives inside the `ObsidianRunner/` subdirectory, not the repository root
- The repository currently appears focused on local/editor play rather than packaged release distribution
- If you want to showcase this repo publicly, adding gameplay screenshots or a short demo clip would make the landing page even stronger

## License

No license file is currently included in this repository. If you plan to share or open-source the project publicly, add a license that matches your intent.
