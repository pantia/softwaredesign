a = [1, 2, 3, 4, 5]
b = [1, 3, 3, 7, 8, 9, 0]
print("intersetion", list(set(a) & set(b)))
a = {"a", "b", "c"}
b = {"a", "d", "e", "j", "k"}
print("union", a.union(b))
print("difference", a.difference(b))
print("symmetric difference", a.symmetric_difference(b))
