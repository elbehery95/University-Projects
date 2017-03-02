/////////////////////////////////////////////////////////////////////////
//Engineer: Abdelrahman Elbehery
//Last Revision: 30-10-2016
/////////////////////////////////////////////////////////////////////////

#include <iostream>
#include <fstream>  
#include <string>
using namespace std;

void create_files(string cmds, string fileName)
{
	std::ofstream outfile(fileName);
	outfile << cmds << std::endl;
	outfile.close();
}

int main(int argc, const char * argv[]) {
	string cmds = "del /f testing.dump\ndel / f compiled_file\niverilog -o compiled_file";
	for (size_t i = 1; i < argc; i++)
	{
		cmds += " ";
		cmds+= argv[i];
		cmds += ".v";
		
	}
	cmds += "\nvvp compiled_file\n";
	create_files(cmds, "sim.bat");
	cmds += "gtkwave testing.dump\n";
	create_files(cmds, "wave.bat");
	for (size_t i = 1; i < argc; i++)
	{
		string fileName = argv[i];
		fileName += ".v";
		create_files("", fileName);
	}
}
