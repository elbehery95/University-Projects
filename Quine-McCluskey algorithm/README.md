# Quine-McCluskey Algorithm to minimize digital circuits

This script was written in summer 2016 as a tool to help answering a [Question about digital logic](http://electronics.stackexchange.com/questions/249212/solving-5-variables-karnaugh-map-grouping/)
on stackexchange. The tool works for solving [Theoretically] any number of inputs. Unlike logic Friday which is limited to only 8 inputs.
The software also allows adding don't cares for even better optimization [In case they do exist]

# TODO
1- Write the code in a more object oriented way

2- Enhance the interface

# HOW TO USE

1- Enter all the names of the circuit inputs in the `input []` list. Ex: `inputs=['A','B','C','D','E']`

2- Add the input bit pattern that yields a high output in the `terms []` list. Ex: `terms=[0b00110, 0b11010]`

3- In case some of the inputs wont exist in your circuit make sure to add them in the don't care list `d []`.

4- Put the output name in the variable `op`. Ex: op='F'
