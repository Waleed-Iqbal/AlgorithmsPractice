import pprint
from pathlib import Path

pprint = pprint.pprint

formatted_input = open(Path(__file__).with_name("input-8.txt").absolute(), "r").read().split('\n')

grid = [[] for x in range(len(formatted_input))]
for index in range(0, len(grid)):
  grid[index] = [x for x in formatted_input[index]]


text = ''
total_length = len(grid)
total_visible_trees = 0
for i, row in enumerate(grid):
  for j, current_tree in enumerate(row):
    is_tree_visible = False

    # towards top edge
    for top in range(i, 0, -1):
      print (top)

    # towards right edge
    for right in range(j, len(row)):
      print (right)

    # towards bottom edge
    for bottom in range(i, total_length):
      print (bottom)

    # towards left edge
    for left in range(j, 0, -1):
      print (left)