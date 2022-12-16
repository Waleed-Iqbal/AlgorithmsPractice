import pprint
import math
from pathlib import Path

pprint = pprint.pprint

formatted_input = open(Path(__file__).with_name("input-9.txt").absolute(), "r").read().split('\n')

# print(formatted_input)

head_pos = {'x': 0, 'y': 0}
tail_pos = {'x': 0, 'y': 0}
reference = 0
tail_visit_pos = []

def get_distance(pos_h, pos_t):
  return  math.sqrt(math.pow(pos_h['x'] - pos_t['x'], 2) + math.pow(pos_h['y'] - pos_t['y'], 2) )

def isSameRow(pos_h, pos_t):
  return pos_h['x'] == pos_t['x']

def isSameColumn(pos_h, pos_t):
  return pos_h['y'] == pos_t['y']

def isDiagonal(pos_h, pos_t):
  return not isSameRow(pos_h, pos_t) and not isSameColumn(pos_h, pos_t)


for step in formatted_input:
  direction = step.split(' ')[0]
  movement = int(step.split(' ')[1])

  is_up = direction == 'U'
  is_right = direction == 'R'
  is_down = direction == 'D'
  is_left = direction == 'L'

  if is_up: head_pos['y'] += movement
  elif is_right: head_pos['x'] += movement
  elif is_down: head_pos['y'] -= movement
  elif is_left: head_pos['x'] -= movement


  distance = get_distance(head_pos, tail_pos)


  print(f'H: {head_pos} - T: {tail_pos} - Distance: {distance}')

