#include<iostream>
#include<fstream>
#include<string>
#include <cstdlib>
using namespace std;

string CeasarCipher(string plainText, int key)
{
    int n = plainText.length();
    string cipherText = "";
    int root;
    for (int i = 0; i < n; i++)
    {
        if ((plainText[i] >= 'a') && (plainText[i] <= 'z'))
            root = 'a';
        else if ((plainText[i] >= 'A') && (plainText[i] <= 'Z'))
            root = 'A';
        else
            root = 0;

        if (root != 0)
        {
            int asc = plainText[i] - root;
            asc = (26 + asc + key) % 26;    // add 26 in case of negative key.
            cipherText += (char)(asc + root);
        }
        else
            cipherText += plainText[i];
    }
    return cipherText;
}

int main(int argc, char* argv[])
{
	char type = argv[1][0];
	int key = atoi(argv[2]);
	char* srcfile = argv[3];
	char* destfile = argv[4];
	
	cout<<"CEASAR FILE ENCRYPTION & DECRYPTION "<<endl;
	cout<<"Type: "<<type<<endl;
    cout<<"Key: "<<key<<endl;
    cout<<"Source file: "<<srcfile<<endl;
    cout<<"Destination file: "<<destfile<<endl;
    
    ifstream inp(srcfile);    // file 'srcfile' chung thu muc voi file ma nguon
    ofstream out(destfile);    // chay xong mo file 'destfile' nay xem ket qua
 
	string s, t;
	while (getline(inp, s))
	{
		if (type == 'e')
			t = CeasarCipher(s, key);
		else
			t = CeasarCipher(s, -key);
		out<<t<<endl;
	}
	
    inp.close();
    out.close();
    
    cout<<endl;
    if (type == 'e')
    	cout<<"Encryption successfull."<<endl;
    else 
    	cout<<"Decryption successfull."<<endl;
	return 0;
}
