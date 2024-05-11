
select * from trainer;
select * from gym_member
CREATE TABLE Workout_Plan(
	id INT IDENTITY(1,1) PRIMARY KEY,
	name VARCHAR(50) NOT NULL,
	);
CREATE TABLE Diet_Plan(
	id INT IDENTITY(1,1) PRIMARY KEY,
	name VARCHAR(50) NOT NULL,
	purpose VARCHAR(50) NOT NULL,
	);
CREATE TABLE GYM_OWNER(
	UName VARCHAR(50) PRIMARY KEY NOT NULL,
	pWord VARCHAR(50) NOT NULL,
	fName VARCHAR(50) NOT NULL,
	lName VARCHAR(50) NOT NULL,
	DOB DATE
	);

CREATE TABLE Gym_Admin(
	UName VARCHAR(50) PRIMARY KEY NOT NULL,
	pWord VARCHAR(50) NOT NULL,
	fName VARCHAR(50) NOT NULL,
	lName VARCHAR(50) NOT NULL,
	DOB DATE
	);
CREATE TABLE Gym(
	id int IDENTITY(1,1) PRIMARY KEY,
	rating FLOAT(2) DEFAULT 0,
	location VARCHAR(50) NOT NULL,
	ownerUName VARCHAR(50),
	noMembers INT DEFAULT 0,
	noTrainers INT DEFAULT 0,
	finances INT DEFAULT 0,
	FOREIGN KEY (ownerUName) REFERENCES GYM_OWNER(UName) --ON DELETE CASCADE
	);



CREATE TABLE Trainer(
	UName VARCHAR(50) PRIMARY KEY NOT NULL,
	pWord VARCHAR(50) NOT NULL,
	fName VARCHAR(50) NOT NULL,
	lName VARCHAR(50) NOT NULL, 
	gender VARCHAR(50),
	DOB DATE, 
	exp_lvl INT DEFAULT 0,
	rating FLOAT(2),
	gym_ID INT,
	startDate DATE,
	FOREIGN KEY (gym_ID) REFERENCES Gym(id) --ON DELETE CASCADE
	);

CREATE TABLE Gym_Member(
	UName VARCHAR(50) PRIMARY KEY NOT NULL,
	pWord VARCHAR(50) NOT NULL,
	fName VARCHAR(50) NOT NULL,
	lName VARCHAR(50) NOT NULL, 
	DOB DATE, 
	wieght INT, 
	reg_date DATE NOT NULL, 
	goal VARCHAR(50), 
	gender VARCHAR(50), 
	subscription VARCHAR(50) NOT NULL, 
	trnUName VARCHAR(50),
	height INT,
	gym_ID INT,
	workPlan INT DEFAULT NULL,
	dietPlan INT DEFAULT NULL,
	FOREIGN KEY (workPlan) REFERENCES Workout_Plan(id),
	FOREIGN KEY (dietPlan) REFERENCES Diet_Plan(id),
	FOREIGN KEY (gym_ID) REFERENCES Gym(id), --ON DELETE CASCADE,
	FOREIGN KEY (trnUname) REFERENCES Trainer(UName) ON DELETE SET NULL
	);

CREATE TABLE Alergy(
	UName VARCHAR(50),
	alergy VARCHAR(50),
	FOREIGN KEY (UName) REFERENCES Gym_Member(UName), --ON DELETE CASCADE,
	PRIMARY KEY (UName, alergy)
	);


CREATE TABLE TRN_PAST_GYM(
	UName VARCHAR(50),
	gymName VARCHAR(50),
	FOREIGN KEY (UName) REFERENCES Trainer(UName), --ON DELETE CASCADE,
	PRIMARY KEY (UName, gymName)
	);



CREATE TABLE Training_Session(
	sessionID INT IDENTITY(1,1) PRIMARY KEY,
	start_time TIME NOT NULL,
	end_time TIME NOT NULL,
	TrainerUName VARCHAR(50) ,
	MemberUName VARCHAR(50),
	FOREIGN KEY (TrainerUName) REFERENCES Trainer(UName), --ON DELETE NO ACTION,
	FOREIGN KEY (MemberUName) REFERENCES Gym_Member(UName),-- ON DELETE CASCADE
	);
CREATE TABLE Franchise_Application(
	id INT IDENTITY(1,1) PRIMARY KEY,
	location VARCHAR(50) NOT NULL,
	demand INT NOT NULL,
	proposition VARCHAR(50) NOT NULL,
	ownerUName VARCHAR(50),
	FOREIGN KEY (ownerUName) REFERENCES GYM_OWNER(UName), --ON DELETE CASCADE
	);

CREATE TABLE Trainer_Feedback(
	id INT IDENTITY(1,1) PRIMARY KEY,
	rating FLOAT(2) NOT NULL,
	comment VARCHAR(50) NOT NULL,
	trainerUName VARCHAR(50) ,
	memberUName VARCHAR(50),
	FOREIGN KEY (trainerUName) REFERENCES Trainer(UName),
	FOREIGN KEY (memberUName) REFERENCES Gym_Member(UName), --ON DELETE CASCADE
	);

