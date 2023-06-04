import pprint
import math
from pathlib import Path

pprint = pprint.pprint

formatted_input = open(Path(__file__).with_name("input-10.txt").absolute(), "r").read().split('\n')

total_cycles = 0
calcualted_x = 1
signal_strength = 0

def calculate_strength():
  global total_cycles
  global calcualted_x
  global signal_strength

  total_cycles = total_cycles + 1

  if total_cycles == 20:
    signal_strength = total_cycles * calcualted_x
    print(
      total_cycles,
      calcualted_x,
      signal_strength
    )

  elif total_cycles % 60 == 0:
    signal_strength = signal_strength + (total_cycles * calcualted_x)
    print(
      total_cycles,
      calcualted_x,
      signal_strength
    )

for operation in formatted_input:
    if operation == 'noop':
      calculate_strength()

    elif operation.startswith('addx'):
      for i in range(0, 2):
        calculate_strength()
      calcualted_x = calcualted_x + int(operation.split(' ')[1])
        

    
      

    
