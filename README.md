# Task Management Application
A simple yet powerful Windows Forms application built with C# and .NET for managing tasks and persons. It includes full CRUD functionality, CSV data storage, filtering, sorting, a visual progress bar, chart display, export to Excel/PDF, and a clean, user-friendly interface. Ideal for tracking task status, deadlines, and responsibilities in personal or team projects.


# Technology Stack🛠️
Language: C#

Framework: .NET (Windows Forms)

IDE: Visual Studio 2022

Data Storage: CSV Files

UI Components: Windows Forms Controls (DataGridView, Chart, ProgressBar, GroupBoxes)

Export Features: Excel and PDF (via third-party libraries or built-in options)

Installer: .exe file created using Visual Studio Setup Project or similar

# 🚀 Installation & Usage
# 🔧 Prerequisites
Visual Studio 2022 or later installed

.NET Desktop Development workload enabled

.NET Framework (e.g., .NET 6 or .NET Core 9, depending on your target)

Windows OS

# 📥 Clone the Repository
bash
Copy
Edit
git clone https://github.com/your-username/project.git
cd SmartTaskManagerApp
🛠️ Run and Compile the Project
Open the .sln file in Visual Studio 2022.

Restore NuGet packages if prompted.

Set the startup project (usually SmartTaskManagerApp).

Click Start or press F5 to build and run the application.

# 📂 File Storage
All data (Tasks & Persons) are saved in local .csv files.

These files are automatically created in the project directory if they don’t exist.

# 🧑‍💼  Features Overview
Add/Edit/Delete Tasks and Persons

Assign one Person to multiple Tasks (one-to-many relationship)

Filter by Task Status or Responsible Person

Sort by Name, Start Date, Due Date, or Person

Progress bar shows overall task completion

Charts visualize task statistics

Export data to Excel/PDF

Installer provided as .exe file for easy distribution

