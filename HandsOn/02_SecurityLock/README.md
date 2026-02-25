# Phase 2: The "Security Lock" Challenge (Business Logic)

This exercise simulates a Software Architect's approach to real-world business rules, specifically mimicking a "Seat (1/1)" access error.

## Context & Objective
* **State Management:** Implement a boolean variable `isLicenseActive` initialized as `false`.
* **Action & Validation:** Separate the action of granting the license (Key **L**) from the action of attempting access (Key **C**).
* **Error Handling:** If unauthorized, the system must trigger a "Seat Unavailable" warning. Master conditional statements (`if/else`) applied to daily business logic requirements.

## Architectural Decisions
* **Separation of Concerns:** The input detection is handled separately from the business validation. This ensures the validation method can be reused by other systems (like UI buttons or server calls) without relying on keyboard inputs.
* **State-First Validation:** The flow ensures that the system state is checked *before* any high-level functionality is executed, preventing logical bypasses.

## Core Business Logic

The snippet below highlights the access validation method. Without a valid `true` state, the system remains locked, preventing unauthorized use of resources.

```csharp
public void ExecuteAccessValidation()
{
    // Business Logic Check
    if (isLicenseActive)
    {
        Debug.Log("Access Authorized: Welcome!");
    }
    else
    {
        Debug.LogWarning("Error: Seat Unavailable. License required to proceed.");
    }
}