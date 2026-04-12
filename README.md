# Prog6221 Part1
===================================================
#  Cybersecurity Awareness Chatbot (C# Console App)
===================================================

>  OVERVIEW

This is a simple **C# console-based chatbot** designed to promote **cybersecurity awareness**.
The chatbot interacts with users, answers basic questions, and provides guidance on staying safe online.

==========
 Features
===========
>  **User Personalization**

  - Prompts user for their name
  - Uses the name in responses

>  **Input Validation**

  - Prevents empty or invalid input
  - Ensures smooth user interaction

>  **Interactive Chat System**

  . Responds to questions like:

    - *How are you?*
    - *What is your purpose?*
    - *What can I ask you about?*

>  **Cybersecurity Topics Covered**

  - Password Safety
  - Phishing Awareness
  - Safe Browsing
  - Malware Protection
  - Wi-Fi Security

>  **User Experience Enhancements**

  - ASCII Art Logo
  - Typing animation effect
  - Colored console output

>  **Audio Features**

  - Startup sound using `.wav` file
  - Text-to-Speech using `System.Speech`

===================
# OOP Concepts Used
===================

> **Interface** → `IChatbot`
> **Encapsulation** → `ChatbotBase` class
> **Inheritance** → `CyberBot` inherits from `ChatbotBase`
> **Polymorphism** → Interface implementation
> **Methods** → Modular functions for clean design

======================
# Technologies Used
======================

- C#
- .NET Framework
- System.Speech (Text-to-Speech)
- System.Media (Audio playback)

==========================
## How to Run the Program
==========================

 1. Open Project

    - Open the project in **Visual Studio** or **VS Code**

 2. Add Audio File

    -Add a file named:

  ```
  Greeting.wav
  ```
  - Place it in the project directory

 3. Configure File Properties

   - Right-click the file → Properties
   - Set:

  ```
  Copy to Output Directory → Copy if newer
  ```

 4. Run the Application

```bash
dotnet run
```

===============
# Requirements
===============

-Windows OS (for `System.Speech`)
- .NET Framework installed
- `.wav` audio file format only

=============================
#  Example Questions to Try
=============================
* How are you?
* What is your purpose?
* What can I ask you about?
* Tell me about phishing
* Password safety tips
* Safe browsing tips

=======================
##  Project Structure
======================

```
CyberChat/
│── Program.cs
│── Greeting.wav
│── README.md
```

==========================
# Future Improvements
===========================
 - Add GUI (Windows Forms / WPF)
 - Save chat history to file
 - Add AI-based responses
 - Add menu-driven navigation

=======
Tools
=======
 >Visual Studio Commnuty 2026
 >Visual studio code

==============
# Author
==============
This project is developed by Seduma Mohau
Developed as a "Cybersecurity Awareness Chatbot" project using C#.






