import pprint
from pathlib import Path

pprint = pprint.pprint

formatted_input = open(Path(__file__).with_name("input.txt").absolute(), "r").read().split('\n')


graph = {}
current_directory = {}
current_directory_path = []
directories_with_required_size = []

def update_current_directory(current_directory):
  for dir_name in current_directory_path:
    if dir_name != '/':
      current_directory = current_directory['directories'][dir_name]
    else:
      current_directory = current_directory[dir_name]
  return current_directory

def find_all_directories_sizes(directory):
  directories_sizes.append(int(directory['size']))
  current_directories = directory['directories']

  if len(current_directories) > 0:
    for folder in current_directories:
      find_all_directories_sizes(current_directories[folder])

def find_required_directories(directory):
  if directory['size'] <= 100000:
    directories_with_required_size.append(directory)
  
  current_directories = directory['directories']

  if len(current_directories) > 0:
    for folder in current_directories:
      find_required_directories(current_directories[folder])

for index, instruction in enumerate(formatted_input):
  instruction = instruction.split(' ')

  if instruction[1] == 'ls': continue

  current_directory = graph
  current_directory = update_current_directory(current_directory)

  if instruction[1] == 'cd':
    name = instruction[2]

    if name == '/':
      graph[name]= { 'directories': {}, 'files': {}, 'size': 0 }
      current_directory_path.append(name)
      continue
    
    if name != '..':
      current_directory_path.append(name)
      current_directory = current_directory['directories'][name]
    else:
      current_directory_size = current_directory['size']
      current_directory_path.pop()
      current_directory = update_current_directory(graph)
      current_directory['size'] += current_directory_size
  else: # output
    if instruction[0] == 'dir':
      current_directory['directories'][instruction[1]] = { 'directories': {}, 'files': {}, 'size': 0 }
    else:
      current_directory['files'][instruction[1]] = instruction[0] 
      current_directory['size'] += int(instruction[0])

find_required_directories(graph['/'])

total_freed_size = 0
for item in directories_with_required_size:
  total_freed_size += int(item['size'])

print(total_freed_size)
# answer - 1667443 (correct)


# part 2
available_space = 70000000
required_free_space = 30000000
total_current_size = int(graph['/']['size'])
unused_space = available_space - total_current_size
unused_space_required = required_free_space - unused_space

directories_sizes = []


find_all_directories_sizes(graph['/'])

sizes_that_free_up_space = []
for size in directories_sizes:
  if size >= unused_space_required:
    sizes_that_free_up_space.append(size)

sizes_that_free_up_space.sort()
print(sizes_that_free_up_space[0])

# answer - 8998590

