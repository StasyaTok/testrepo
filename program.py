import re
f = input ('Введите строку: ');
a = re.findall(r"\bт\w*\b",f)
b = re.findall(r"\bТ\w*\b",f)
c = len(a) + len(b)
print(c)
