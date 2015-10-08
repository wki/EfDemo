# Entity Framework 7 Postgres experiment

## Gotchas

 * Startup Class must exist until a bug is fixed
 * Postgres: database must exist prior to dnx ef command executions
 * Postgres: quoted identifiers are causing PascalCased tables and columns
 
## Commands

```
// create a migration
$ dnx ef migrations add initial-checkin

// update database definition
$ dnx ef database update

```
 