CREATE TABLE exercise(
	name VARCHAR(50) PRIMARY KEY NOT NULL,
	machine VARCHAR(50) NOT NULL,
	Setss INT,
	Reps INT,
	RestInterval INT
	);
CREATE TABLE ExerciseInDay(
	exerciseName VARCHAR(50) ,
	dayFK VARCHAR(50),
	planFK INT,
	FOREIGN KEY (exerciseName) REFERENCES exercise(name) ON DELETE CASCADE,
	FOREIGN KEY (planFK) REFERENCES Workout_Plan(id) ON DELETE CASCADE,
	PRIMARY KEY (dayFK, planFK)
	);
CREATE TABLE Meal(
	name VARCHAR(50) PRIMARY KEY NOT NULL,
	portionSize INT NOT NULL,
	protein INT NOT NULL,
	carbs INT NOT NULL,
	fat INT NOT NULL,
	fiber INT NOT NULL,
	Allergen VARCHAR(50)
	);
CREATE TABLE MealInDay(
	mealName VARCHAR(50),
	dayFK VARCHAR(50),
	planFK INT,
	FOREIGN KEY (mealName) REFERENCES Meal(name) ON DELETE CASCADE,
	FOREIGN KEY (planFK) REFERENCES Diet_Plan(id) ON DELETE CASCADE,
	PRIMARY KEY (dayFK, planFK)
	);

CREATE TABLE GYM_Attendance(
	id INT IDENTITY(1,1) PRIMARY KEY,
	memberUName VARCHAR(50),
	trainerUName VARCHAR(50),
	attendance FLOAT(2) NOT NULL,
	FOREIGN KEY (memberUName) REFERENCES Gym_Member(UName) ON DELETE CASCADE,
	FOREIGN KEY (trainerUName) REFERENCES Trainer(UName)
	);





	-- audit logs--

	CREATE TABLE Audit_Log (
    logID INT IDENTITY(1,1) PRIMARY KEY,
    tableName VARCHAR(50) NOT NULL,
    operationType VARCHAR(10) NOT NULL,
    operationTime DATETIME DEFAULT GETDATE(),
    userName VARCHAR(50)
);


CREATE TRIGGER trg_Gym_Member_Audit
ON Gym_Member
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    DECLARE @OperationType VARCHAR(10);

    IF EXISTS(SELECT * FROM inserted)
    BEGIN
        IF EXISTS(SELECT * FROM deleted)
            SET @OperationType = 'UPDATE';
        ELSE
            SET @OperationType = 'INSERT';
    END
    ELSE IF EXISTS(SELECT * FROM deleted)
    BEGIN
        SET @OperationType = 'DELETE';
    END

    INSERT INTO Audit_Log (tableName, operationType, operationTime, userName)
    VALUES ('Gym_Member', @OperationType, GETDATE(), SUSER_NAME());
END;


-- Trigger for Trainer table
CREATE TRIGGER trg_Trainer_Audit
ON Trainer
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    DECLARE @OperationTypeTrainer VARCHAR(10);

    IF EXISTS(SELECT * FROM inserted)
    BEGIN
        IF EXISTS(SELECT * FROM deleted)
            SET @OperationTypeTrainer = 'UPDATE';
        ELSE
            SET @OperationTypeTrainer = 'INSERT';
    END
    ELSE IF EXISTS(SELECT * FROM deleted)
    BEGIN
        SET @OperationTypeTrainer = 'DELETE';
    END

    INSERT INTO Audit_Log (tableName, operationType, operationTime, userName)
    VALUES ('Trainer', @OperationTypeTrainer, GETDATE(), SUSER_NAME());
END;

-- Trigger for GYM_OWNER table
CREATE TRIGGER trg_GYM_OWNER_Audit
ON GYM_OWNER
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    DECLARE @OperationTypeOwner VARCHAR(10);

    IF EXISTS(SELECT * FROM inserted)
    BEGIN
        IF EXISTS(SELECT * FROM deleted)
            SET @OperationTypeOwner = 'UPDATE';
        ELSE
            SET @OperationTypeOwner = 'INSERT';
    END
    ELSE IF EXISTS(SELECT * FROM deleted)
    BEGIN
        SET @OperationTypeOwner = 'DELETE';
    END

    INSERT INTO Audit_Log (tableName, operationType, operationTime, userName)
    VALUES ('GYM_OWNER', @OperationTypeOwner, GETDATE(), SUSER_NAME());
END;



	--insert triggers---------------------------------------------------------

CREATE TRIGGER increase_member_count
ON Gym_Member
AFTER  INSERT
AS
BEGIN
    -- Update the Gym table to increase the member count for the specific gym (inserted is backend table supposedly)
    UPDATE Gym
    SET noMembers = noMembers + (SELECT COUNT(*) FROM INSERTED WHERE Gym.id = INSERTED.gym_ID)
    WHERE id IN (SELECT DISTINCT gym_ID FROM INSERTED);
