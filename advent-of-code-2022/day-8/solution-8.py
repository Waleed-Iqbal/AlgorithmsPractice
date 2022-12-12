import pprint
from pathlib import Path

pprint = pprint.pprint

formatted_input = open(Path(__file__).with_name("input-8.txt").absolute(), "r").read().split('\n')
