# Unity & C# Logic & Architecture Lab

A professional repository dedicated to mastering C# logic, software architecture, and data manipulation within the Unity Engine. This project focuses on the transition from basic scripting to scalable software engineering.

## Tech Stack
* **Language:** C# (.NET)
* **Engine:** Unity 2022.3+
* **Principles:** SOLID (SRP), State Machines, Encapsulation.

## Learning Objectives
* **State Management:** Implementing finite state machines (FSM) using `switch/case`.
* **Method Architecture:** Decoupling mathematical engines from input triggers.
* **Data Manipulation:** Strategic use of variables (`int`, `float`, `bool`) and parameterized methods.

## Exercise Modules

### Phase 2: Security Lock (Business Logic)
* **Logic:** License validation system simulating a "Seat (1/1)" access error.
* **Key Concept:** State-first validation preventing logical bypasses and separating input detection from business rules.

### Phase 3: Access Control System (Privilege Levels)
* **Logic:** A cyclical security system that rotates through 4 privilege tiers.
* **Key Concept:** Using the modulo operator (%) to create a clean, continuous state loop without extensive conditional blocks.

### Phase 5: Resource & Donation Tracker
* **Logic:** Real-time financial monitoring with goal tracking and percentage calculations.
* **Key Concept:** Using method parameters (amount) to create a reusable logic engine for multiple inputs.
* **Formula:** Progress = (totalDonations / donationGoal) * 100

---
**Developed by Jefferson**
*"Building solid logic, one frame at a time."*
