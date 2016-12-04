import os

def compare (side_1, side_2, side_3):
    if side_1 + side_2 > side_3:
        return True
    else:
        return False

fn = os.path.join(os.path.dirname(__file__), 'sides.txt')
with open(fn) as f:
    lines = f.readlines()
numTriangles = 0;
triangles = []
columnList = []
for line in lines:
    triangles.append(line.strip().split('     '))
for triangle in triangles:
    triangle[0] = triangle[0].replace('   ',' ')
    triangle[0] = triangle[0].replace('  ',' ')
for triangle in triangles:
    column_1 = triangle[0].split(' ')[0]
    columnList.append(column_1)
for triangle in triangles:
    column_2 = triangle[0].split(' ')[1]
    columnList.append(column_2)
for triangle in triangles:
    column_3 = triangle[0].split(' ')[2]
    columnList.append(column_3)
for i in range (0, len(columnList), 3):
    side_a = columnList[i]
    side_b = columnList[i+1]
    side_c = columnList[i+2]
    compare_1 = compare(int(side_a), int(side_b), int(side_c))
    compare_2 = compare(int(side_a), int(side_c), int(side_b))
    compare_3 = compare(int(side_b), int(side_c), int(side_a))
    if compare_1 and compare_2 and compare_3:
        numTriangles = numTriangles + 1
print (numTriangles)
