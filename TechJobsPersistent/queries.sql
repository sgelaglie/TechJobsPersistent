--Part 1:

Select COLUMN_NAME,* FROM INFORMATION_SCHEMA.COLUMNS  WHERE TABLE_NAME = "Job"


--Part 2: 
select * from employers Where (location = "st Louis city");


--Part 3 
select * from skills,jobskills WHERE  skills.Id = Jobskills.skillId and jobskill.skillId is not null order by skills.Name ASC

