# WorkoutTrackerApp Backend Repo


## About The Project
This project is to practice my dotnet skills and build a Relational BE structure for WorkoutTrackerApp

## Installation
1. Clone the repository
```
https://github.com/usman1947/TrackerPortal.git
```
2. You will need Postgres server running in background at port 5433
3. Change appsetting.json to update Db password and hostname
4. Run this command
```
dotnet watch run 
```

## Db Schema
Database Schema can be found at this link (Note that the link will let you edit but not save)
```
https://drawsql.app/teams/workoutplanner/diagrams/workoutplanner
```

## Postman Api Collection
Some of the useful Apis can be found in this collection.
```
https://www.getpostman.com/collections/350ada4eb2e1469b4748
```

## Migrations
* To Add New Migrations
```
dotnet ef migrations add YourMigrationName --context DataContext
```

* To Apply Latest Migration to Database
```
dotnet ef database update
```

* To Remove Last Created Migrations, You Need to Revert Your DB To Previous Migration (if applied to DB already)
```
dotnet ef database update YourPreviousMigrationName --context DataContext
```

* To Delete Last Created Migration Files
```
dotnet ef migrations remove --context TenantDbContext
````

## BoilerPlate 

To jump start the project, boilerplate was downloaded from:
```
https://jasonwatmore.com/post/2022/06/23/net-6-connect-to-postgresql-database-with-entity-framework-core
```
* BoilerPlate documentation:
```
documentation plate: https://jasonwatmore.com/post/2022/03/15/net-6-crud-api-example-and-tutorial
```
* BoilerPlate github:
```
GitHub: https://github.com/cornflourblue/dotnet-6-crud-api
```
