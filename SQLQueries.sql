USE StudentsDB;
GO

--1 запрос
SELECT
	Fullname,
	Birthday,
	Score
FROM
	Study
JOIN Student
ON Study.IdStudent = Student.Id
JOIN [Subject]
ON Study.IdSubject = [Subject].Id
JOIN Assessment
ON Study.IdAssessment = Assessment.Id
WHERE
	Birthday <= '26.12.1991' AND ([Name] = 'Информатика' AND Score >= 3);

--2 запрос
SELECT
	Fullname
FROM
	Study
JOIN Student
ON Study.IdStudent = Student.Id
JOIN [Subject]
ON Study.IdSubject = [Subject].Id
JOIN Assessment
ON Study.IdAssessment = Assessment.Id
WHERE
	Score = 5
GROUP BY
	Student.Id, Student.Fullname
HAVING
	COUNT([Subject].Id) >= 2;

--3 запрос
SELECT
	Course,
	COUNT(*) AS [Количество студентов]
FROM
	Student
GROUP BY
	Course;

--4 запрос
SELECT
	Fullname,
	Birthday,
	dbo.SumDigitsInDate(Birthday) AS [Сумма цифр]
FROM
	Student
WHERE
	dbo.SumDigitsInDate(Birthday) < 40
