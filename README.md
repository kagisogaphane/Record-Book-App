
# Record Book App

A simple yet powerful desktop application built with **C#**, leveraging **WPF** and the **MVVM pattern**.  
The Record Book App allows users to **add records** and **search for records by name**, providing a clean and efficient way to manage information.

---

## 🚀 Features
- **Add Records**: Users can create new entries with ease.
- **Search Records**: Quickly find records by entering a name.
- **MVVM Architecture**: Ensures separation of concerns, testability, and maintainability.
- **Command-Based Navigation**: Minimizes event handling by using commands to open and manage windows.
- **Modern Framework**: Built on **.NET 10** for performance and scalability.

---

## 🛠️ Tech Stack
- **Language**: C#
- **Framework**: WPF (Windows Presentation Foundation)
- **Architecture**: MVVM (Model-View-ViewModel)
- **Core Concepts**:
  - Data binding for UI responsiveness
  - Minimal event usage for cleaner code

---

##  Project Structure
```
RecordBookApp/
│
├── Models/          # Classes
├── ViewModels/      # Business logic 
├── Views/           # WPF XAML pages/windows
├── Commands/        # Commands
└── App.xaml         # Application entry point
```

---

##  Getting Started

### Prerequisites
- Windows OS
- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- Visual Studio 2022 or later

### Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/kagisogaphane/Record-Book-App.git
   ```
2. Open the solution in Visual Studio.
3. Build and run the project.

---

## Usage
1. Launch the app.
2. Add a new record by filling in the required fields.
3. Search for existing records by entering a name in the search bar.


---

##  Future Improvements
- Add record editing and deletion functionality.
- Implement persistent storage (e.g., SQLite or SQL Server).
- Add unit tests for ViewModels and services.

---

## Contributing
Contributions are welcome!  
Feel free to fork the repo, open issues, or submit pull requests.

