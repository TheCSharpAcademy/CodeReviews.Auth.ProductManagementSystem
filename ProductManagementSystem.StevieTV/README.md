# Project - Product Management System - Authorization and Authentication Roles

The goal of this project was to learn about authorization and authentication within an MVC project.
The project is part of TheCSharpAcademy: https://thecsharpacademy.com/project/72/product-management-system

The project makes use of ASP.Net Identity to provide user and role functionality.
`Staff` may add or edit VideoGames, however only `Admin` users can delete them.

### Features of the project

* A user who registers will default to the roll `Staff`.
* Users with the role `Admin` can edit other users and provide them additional roles.
* The links for role and user management will only appear to `Admin` users.
* Registration needs to be confirmed by a link in an email sent after registration.
* `Staff` may add or edit VideoGames, however only `Admin` users can delete them.
* None logged in users will not see edit or delete links
* Error logging is done to database by means of a Custom ILogger implementation

### Configuration

* The email settings should be edited in appsettings.json before running
* Default admin user is `admin@admin.com` with password `Password123!`
* Default staff user is `staff@staff.com` with password `Password123!`