CREATE DATABASE ScienceQuestionsDB;

USE ScienceQuestionsDB;

CREATE TABLE ScienceQuestions (
    QuestionID INT PRIMARY KEY,
    QuestionText NVARCHAR(MAX),
    Option1 NVARCHAR(MAX),
    Option2 NVARCHAR(MAX),
    Option3 NVARCHAR(MAX),
    Option4 NVARCHAR(MAX),
    CorrectOption INT
);

-- Science Questions
INSERT INTO ScienceQuestions (QuestionID, QuestionText, Option1, Option2, Option3, Option4, CorrectOption)
VALUES
(1, 'What is the chemical symbol for water?', 'H2O', 'CO2', 'O2', 'NaCl', 1),
(2, 'Which planet is known as the Red Planet?', 'Earth', 'Mars', 'Jupiter', 'Venus', 2),
(3, 'What is the unit of measurement for force?', 'Kilogram', 'Meter', 'Newton', 'Joule', 3),
(4, 'What is the process by which plants make their food called?', 'Photosynthesis', 'Respiration', 'Transpiration', 'Fermentation', 1),
(5, 'What is the hardest natural substance on Earth?', 'Diamond', 'Graphite', 'Quartz', 'Topaz', 1),
(6, 'Which gas is most abundant in the Earth''s atmosphere?', 'Oxygen', 'Nitrogen', 'Carbon Dioxide', 'Helium', 2),
(7, 'What is the study of living organisms called?', 'Geology', 'Biology', 'Physics', 'Chemistry', 2),
(8, 'Which of the following is a renewable source of energy?', 'Coal', 'Natural Gas', 'Solar Power', 'Petroleum', 3),
(9, 'What is the closest star to Earth?', 'Proxima Centauri', 'Sirius', 'Alpha Centauri', 'Betelgeuse', 1),
(10, 'What is the process of turning a liquid into vapor called?', 'Condensation', 'Evaporation', 'Sublimation', 'Filtration', 2);

-- Sports Questions
INSERT INTO SportsQuestions (QuestionID, QuestionText, Option1, Option2, Option3, Option4, CorrectOption)
VALUES
(1, 'Which sport uses a racket to hit a ball?', 'Basketball', 'Tennis', 'Soccer', 'Golf', 2),
(2, 'Which of these is a team sport?', 'Swimming', 'Tennis', 'Golf', 'Football', 4),
(3, 'Which country won the FIFA World Cup in 2018?', 'Germany', 'Brazil', 'Argentina', 'France', 4),
(4, 'In which sport would you perform a slam dunk?', 'Basketball', 'Soccer', 'Tennis', 'Golf', 1),
(5, 'How many players are there on a baseball team?', '5', '7', '9', '11', 3),
(6, 'Which sport is played on ice with a stone and brooms?', 'Curling', 'Ice Hockey', 'Figure Skating', 'Speed Skating', 1),
(7, 'Which country won the most Olympic gold medals in the 2016 Summer Olympics?', 'USA', 'China', 'Russia', 'Great Britain', 1),
(8, 'Who holds the record for the most Grand Slam titles in men''s tennis?', 'Roger Federer', 'Rafael Nadal', 'Novak Djokovic', 'Pete Sampras', 1),
(9, 'Which sport is known as the "king of sports"?', 'Soccer', 'Tennis', 'Basketball', 'Golf', 1),
(10, 'What is the diameter of a basketball hoop in inches?', '16', '18', '20', '22', 2);

-- History Questions
INSERT INTO HistoryQuestions (QuestionID, QuestionText, Option1, Option2, Option3, Option4, CorrectOption)
VALUES
(1, 'Who was the first President of the United States?', 'Thomas Jefferson', 'George Washington', 'Abraham Lincoln', 'John Adams', 2),
(2, 'In which year did World War II end?', '1945', '1939', '1918', '1941', 1),
(3, 'Who wrote the famous diary during World War II?', 'Anne Frank', 'Rosa Parks', 'Helen Keller', 'Joan of Arc', 1),
(4, 'Who was the first female Prime Minister of the United Kingdom?', 'Margaret Thatcher', 'Theresa May', 'Queen Elizabeth II', 'Angela Merkel', 1),
(5, 'Which city was the capital of the Roman Empire?', 'Rome', 'Athens', 'Paris', 'London', 1),
(6, 'Which famous battle took place in 1066 and changed the course of English history?', 'Battle of Hastings', 'Battle of Agincourt', 'Battle of Thermopylae', 'Battle of Waterloo', 1),
(7, 'Who was the first Emperor of China?', 'Qin Shi Huang', 'Sun Tzu', 'Confucius', 'Mao Zedong', 1),
(8, 'Which ancient civilization built the pyramids?', 'Greeks', 'Romans', 'Egyptians', 'Persians', 3),
(9, 'Who was the leader of the Soviet Union during the Cuban Missile Crisis?', 'Nikita Khrushchev', 'Joseph Stalin', 'Vladimir Lenin', 'Mikhail Gorbachev', 1),
(10, 'Who was the longest-reigning monarch in British history?', 'Queen Victoria', 'King Henry VIII', 'Queen Elizabeth II', 'King George III', 3);

-- Math Questions
INSERT INTO MathQuestions (QuestionID, QuestionText, Option1, Option2, Option3, Option4, CorrectOption)
VALUES
(1, 'What is the value of π (pi) rounded to two decimal places?', '3.14', '3.16', '3.12', '3.18', 1),
(2, 'What is the square root of 144?', '12', '14', '10', '16', 1),
(3, 'What is the sum of the angles in a triangle?', '90 degrees', '180 degrees', '270 degrees', '360 degrees', 2),
(4, 'What is the mathematical constant e (Euler''s number) approximately equal to?', '2.72', '3.14', '1.62', '1.41', 1),
(5, 'What is the value of the expression: 5 * (8 + 2) / 2?', '30', '25', '40', '35', 2),
(6, 'What is the perimeter of a rectangle with length 10 units and width 5 units?', '20 units', '25 units', '30 units', '35 units', 3),
(7, 'What is the next number in the sequence: 1, 1, 2, 3, 5, 8, ...?', '10', '11', '12', '13', 8),
(8, 'What is the largest prime number less than 20?', '15', '17', '19', '21', 3),
(9, 'What is the value of 3 factorial (3!)?', '3', '6', '9', '12', 2),
(10, 'What is the area of a circle with radius 6 units?', '12π square units', '18π square units', '24π square units', '36π square units', 4);





