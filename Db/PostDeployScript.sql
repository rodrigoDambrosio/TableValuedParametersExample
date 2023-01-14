if not exists (select 1 from Driver)
begin
	insert into Driver (FirstName,LastName,Number,PhotoPath,Wins)
	values ( 'Fernando', 'Alonso' , 14,'1.jpg',32),
	('Sebastian','Vettel',4,'2.jpg',53),
	('Max','Verstappen',1,'3.jpg',35);
end
