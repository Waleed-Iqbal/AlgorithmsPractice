import pprint
import math
from pathlib import Path

pprint = pprint.pprint

formatted_input = open(Path(__file__).with_name("input-9.txt").absolute(), "r").read().split('\n')

print(formatted_input)


def find_distance(pos_h, pos_t):
  return  math.sqrt(math.pow(pos_h.x - pos_t.x, 2))

def isSameRow(pos_h, pos_t):
  return pos_h.x == poh_t.x

def isSameColumn(pos_h, pos_t):
  return pos_h.y == poh_t.y

def isDiagonal(pos_h, pos_t):
  return not isSameRow(pos_h, pos_t) and not isSameColumn(pos_h, pos_t)


head_pos = {x: 0, y: 0}
tail_pos = {x: 0, y: 0}