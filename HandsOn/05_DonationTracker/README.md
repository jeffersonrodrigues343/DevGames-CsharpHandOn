# Phase 5: Recourse & Donation Tracker

This module simulates a financial tracking system, managing cumulative donations against a predefined goal and calculating the progress percentage.

## Objective

* Implement parameterized methods to handle verying input values.
* Calculate real-time percentage based on a mathematical formula.
* Output formatted data only when explicitly requested by the user.

## Architectural Decisions

* **Independent Execution Flow:** The `Update()` loop handles multiple inputs without `else if` chains. This allows the system to process a donation (Keys A, B, C) and a status report request (Spacebar key) within the same frame independently.

* **Single Responsibility Principle (SRP):** * `AddDonation(float amount)` is strictly responsible for modifying the data state.
  * `CalculateProgress()` is a pure mathematical engine that returns a `float` without interacting with the console.
  * `ShowReport()` acts as the presentation layer, requesting the math result and formatting the string output.

## Flowchart

![My Diagram](05_DonationTracker/Tracker.png).




## Core Logic

Below is the implementation of the independent triggers and the mathematical percentage engine:

```csharp
void Update()
{
    // State Modification Triggers
    if (Input.GetKeyDown(KeyCode.A)) AddDonation(10f);
    if (Input.GetKeyDown(KeyCode.B)) AddDonation(50f);
    if (Input.GetKeyDown(KeyCode.C)) AddDonation(100f);

    // Presentation Trigger
    if (Input.GetKeyDown(KeyCode.Space))
    {
        ShowReport();
    }
}

private float CalculateProgress()
{
    return (totalDonations / donationGoal) * 100f;
}

```


Mathematical Formula: 
    
![Alt text](Assets/Docs/Diagrams/Percentage.png)

Note: The complete working script, including the UI string interpolation, is available in DonationTracker.cs.