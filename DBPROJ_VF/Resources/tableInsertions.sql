-- Insert data into GYM_OWNER table
INSERT INTO GYM_OWNER (UName, pWord, fName, lName, DOB)
VALUES ('owner1', 'password1', 'John', 'Doe', '1990-05-15'),
       ('owner2', 'password2', 'Jane', 'Smith', '1985-08-20');

-- Insert data into Gym_Admin table
INSERT INTO Gym_Admin (UName, pWord, fName, lName, DOB)
VALUES ('admin1', 'adminpass1', 'Admin', 'One', '1980-01-10'),
       ('admin2', 'adminpass2', 'Admin', 'Two', '1975-03-25');

-- Insert data into Gym table
INSERT INTO Gym (rating, location, ownerUName, noMembers, noTrainers, finances)
VALUES (4.5, 'New York', 'owner1', 100, 10, 50000),
       (3.8, 'Los Angeles', 'owner2', 80, 8, 40000);

-- Insert data into Trainer table
INSERT INTO Trainer (UName, pWord, fName, lName, gender, DOB, exp_lvl, rating, gym_ID, startDate)
VALUES ('trainer1', 'trainerpass1', 'Mike', 'Johnson', 'Male', '1988-09-20', 5, 4.3, 1, '2020-02-10'),
       ('trainer2', 'trainerpass2', 'Sarah', 'Lee', 'Female', '1992-04-05', 3, 4.1, 2, '2021-01-15');

-- Insert data into Gym_Member table
INSERT INTO Gym_Member (UName, pWord, fName, lName, DOB, wieght, reg_date, goal, gender, subscription, trnUName, height, gym_ID)
VALUES ('member1', 'memberpass1', 'Emily', 'Brown', '1995-07-12', 150, '2020-03-01', 'Lose Weight', 'Female', 'Gold', 'trainer1', 165, 1),
       ('member2', 'memberpass2', 'David', 'Miller', '1990-11-30', 180, '2021-05-10', 'Build Muscle', 'Male', 'Platinum', 'trainer2', 180, 2);

-- Insert data into Alergy table
INSERT INTO Alergy (UName, alergy)
VALUES ('member1', 'Peanuts'),
       ('member2', 'Shellfish');

-- Insert data into TRN_PAST_GYM table
INSERT INTO TRN_PAST_GYM (UName, gymName)
VALUES ('trainer1', 'Previous Gym A'),
       ('trainer2', 'Previous Gym B');

-- Insert data into Training_Session table
INSERT INTO Training_Session (start_time, end_time, TrainerUName, MemberUName)
VALUES ('08:00:00', '09:00:00', 'trainer1', 'member1'),
       ('10:00:00', '11:00:00', 'trainer2', 'member2');

-- Insert data into Franchise_Application table
INSERT INTO Franchise_Application (location, demand, proposition, ownerUName)
VALUES ('Chicago', 150, 'High demand area', 'owner1'),
       ('Miami', 120, 'Growing fitness market', 'owner2');

-- Insert data into Trainer_Feedback table
INSERT INTO Trainer_Feedback (rating, comment, trainerUName, memberUName)
VALUES (4.5, 'Great trainer, very motivating', 'trainer1', 'member1'),
       (4.0, 'Knowledgeable but could improve punctuality', 'trainer2', 'member2');

-- Insert data into Workout_Plan table
INSERT INTO Workout_Plan (name, type, trainerUName, memUName)
VALUES ('Beginner Full Body Workout', 'Strength', 'trainer1', 'member1'),
       ('Advanced Split Routine', 'Hypertrophy', 'trainer2', 'member2');

-- Insert data into workout_day table
INSERT INTO workout_day (planID, wDay)
VALUES (1, 'Monday'),
       (2, 'Wednesday');

-- Insert data into exercise table
INSERT INTO exercise (name, machine, targetMuscle, Setss, Reps, RestInterval)
VALUES ('Squats', 'Leg Press Machine', 'Legs', 3, 12, 60),
       ('Bench Press', 'Barbell Bench Press', 'Chest', 4, 10, 90);

-- Insert data into ExerciseInDay table
INSERT INTO ExerciseInDay (exerciseName, dayFK, planFK)
VALUES ('Squats', 'Monday', 1),
       ('Bench Press', 'Wednesday', 2);

-- Insert data into Meal table
INSERT INTO Meal (name, portionSize, protein, carbs, fat, fiber, Allergen)
VALUES ('Grilled Chicken Salad', 1, 30, 10, 5, 8, NULL),
       ('Salmon with Quinoa', 1, 25, 20, 10, 6, 'Fish');

-- Insert data into Diet_Plan table
INSERT INTO Diet_Plan (name, type, purpose, trainerUName, memUName)
VALUES ('Weight Loss Meal Plan', 'Balanced', 'Reduce body fat', 'trainer1', 'member1'),
       ('Muscle Gain Meal Plan', 'High Protein', 'Increase muscle mass', 'trainer2', 'member2');

-- Insert data into meal_day table
INSERT INTO meal_day (planID, mDay)
VALUES (1, 'Monday'),
       (2, 'Wednesday');

-- Insert data into MealInDay table
INSERT INTO MealInDay (mealName, dayFK, planFK)
VALUES ('Grilled Chicken Salad', 'Monday', 1),
       ('Salmon with Quinoa', 'Wednesday', 2);

-- Insert data into GYM_Attendance table
INSERT INTO GYM_Attendance (memberUName, trainerUName, attendance)
VALUES ('member1', 'trainer1', 0.9),
       ('member2', 'trainer2', 0.8);
