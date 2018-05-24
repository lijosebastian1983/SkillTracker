Create table AssociateTable
(
Associate_ID int NOT NULL Identity(1,1) Primary key,
Name varchar(50),
Email varchar(25),
Mobile int,
Pic image,
Status varchar(10),
Level varchar(10),
Remark varchar(500),
Strength varchar(100),
Weekness varchar(100)
)

Create table SkillsTable
(
Skill_ID int NOT NULL Identity(1,1) Primary key,
Skill_Name Varchar(50)

)
Create table AssociateSkillsTable
(
Associate_ID int,
FOREIGN KEY(Associate_ID) REFERENCES AssociateTable(Associate_ID),
Skill_ID int,
FOREIGN KEY(Skill_ID) REFERENCES SkillsTable(Skill_ID),

)
