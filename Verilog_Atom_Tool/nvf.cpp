/////////////////////////////////////////////////////////////////////////
//Engineer: Abdelrahman Elbehery
//Last Revision: 30-10-2016
/////////////////////////////////////////////////////////////////////////

#include <iostream>
#include <fstream>  
#include <string>

using namespace std;

ifstream currentSimFile[2];// ("sim.bat"), currentWaveFile("wave.bat");
string line[6]; // creates SIZE empty strings

string addedFiles="";
void create_files(string cmds, string fileName)
{
	std::ofstream outfile(fileName);
	outfile << cmds << std::endl;
	outfile.close();
}

int main(int argc, const char * argv[]) {
	currentSimFile[0] = ifstream("sim.bat");
	currentSimFile[1] = ifstream("wave.bat");
	int count = 0;
	for (size_t i = 1; i < argc; i++)
	{
		string fileName = argv[i];
		fileName += ".v";
		create_files("", fileName);
		addedFiles += " ";
		addedFiles += fileName;
		
	}
x:
	size_t i = 0;
	while (!currentSimFile[count].eof() && i < 6) {
		getline(currentSimFile[count], line[i],'\n');
		i++;
	}
	for (size_t i = 0; i < 6; i++)
	{
		if (line[i].find("iverilog")!=-1)
		{
			line[i] += addedFiles;
			break;
		}
	}
	string cmds = "";
	string fileName;
	for (size_t i = 0; i < 6; i++)
	{
		cmds += line[i] + '\n';
	}
	fileName = (count == 0) ? "sim.bat" : "wave.bat";
	create_files(cmds, fileName);
	if (count==0)
	{
		count += 1;
		goto x;
	}
	return 0;
}
