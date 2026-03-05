# Windows Forms ComboBox & Image Switcher

A practical C# Windows Forms application designed to demonstrate the interaction between a `ComboBox` and a `PictureBox`. This project serves as an educational exercise in handling selection events and dynamic resource management.

## Project Overview
The application allows users to select an item name from a dropdown list (ComboBox). Once an item is selected, the application dynamically updates the UI to display the corresponding image and a descriptive label.

## Key Features
* **Dynamic Event Handling:** Uses the `SelectedIndexChanged` event to trigger UI updates.
* **Resource Management:** Efficiently loads images from project resources based on user selection.
* **Modular Code:** Implementation of a dedicated method (`changeComboBox`) to handle the logic, making the code cleaner and reusable.
* **Real-time UI Updates:** Instant feedback for the user through labels and picture boxes.

## Technologies Used
* **Language:** C#
* **Framework:** .NET Framework 4.7.2
* **UI Technology:** WinForms (Windows Forms)

## How It Works
1. The user opens the dropdown menu containing a list of objects (Book, Girl, Boy, Pen).
2. Upon selecting an item, the `cb1_SelectedIndexChanged` event is fired.
3. The `changeComboBox` method evaluates the selected index using a `switch` statement.
4. The `PictureBox` image and the `Label` text are updated according to the selection.

## Installation & Setup
1. Clone the repository.
2. Open the solution file (`.sln`) in Visual Studio.
3. Build and run the project (Press `F5`).
