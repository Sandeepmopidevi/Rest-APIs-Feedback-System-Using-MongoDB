# Feedback System Using MongoDB

## Overview

This project is a Feedback Management System built with ASP.NET Core and MongoDB. It provides a RESTful API to manage feedback entries, allowing users to create, retrieve, update, and delete feedback records. The system is designed to be simple and efficient, leveraging MongoDB for its NoSQL database capabilities to handle unstructured data.

## Key Features

- **CRUD Operations**: Create, Read, Update, and Delete feedback entries.
- **MongoDB Integration**: Utilizes MongoDB for storing and managing feedback data.
- **Simple REST API**: Exposes endpoints for interacting with feedback data.
- **NoSQL Flexibility**: Takes advantage of MongoDB’s schema-less nature to handle various feedback formats.

## API Endpoints

- **`GET /api/feedback`**: Retrieve a list of all feedback entries.
- **`GET /api/feedback/{id}`**: Retrieve a specific feedback entry by ID.
- **`POST /api/feedback`**: Create a new feedback entry.
- **`PUT /api/feedback/{id}`**: Update an existing feedback entry by ID.
- **`DELETE /api/feedback/{id}`**: Delete a feedback entry by ID.

## Getting Started

### Prerequisites

- .NET SDK 6.0 or later
- MongoDB instance or MongoDB Atlas cluster

### Installation

1. **Clone the Repository**

   ```bash
   git clone https://github.com/Sandeepmopidevi/Rest-APIs-Feedback-System-Using-MongoDB/
   cd Rest-APIs-Feedback-System-Using-MongoDB
   ```

2. **Configure MongoDB**

   Update the `appsettings.json` file with your MongoDB connection string and database name:

   ```json
   "MongoDbSettings": {
     "ConnectionString": "mongodb+srv://admin:<password>@api-test.yyyr6qt.mongodb.net/?retryWrites=true&w=majority&appName=api-test",
     "DatabaseName": "FeedbackDB"
   }
   ```

3. **Restore Dependencies**

   ```bash
   dotnet restore
   ```

4. **Run the Application**

   ```bash
   dotnet run
   ```

  ### Usage

You can use tools like [Postman](https://www.postman.com/) or [curl](https://curl.se/) to interact with the API endpoints. For example, to create a new feedback entry, you can send a POST request to `https://localhost:5001/api/feedback` with the following JSON body:

```json
{
    "name": "Sandeep",
    "email": "Sandeep@example.com",
    "phone": "123-456-7890",
    "comments": "Great service!",
    "rating": 5
}
```

### Contributing

Contributions are welcome! Please open an issue or submit a pull request to suggest improvements or report bugs.

### License

This project is licensed under the MIT License. See the LICENSE file for details.

## Contact

For questions or feedback, please contact (mailto:asksandeepsdl@gmail.com).
