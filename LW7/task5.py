# variant 33/10=3
from collections import namedtuple

def good_athletes(tupl):
    total = 0
    for t in tupl:
        total = total + t.grade
    mid = total / len(tupl)
    print("Найкращі спортсмени:")
    for t in tupl:
        if t.grade > mid:
            print(t)
        

Athlete = namedtuple('Athlete', ['surname', 'birth', 'grade', 'city'])
tuple = (Athlete("Surname1","1999",10,"Chernivtsi"),
         Athlete("Surname2","2000",11,"Lviv"),
         Athlete("Surname3","2000",9,"Mykolaiv"),
         Athlete("Surname4","2000",8,"Vinnytsia"),
         Athlete("Surname5","2001",12,"Kryvyi Rih"),
         Athlete("Surname6","2000",5,"Dnipro"),
         Athlete("Surname7","2000",5,"Kherson"))
good_athletes(tuple)

