WITH tempWeather AS 
(SELECT id, temperature,
LAG(temperature) OVER (ORDER BY recordDate) AS previous_temp
FROM Weather)

SELECT id
FROM tempWeather
WHERE temperature > previous_temp