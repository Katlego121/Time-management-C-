# Time Management Application (ASP WEB APPLICATION)
# DATABSE
* The web app is using a local database which is embedded on the project called StudyDB.mdf after opening the app
  please click on the database on solution explore underneath all the pages. This will help you get your connection string
  please change the login.cshtml.cs, index.cshtml.cs and display.cshtml.cs and modules.cshtml.cs to be able to connect to the database and use it.

## Description

This is a asp web core application built using C# and visual studio to code and create an sql local database to help save all the data. 
The application allows users to login, register and manage their study hours and self-study goals for different modules throughout a semester. 
The website saves the data.

## Features

- Registration page.
- Login Page.(Username: katlego, Password: 12345678)
- Display Page (With the saved modules data)
- Add and manage modules for the semester.
- Calculate self-study hours per week based on module credits and class hours.
- Record study hours for specific modules and dates.
- Display remaining self-study hours for each module.
- Data is stored in locally in StudyDB.mdf databse file found inside the project.

## Requirements

- .ASP CORE WEB Template

## Begin project

1. Open the solution in Visual Studio.
3. Build the solution to restore NuGet packages and generate necessary files.

## Usage

1. Run the web app.
2. Index page will pop up with a registration form, register.
3. Click "Already have an account" to navigate to the login page.
4. Fill in the modules form.
5. To see your data just click on DISPLAY on top of the form - it will direct you to the
   display page.


