# Ahunter_Final_CIDM3312

**Purpose and Functionality**
The primary purpose of "CommunityCanvas" is to serve as an interactive platform where users
can access and manage information about local nonprofit organizations and various community
projects. This centralized location for information will encourages community members to get
involved within their area.

**Key Features and Structure**
"CommunityCanvas" is structured into five essential pages:

● Main Page: Users are greeted with an overview of the community.For the purpose of this
project, it will focus on the Canyon/Amarillo area. The page is designed to be informative
and welcoming, and direct users to other pages.

● Organizations Page: This page features a searchable list of local nonprofit organizations.
Within the page, there is a button to “'Add Organization” button, which directs to the
form to add new nonprofit profiles to the database.

● Add Organizations Form: This form allows users to add new organizations to the
database. Essential details such as the organization's name, description, date of
establishment, and contact email can be entered here.

● Projects Page: This page lists out various projects, each with its name, description, end
date, and associated organizations. Similar to the Organizations page, this section
includes an 'Add Project' button, which links to the add project form.

● Add Project Form: Users can fill in details like the project name, a description, the
projected end date, and link the project to one or more organizations involved.

**Data Structure and Storage**
The data behind "CommunityCanvas" will consist of two tables: information about organizations
and details regarding community projects.

● Organizations Table: This will include:
- organization's name
- description
- contact email
- list of projects associated
  
● Projects Table: This table will hold:
- project name
- description
- end date
- list of participating organizations



# CheckList / Requirements

For the final project you will create an ASP.NET Core application using EF Core. You will combine all the
skills and technologies learned throughout this class into one complete web application.
Your task is to develop an idea for a web application that requires data storage and management, and
implement it using ASP.NET and EF Core with the following requirements.

