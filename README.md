# VR Fruit Ninja Concept

A proof-of-concept for a fruit-slicing game built from scratch in Unity for VR. This project serves as a foundational example of core VR interaction mechanics, physics-based object spawning, and collision detection, inspired by the classic Fruit Ninja.

---

## 🌟 Core Features

* **VR Controller Ready:** Designed for VR interaction, allowing players to wield a virtual sword.
* **Physics-Based Spawning:** Fruits are launched with randomized force and torque, creating a dynamic and challenging experience.
* **Slice & Miss Detection:** Core gameplay loop is implemented with scripts that correctly detect sword collisions ("slices") and floor collisions ("misses").
* **Modular Assets:** Includes a set of royalty-free, low-poly assets to get started, with the freedom to add your own.
* **Clean Repository:** Configured with a proper `.gitignore` for Unity to ensure the repository remains clean and manageable.

---

## 📦 Included Assets

This repository includes a starter pack of 3D models to build out the game. The assets are provided in `.zip` and `.fbx` formats in the root directory:

* **Swords:**
    * `Sting-Sword-lowpoly.fbx`
    * `55-sting-sword-lowpoly.fbx.zip`
    * `cyber-katana.zip`
* **Targets:**
    * `lowpoly-fruits-vegetables.zip`

*Users are encouraged to unzip these assets and import them into the Unity project, applying their own materials and textures.*

---

## 🚀 Getting Started

To run this project, follow these steps:

1.  **Clone the Repository:**
    ```bash
    git clone [https://github.com/ArpanMoharana/VR-Fruit-Ninja-Concept.git](https://github.com/ArpanMoharana/VR-Fruit-Ninja-Concept.git)
    ```
2.  **Open in Unity Hub:**
    * Launch Unity Hub.
    * Click "Open" -> "Add project from disk".
    * Navigate to the cloned `VR-Fruit-Ninja-Concept` folder and select the `VR FRUIT NINJA` sub-folder.
3.  **Run the Scene:**
    * Once the project is open, load the main scene from the `Assets/Scenes` folder.
    * Press the ▶️ Play button to start the game in the Editor (using the XR Device Simulator).

---

## 📝 Future Development

This project provides a strong foundation. The next logical steps for development are:

* **Implement 3D Models:** Replace the placeholder fruit objects with the models from the included assets.
* **Add VFX & SFX:** Create particle effects for fruit slices and add satisfying sound effects.
* **Develop a Scoring System:** Implement a `GameManager` to track score, combos, and misses.
* **Create a UI:** Design a user interface to display the score and other game information.
* **Introduce Obstacles:** Add bombs or other objects that the player must avoid.
