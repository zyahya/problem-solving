In SQL Server string comparison is mostly insensitive but that's depending on the `Collation` settings. If it's contain `CI` mean it's insensitive.

```sql
SELECT DATABASEPROPERTYEX(DB_NAME(), 'Collation'); -- SQL_Latin1_General_CP1_CI_AS
```
