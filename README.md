# CSYE7270_Final__Unity_AI_Navigation_Demo
# Unity AI Navigation Essentials 🧭

> A demonstration of Unity's built-in Navigation System, featuring Pathfinding, NavMesh Agents, and Dynamic Obstacle Avoidance.

**Author**: Yuelu Zhang
**Tools**: Unity 2022.3 (or your version)

## 📖 Project Overview
This project demonstrates the fundamental concepts of AI Navigation in Unity. It compares **Static Baking** vs. **Dynamic Carving** to solve common gameplay challenges, such as moving obstacles and blocked paths.

### Key Features
* **NavMesh Setup**: Basic environment baking using Unity's AI Navigation package.
* **Intelligent Agent**: A Sphere agent configured to find the optimal path to a target.
* **Dynamic Obstacles**: A "Moving Gate" demonstration showing how to use `NavMesh Obstacle` with **Carving** enabled for real-time path recalculation.

## 🎮 How to Play / Demo
1.  Clone this repository.
2.  Open the project in Unity.
3.  Open the scene `Assets/Scenes/MazeDemo.unity`.
4.  Press **Play**.
5.  **Interact**: Drag the "Gate" object in the Scene View to block the agent's path and watch it recalculate in real-time!

## ⚙️ Technical Highlights
* **NavMesh Agent Component**: Handles acceleration, speed, and stopping distance.
* **NavMesh Obstacle Component**:
    * `Carve`: Enabled (True)
    * `Move Threshold`: Tuned for responsive updates.
    * `Time To Stationary`: Adjusted for real-time avoidance.

## 📸 Screenshots
<img width="648" height="602" alt="fc967e00506cb223bbdbc4e8b3a92ec7" src="https://github.com/user-attachments/assets/115d1b04-c08d-4d1c-ae3e-bfdf268c74fc" />

## 🎬 Demo Video

Watch the demo here:  
[▶️ Demo Video]（(/Demo.mov))


## 📄 License
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
