import pprint
from pathlib import Path

pprint = pprint.pprint

input = open(Path(__file__).with_name("input.txt").absolute(), "r").read()

class Directory:
  def __init__(self, name, parent, files, directories):
    self.name = name
    self.files = files
    self.parent = parent
    self.directories = directories

class File:
  def __init__(self, name, size, parent):
    self.name = name
    self.size = size
    self.parent = parent

class Graph:
  def __init__(self, nodes):
    self.name = name
    self.is_dir = is_dir




graph = {}
formatted_input = input.split('\n')
# current_directory = { 'name': '', 'size': 0 }
current_directory = {}
current_directory_path = []
previous_directory_size = 0


def get_directory(name, size): 
  return {'name': name, 'size': size}

def update_current_directory(current_directory):
  for dir_name in current_directory_path:
    if dir_name is not '/':
      current_directory = current_directory['directories'][dir_name]
    else:
      current_directory = current_directory[dir_name]
  return current_directory

for index, instruction in enumerate(formatted_input):
  # if index > 23: break
  instruction = instruction.split(' ')

  if instruction[1] == 'ls': continue

  current_directory = graph
  current_directory = update_current_directory(current_directory)

  if instruction[1] == 'cd':
    name = instruction[2]

    if name is '/':
      graph[name]= { 'directories': {}, 'files': {}, 'size': 0 }
      current_directory_path.append(name)
      continue
    
    if name != '..':
      current_directory_path.append(name)
      current_directory = current_directory['directories'][name]
    else:
      current_directory_path.pop()
  else: # output
    if instruction[0] == 'dir':
      current_directory['directories'][instruction[1]] = { 'directories': {}, 'files': {}, 'size': 0 }
    else:
      current_directory['files'][instruction[1]] = instruction[0] 
    

pprint(graph)

directories_with_required_size = []
total_size = 0


# first guess - 1030948

# {
#   name: '/',
#   directories:{
#     'a':{
#       name: 'a',
#       directories: {
#         'e': {
#           name: 'e',
#           directories: {},
#           files: {'i': 584}
#         },
#       },
#       files: {
#         'f': 29116,
#         'g': 2557,
#         'h.lst': 62596,
#       }
#     },
#     'd':{
#       name: 'd',
#       directories: {

#       },
#       'files': {
#         'j': 4060174,
#         'd.log': 8033020,
#         'd.ext': 5626152,
#         'k': 7214296
#       }
#     },
#   },
#   files: {
#     'b.txt': 14848514,
#     'c.dat': 8504156
#   }
# }