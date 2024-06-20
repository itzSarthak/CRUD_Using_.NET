# Task Manager API

A simple Task Manager API built with .NET, which supports CRUD operations (Create, Read, Update, Delete) on tasks. This project consists of five main APIs: `GET`, `GET {id}`, `POST`, `PUT`, and `DELETE`.


## Features

- **GET**: Retrieve all tasks.
- **GET {id}**: Retrieve a specific task by ID.
- **POST**: Create a new task.
- **PUT**: Update an existing task by ID.
- **DELETE**: Delete a task by ID.

Additionally, the project includes support for managing categories and subtasks:

- **Category**: Parent of Task
  - **GET**: Retrieve all categories.
  - **POST**: Create a new category.
  - **PUT**: Update an existing category by ID.
  - **DELETE**: Delete a category by ID.
  
- **Subtask**: Child of Task
  - **GET**: Retrieve all subtasks.
  - **POST**: Create a new subtask.
  - **PUT**: Update an existing subtask by ID.
  - **DELETE**: Delete a subtask by ID.

## Technologies Used

- .NET
- ASP.NET Core
- Entity Framework Core




## API Endpoints

### Task Endpoints

- **GET /api/tasks**: Retrieve all tasks.
- **GET /api/tasks/{id}**: Retrieve a specific task by ID.
- **POST /api/tasks**: Create a new task.
- **PUT /api/tasks/{id}**: Update an existing task by ID.
- **DELETE /api/tasks/{id}**: Delete a task by ID.

### Category Endpoints

- **GET /api/categories**: Retrieve all categories.
- **POST /api/categories**: Create a new category.
- **PUT /api/categories/{id}**: Update an existing category by ID.
- **DELETE /api/categories/{id}**: Delete a category by ID.

### Subtask Endpoints

- **GET /api/subtasks**: Retrieve all subtasks.
- **POST /api/subtasks**: Create a new subtask.
- **PUT /api/subtasks/{id}**: Update an existing subtask by ID.
- **DELETE /api/subtasks/{id}**: Delete a subtask by ID.




## Contact

If you have any questions or suggestions about this project, feel free to reach out.

- **GitHub**: [itzSarthak](https://github.com/itzSarthak)

---

Thank you for using the Task Manager API! We hope it helps you manage your tasks efficiently.
