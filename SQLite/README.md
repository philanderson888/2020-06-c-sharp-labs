# SQLite



SQL => large server

SQLite => mobile or tablet, very small 'footprint' ie space it takes and CPU/RAM required to run 

- Industry standard
- Similar syntax to real SQL

### Tools

1. SQLite.org

   Note : use SQLite with older `cmd` rather than newer `powershell`

2. SQLiteStudio.pl



### Modes

1. Interactive (live)
2. Execute command from outside the environment



### New Database

from `outside the environment` 

```
sqlite3 mydatabase.db
```

list 

```
.databases
```

use

```
.open mydatabase.db
```



### Create table

```
create table mytable(
	id int,
	name varchar(20)
);
```

Check tables

```
.tables
```

### Insert data

```
insert into mytable values (1,'bob');
insert into mytable values (2,'tim');
insert into mytable values (3,'paul');
```

Check data

```
select * from mytable;
```

### Install and use northwind

1. download .sql Northwind file

2. Create database with 

   ```
   sqlite3 Northwind.db < Northwind.sql
   ```

   

### Autoincrement

```
create table mytable (
	id integer primary key, 
	name varchar(20)  
);
```





### Can we use this in C#?????????

- Copy Northwind.db into our C# API project at the root of the project, not in the .bin folder

- In Visual Studio Startup.cs add this line

  ```
              services.AddDbContext<NorthwindContext>(options => options.UseSqlite("Filename=Northwind.db"));
  ```

  