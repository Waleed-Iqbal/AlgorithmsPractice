import pprint
from pathlib import Path

pprint = pprint.pprint

formatted_input = open(Path(__file__).with_name("input-8.txt").absolute(), "r").read().split('\n')

grid = [[] for x in range(len(formatted_input))]
for index in range(0, len(grid)):
  grid[index] = [int(x) for x in formatted_input[index]]

total_length = len(grid)
is_tree_visible = False
total_visible_trees = 0


def checkForTreeVisibility():
  global total_visible_trees
  global is_tree_visible

  if is_tree_visible:
    total_visible_trees += 1



for i in range(1, total_length):
  row = grid[i]

  for j in range(1, len(row)):
    current_tree = row[j]

    # towards top edge
    for top in range(i-1, -1, -1):
      is_tree_visible = current_tree > grid[top][j]
      if not is_tree_visible: break
    if is_tree_visible:
      total_visible_trees += 1
      continue

    # towards right edge
    for right in range(j+1, len(row)):
      is_tree_visible = current_tree > grid[i][right]
      if not is_tree_visible: break
    if is_tree_visible:
      total_visible_trees += 1
      continue

    # towards bottom edge
    for bottom in range(i+1, total_length):
      is_tree_visible = current_tree > grid[bottom][j]
      if not is_tree_visible: break
    if is_tree_visible:
      total_visible_trees += 1
      continue

    # towards left edge
    for left in range(j-1, -1, -1):
      is_tree_visible = current_tree > grid[i][left]
      if not is_tree_visible: break
    if is_tree_visible:
      total_visible_trees += 1


total_visible_trees += (total_length * 4 ) - 4
print(total_visible_trees )

