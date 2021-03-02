#pragma once
class TextReader
{
public:
	TextReader();
	~TextReader();
	void read();
	void doRead();
private:
	char rawText;
	Dialog dialogs;
	int mStartLine;
	contentType status;
	int nowDialog;
	
};

struct Dialog
{

};
enum contentType
{ctNothing
,ctName
,ctDialog
,ctEndOfDialog
,ctDescription
,ctUnrecognized
};
