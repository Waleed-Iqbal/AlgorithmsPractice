import pprint
import math
from pathlib import Path

pprint = pprint.pprint

formatted_input = open(Path(__file__).with_name("input-9.txt").absolute(), "r").read().split('\n')

head_pos = {'x': 0, 'y': 0}
tail_pos = {'x': 0, 'y': 0}
reference = 0
tail_visit_pos = {}

def get_distance(pos_h, pos_t):
  return  math.sqrt(math.pow(pos_h['x'] - pos_t['x'], 2) + math.pow(pos_h['y'] - pos_t['y'], 2) )

def isSameRow(pos_h, pos_t):
  return pos_h['y'] == pos_t['y']

def isSameColumn(pos_h, pos_t):
  return pos_h['x'] == pos_t['x']

def isDiagonal(pos_h, pos_t):
  return not isSameRow(pos_h, pos_t) and not isSameColumn(pos_h, pos_t)


for step in formatted_input:
  step_info = step.split(' ')
  direction = step_info[0]
  movement = int(step_info[1])

  is_up = direction == 'U'
  is_right = direction == 'R'
  is_down = direction == 'D'
  is_left = direction == 'L'

  print(f" ---- NEXT STEP  {step} ----")

  for step_distance in range(1, movement + 1):
    if is_up: head_pos['y'] += 1
    elif is_right: head_pos['x'] += 1
    elif is_down: head_pos['y'] -= 1
    elif is_left: head_pos['x'] -= 1

    distance = get_distance(head_pos, tail_pos)
    isTouching = distance < 2

    if isTouching: continue # don't need an else as that means not touching

    if isSameRow(head_pos, tail_pos):
      if is_right: tail_pos['x'] += 1
      elif is_left: tail_pos['x'] -= 1
      print(f'same row : Head({head_pos["x"]}, {head_pos["y"]}) -- Tail({tail_pos["x"]}, {tail_pos["y"]})')
    elif isSameColumn(head_pos, tail_pos):
      if is_up: tail_pos['y'] += 1
      elif is_down: tail_pos['y'] -= 1
      print(f'same col : Head({head_pos["x"]}, {head_pos["y"]}) -- Tail({tail_pos["x"]}, {tail_pos["y"]})')
    else:
      if is_up or is_right: 
        tail_pos['y'] += 1
        tail_pos['x'] += 1
      elif is_down or is_left:
        tail_pos['y'] -= 1
        tail_pos['x'] -= 1
      print(f'diagonal : Head({head_pos["x"]}, {head_pos["y"]}) -- Tail({tail_pos["x"]}, {tail_pos["y"]})')

    tail_visit_pos[f'{tail_pos["x"]}--{tail_pos["y"]}'] = 'visited'
    print('----------------------')

# print(tail_visit_pos)
print(len(tail_visit_pos.keys()))


"""
Guesses
1. 7178 - too high
2. 817 - too low
3. 1214 - too low
"""
