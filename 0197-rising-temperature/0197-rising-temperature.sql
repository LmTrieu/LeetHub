# Write your MySQL query statement below
SELECT w1.id
FROM Weather as W1 JOIN Weather as W2
    ON DATEDIFF(W1.recordDate,W2.recordDate) = 1
WHERE w1.temperature > w2.temperature