Mark each complete (#) before submission:

# • Create a .gitignore file that contains “bin/” and “obj/”.

# • Your web application should have at least TWO database tables implemented as entity classes.

# • Follow steps 1-8 from Week 13 to create your ASP.NET Core project with EF Core.

• Use scaffolding (for step 8) on one of your entity classes.

# • Write code to display or modify related data. This can’t be scaffolded.

# • Seed the database with records for all your entities. Ensure that one entity has enough records (at least 25) to support paging.

# • Add Data Validation to all the necessary properties.

# Add paging support to a razor page. For example, list only ten records at a time.

• Add a search bar to at least one razor page. Allow the user to type in a search string and show
only those results.

• Allow the user to sort on at least one record both ascending and descending – OR – filter
records using a SelectList.

# • Add links to all appropriate pages in the navigation bar






# ASP.NET Core + EF Core 

In this lab exercise you will perform the 8 steps to create an ASP.NET Core app with EF Core. Your app will hard-code Organization names in an EF Core database and display those names in a Razor Page. You will also use a SelectList to allow the user to select a specific Organization.

## Step 1: Create an ASP.NET Core Project

1. Create an ASP.NET Core Project using the `dotnet new webapp` command.

## Step 2: Bring in EF Core Packages

1.	Add EF Core to the project:

```
dotnet add package Microsoft.EntityFrameworkCore.Sqlite --need to change version ?
dotnet add package Microsoft.EntityFrameworkCore.Design
```

## Step 3: Create the Complete EF Core Data Model

1.	Create a new folder called `Models`

2.	Inside the Models folder, create a new file called `Organization.cs`. This is an Entity Class.
      
3.	Inside the Models folder, create a new file called `OrganizationContext.cs`

## Step 4: Configure database settings in `appsettings.json`

1.	Write the proper configuration in the appsettings.json file.   

## Step 5: Dependency Injection Part 1

1.	Register your database context as a service using dependency injection
2.	**PAUSE**. Run dotnet build now at the terminal. If you see build errors, debug!

## Step 6: Migrations

1.	Perform the initial migrations at the terminal.

## Step 7: Seed Data

1.	Inside the `Models` folder, create a new file called `SeedData.cs`
2.	Write the code to create the `SeedData` class. Make at least 3 Organizations.
3.	Within `Program.cs`, write the code to call your `SeedData.Initialize()` method.
4.	**PAUSE**. Run dotnet build now at the terminal. If you see build errors, debug!



## Step 9: Use a SelectList inside a Form

1.	Create a new Razor Page with Page Model (`Organization.cshtml` + `Organization.cshtml.cs`)
2.	Inside the Page Model, use a SelectList to create a drop down with the list of Organizations.
      * The SelectList can display just the Organization’s first name.
3.	Inside the Razor Page, create a new form using Bootstrap techniques. Within the form:
      * Place a `<select>` tag with the appropriate HTML code and tag helpers.
      * Add a Submit button.
4.	Your web page should look similar to the pictures below.

![Image of webpage 1](https://i.imgur.com/z7kyPpl.png)
![Image of webpage 2](https://i.imgur.com/mGSArfm.png)

## Step 10: Making the Form work - Model Binding and OnPost()

1.	Add code to your Page Model and Razor Page so that the Submit button works.
2.	That means, once the user selects a Organization and hits submit, your app should find that Organization in the database and then display the selected Organization back on the web page.
3.	See the picture below for an illustration of how your page should work.
4.	This will require the following techniques:
     * Model Binding
     * Using the asp-for tag helper to facilitate Model Binding
     * Adding code to your OnPost() method that will find the selected Organization
     * Adding code to your Razor Page that will display the selected Organization
5.	Good luck!







# Web App Redux: Scaffolding and Related Data

In this lab exercise you will perform scaffolding, add a second entity class to your project, and connect that class with your existing one. This process is known as connecting related data.

## Step 0: Prepare Your Environment

1. Open your completed Lab 11 in Visual Studio Code

## Step 1: Scaffolding

1.  Bring in the required packages and tools for scaffolding:
```
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet tool uninstall --global dotnet-aspnet-codegenerator
dotnet tool install --global dotnet-aspnet-codegenerator
```
     
2.  Run the scaffolding command. Refer to the slides for the correct command. Note: You will have to make changes to the command to match your project.

3.  Once scaffolding is complete, run your project and visit the newly scaffolded pages.
      * Look at the Index page and ensure you have a list of all the Organizations.
      * Click “Create New” and make a new Organization. Ensure that it is added to your list.
      * Click “Edit” and edit a Organization. Ensure that your changes worked.
      * Click “Details” and see the details of a Organization.
      * Click “Delete” and delete a Organization. Ensure that the Organization is removed.

## Step 2: Connect Related Data

1.   Add a Project entity class. 
     * Each Project should have a ProjectId and a Description property.
     * Each Project is taught by ONE Organization, and a Organization may teach MANY Projects. Put in the correct navigation properties.
     * Add the DbSet<Project> property to your DbContext class.
2.   Modify your SeedData class:
     * One Organization should teach one Project.
     * Another Organization should teach at least two Projects.
     * A third Organization should teach no Projects.
     * Delete your Migrations/ folder and your database.db file. Re-run your migrations.
3.   **PAUSE**. Run your project. If you see build errors, debug! You should not see any changes on your website yet. Just make sure that it runs and looks OK.

## Step 3: Display your Projects (Read part of CRUD)

1.   Modify the Details page so that it shows each Project for each Organization.
     * Alter the Page Model to bring in the Projects using .Include()
     * Alter the Razor Page to loop through each Project and display them.
     * See Figure 1 for an illustration.

## Step 4: Delete a Project (Delete part of CRUD)

1.   Pick one of the two techniques shown in the slides and implement it.
     * Technique one is to create a Delete button inside the Details page
     * Technique two is to create a separate Delete page with a SelectList
     * Implement BOTH techniques for **extra credit.**
     * See Figures 1 and 2 for illustrations

## Step 5: Create a new Project (Create part of CRUD)

1.   Create an AddProject.cshtml Razor Page and AddProject.cshtml.cs Page Model
2.   Refer to Figure 2 for an example. When the user hits Submit, the page should redirect back to the Index page.
3.   Use a SelectList to allow the user to select from a drop down menu which Organization they want to teach the Project.
            
            
