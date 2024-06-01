# Git Platform Simulation in C#

![GitHub](https://img.shields.io/badge/GitHub-Git--Simulation-blue)

## Overview

This project is a simulation of a Git-like platform developed in C#. It leverages various design patterns to provide a robust and scalable solution. The aim is to mimic the core functionalities of Git while demonstrating the application of different design patterns.

## Features

- **Version Control:** Simulate basic Git operations like commit, branch, merge, and checkout.
- **Repository Management:** Create, clone, and delete repositories.
- **Design Patterns:** Utilizes multiple design patterns such as Singleton, Factory, Observer, Command, State, Memento, Flyweight, and Composite.
- **User Interface:** Simple command-line interface to interact with the system.

## Design Patterns Used

- **Singleton:** Ensures a single instance of the repository manager.
- **Factory:** Creates various objects like commits, branches, and repositories.
- **Observer:** Implements notification system for changes in repositories.
- **Command:** Encapsulates Git commands as objects to decouple sender and receiver.
- **State:** Manages the state of repository objects and transitions.
- **Memento:** Allows capturing and restoring the state of objects.
- **Flyweight:** Reduces memory usage by sharing as much data as possible with similar objects.
- **Composite:** Composes objects into tree structures to represent part-whole hierarchies.

## Getting Started

### Prerequisites

- [.NET 7 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)

### Installation

1. Clone the repository:
    ```sh
    git clone https://github.com/YourUsername/Git-Simulation.git
    ```

2. Navigate to the project directory:
    ```sh
    cd Git-Simulation
    ```

3. Build the project:
    ```sh
    dotnet build
    ```

### Usage

Run the application:
```sh
dotnet run
