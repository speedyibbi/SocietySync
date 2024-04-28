use SocietySyncDB;

CREATE TABLE Users (
  user_id INT PRIMARY KEY IDENTITY(1,1),
  email VARCHAR(100) UNIQUE NOT NULL,
  password_hash VARCHAR(MAX) NOT NULL,
  first_name VARCHAR(50) NOT NULL,
  last_name VARCHAR(50) NOT NULL,
  phone_number VARCHAR(20),
  admin BIT DEFAULT 0
);

CREATE TABLE Societies (
  society_id INT PRIMARY KEY IDENTITY(1,1),
  name VARCHAR(255) UNIQUE NOT NULL,
  description TEXT,
  president INT FOREIGN KEY REFERENCES Users(user_id) ON DELETE SET NULL,
  created_at DATETIME DEFAULT CURRENT_TIMESTAMP,
  CONSTRAINT fk_society_president FOREIGN KEY (president) REFERENCES Users(user_id)
);

CREATE TABLE UserRoles (
  role_id INT PRIMARY KEY IDENTITY(1,1),
  name VARCHAR(50) NOT NULL,
  description TEXT
);

CREATE TABLE Memberships (
  membership_id INT PRIMARY KEY IDENTITY(1,1),
  user_id INT FOREIGN KEY REFERENCES Users(user_id) ON DELETE CASCADE,
  society_id INT FOREIGN KEY REFERENCES Societies(society_id) ON DELETE CASCADE,
  role_id INT FOREIGN KEY REFERENCES UserRoles(role_id) ON DELETE SET NULL,
  joined_at DATETIME DEFAULT CURRENT_TIMESTAMP,
  CONSTRAINT fk_membership_user FOREIGN KEY (user_id) REFERENCES Users(user_id),
  CONSTRAINT fk_membership_society FOREIGN KEY (society_id) REFERENCES Societies(society_id),
  CONSTRAINT fk_membership_role FOREIGN KEY (role_id) REFERENCES UserRoles(role_id)
);

CREATE TABLE Events (
  event_id INT PRIMARY KEY IDENTITY(1,1),
  society_id INT FOREIGN KEY REFERENCES Societies(society_id) ON DELETE CASCADE,
  title VARCHAR(255) NOT NULL,
  description TEXT,
  start_date DATETIME NOT NULL,
  end_date DATETIME NOT NULL,
  location VARCHAR(255),
  created_by INT FOREIGN KEY REFERENCES Users(user_id) ON DELETE SET NULL,
  created_at DATETIME DEFAULT CURRENT_TIMESTAMP,
  CONSTRAINT fk_event_society FOREIGN KEY (society_id) REFERENCES Societies(society_id),
  CONSTRAINT fk_event_creator FOREIGN KEY (created_by) REFERENCES Users(user_id)
);

CREATE TABLE Teams (
  team_id INT PRIMARY KEY IDENTITY(1,1),
  event_id INT FOREIGN KEY REFERENCES Events(event_id) ON DELETE CASCADE,
  name VARCHAR(255) NOT NULL,
  description TEXT,
  team_head_id INT FOREIGN KEY REFERENCES Users(user_id) ON DELETE SET NULL,
  created_at DATETIME DEFAULT CURRENT_TIMESTAMP,
  CONSTRAINT fk_team_event FOREIGN KEY (event_id) REFERENCES Events(event_id),
  CONSTRAINT fk_team_head FOREIGN KEY (team_head_id) REFERENCES Users(user_id)
);

CREATE TABLE TeamMembers (
  team_member_id INT PRIMARY KEY IDENTITY(1,1),
  team_id INT FOREIGN KEY REFERENCES Teams(team_id) ON DELETE CASCADE,
  user_id INT FOREIGN KEY REFERENCES Users(user_id) ON DELETE CASCADE,
  CONSTRAINT fk_team_member_team FOREIGN KEY (team_id) REFERENCES Teams(team_id),
  CONSTRAINT fk_team_member_user FOREIGN KEY (user_id) REFERENCES Users(user_id)
);

CREATE TABLE Tasks (
  task_id INT PRIMARY KEY IDENTITY(1,1),
  team_id INT FOREIGN KEY REFERENCES Teams(team_id)  ON DELETE CASCADE,
  title VARCHAR(255) NOT NULL,
  description TEXT,
  assigned_to INT FOREIGN KEY REFERENCES Users(user_id) ON DELETE SET NULL,
  due_date DATETIME,
  created_at DATETIME DEFAULT CURRENT_TIMESTAMP,
  completed BIT DEFAULT 0,
  CONSTRAINT fk_task_team FOREIGN KEY (team_id) REFERENCES Teams(team_id),
  CONSTRAINT fk_task_assignee FOREIGN KEY (assigned_to) REFERENCES Users(user_id)
);

CREATE TABLE Announcements (
  announcement_id INT PRIMARY KEY IDENTITY(1,1),
  user_id INT FOREIGN KEY REFERENCES Users(user_id) ON DELETE SET NULL,
  society_id INT FOREIGN KEY REFERENCES Societies(society_id) ON DELETE SET NULL,
  event_id INT FOREIGN KEY REFERENCES Events(event_id),
  text TEXT NOT NULL,
  created_at DATETIME DEFAULT CURRENT_TIMESTAMP,
  CONSTRAINT fk_announcement_user FOREIGN KEY (user_id) REFERENCES Users(user_id),
  CONSTRAINT fk_announcement_society FOREIGN KEY (society_id) REFERENCES Societies(society_id),
  CONSTRAINT fk_announcement_event FOREIGN KEY (event_id) REFERENCES Events(event_id)
);

SELECT * FROM Users;
DELETE FROM Users;

UPDATE Users
SET admin = 1
WHERE user_id = 1;

SELECT * FROM UserRoles;
INSERT INTO UserRoles (name, description) VALUES ('President', 'Highest level executive in a society.');
INSERT INTO UserRoles (name, description) VALUES ('Executive', 'Division head in a society.');
INSERT INTO UserRoles (name, description) VALUES ('Member', 'Part of a society.');
INSERT INTO UserRoles (name, description) VALUES ('Head', 'Team lead in an event.');
INSERT INTO UserRoles (name, description) VALUES ('Pending', 'Unofficial part of a society.');

SELECT * FROM Memberships;
DELETE FROM Memberships;

SELECT * FROM Societies;
DELETE FROM Societies;

SELECT * FROM Events;
DELETE FROM Events;

SELECT * FROM Announcements;
DELETE FROM Announcements;

DROP TABLE Teams;
DROP TABLE TeamMembers;
DROP TABLE Tasks;
DROP TABLE Events;
DROP TABLE Announcements;
DROP TABLE Memberships;
DROP TABLE Societies;
DROP TABLE UserRoles;
DROP TABLE Users;
