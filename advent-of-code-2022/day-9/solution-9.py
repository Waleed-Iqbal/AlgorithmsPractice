import pprint
import math
from pathlib import Path

pprint = pprint.pprint

formatted_input = open(Path(__file__).with_name("input-9.txt").absolute(), "r").read().split('\n')

head_pos = {'x': 0, 'y': 0}
tail_pos = {'x': 0, 'y': 0}
reference = 0
tail_visit_pos = {}

def get_distance():
  return math.sqrt(math.pow(head_pos['x'] - tail_pos['x'], 2) + math.pow(head_pos['y'] - tail_pos['y'], 2))

def isSameRow():
  return head_pos['y'] == tail_pos['y']

def isSameColumn():
  return head_pos['x'] == tail_pos['x']

for step in formatted_input:
  step_info = step.split(' ')
  direction = step_info[0]
  movement = int(step_info[1])

  is_up = direction == 'U'
  is_down = direction == 'D'
  is_left = direction == 'L'
  is_right = direction == 'R'

  print(f"---- NEXT STEP {step} ----")

  for step_distance in range(0, movement):
    if is_up: head_pos['y'] += 1
    elif is_down: head_pos['y'] -= 1
    elif is_left: head_pos['x'] -= 1
    elif is_right: head_pos['x'] += 1

    distance = get_distance()

    if distance < 2: continue # don't need an else as that means not touching

    result = ""
    if isSameRow():
      result = 'same row : '
      if is_right: tail_pos['x'] += 1
      elif is_left: tail_pos['x'] -= 1

    elif isSameColumn():
      result = 'same col : '
      if is_up: tail_pos['y'] += 1
      elif is_down: tail_pos['y'] -= 1

    else:
      result = 'diagonal : '
      is_up_right = head_pos['x'] > tail_pos['x'] and head_pos['y'] > tail_pos['y'] 
      is_up_left = head_pos['x'] < tail_pos['x'] and head_pos['y'] > tail_pos['y'] 
      is_down_right = head_pos['x'] > tail_pos['x'] and head_pos['y'] < tail_pos['y'] 
      is_down_left = head_pos['x'] < tail_pos['x'] and head_pos['y'] < tail_pos['y'] 

      if is_up_right:
        tail_pos['y'] += 1
        tail_pos['x'] += 1
      elif is_up_left:
        tail_pos['y'] += 1
        tail_pos['x'] -= 1
      elif is_down_right:
        tail_pos['y'] -= 1
        tail_pos['x'] += 1
      elif is_down_left:
        tail_pos['y'] -= 1
        tail_pos['x'] -= 1

    print(f'{result} Distance: {distance} -- Head({head_pos["x"]}, {head_pos["y"]}) -- Tail({tail_pos["x"]}, {tail_pos["y"]})')

    tail_visit_pos[f'{tail_pos["x"]}--{tail_pos["y"]}'] = 'visited'
  print('----------------------')

# print(tail_visit_pos)
print(len(tail_visit_pos.keys()))

"""
Guesses
1. 7178 - too high
2. 817 - too low
3. 1214 - too low
4. 6486 - correct answer
"""