END ; 

CREATE TRIGGER increase_TRAINER_count
ON		Trainer
AFTER  INSERT
AS 
BEGIN
    -- Update the Gym table to increase the member count for the specific gym (inserted is backend table supposedly)
    UPDATE Gym
    SET noTrainers = noTrainers + (SELECT COUNT(*) FROM INSERTED WHERE Gym.id = INSERTED.gym_ID)
    WHERE id IN (SELECT DISTINCT gym_ID FROM INSERTED);
END ; 



CREATE TRIGGER update_Finances
ON Gym_Member
AFTER INSERT
AS
BEGIN
    UPDATE Gym
    SET finances = finances + 
        (SELECT 
            CASE 
                WHEN subscription = 'Bronze' THEN 100  
                WHEN subscription = 'Silver' THEN 200  
                WHEN subscription = 'Gold' THEN 300
				WHEN subscription = 'Platinum' THEN 400
                ELSE 0  
            END
         FROM INSERTED
         WHERE Gym.id = INSERTED.gym_ID);

   END;



CREATE TRIGGER Update_trainer_rating
ON Trainer_Feedback
AFTER INSERT
AS
BEGIN
    -- Update the trainer's average rating based on the newly inserted feedback
    UPDATE Trainer
    SET rating = (
        SELECT AVG(rating)
        FROM Trainer_Feedback
        WHERE Trainer_Feedback.trainerUName = Trainer.UName
    )
    WHERE Trainer.UName IN (
        SELECT trainerUName
        FROM inserted
    );
END;

-- delete and cascade trigs--
-----------------------------------------------------
-- OWNER
-- Create trigger to delete gym and franchise appli when gym owner is deleted
CREATE TRIGGER trg_delete_owner_gym_and_franchise
ON GYM_OWNER
INSTEAD OF DELETE
AS
BEGIN
    -- Delete gyms associated with the deleted owner
    DELETE FROM Gym
    WHERE ownerUName IN (SELECT UName FROM DELETED);

    -- Delete franchise applications associated with the deleted owner
    DELETE FROM Franchise_Application
    WHERE ownerUName IN (SELECT UName FROM DELETED);

    -- Delete the owner
    DELETE FROM GYM_OWNER
    WHERE UName IN (SELECT UName FROM DELETED);
END;

-- GYM
CREATE TRIGGER trg_delete_gym_member
ON Gym
INSTEAD OF DELETE
AS
BEGIN
    -- delete the member and trainer in this gym
	DELETE FROM Gym_Member
    WHERE gym_ID IN (SELECT id FROM DELETED);

	DELETE FROM Trainer
    WHERE gym_ID IN (SELECT id FROM DELETED);

	-- delete gym
    DELETE FROM Gym
    WHERE id IN (SELECT id FROM DELETED);
END;

-- trainer
CREATE TRIGGER trg_Trainer
ON Trainer
INSTEAD OF DELETE
AS
BEGIN
    -- Decrement the count of trainers from their gym
    UPDATE Gym
    SET noTrainers = noTrainers - 1
    WHERE id IN (SELECT gym_ID FROM DELETED);
	
	-- Delete past gyms associated with the deleted trainer
    DELETE FROM TRN_PAST_GYM
    WHERE UName IN (SELECT UName FROM DELETED);

    -- Delete training sessions associated with the deleted trainer
    DELETE FROM Training_Session
    WHERE TrainerUName IN (SELECT UName FROM DELETED);

	-- Delete feedback associated with the deleted trainer
    DELETE FROM Trainer_Feedback
    WHERE trainerUName IN (SELECT UName FROM DELETED);

	-- Delete attendance records associated with the deleted trainer
    DELETE FROM GYM_Attendance
    WHERE trainerUName IN (SELECT UName FROM DELETED);


    -- Delete the trainer
    DELETE FROM Trainer
    WHERE UName IN (SELECT UName FROM DELETED);
END;

-- MEMBER TRIGGER
CREATE TRIGGER trg_Member
ON Gym_Member
INSTEAD OF DELETE
AS
BEGIN
    -- Decrement the count of members from their gym
    UPDATE Gym
    SET noMembers = noMembers - 1
    WHERE id IN (SELECT gym_ID FROM DELETED);
	
	-- Delete allergies associated with the deleted member
    DELETE FROM Alergy
    WHERE UName IN (SELECT UName FROM DELETED);

    -- Delete training sessions associated with the deleted member
    DELETE FROM Training_Session
    WHERE MemberUName IN (SELECT UName FROM DELETED);

	 -- Delete feedback associated with the deleted member
    DELETE FROM Trainer_Feedback
    WHERE memberUName IN (SELECT UName FROM DELETED);

	-- Delete attendance records associated with the deleted member
    DELETE FROM GYM_Attendance
    WHERE memberUName IN (SELECT UName FROM DELETED);

    -- Delete the member
    DELETE FROM Gym_Member
    WHERE UName IN (SELECT UName FROM DELETED);
END;




