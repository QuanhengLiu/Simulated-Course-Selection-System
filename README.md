# Simulated-Course-Selection-System
Tongji University Course Selection Simulation System Developed Using C# and SQL Server


## Project Demo

| Login Interface | Course Selection |
| :---: | :---: |
| ![Login Screen](https://github.com/user-attachments/assets/cb468eb3-238a-4e5a-9666-d11d54430adc) | ![Selection Screen](https://github.com/user-attachments/assets/8309cff6-c5b5-4e00-b7e2-6d4221d8f0c5) |

---

## Technologies Used

* **Language:** C# (.NET Framework 4.6.1)
* **Database:** Microsoft SQL Server
* **IDE:** Visual Studio 2017
* **Key Concepts:**
    * **WinForms:** For building the graphical user interface.
    * **ADO.NET:** For efficient database connectivity and operations.

---

## Key Features

* **Role-Based Access Control (RBAC):** Supports three distinct user roles—Student, Teacher, and Administrator—with specific permissions and views.
* **Conflict Detection:** Automatically detects time conflicts during the course selection process to prevent overlapping schedules.
* **Schedule Management:** Allows students to view and save their personalized class schedules.
* **Security:** Implements basic validation mechanisms to prevent SQL injection attacks.

---

## Database Design

> **Note:** Due to local environment limitations, an automated SQL initialization script is not currently included.

**Please refer to `Database_Design_Doc.pdf` for the detailed database schema, E-R diagrams, and design documentation.**

---

## How to Run

1.  **Clone the repository:**
    ```bash
    git clone https://github.com/QuanhengLiu/Simulated-Course-Selection-System.git
    ```
2.  **Open the project:**
    Launch Visual Studio and open the `.sln` solution file.
3.  **Configure Database:**
    First import the ".sql" file into your own database. Then in the "登录.cs" file, configure the database connection to your own.
4.  **Build and Run:**
    Click `Start` in Visual Studio to launch the application.

---

## Acknowledgments

* Special thanks to **Jianfeng Zhao** for his valuable assistance in the design and implementation of the database.
* Thanks to **Haoyu Wang** for preparing the presentation documentation and demo materials.

---

## License

This project is licensed under the [MIT License](LICENSE).
