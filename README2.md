Person (Abstract)
-----------------------
- FirstName : string
- LastName : string
- Phone : string
- Email : string
+ ShowInfo() : void (abstract)

Student : Person
-----------------------
- StudentID : string
- Faculty : string
+ ShowInfo()

Teacher : Person
-----------------------
- Position : string
+ ShowInfo()

GeneralPerson : Person
-----------------------
- Company : string
+ ShowInfo()

ICourse (Interface)
-----------------------
+ Register(Person) : void
+ ShowParticipants() : void

Course : ICourse
-----------------------
- CourseName : string
- participants : List<Person>
+ Register(Person)
+ ShowParticipants()
