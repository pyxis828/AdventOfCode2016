import os

def check_not_supported(line):
    startIndex = 0
    inside = False
    for i in range (startIndex, len(line)):
        if line[i] == '[':
            startIndex = i
            for j in range(startIndex, len(line)):
                if line[j] == ']':
                    endIndex = j 
                    for k in range (startIndex+1, endIndex-3):
                        if line[k] == line[k+3] and line[k+1] == line[k+2]:
                            inside = True
                            break
                    startIndex = j+1
                    break
    return inside

def check_IPAddress(line):
    startIndex = 0
    endIndex = len(line)
    outside = False
    for i in range (startIndex, endIndex):
        if line[i] == '[':
            endIndex = i
            # TODO: refactor this section to own method
            for j in range (startIndex, endIndex-3):
                if line[j] == line[j+3] and line[j+1] == line[j+2]:
                    if line[j] == line[j+1] and line[j+2] == line[j+3]: 
                        continue
                    else:
                         outside = True 
                         return outside 
            startIndex = endIndex+1
            endIndex = len(line)
            for k in range (startIndex, endIndex):
                if line[k] == ']':
                    startIndex = k
                    break
    if startIndex < endIndex:
        # TODO: refactor this section to own method
        for j in range (startIndex, endIndex-3):
                if line[j] == line[j+3] and line[j+1] == line[j+2]:
                    if line[j] == line[j+1] and line[j+2] == line[j+3]: 
                        continue
                    else:
                         outside = True 
                         return outside 
    return outside



fn = os.path.join(os.path.dirname(__file__), 'input.txt')
with open(fn) as f:
    lines = f.readlines()
list = []
outside = 0
for line in lines:
        list.append(line.strip())
        if not check_not_supported(line):
            if check_IPAddress(line):
                outside += 1
print(outside)