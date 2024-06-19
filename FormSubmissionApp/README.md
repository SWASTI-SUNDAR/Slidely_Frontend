# My Windows Desktop Application

## Overview

This project is a Windows Desktop Application created using Visual Studio with Visual Basic. It includes functionality for viewing, creating, updating, and deleting submissions, along with a stopwatch feature.

## Features

- **View Submissions**: Navigate through submitted forms.
- **Create Submissions**: Submit new forms with details like Name, Email, Phone Number, GitHub repo link, and Stopwatch time.
- **Update Submissions**: Edit existing form submissions.
- **Delete Submissions**: Remove submissions by index.
- **Search Submissions**: Search for submissions by email.

## Installation and Setup

### Frontend

1. Open the solution in Visual Studio.
2. Restore NuGet packages if needed.
3. Build the solution to ensure all dependencies are resolved.

### Backend

1. Navigate to the backend directory in the terminal.
2. Run `npm install` to install dependencies.
3. Start the server with `npm start`.

## Usage

- **View Submissions**: Click "View Submissions" or press `Ctrl + V`.
- **Create New Submission**: Click "Create New Submission" or press `Ctrl + N`.
- **Toggle Stopwatch**: Press `Ctrl + T`.
- **Submit Form**: Press `Ctrl + S`.
- **Navigate Submissions**: Use `Ctrl + P` for Previous and `Ctrl + N` for Next.

## API Endpoints

- `GET /ping`: Check server status.
- `POST /submit`: Submit a new form.
- `GET /read`: Read a form submission by index.
- `DELETE /delete`: Delete a form submission by index.
- `PUT /update`: Update a form submission by index.
- `GET /search`: Search for submissions by email.

## Database

- **db.json**:
  ```json
  [
    {
      "name": "John Doe",
      "email": "john@example.com",
      "phone": "1234567890",
      "github_link": "https://github.com/johndoe",
      "stopwatch_time": "00:00:00"
    }
  ]
