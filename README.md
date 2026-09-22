# 👾 Console Invaders (C# Terminal Engine)

A lightweight, purely console-based arcade engine built natively in C# targeting the standard Windows terminal. This project is a functional clone of the classic Space Invaders, designed strictly as an exercise in Object-Oriented Programming (OOP) and low-level memory optimization.

## 🏗️ Software Architecture & OOP Patterns
* **Inheritance & Polymorphism:** Employs a strict class hierarchy originating from a base `Sprite` class. Entities like `Enemy1`, `Enemy2`, and `Enemy3` inherit core behaviors while overriding specific visual outputs and color logic, ensuring deep code reusability.
* **Spatial Algorithms:** The enemy grid is managed using a highly efficient 1D array mapped to 2D coordinates via modulo operator mathematics, minimizing memory overhead during bulk rendering operations.
* **Entity Pooling:** Implements a rudimentary Object Pool pattern for projectiles (`Disparo.cs`). Instead of continuously instantiating and destroying objects (which strains the Garbage Collector), the engine recycles projectile entities via active/inactive boolean flags.

## ✨ Technical Features
* 🎮 **Non-blocking Input/Output:** Custom game loop reading standard console inputs (`Console.ReadKey`) asynchronously without stalling physics updates or enemy movements.
* 🖥️ **Direct Buffer Manipulation:** Uses `Console.SetCursorPosition` and custom string rendering to draw and wipe frames, managing a localized render pipeline directly on the terminal buffer.
* 💾 **In-Memory State Management:** Handles dynamic array sorting to update and display high scores in real-time during the application session.

## ⚙️ Installation & Usage

### Prerequisites
- Visual Studio 2022 (or any C# IDE) / .NET SDK.

### Running the Game
1. Clone the repository:
   `git clone https://github.com/tu-usuario/ConsoleInvaders.git`
2. Open the solution (`.sln`) in Visual Studio.
3. Press `F5` to run it directly in your terminal, or use the command line:
   `dotnet run`
