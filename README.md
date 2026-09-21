# Console Invaders 🚀

A clone of the classic arcade game *Space Invaders*, developed entirely in C# to run in the command console. This project serves as an Object-Oriented Programming (OOP) practice, applying concepts such as inheritance, polymorphism, constructor overloading, and collision management in a text-based environment.

## 👾 Key Features

* **Fleet System:** An organized block of 30 enemies distributed across 3 rows, each featuring a distinct alien type (different shapes and colors).
* **Swarm Intelligence:** Enemies move as a single block, bouncing off the screen edges and gradually descending.
* **The Elusive UFO:** Random appearance of a UFO at the top of the screen that quickly crosses from side to side.
* **Console Rendering Engine:** Optimized coordinate-based drawing and erasing system (preventing excessive flickering and removing the need to clear the entire screen every frame).
* **Player Control:** Fluid movement of the defender ship using asynchronous keystroke reading.

## 💻 Technologies & Concepts

* **Language:** C# (.NET)
* **Paradigm:** Object-Oriented Programming (OOP).
* **Key applied concepts:**
  * **Inheritance:** Derived classes (`Nave`, `Ovni`, `Enemigo1`, `Enemigo2`) inheriting from base classes.
  * **Constructor Overloading:** Flexibility to instantiate objects at default positions or specific coordinates.
  * **Arrays:** Enemy fleet management using arrays and modular mathematics to simulate a 2D grid.

## 🎮 Game Controls

* **Left Arrow (`<-`):** Move the ship left.
* **Right Arrow (`->`):** Move the ship right.
* **Spacebar:** Shoot.
* **ESC:** Exit the game and return to the main menu.

## 🛠️ Prerequisites

To compile and run this project, you will need to have installed:

* [.NET SDK](https://dotnet.microsoft.com/download) (version 6.0 or higher recommended).
* A compatible terminal or console (the native Windows console is recommended for optimal rendering of ASCII characters and colors).

## 🚀 Installation & Execution

1. Clone this repository to your local machine:
   ```bash
   git clone [https://github.com/YOUR_USERNAME/YOUR_REPOSITORY.git](https://github.com/YOUR_USERNAME/YOUR_REPOSITORY.git)
