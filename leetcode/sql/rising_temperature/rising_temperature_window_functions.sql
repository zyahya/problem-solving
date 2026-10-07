SELECT id AS Id
FROM (
    SELECT
        *,
        LAG(recordDate) OVER (ORDER BY recordDate) AS PreviousDay,
        LAG(temperature) OVER (ORDER BY recordDate) AS PreviousDayTemperature
    FROM Weather
)t WHERE
    temperature > PreviousDayTemperature
    AND
    DATEDIFF(day, PreviousDay, recordDate) = 1;
