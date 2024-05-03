
-- triggers 1 done letsgoooo

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
