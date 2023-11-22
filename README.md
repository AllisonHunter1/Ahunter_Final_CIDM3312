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

Create a .gitignore file that contains “bin/” and “obj/”.

Your web application should have at least TWO database tables implemented as entity classes.

Follow steps 1-8 from Week 13 to create your ASP.NET Core project with EF Core.

Use scaffolding (for step 8) on one of your entity classes.

Write code to display or modify related data. This can’t be scaffolded.

Seed the database with records for all your entities. Ensure that one entity has enough records (at least 25) to support paging.

Add Data Validation to all the necessary properties.

Add paging support to a razor page. For example, list only ten records at a time.

Add a search bar to at least one razor page. Allow the user to type in a search string and show only those results.

Allow the user to sort on at least one record both ascending and descending – OR – filter records using a SelectList.

Add links to all appropriate pages in the navigation bar
