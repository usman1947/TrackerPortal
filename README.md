# TrackerPortal Schema

Database Schema can be found at this link (Note that the link will let you edit but not save)
https://drawsql.app/teams/workoutplanner/diagrams/workoutplanner

# Migrations
To add new migration add use command: *dotnet ef migrations add YourMigrationName --context DataContext*
 
To apply migrations to data base run command: *dotnet ef database update*

To revert a migration, you need to revert your db to the previous migration by running this command: 
*dotnet ef database update YourPreviousMigrationName --context DataContext*

After this your need to run the command: *dotnet ef migrations remove --context TenantDbContext*
This will delete the new created migration files and update the snapshot.

# BoilerPlate 

To jump start the project, boilerplate was downloaded from:
https://jasonwatmore.com/post/2022/06/23/net-6-connect-to-postgresql-database-with-entity-framework-core

documentation plate: https://jasonwatmore.com/post/2022/03/15/net-6-crud-api-example-and-tutorial

GitHub: https://github.com/cornflourblue/dotnet-6-crud-api
