# 🎯 Quiz Generator – C# Console Application

A clean and practical **C# console-based Quiz Generator** built using solid **Object-Oriented Programming (OOP)** concepts and **LINQ**.  
The application dynamically generates quizzes with **Multiple Choice Questions (MCQ)** and **True/False** questions, validates user input, and calculates scores in real-time.

---

## 🚀 Features

- ✅ **Dynamic quiz generation** with randomized questions using LINQ.
- ✅ Supports both:
  - **MCQ (4 choices)**
  - **True / False (2 choices)**.
- ✅ **Real-time answer validation & scoring system**.
- ✅ Robust **user input validation** using `int.TryParse`.
- ✅ Clean separation of responsibilities:
  - `Program` → Application entry point.
  - `Exam` → Quiz flow & validation logic.
  - `QuestionBank` → Question storage & quiz generation.
  - `Question`, `Choice`, `Student` → Domain models.
- ✅ User-friendly console output with colored feedback.

---

## 🛠️ Technologies Used

- **C# (.NET Console Application)**
- **LINQ** for randomization and filtering
- **Object-Oriented Programming**
- Safe input validation patterns
