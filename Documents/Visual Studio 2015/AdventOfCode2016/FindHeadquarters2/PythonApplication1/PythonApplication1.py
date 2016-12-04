def move_x(start_x, direction_y, turn, distance):
    if direction_y == 'North' and turn == 'R':
        end_x = start_x + distance
        direction_x = 'East'
    elif direction_y == 'North' and turn == 'L':
        end_x = start_x - distance
        direction_x = 'West'
    elif direction_y == 'South' and turn == 'R':
        end_x = start_x - distance
        direction_x = 'West'
    elif direction_y == 'South' and turn == 'L':
         end_x = start_x + distance
         direction_x = 'East'
    return end_x, direction_x

def move_y(start_y, direction_x, turn, distance):
    if direction_x == 'East' and turn == 'R':
        end_y = start_y - distance
        direction_y = 'South'
    elif direction_x == 'East' and turn == 'L':
        end_y = start_y + distance
        direction_y = 'North'
    elif direction_x == 'West' and turn == 'R':
        end_y = start_y + distance
        direction_y = 'North'
    elif direction_x == 'West' and turn == 'L':
         end_y = start_y - distance
         direction_y = 'South'
    return end_y, direction_y

def check_path(coord_x, coord_y):
    coord = [(0,0)]
    length = len(coord_x)
    for i in range (length):
        coord.append((coord_x[i], coord_y[i]))
    for i in range (len(coord)):
        j = i + 1
        for j in range (j, len(coord)):
            if coord[i] == coord[j]:
                x = coord[i][0]
                y = coord[i][1]
                total_distance = abs(x) + abs(y)
                return total_distance
            else:
                continue
    total_distance = -1
    return total_distance

list_directions = 'R1, R1, R3, R1, R1, L2, R5, L2, R5, R1, R4, L2, R3, L3, R4, L5, R4, R4, R1, L5, L4, R5, R3, L1, R4, R3, L2, L1, R3, L4, R3, L2, R5, R190, R3, R5, L5, L1, R54, L3, L4, L1, R4, R1, R3, L1, L1, R2, L2, R2, R5, L3, R4, R76, L3, R4, R191, R5, R5, L5, L4, L5, L3, R1, R3, R2, L2, L2, L4, L5, L4, R5, R4, R4, R2, R3, R4, L3, L2, R5, R3, L2, L1, R2, L3, R2, L1, L1, R1, L3, R5, L5, L1, L2, R5, R3, L3, R3, R5, R2, R5, R5, L5, L5, R2, L3, L5, L2, L1, R2, R2, L2, R2, L3, L2, R3, L5, R4, L4, L5, R3, L4, R1, R3, R2, R4, L2, L3, R2, L5, R5, R4, L2, R4, L1, L3, L1, L3, R1, R2, R1, L5, R5, R3, L3, L3, L2, R4, R2, L5, L1, L1, L5, L4, L1, L1, R1'
directions = list_directions.split(', ')
start_x = 0
start_y = 0
coord_x = []
coord_y = []
coord = []
direction_y = 'North'
for i in range (len(directions)):
    turn = directions[i][0:1]
    distance = int(directions[i][1:])
    if i == 0 or i % 2 == 0:
        end_x, direction_x = move_x(start_x, direction_y, turn, distance)
        for i in range (distance + 1):
            if end_x > start_x:
                start_x = start_x + 1
            elif start_x == end_x:
                continue
            else:
                start_x = start_x - 1
            coord_x.append(start_x)
            coord_y.append(start_y)
        start_x = end_x
        total_distance = check_path(coord_x, coord_y)
        if total_distance > -1:
            print (total_distance)
            break
        else:
            continue
    else:
        end_y, direction_y = move_y(start_y, direction_x, turn, distance)
        for i in range (distance + 1):
            if end_y > start_y:
                start_y = start_y + 1
            elif start_y == end_y:
                continue
            else:
                start_y = start_y - 1
            coord_x.append(start_x)
            coord_y.append(start_y)
        start_y = end_y
        total_distance = check_path(coord_x, coord_y)
        if total_distance > -1:
            print (total_distance)
            break
        else:
            continue
