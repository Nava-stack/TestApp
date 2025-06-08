CREATE TABLE Events (
    EventID INT IDENTITY(1,1) PRIMARY KEY,
    EventName NVARCHAR(100) NOT NULL,
    EventDate DATE NOT NULL,
    Location NVARCHAR(100) NOT NULL,
    EventType NVARCHAR(50) NOT NULL,
    IsIndoor BIT NOT NULL,
    MaxParticipants INT NOT NULL
);

INSERT INTO Events (EventName, EventDate, Location, EventType, IsIndoor, MaxParticipants)
VALUES 
('Judo Open Tournament', '2025-07-15', 'Colombo Stadium', 'Tournament', 0, 200),
('Beginner Practice Session', '2025-07-20', 'Club Dojo', 'Practice', 1, 30),
('Advanced Belt Seminar', '2025-08-01', 'Kandy Sports Center', 'Seminar', 1, 50),
('Kids Friendly Match Day', '2025-08-10', 'Galle Grounds', 'Tournament', 0, 100),
('Evening Practice Drill', '2025-08-15', 'Club Dojo', 'Practice', 1, 20),
('Guest Seminar with Sensei Tanaka', '2025-09-05', 'Colombo Conference Hall', 'Seminar', 1, 150);

SELECT * FROM Events;