import os

def compare (side_1, side_2, side_3):
    if side_1 + side_2 > side_3:
        return True
    else:
        return False

fn = os.path.join(os.path.dirname(__file__), 'Sides.txt')
with open(fn) as f:
    lines = f.readlines()
numTriangles = 0;
triangles = []
for line in lines:
    triangles.append(line.strip().split('     '))
for triangle in triangles:
    triangle[0] = triangle[0].replace('   ',' ')
    triangle[0] = triangle[0].replace('  ',' ')    
    side_a = triangle[0].split(' ')[0]
    side_b = triangle[0].split(' ')[1]
    side_c = triangle[0].split(' ')[2]
    compare_1 = compare(int(side_a), int(side_b), int(side_c))
    compare_2 = compare(int(side_a), int(side_c), int(side_b))
    compare_3 = compare(int(side_b), int(side_c), int(side_a))
    if compare_1 and compare_2 and compare_3:
        numTriangles = numTriangles + 1
print (numTriangles)