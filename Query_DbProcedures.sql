USE DBSYS

CREATE PROCEDURE SP_NewUserAccount @UName varchar(255), @UPassword varchar(255), @RoleID int, @CreatedByID int
AS
INSERT INTO UserAccount(userName, userPassword, roleId, createdById)
VALUES (@UName, @UPassword, @RoleID, @CreatedByID)