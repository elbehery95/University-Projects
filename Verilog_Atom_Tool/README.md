#Atom and iVerilog assist tool wirtten in C++

This tool was written in order to develop and simulate Verilog tools using Atom text editor, iVerilog verilog compiler and GTK wave viewer. The main cause
for creating this tool is the slow ModelSim EDA that we were told to use during the course.
Many of students [Including me] used this tool while taking the Computer Organisation course.
#TODO
1- Enhance the code readability

#HOW TO USE
1- After building the project and having all the executable ready, add the binary files in your system environmental variables 

2- In order to create a new Verilog project type the command `nvp <file1name> <file2name>` and all the necessary files will be automatically
generated in your current project directory

-- Once your testbench is ready, run it by typing in the command terminal `sim.bat`, In case you want to open GTKwave run instead the command
`wave.bat`

-- Whenever a project file is to be deleted, type in the command terminal `dvp <filexname>`

-- Whenever a project file is to be added, type in the command terminal `nvf <filename>`
