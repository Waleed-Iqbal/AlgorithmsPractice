import pprint
import math
from pathlib import Path

pprint = pprint.pprint

formatted_input = open(Path(__file__).with_name("input-9.txt").absolute(), "r").read().split('\n')

head_pos = {'x': 0, 'y': 0}
tail_pos = {'x': 0, 'y': 0}
reference = 0
tail_visit_positions = {}

def get_distance():
  return math.sqrt(math.pow(head_pos['x'] - tail_pos['x'], 2) + math.pow(head_pos['y'] - tail_pos['y'], 2))

def get_distance(pos_h, pos_t):
  return math.sqrt(math.pow(pos_h['x'] - pos_t['x'], 2) + math.pow(pos_h['y'] - pos_t['y'], 2))

def isSameRow():
  return head_pos['y'] == tail_pos['y']

def isSameRow(pos_h, pos_t):
  return pos_h['y'] == pos_t['y']

def isSameColumn():
  return head_pos['x'] == tail_pos['x']

def isSameColumn(pos_h, pos_t):
  return pos_h['x'] == pos_t['x']

# for step in formatted_input:
#   step_info = step.split(' ')
#   direction = step_info[0]
#   movement = int(step_info[1])

#   is_up = direction == 'U'
#   is_down = direction == 'D'
#   is_left = direction == 'L'
#   is_right = direction == 'R'

#   for step_distance in range(0, movement):
#     if is_up: head_pos['y'] += 1
#     elif is_down: head_pos['y'] -= 1
#     elif is_left: head_pos['x'] -= 1
#     elif is_right: head_pos['x'] += 1

#     if get_distance() < 2: continue # don't need an else as that means not touching

#     if isSameRow():
#       if is_right: tail_pos['x'] += 1
#       elif is_left: tail_pos['x'] -= 1

#     elif isSameColumn():
#       if is_up: tail_pos['y'] += 1
#       elif is_down: tail_pos['y'] -= 1

#     else:
#       is_direction_up_right = head_pos['x'] > tail_pos['x'] and head_pos['y'] > tail_pos['y'] 
#       is_direction_up_left = head_pos['x'] < tail_pos['x'] and head_pos['y'] > tail_pos['y'] 
#       is_direction_down_right = head_pos['x'] > tail_pos['x'] and head_pos['y'] < tail_pos['y'] 
#       is_direction_down_left = head_pos['x'] < tail_pos['x'] and head_pos['y'] < tail_pos['y'] 

#       if is_direction_up_right:
#         tail_pos['y'] += 1
#         tail_pos['x'] += 1
#       elif is_direction_up_left:
#         tail_pos['y'] += 1
#         tail_pos['x'] -= 1
#       elif is_direction_down_right:
#         tail_pos['y'] -= 1
#         tail_pos['x'] += 1
#       elif is_direction_down_left:
#         tail_pos['y'] -= 1
#         tail_pos['x'] -= 1

#     tail_visit_positions[f'{tail_pos["x"]}--{tail_pos["y"]}'] = 'visited'

# print(len(tail_visit_positions.keys()))

"""
Guesses
1. 7178 - too high
2. 817 - too low
3. 1214 - too low
4. 6486 - correct answer
"""


# Part 2

temp = [{'name': x, 'x': 0, 'y': 0} for x in range(0, 10)]
head = 0

rope = {}
for part in temp:
  rope[part['name']] = {'x': part['x'], 'y': part['y']}

tail_visit_positions = {}

for step in formatted_input:
  step_info = step.split(' ')
  direction = step_info[0]
  movement = int(step_info[1])

  is_up = direction == 'U'
  is_down = direction == 'D'
  is_left = direction == 'L'
  is_right = direction == 'R'

  for step_distance in range(0, movement):
    if is_up: rope[head]['y'] += 1
    elif is_down: rope[head]['y'] -= 1
    elif is_left: rope[head]['x'] -= 1
    elif is_right: rope[head]['x'] += 1

    for new_step in range(1, 10):
      pos_t = rope[new_step]
      pos_h = rope[new_step - 1]

      distance = get_distance(pos_h, pos_t)

      if distance < 2: continue

      if isSameRow(pos_h, pos_t):
        if pos_h['x'] > pos_t['x']: pos_t['x'] += 1
        elif pos_h['x'] < pos_t['x']: pos_t['x'] -= 1

      elif isSameColumn(pos_h, pos_t):
        if pos_h['y'] > pos_t['y']: pos_t['y'] += 1
        elif pos_h['y'] < pos_t['y']: pos_t['y'] -= 1

      else:
        is_direction_up_right = pos_h['x'] > pos_t['x'] and pos_h['y'] > pos_t['y'] 
        is_direction_up_left = pos_h['x'] < pos_t['x'] and pos_h['y'] > pos_t['y'] 
        is_direction_down_right = pos_h['x'] > pos_t['x'] and pos_h['y'] < pos_t['y'] 
        is_direction_down_left = pos_h['x'] < pos_t['x'] and pos_h['y'] < pos_t['y']  

        if is_direction_up_right:
          pos_t['y'] += 1
          pos_t['x'] += 1
        elif is_direction_up_left:
          pos_t['y'] += 1
          pos_t['x'] -= 1
        elif is_direction_down_right:
          pos_t['y'] -= 1
          pos_t['x'] += 1
        elif is_direction_down_left:
          pos_t['y'] -= 1
          pos_t['x'] -= 1

    tail_visit_positions[f'{rope[9]["x"]}--{rope[9]["y"]}'] = 'visited'
print(len(tail_visit_positions.keys()))



"""
Guesses
1. 3178 - too high
2. 1409 - too low
3. 2678 - correct
"""