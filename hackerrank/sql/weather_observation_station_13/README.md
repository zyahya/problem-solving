Use can use the `BETWEEN` operator in the where clause instead of writing a range.

```sql
SELECT CAST(ROUND(SUM(LAT_N), 4, 1) AS DECIMAL(32, 4))
FROM STATION
WHERE LAT_N BETWEEN 38.7880 AND 137.2345;
```
