# vartiant 33/12=9
list = []
list.append(("Worker 1", 1000))
list.append(("Worker 2", 2000))
list.append(("Worker 3", 3000))
list.append(("Worker 4", 4000))
print(list)
total = 0
for worker in list:
    total = total + worker[1]
total = total / len(list)
print(total)
count = 0
for worker in list:
    if worker[1] < total:
        count = count + 1
print(count) 
