# PdfDocxFileConvertToBase64

PdfDocxFileConvertToBase64 is an ASP.NET MVC project that allows users to upload PDF and DOCX files, converts them to Base64 format, and stores the Base64-encoded content along with file metadata in a database. This project serves as a simple example of file upload and database interaction in an ASP.NET MVC application.

## Features

- **File Upload:** Users can select PDF or DOCX files to upload.
- **Base64 Conversion:** Uploaded files are converted to Base64 format for storage.
- **Database Integration:** The Base64 content, along with file metadata, is stored in a SQL Server database.
- **Alert on Success:** Users receive an alert upon successful file upload and database update.

## Getting Started

To run this project locally, follow these steps:

1. Clone the repository:

   git clone https://github.com/alif-dot/PdfDocxFileConvertToBase64.git

2. Open the solution in Visual Studio.

3. Update the connection string in `Web.config` to point to your SQL Server instance.

4. Run the application.

5. Access the application in your web browser at `http://localhost:port` (replace `port` with the appropriate port number).

## Technologies Used

- **ASP.NET MVC:** Framework for building web applications.
- **Entity Framework:** Object-relational mapper for database interaction.
- **C#:** Programming language used for server-side logic.
- **JavaScript and jQuery:** Used for client-side scripting and alert display.
- **SQL Server:** Database management system for storing file data.

## Contributing

Contributions are welcome! If you have suggestions or improvements, feel free to open an issue or submit a pull request.
