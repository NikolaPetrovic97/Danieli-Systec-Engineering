select * from Movies where Genre LIKE "Action%";

select * from Movies inner join Loans on Loans.Movie=Movies.ID where Genre LIKE "Action%";

update Members set Status="Frequent" where ID=1 and ID<12;

update Movies set Genre ="CLasic" where Year>1980;