import re
f = input ('������� ������: ');
a = re.findall(r"\b�\w*\b",f)
b = re.findall(r"\b�\w*\b",f)
c = len(a) + len(b)
print(c)
