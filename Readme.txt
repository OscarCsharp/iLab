---Prepare enviroment for the API--

1. Download and Install dotnet-sdk-2.2.207-win-x64
2.Download and Install Visual Code
3. Make sure you have the SQL Server installed along with MS Server Management Studio
4. Open the API Project with Visual Code, go to the Json file to modify the sql server details and put yours 
5. Go to View select terminal , select terminal then type "dotnet restore"
6. Then do migration : dotnet ef migrations add InitialCreate, dotnet ef database update
7. Run the API .. dotnet run

---Run the below script on your SQL to create sample data----

INSERT INTO Books (Title,Author,Description,Year,Status)
VALUES ('C#','Developer','Coding Standard' ,'2015','Available'),
('Merlin','King James','The Megician' ,'2011','Available'),
('Thor','Martin Luther','The Lost King' ,'2015','Available'),
('Emotional Skill','Dr Phil','Master Yourself' ,'2015','On Loan'),
('Hustle','Steve Jobs','Money and Product' ,'2012','On Loan');

INSERT INTO BookingRecords (CurrentOwner,CellNo,Email,RequestedDate,ReturnDate,Status,BookId,ReturnedOn,ReturnedBy)
VALUES ('Oscar Ndlovu','0748199186','Oscarndlovu01@gmail.com' ,'2020/08/19','2020/08/20','Not Returned','4','2020/08/20','Dev'),
('Oscar Ndlovu','0748199186','Oscarndlovu01@gmail.com' ,'2020/08/12','2020/08/15','Returned','5','2020/08/20','Dev') ;

---Prepare enviroment for the API--
1. Download and Install node.js
2. Open the ClientAPP Project with Visual Code
3. Go to View select terminal , select terminal then type "npm i @angular/cli@7.3.10"
4. If you can't write the command then copy and paste this commad (set-executionpolicy remotesigned) , then do no 3.
5. If the problems still exists open the project with CMD then do no 3.
6. The run the APP : ng serve -o --port4200
        




