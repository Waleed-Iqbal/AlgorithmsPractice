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

"""
def checkForTreeVisibility():
  global total_visible_trees
  global is_tree_visible

  if is_tree_visible:
    total_visible_trees += 1

for i in range(1, total_length - 1):
  row = grid[i]

  for j in range(1, len(row) - 1):
    current_tree = row[j]

    # towards top edge
    for top in range(i - 1, -1, -1):
      is_tree_visible = current_tree > grid[top][j]
      if is_tree_visible is False: break
    if is_tree_visible:
      checkForTreeVisibility()
      continue

    # towards right edge
    for right in range(j + 1, len(row)):
      is_tree_visible = current_tree > grid[i][right]
      if is_tree_visible is False: break
    if is_tree_visible:
      checkForTreeVisibility()
      continue

    # towards bottom edge
    for bottom in range(i + 1, total_length):
      is_tree_visible = current_tree > grid[bottom][j]
      if is_tree_visible is False: break
    if is_tree_visible:
      checkForTreeVisibility()
      continue

    # towards left edge
    for left in range(j - 1, -1, -1):
      is_tree_visible = current_tree > grid[i][left]
      if is_tree_visible is False: break
    if is_tree_visible:
      checkForTreeVisibility()

total_visible_trees += (total_length * 4 ) - 4
# 1708 is correct
"""

# part 2
scenic_distances = []

for i in range(0, total_length):
  row = grid[i]

  for j in range(0, len(row)):
    current_tree = row[j]

    distance_top = 1
    distance_right = 1
    distance_bottom = 1
    distance_left = 1

    # towards top edge
    for top in range(i - 1, -1, -1):
      if current_tree == grid[top][j]: break
      if current_tree > grid[top][j]: distance_top += 1

    # towards right edge
    for right in range(j + 1, len(row)):
      if current_tree == grid[i][right]: break
      if current_tree > grid[i][right]: distance_right += 1

    # towards bottom edge
    for bottom in range(i + 1, total_length):
      if current_tree == grid[bottom][j]: break
      if current_tree > grid[bottom][j]: distance_bottom += 1

    # towards left edge
    for left in range(j - 1, -1, -1):
      if current_tree == grid[i][left]: break
      if current_tree > grid[i][left]: distance_left += 1

    scenic_distances.append(distance_top * distance_right * distance_bottom * distance_left)


print(max(scenic_distances))

"""
Guesses

56925 - too low
562275 - too high
"""