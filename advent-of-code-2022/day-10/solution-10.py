import pprint
import math
from pathlib import Path

pprint = pprint.pprint

formatted_input = open(Path(__file__).with_name("input-10.txt").absolute(), "r").read().split('\n')

total_cycles = 0
calcualted_x = 1
signal_strengths = []
total_strength = 0

def calculate_strength():
  global total_cycles
  global calcualted_x
  global signal_strengths

  total_cycles = total_cycles + 1

  if total_cycles == 20:
    signal_strengths.append(total_cycles * calcualted_x)

  elif total_cycles % 20 == 0:
    signal_strengths.append(total_cycles * calcualted_x)

for operation in formatted_input:
    if operation == 'noop':
      calculate_strength()

    elif operation.startswith('addx'):
      for i in range(0, 2):
        calculate_strength()
      calcualted_x = calcualted_x + int(operation.split(' ')[1])
        
for index, value in enumerate(signal_strengths):
  print(value, index)
  if index % 2 != 0: continue
  total_strength = total_strength + value

# print(total_strength) ()


# part 2
    
      

    
