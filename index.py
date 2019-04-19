import re
f = input ('Введите строку: ');
result = re.findall(r"\bт\w*\b",f)
print(len(result))

