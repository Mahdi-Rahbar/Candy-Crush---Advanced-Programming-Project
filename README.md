# 🍬 Candy Crush - Advanced Programming Project

## 📌 Introduction
This project is a Windows Forms application developed in **C#** as part of an advanced programming university course. The goal is to implement a **Candy Crush**-like game using **object-oriented programming (OOP)** principles and advanced **C#** concepts.

## 🎯 Features Implemented

### 🔹 Initial Menu
- The first form that opens upon running the project.
- It contains two buttons:
  - **Sign Up:** Users can register with a username and password.
  - **Sign In:** Users can log in to access the main menu.

### 🔹 Main Menu
- After signing in, users enter the main menu, which includes:
  - **Play:** Starts the game.
  - **Match (Not Implemented):** Intended for a two-player mode.
  - **Exit:** Closes the application.
- Three buttons for user interaction:
  - **Sign Up:** Users can register with a username and password.
  - **Sign In:** Users can log in to access the game.
  - **Exit:** Closes the application.

### 🔹 User Authentication
- **Sign Up Form:** Allows users to create an account with credentials.
- **Sign In Form:** Users log in using their registered credentials to access the main menu.

### 🔹 Game Screen
- A grid of candies is displayed.
- Players can swap candies using the **mouse** and **arrow keys**.
- **1-minute timer** to reach a target score.
- Successful moves trigger **sound effects** and increase the score.
- **Rearrange button** to shuffle the board randomly.

### 🔹 Match Mode (Not Implemented)
- This feature was planned for a two-player mode but is not implemented in this version.

### 🔹 Exit Button
- Allows users to exit the game safely.

## 📂 Data Handling
- The project uses **Entity Framework** to manage database operations.
- **SQL Server** is used to store user authentication data.

## 🛠 Technologies & Libraries Used
- **C# .NET (Windows Forms)** for UI and logic.
- **Entity Framework** for database interactions.
- **SQL Server** for data storage.
- **Multimedia Support** for background music and sound effects.

## 🚀 How to Run
1. **Clone this repository:**
   ```bash
   git clone https://github.com/yourusername/candy-crush.git
   cd candy-crush
   ```
2. **Set up the database:**
   - Ensure **SQL Server** is installed and configured.
   - Run the provided SQL script to create the necessary tables.
3. **Build and Run:**
   - Open the project in **Visual Studio**.
   - Restore NuGet packages and build the solution.
   - Run the application.

## 🔮 Future Enhancements
- Implementing **multiplayer mode**.
- Adding more **game mechanics** and special effects.
- Enhancing the **UI/UX** for a more immersive experience.

## 📸 Screenshots
Here are some screenshots from the project:

![Sign Up Form](https://github.com/Mahdi-Rahbar/Candy-Crush---Advanced-Programming-Project/blob/main/Screenshots/Screenshot%202025-01-29%20174241.png?raw=true.png)
![Sign In Form](https://github.com/Mahdi-Rahbar/Candy-Crush---Advanced-Programming-Project/blob/main/Screenshots/Screenshot%202025-01-29%20215704.png?raw=true.png)
![Main Menu](https://github.com/Mahdi-Rahbar/Candy-Crush---Advanced-Programming-Project/blob/main/Screenshots/Screenshot%202025-01-29%20215919.png?raw=true.png)
![Game Screen](https://github.com/Mahdi-Rahbar/Candy-Crush---Advanced-Programming-Project/blob/main/Screenshots/Screenshot%202025-01-29%20215934.png?raw=true.png)
![Game Gif](https://github.com/Mahdi-Rahbar/Candy-Crush---Advanced-Programming-Project/blob/main/Screenshots/tet_gif.gif?raw=true.gif)

