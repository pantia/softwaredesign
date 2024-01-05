dict = {
  "key1": "value1",
  "key2": "value2",
  "key3": 50
}
print("value1 in dict", "value1" in dict.values())
print(dict)
dict["addedkey"] = "added value"
print(dict)
del dict["key1"]
print(dict)
print("key2 in dict", "key2" in dict)

print("len", len(dict))
dict.clear()
print("value1 in dict", "value1" in dict.values())
print("cleared")
print(dict)
print("key1 in dict", "key1" in dict)
