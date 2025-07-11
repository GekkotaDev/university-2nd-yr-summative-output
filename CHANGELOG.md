# Changelogs

[Semver (Semantic Versioning) reference](https://semver.org)

## May 7 2025 `v0.3.3`

- Added [Csharpier](https://github.com/belav/csharpier) for automated code
  formatting. Life's too short to do it manually.

## May 8 2025 `v0.4.0`

- Added [`MainMenu` scene](./Assets/Scenes).
  - Basic working UI prototype.
  - Game logic to start the game.
- Created GitHub repository

### NOTES

This is a good enough bare minimum for now. I'll take care of adding additional
Git metadata (such as tags) and creating versioned releases of both the source
code and executable file (that is, the compiled build) hopefully using GitHub
Actions to automate this.

## May 9 2025 `v0.4.0`

- Installed additional packages.
  - Visual Studio Code Editor
  - AI Navigation

### NOTES

- The addition of the `AI Navigation` package should provide us the means to
  create a more engaging set of behaviors for the NPCs of the game. A possible
  problem is that it's way too easy to cheese the AI into getting themselves
  stuck inside a room.

  ***Now we wouldn't want that for the boss, do we?*** But it's fine if it's
  easy to cheese the boss in the default Scene. Perhaps teleporting the player
  to a new Scene a la boss room?
- C# Dev Kit + Unity extension so far so good. I'm way too used to VS Code to
  give it up now.
- The fireballs don't despawn. *thousand yard stare*

## May 14 `v0.4.0`

- Added guide for controls
- Music! (M.U.L.E \[Labyrinth Mix\] by Vomic)
- Music toggle.
- A game over screen.
- Experience based unlock.

### NOTES

- I will have to be honest here even if it's a bit too much. On top of me not
  having any experience in Unity, the lack of organization in the hierarchy has
  made it more difficult to navigate the project and implement features. I can
  not make any guarantees that every feature wanted will be in the final game
  so I'll have to throw in the towel and make the scope smaller. Suggestions:
  - [Dependency Injection](https://developer.android.com/training/dependency-injection).
    Bonus points if you study related Design Patterns such as the Strategy
    Pattern (related to `interface`s). This enables code to not be tightly
    coupled in a way where any changes should minimize propagation of
    side-effects and makes for highly testable and easily modifiable code.
  - [Observer Pattern](https://refactoring.guru/design-patterns/observer) and/or
    event-driven programming.
  - I apologize in advance if this is a bit too harsh. Just know this is out of
    genuine concern.
