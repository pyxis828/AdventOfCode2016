import os
from collections import Counter
from operator import itemgetter

fn = os.path.join(os.path.dirname(__file__), 'message.txt')
with open(fn) as f:
    lines = f.readlines()
for line in lines:
    length = len(line)
    columns = [ [] for _ in range(length)]
for line in lines:
    line = line.strip()
    for i in range (length):
        columns[i].append(line[i])
word = ''
for column in columns:
    num_letters = Counter(column)
    sortLetters = sorted(num_letters.items(), key=itemgetter(1))
    index = len(sortLetters)
    #letter = sortLetters[index-1][0]  # part 1
    letter = sortLetters[0][0]         # part 2
    word = word + letter
print(word)